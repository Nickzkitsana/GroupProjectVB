﻿Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient

Public Class SnakeGame

    Dim GR As System.Random = New System.Random
    Dim G As Graphics
    Dim BBG As Graphics
    Dim BB As Bitmap
    Dim r As Rectangle
    Dim ts As Integer = 28
    Dim P1 As New Player
    Dim conStr As String = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=|DataDirectory|\Minigame.mdf"
    Dim conn As New SqlConnection(conStr)


    Dim isGameOver As Boolean = False
    Dim score As Integer = 0

    'is running
    Dim isRunning As Boolean = True
    'fps
    Dim tSec As Integer = TimeOfDay.Second
    Dim tTicks As Integer = 60
    Dim maxTicks As Integer = 60

    'food
    Dim foodx As Integer
    Dim foody As Integer

    Private Sub SnakeGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Focus()

        G = Me.CreateGraphics
        BBG = Me.CreateGraphics
        BB = New Bitmap(Me.Width, Me.Height)


        spawnFood()

        StartGameLoop()
    End Sub

    Private Sub StartGameLoop()
        Dim t2 As Integer = 0
        Dim once As Integer = 0
        Do While isRunning = True
            Application.DoEvents()
            If isGameOver = False Then
                DrawGraphics()
                checkCollisions()
                t2 = t2 + 1
                If t2 > (maxTicks / 6) Then
                    P1.Move()
                    t2 = 0
                End If
            Else
                DrawGraphics()
                If once = 0 Then
                    Me.Dispose()
                    MessageBox.Show("GameOver")
                    Dim name As String
                    Dim message = "Enter your name"
                    Dim title = "GameOver"
                    name = InputBox(message, title, "")
                    If name <> "" Then
                        MessageBox.Show("Score : " & score & vbNewLine & "Name : " & name, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim frm = MessageBox.Show("You need to insert data to database ?", "Submit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If frm = DialogResult.OK Then
                            'Connect and Insert to DB
                            conn.Open()
                            Dim sql As String = "INSERT INTO Snake(name,
                                                        score)
                                     values (@name , @score)"
                            Dim cmd As New SqlCommand(sql, conn)
                            cmd.Parameters.AddWithValue("name", name)
                            cmd.Parameters.AddWithValue("score", score)
                            If cmd.ExecuteNonQuery = 1 Then
                                MessageBox.Show("Insert Success", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Insert Failed", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                            conn.Close()
                        Else
                            MessageBox.Show("You've canceled insert" & vbNewLine & vbNewLine & "Back to menu", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        MessageBox.Show("Canceled / Empty Input" & vbNewLine & vbNewLine & "Back to menu", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.Close()
                        SnakeMenu.Show()
                        Exit Sub
                    End If
                    SnakeMenu.Show()
                    once = once + 1
                End If
            End If
        Loop
        Me.Close()
    End Sub

    Private Sub DrawGraphics()
        'draw blocks
        For x As Integer = 0 To 480 Step 30
            For y As Integer = 0 To 480 Step 30
                If x = 0 Or y = 0 Or x = 480 Or y = 480 Then
                    G.FillRectangle(Brushes.Silver, x, y, ts, ts)
                Else
                    G.FillRectangle(Brushes.LightGreen, x, y, ts, ts)
                End If

            Next y
        Next x

        P1.Draw(G)

        G.FillRectangle(Brushes.OrangeRed, foodx, foody, ts, ts)
        lblscore.Text = "Score: " & score.ToString
        G = Graphics.FromImage(BB)

        BBG.DrawImage(BB, 0, 0, Me.Width, Me.Height)
        'clear
        G.Clear(Color.White)
    End Sub

    Private Sub spawnFood()
        Dim randomx As Integer = P1.generateRandomNumber(1, 14) * 30
        Dim randomy As Integer = P1.generateRandomNumber(1, 14) * 30
        For Each p In P1.snakeParts
            If (p.X = randomx And p.Y = randomy) Or (P1.x = randomx And P1.y = randomy) Then
                spawnFood()
                Return
            End If
        Next p
        foodx = randomx
        foody = randomy

    End Sub

    Private Sub checkCollisions()
        For Each part In P1.snakeParts
            If P1.x = part.X And P1.y = part.Y Then
                isGameOver = True
            End If
        Next part

        If P1.x < 30 Or P1.x > 450 Or P1.y < 30 Or P1.y > 450 Then
            isGameOver = True
        End If

        If P1.x = foodx And P1.y = foody Then
            score = score + 1
            spawnFood()
            Dim newPartX As Integer
            Dim newPartY As Integer
            Dim lastPartX As Integer = P1.x
            Dim lastPartY As Integer = P1.y
            Dim lastDirection As String = P1.moveDirection
            If P1.snakeParts.Count > 0 Then
                lastPartX = P1.snakeParts.Last.Value.X
                lastPartY = P1.snakeParts.Last.Value.Y
                lastDirection = P1.snakeParts.Last.Value.direction
            End If


            Select Case lastDirection
                Case "up"
                    newPartX = lastPartX
                    newPartY = lastPartY + 30
                Case "down"
                    newPartX = lastPartX
                    newPartY = lastPartY - 30
                Case "left"
                    newPartX = lastPartX + 30
                    newPartY = lastPartY
                Case "right"
                    newPartX = lastPartX - 30
                    newPartY = lastPartY

            End Select
            Dim sp As New SnakePart(lastDirection, newPartX, newPartY)
            P1.snakeParts.AddLast(sp)

        End If
    End Sub


    Private Sub SnakeGame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If P1.moveDirection <> "down" Then
                    P1.changeDirection("up")
                End If
            Case Keys.Down
                If P1.moveDirection <> "up" Then
                    P1.changeDirection("down")
                End If
            Case Keys.Left

                If P1.moveDirection <> "right" Then
                    P1.changeDirection("left")
                End If
            Case Keys.Right
                If P1.moveDirection <> "left" Then
                    P1.changeDirection("right")
                End If
        End Select
    End Sub

    Private Sub SnakeGame_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        G.Dispose()
        BBG.Dispose()
        BB.Dispose()
    End Sub

    Private Sub SnakeGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isRunning = True Then
            isRunning = False
            e.Cancel = True
        End If
    End Sub
End Class
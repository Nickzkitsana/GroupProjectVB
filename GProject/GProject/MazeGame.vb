Imports System.Data
Imports System.Data.SqlClient

Public Class MazeGame
    Dim conStr As String = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=|DataDirectory|\Minigame.mdf"
    Dim conn As New SqlConnection(conStr)
    Dim sec As Integer = 0
    Dim min As Integer = 0
    Dim time As String
    Dim Game As Boolean = False

    Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()
            MovetoStart()
            ' Add any initialization after the InitializeComponent() call.

        End Sub

    Private Sub MazeGame_MouseEnter(sender As Object, e As EventArgs) Handles Label49.MouseEnter
        Timer1.Stop()
        MessageBox.Show("GOAL !!")
        Dim name As String
        Dim message = "Enter your name"
        Dim title = "GameOver"
        name = InputBox(message, title, "")
        If name <> "" Then
            MessageBox.Show("Time : " & time & vbNewLine & "Name : " & name, "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frm = MessageBox.Show("You need to insert data to database ?", "Submit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If frm = DialogResult.OK Then
                'Connect and Insert to DB
                conn.Open()
                Dim sql As String = "INSERT INTO Maze(name,time)
                                     values (@name , @time)"
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("name", name)
                cmd.Parameters.AddWithValue("time", time)
                If cmd.ExecuteNonQuery = 1 Then
                    MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                conn.Close()
            Else
                MessageBox.Show("You've canceled insert" & vbNewLine & vbNewLine & "Back to menu", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Canceled / Empty Input" & vbNewLine & vbNewLine & "Back to menu", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            MazeMenu.Show()
            Exit Sub
        End If
        Me.Close()
        MazeMenu.Show()
    End Sub

    Private Sub MovetoStart()
        Dim Startingpoint = Panel1.Location()
        Startingpoint.Offset(545, 255)
        Cursor.Position = PointToScreen(Startingpoint)
    End Sub

    Private Sub Wall_mouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label5.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        MovetoStart()
    End Sub

    Private Sub MazeGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sec = sec + 1
        If sec = 60 Then
            sec = 0
            min = min + 1
        End If
        time = min.ToString("00") & ":" & sec.ToString("00")
        Label50.Text = min.ToString("00") & ":" & sec.ToString("00")
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = 42 Then
            e.Handled = True
            Dim userMsg = InputBox("What is your secret code?", "Secret Entry Form", "Enter your secret code here")
            If userMsg = "GIVE ME GRADE A" Then
                Timer1.Stop()
                MessageBox.Show("THIS IS GOAL" + vbNewLine + "Your time is " & time.ToString)
                Close()
                MazeMenu.Show()
            Else
                MessageBox.Show("Incorrect")
            End If
        End If
    End Sub

End Class

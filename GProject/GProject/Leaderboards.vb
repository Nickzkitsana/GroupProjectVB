Imports System.Data
Imports System.Data.SqlClient

Public Class Leaderboards
    Dim conStr As String = "Server=(LocalDB)\MSSQLLocalDB;AttachDBFilename=|DataDirectory|\Minigame.mdf"
    Dim conn As New SqlConnection(conStr)
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If GroupBoxSnake.Enabled = True Then
            SnakeMenu.Show()
            GroupBoxSnake.Enabled = False
            Me.Hide()
        End If
        If GroupBoxAntHit.Enabled = True Then
            AntHitMenu.Show()
            GroupBoxAntHit.Enabled = False
            Me.Hide()
        End If
        If GroupBoxMaze.Enabled = True Then
            MazeMenu.Show()
            GroupBoxMaze.Enabled = False
            Me.Hide()
        End If

    End Sub

    Private Sub GroupBoxMaze_Enter(sender As Object, e As EventArgs) Handles GroupBoxMaze.Enter

    End Sub

    Private Sub GroupBoxAntHit_Enter(sender As Object, e As EventArgs) Handles GroupBoxAntHit.Enter

    End Sub

    Private Sub GroupBoxSnake_Enter(sender As Object, e As EventArgs) Handles GroupBoxSnake.Enter

    End Sub

    Private Sub Leaderboards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnthitScore()
        SnakeScore()
        MazeScore()
    End Sub

    Private Sub AnthitScore()
        conn.Open()
        Dim sql As String = "SELECT name , score 
                             FROM Anthit
                             ORDER BY score desc"
        Dim cmd As New SqlCommand(sql, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adapter.Fill(data, "AH")

        gridAnthit.DataSource = data.Tables("AH")
        conn.Close()
    End Sub

    Private Sub SnakeScore()
        conn.Open()
        Dim sql As String = "SELECT name , score 
                             FROM Snake
                             ORDER BY score desc"
        Dim cmd As New SqlCommand(sql, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adapter.Fill(data, "SN")

        gridSnake.DataSource = data.Tables("SN")
        conn.Close()
    End Sub

    Private Sub MazeScore()
        conn.Open()
        Dim sql As String = "SELECT name , time 
                             FROM Maze"
        Dim cmd As New SqlCommand(sql, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim data As New DataSet()
        adapter.Fill(data, "MZ")

        gridMaze.DataSource = data.Tables("MZ")
        conn.Close()
    End Sub

    Private Sub gridSnake_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridSnake.CellContentClick

    End Sub

    Private Sub gridAnthit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridAnthit.CellContentClick

    End Sub

    Private Sub gridMaze_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridMaze.CellContentClick

    End Sub
End Class
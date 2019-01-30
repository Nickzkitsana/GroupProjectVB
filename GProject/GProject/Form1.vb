Public Class Mainmenu
    Private Sub btnSnake_Click(sender As Object, e As EventArgs) Handles btnSnake.Click
        Snake.Show()
        Me.Hide()
    End Sub

    Private Sub btnAntHit_Click(sender As Object, e As EventArgs) Handles btnAntHit.Click
        AntHit.Show()
        Me.Hide()
    End Sub

    Private Sub btnMaze_Click(sender As Object, e As EventArgs) Handles btnMaze.Click
        Maze.Show()
        Me.Hide()
    End Sub
End Class

Public Class Mainmenu
    Private Sub btnSnake_Click(sender As Object, e As EventArgs) Handles btnSnake.Click
        SnakeMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnAntHit_Click(sender As Object, e As EventArgs) Handles btnAntHit.Click
        AntHitMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnMaze_Click(sender As Object, e As EventArgs) Handles btnMaze.Click
        MazeMenu.Show()
        Me.Hide()
    End Sub
End Class

Public Class SnakeMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Mainmenu.Show()
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Me.Hide()
        Leaderboards.Show()
        Leaderboards.GroupBoxSnake.Show()
        Leaderboards.GroupBoxSnake.Enabled = True
        Leaderboards.GroupBoxAntHit.Hide()
        Leaderboards.GroupBoxMaze.Hide()
    End Sub
End Class
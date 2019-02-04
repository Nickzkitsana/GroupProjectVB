Public Class MazeMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Mainmenu.Show()
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Me.Hide()
        Leaderboards.Show()
        Leaderboards.GroupBoxMaze.Show()
        Leaderboards.GroupBoxMaze.Enabled = True
        Leaderboards.GroupBoxAntHit.Hide()
        Leaderboards.GroupBoxSnake.Hide()
    End Sub
End Class
Public Class Snake
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Mainmenu.Show()
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Me.Hide()
        LeaderBoard.Show()
        LeaderBoard.GroupBoxSnake.Show()
        LeaderBoard.GroupBoxSnake.Enabled = True
        LeaderBoard.GroupBoxAntHit.Hide()
        LeaderBoard.GroupBoxMaze.Hide()
    End Sub
End Class
Public Class Maze
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Mainmenu.Show()
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Me.Hide()
        LeaderBoard.Show()
        LeaderBoard.GroupBoxAntHit.Hide()
        LeaderBoard.GroupBoxMaze.Show()
        LeaderBoard.GroupBoxSnake.Hide()
    End Sub
End Class
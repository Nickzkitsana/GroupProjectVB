Public Class AntHit
    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Me.Hide()
        LeaderBoard.Show()
        LeaderBoard.GroupBoxAntHit.Show()
        LeaderBoard.GroupBoxMaze.Hide()
        LeaderBoard.GroupBoxSnake.Hide()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

    End Sub

    Private Sub AntHit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Mainmenu.Show()
    End Sub
End Class
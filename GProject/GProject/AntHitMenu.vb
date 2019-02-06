
Public Class AntHitMenu
    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Me.Hide()
        Leaderboards.Show()
        Leaderboards.GroupBoxAntHit.Show()
        Leaderboards.GroupBoxAntHit.Enabled = True
        Leaderboards.GroupBoxMaze.Hide()
        Leaderboards.GroupBoxSnake.Hide()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        AntHitGame.Show()
    End Sub

    Private Sub AntHit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Mainmenu.Show()
    End Sub

End Class
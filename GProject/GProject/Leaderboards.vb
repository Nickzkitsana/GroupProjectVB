Public Class Leaderboards
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
End Class
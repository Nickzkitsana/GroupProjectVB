Public Class LeaderBoard
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        If GroupBoxSnake.TabIndex = 0 Then
            Snake.Show()
        End If
        If GroupBoxAntHit.TabIndex = 1 Then
            AntHit.Show()
        End If
        If GroupBoxMaze.TabIndex = 2 Then
            Maze.Show()
        End If

    End Sub

    Private Sub GroupBoxMaze_Enter(sender As Object, e As EventArgs) Handles GroupBoxMaze.Enter

    End Sub

    Private Sub GroupBoxAntHit_Enter(sender As Object, e As EventArgs) Handles GroupBoxAntHit.Enter

    End Sub

    Private Sub GroupBoxSnake_Enter(sender As Object, e As EventArgs) Handles GroupBoxSnake.Enter

    End Sub
End Class
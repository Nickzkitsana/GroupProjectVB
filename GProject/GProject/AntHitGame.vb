Public Class AntHitGame
    Dim score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Top -= 10
        PictureBox2.Top -= 10
        PictureBox3.Top -= 10
        PictureBox4.Top -= 10
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y < -60 And PictureBox2.Location.Y < -60 And PictureBox3.Location.Y < -60 And PictureBox4.Location.Y < -60 Then
            Me.Dispose()
            MsgBox("GAMEOVER")
            AntHitMenu.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        score = score + 1
        PictureBox1.Location = New Point(200, 400)
        Label1.Text = score
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        score = score + 1
        PictureBox2.Location = New Point(200, 400)
        Label1.Text = score
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        score = score + 1
        PictureBox3.Location = New Point(200, 400)
        Label1.Text = score
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        score = score + 1
        PictureBox4.Location = New Point(200, 400)
        Label1.Text = score
    End Sub
End Class
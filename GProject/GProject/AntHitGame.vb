Public Class AntHitGame
    Dim score As Integer
    Dim Rand As New Random()
    Dim RandX As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If score <= 10 Then
            PictureBox1.Top -= 5
            PictureBox2.Top -= 5
            PictureBox3.Top -= 5
            PictureBox4.Top -= 5
        ElseIf score > 10 And score <= 30 Then
            PictureBox1.Top -= 7
            PictureBox2.Top -= 7
            PictureBox3.Top -= 7
            PictureBox4.Top -= 7
        ElseIf score > 30 And score <= 50 Then
            PictureBox1.Top -= 10
            PictureBox2.Top -= 10
            PictureBox3.Top -= 10
            PictureBox4.Top -= 10
        ElseIf score > 50 And score <= 70 Then
            PictureBox1.Top -= 13
            PictureBox2.Top -= 13
            PictureBox3.Top -= 13
            PictureBox4.Top -= 13
        ElseIf score > 70 And score <= 100 Then
            PictureBox1.Top -= 15
            PictureBox2.Top -= 15
            PictureBox3.Top -= 15
            PictureBox4.Top -= 15
        ElseIf score > 100 And score <= 150 Then
            PictureBox1.Top -= 18
            PictureBox2.Top -= 18
            PictureBox3.Top -= 18
            PictureBox4.Top -= 18
        ElseIf score > 150 And score <= 200 Then
            PictureBox1.Top -= 22
            PictureBox2.Top -= 22
            PictureBox3.Top -= 22
            PictureBox4.Top -= 22
        ElseIf score > 200 And score <= 270 Then
            PictureBox1.Top -= 26
            PictureBox2.Top -= 26
            PictureBox3.Top -= 26
            PictureBox4.Top -= 26
        Else
            PictureBox1.Top -= 40
            PictureBox2.Top -= 40
            PictureBox3.Top -= 40
            PictureBox4.Top -= 40
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y < -60 Or PictureBox2.Location.Y < -60 Or PictureBox3.Location.Y < -60 Or PictureBox4.Location.Y < -60 Then
            Me.Dispose()
            Dim name As String = InputBox("Enter Your Name", "GameOver", "")
            If name = "" Then
                MessageBox.Show("Cant", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("GAMEOVER" & vbNewLine & "Score : " & score & vbNewLine & "Name : " & name, "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim frm = MessageBox.Show("You need to insert data to database ?", "Submit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If frm = DialogResult.OK Then
                    MessageBox.Show("Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cancel", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
            AntHitMenu.Show()
        End If
        Label1.Text = score
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        score = score + 1
        Label1.Text = score
        RandX = Rand.Next(400)
        PictureBox1.Location = New Point(RandX, 600)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        score = score + 1
        Label1.Text = score
        RandX = Rand.Next(400)
        PictureBox2.Location = New Point(RandX, 600)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        score = score + 1
        Label1.Text = score
        RandX = Rand.Next(400)
        PictureBox3.Location = New Point(RandX, 600)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        score = score + 1
        Label1.Text = score
        RandX = Rand.Next(400)
        PictureBox4.Location = New Point(RandX, 600)
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AntHitGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
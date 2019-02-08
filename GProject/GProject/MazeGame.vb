Public Class MazeGame
    Dim Game As Boolean = False
    Dim Time As String
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        MovetoStart()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub MazeGame_MouseEnter(sender As Object, e As EventArgs) Handles Label49.MouseEnter
        Game = True
        If Game = True Then
            Timer1.Stop()
            MessageBox.Show("THIS IS GOAL" + vbNewLine + "Your time is " & Time.ToString)
            Close()
            MazeMenu.Show()
        End If

    End Sub
    Private Sub MovetoStart()
        Dim Startingpoint = Panel1.Location()
        Startingpoint.Offset(545, 255)
        Cursor.Position = PointToScreen(Startingpoint)
    End Sub
    Private Sub Wall_mouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label5.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        MovetoStart()
    End Sub

    Dim hr, min, sec As Integer 'msec;

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'msec++;
        'if(msec == 60)  { msec = 0; sec++; }

        sec += 1
        If (sec = 60) Then
            sec = 0 : min += 1
        End If
        If (min = 60) Then
            min = 0 : hr += 1
        End If
        If (hr = 24) Then
            hr = 0 : min = 0 : sec = 0
        End If
        Time = String.Format("{0}:{1}:{2}", hr, min, sec)
    End Sub

    Private Sub TxtSearch_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = 42 Then
            e.Handled = True
            Dim userMsg = InputBox("What is your secret code?", "Secret Entry Form", "Enter your secret code here")
            If userMsg = "GIVE ME GRADE A" Then
                Timer1.Stop()
                MessageBox.Show("THIS IS GOAL" + vbNewLine + "Your time is " & Time.ToString)
                Close()
                MazeMenu.Show()
            Else
                MessageBox.Show("Incorrect")
            End If
        End If
    End Sub

End Class
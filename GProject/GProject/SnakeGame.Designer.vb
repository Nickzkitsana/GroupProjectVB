<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SnakeGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SnakeGame))
        Me.lblscore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.BackColor = System.Drawing.Color.Black
        Me.lblscore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblscore.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblscore.Location = New System.Drawing.Point(669, 46)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(2, 28)
        Me.lblscore.TabIndex = 0
        '
        'SnakeGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 510)
        Me.Controls.Add(Me.lblscore)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "SnakeGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SnakeGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblscore As Label
End Class

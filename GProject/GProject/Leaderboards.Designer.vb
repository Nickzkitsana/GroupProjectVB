<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboards
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leaderboards))
        Me.GroupBoxSnake = New System.Windows.Forms.GroupBox()
        Me.GroupBoxAntHit = New System.Windows.Forms.GroupBox()
        Me.GroupBoxMaze = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GroupBoxSnake
        '
        Me.GroupBoxSnake.Enabled = False
        Me.GroupBoxSnake.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxSnake.Location = New System.Drawing.Point(41, 16)
        Me.GroupBoxSnake.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxSnake.Name = "GroupBoxSnake"
        Me.GroupBoxSnake.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxSnake.Size = New System.Drawing.Size(973, 481)
        Me.GroupBoxSnake.TabIndex = 0
        Me.GroupBoxSnake.TabStop = False
        Me.GroupBoxSnake.Text = "Leaderboards Snake"
        '
        'GroupBoxAntHit
        '
        Me.GroupBoxAntHit.Enabled = False
        Me.GroupBoxAntHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxAntHit.Location = New System.Drawing.Point(33, 16)
        Me.GroupBoxAntHit.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxAntHit.Name = "GroupBoxAntHit"
        Me.GroupBoxAntHit.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxAntHit.Size = New System.Drawing.Size(973, 481)
        Me.GroupBoxAntHit.TabIndex = 1
        Me.GroupBoxAntHit.TabStop = False
        Me.GroupBoxAntHit.Text = "Leaderboards AntHit"
        '
        'GroupBoxMaze
        '
        Me.GroupBoxMaze.Enabled = False
        Me.GroupBoxMaze.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxMaze.Location = New System.Drawing.Point(25, 16)
        Me.GroupBoxMaze.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxMaze.Name = "GroupBoxMaze"
        Me.GroupBoxMaze.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxMaze.Size = New System.Drawing.Size(973, 481)
        Me.GroupBoxMaze.TabIndex = 2
        Me.GroupBoxMaze.TabStop = False
        Me.GroupBoxMaze.Text = "Leaderboards Maze"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(864, 505)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(151, 34)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'LeaderBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.GroupBoxMaze)
        Me.Controls.Add(Me.GroupBoxAntHit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBoxSnake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "LeaderBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leaderboards"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBoxSnake As GroupBox
    Friend WithEvents GroupBoxAntHit As GroupBox
    Friend WithEvents GroupBoxMaze As GroupBox
End Class

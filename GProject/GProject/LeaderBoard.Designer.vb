<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeaderBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LeaderBoard))
        Me.GroupBoxSnake = New System.Windows.Forms.GroupBox()
        Me.GroupBoxAntHit = New System.Windows.Forms.GroupBox()
        Me.GroupBoxMaze = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GroupBoxSnake
        '
        Me.GroupBoxSnake.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxSnake.Location = New System.Drawing.Point(31, 13)
        Me.GroupBoxSnake.Name = "GroupBoxSnake"
        Me.GroupBoxSnake.Size = New System.Drawing.Size(730, 391)
        Me.GroupBoxSnake.TabIndex = 0
        Me.GroupBoxSnake.TabStop = False
        Me.GroupBoxSnake.Text = "LeaderBoard Snake"
        '
        'GroupBoxAntHit
        '
        Me.GroupBoxAntHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxAntHit.Location = New System.Drawing.Point(25, 13)
        Me.GroupBoxAntHit.Name = "GroupBoxAntHit"
        Me.GroupBoxAntHit.Size = New System.Drawing.Size(730, 391)
        Me.GroupBoxAntHit.TabIndex = 1
        Me.GroupBoxAntHit.TabStop = False
        Me.GroupBoxAntHit.Text = "LeaderBoard AntHit"
        '
        'GroupBoxMaze
        '
        Me.GroupBoxMaze.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxMaze.Location = New System.Drawing.Point(19, 13)
        Me.GroupBoxMaze.Name = "GroupBoxMaze"
        Me.GroupBoxMaze.Size = New System.Drawing.Size(730, 391)
        Me.GroupBoxMaze.TabIndex = 2
        Me.GroupBoxMaze.TabStop = False
        Me.GroupBoxMaze.Text = "LeaderBoard Maze"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(648, 410)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 28)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'LeaderBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBoxMaze)
        Me.Controls.Add(Me.GroupBoxAntHit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBoxSnake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LeaderBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LeaderBoard"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBoxSnake As GroupBox
    Friend WithEvents GroupBoxAntHit As GroupBox
    Friend WithEvents GroupBoxMaze As GroupBox
End Class

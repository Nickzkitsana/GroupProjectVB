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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBoxSnake.SuspendLayout()
        Me.GroupBoxAntHit.SuspendLayout()
        Me.GroupBoxMaze.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxSnake
        '
        Me.GroupBoxSnake.Controls.Add(Me.DataGridView3)
        Me.GroupBoxSnake.Enabled = False
        Me.GroupBoxSnake.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxSnake.Location = New System.Drawing.Point(42, 13)
        Me.GroupBoxSnake.Name = "GroupBoxSnake"
        Me.GroupBoxSnake.Size = New System.Drawing.Size(730, 391)
        Me.GroupBoxSnake.TabIndex = 0
        Me.GroupBoxSnake.TabStop = False
        Me.GroupBoxSnake.Text = "Leaderboards Snake"
        '
        'GroupBoxAntHit
        '
        Me.GroupBoxAntHit.Controls.Add(Me.DataGridView2)
        Me.GroupBoxAntHit.Enabled = False
        Me.GroupBoxAntHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxAntHit.Location = New System.Drawing.Point(36, 13)
        Me.GroupBoxAntHit.Name = "GroupBoxAntHit"
        Me.GroupBoxAntHit.Size = New System.Drawing.Size(730, 391)
        Me.GroupBoxAntHit.TabIndex = 1
        Me.GroupBoxAntHit.TabStop = False
        Me.GroupBoxAntHit.Text = "Leaderboards AntHit"
        '
        'GroupBoxMaze
        '
        Me.GroupBoxMaze.Controls.Add(Me.DataGridView1)
        Me.GroupBoxMaze.Enabled = False
        Me.GroupBoxMaze.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxMaze.Location = New System.Drawing.Point(31, 13)
        Me.GroupBoxMaze.Name = "GroupBoxMaze"
        Me.GroupBoxMaze.Size = New System.Drawing.Size(730, 391)
        Me.GroupBoxMaze.TabIndex = 2
        Me.GroupBoxMaze.TabStop = False
        Me.GroupBoxMaze.Text = "Leaderboards Maze"
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(671, 324)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(22, 37)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(687, 336)
        Me.DataGridView2.TabIndex = 0
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(25, 49)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(686, 324)
        Me.DataGridView3.TabIndex = 0
        '
        'Leaderboards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBoxMaze)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBoxAntHit)
        Me.Controls.Add(Me.GroupBoxSnake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Leaderboards"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leaderboards"
        Me.GroupBoxSnake.ResumeLayout(False)
        Me.GroupBoxAntHit.ResumeLayout(False)
        Me.GroupBoxMaze.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBoxSnake As GroupBox
    Friend WithEvents GroupBoxAntHit As GroupBox
    Friend WithEvents GroupBoxMaze As GroupBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
End Class

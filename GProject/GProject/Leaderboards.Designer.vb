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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leaderboards))
        Me.GroupBoxSnake = New System.Windows.Forms.GroupBox()
        Me.gridSnake = New System.Windows.Forms.DataGridView()
        Me.GroupBoxAntHit = New System.Windows.Forms.GroupBox()
        Me.gridAnthit = New System.Windows.Forms.DataGridView()
        Me.GroupBoxMaze = New System.Windows.Forms.GroupBox()
        Me.gridMaze = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBoxSnake.SuspendLayout()
        CType(Me.gridSnake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAntHit.SuspendLayout()
        CType(Me.gridAnthit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxMaze.SuspendLayout()
        CType(Me.gridMaze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxSnake
        '
        Me.GroupBoxSnake.Controls.Add(Me.gridSnake)
        Me.GroupBoxSnake.Enabled = False
        Me.GroupBoxSnake.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxSnake.Location = New System.Drawing.Point(42, 13)
        Me.GroupBoxSnake.Name = "GroupBoxSnake"
        Me.GroupBoxSnake.Size = New System.Drawing.Size(730, 416)
        Me.GroupBoxSnake.TabIndex = 0
        Me.GroupBoxSnake.TabStop = False
        Me.GroupBoxSnake.Text = "Leaderboards Snake"
        '
        'gridSnake
        '
        Me.gridSnake.AllowUserToAddRows = False
        Me.gridSnake.AllowUserToDeleteRows = False
        Me.gridSnake.AllowUserToResizeColumns = False
        Me.gridSnake.AllowUserToResizeRows = False
        Me.gridSnake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridSnake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridSnake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSnake.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridSnake.DefaultCellStyle = DataGridViewCellStyle1
        Me.gridSnake.Location = New System.Drawing.Point(25, 44)
        Me.gridSnake.Name = "gridSnake"
        Me.gridSnake.ReadOnly = True
        Me.gridSnake.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gridSnake.RowHeadersVisible = False
        Me.gridSnake.RowTemplate.Height = 35
        Me.gridSnake.RowTemplate.ReadOnly = True
        Me.gridSnake.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridSnake.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridSnake.Size = New System.Drawing.Size(686, 354)
        Me.gridSnake.TabIndex = 0
        '
        'GroupBoxAntHit
        '
        Me.GroupBoxAntHit.Controls.Add(Me.gridAnthit)
        Me.GroupBoxAntHit.Enabled = False
        Me.GroupBoxAntHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxAntHit.Location = New System.Drawing.Point(37, 18)
        Me.GroupBoxAntHit.Name = "GroupBoxAntHit"
        Me.GroupBoxAntHit.Size = New System.Drawing.Size(724, 411)
        Me.GroupBoxAntHit.TabIndex = 1
        Me.GroupBoxAntHit.TabStop = False
        Me.GroupBoxAntHit.Text = "Leaderboards AntHit"
        '
        'gridAnthit
        '
        Me.gridAnthit.AllowUserToAddRows = False
        Me.gridAnthit.AllowUserToDeleteRows = False
        Me.gridAnthit.AllowUserToResizeColumns = False
        Me.gridAnthit.AllowUserToResizeRows = False
        Me.gridAnthit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridAnthit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridAnthit.ColumnHeadersHeight = 18
        Me.gridAnthit.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridAnthit.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridAnthit.Location = New System.Drawing.Point(22, 37)
        Me.gridAnthit.Name = "gridAnthit"
        Me.gridAnthit.ReadOnly = True
        Me.gridAnthit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gridAnthit.RowHeadersVisible = False
        Me.gridAnthit.RowTemplate.Height = 35
        Me.gridAnthit.RowTemplate.ReadOnly = True
        Me.gridAnthit.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridAnthit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridAnthit.Size = New System.Drawing.Size(687, 353)
        Me.gridAnthit.TabIndex = 0
        '
        'GroupBoxMaze
        '
        Me.GroupBoxMaze.Controls.Add(Me.gridMaze)
        Me.GroupBoxMaze.Enabled = False
        Me.GroupBoxMaze.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GroupBoxMaze.Location = New System.Drawing.Point(31, 18)
        Me.GroupBoxMaze.Name = "GroupBoxMaze"
        Me.GroupBoxMaze.Size = New System.Drawing.Size(730, 419)
        Me.GroupBoxMaze.TabIndex = 2
        Me.GroupBoxMaze.TabStop = False
        Me.GroupBoxMaze.Text = "Leaderboards Maze"
        '
        'gridMaze
        '
        Me.gridMaze.AllowUserToAddRows = False
        Me.gridMaze.AllowUserToDeleteRows = False
        Me.gridMaze.AllowUserToResizeColumns = False
        Me.gridMaze.AllowUserToResizeRows = False
        Me.gridMaze.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridMaze.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridMaze.ColumnHeadersHeight = 18
        Me.gridMaze.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridMaze.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridMaze.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.gridMaze.Location = New System.Drawing.Point(28, 37)
        Me.gridMaze.Name = "gridMaze"
        Me.gridMaze.ReadOnly = True
        Me.gridMaze.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gridMaze.RowHeadersVisible = False
        Me.gridMaze.RowTemplate.Height = 35
        Me.gridMaze.RowTemplate.ReadOnly = True
        Me.gridMaze.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridMaze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridMaze.Size = New System.Drawing.Size(671, 354)
        Me.gridMaze.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightCoral
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnExit.Location = New System.Drawing.Point(629, 459)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 44)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = Global.GProject.My.Resources.Resources.free_vector_refresh_clip_art_117474_Refresh_clip_art_hight
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Location = New System.Drawing.Point(552, 454)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(55, 55)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Leaderboards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 521)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.GroupBoxMaze)
        Me.Controls.Add(Me.GroupBoxAntHit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBoxSnake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Leaderboards"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leaderboards"
        Me.GroupBoxSnake.ResumeLayout(False)
        CType(Me.gridSnake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAntHit.ResumeLayout(False)
        CType(Me.gridAnthit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMaze.ResumeLayout(False)
        CType(Me.gridMaze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBoxSnake As GroupBox
    Friend WithEvents GroupBoxAntHit As GroupBox
    Friend WithEvents GroupBoxMaze As GroupBox
    Friend WithEvents gridSnake As DataGridView
    Friend WithEvents gridAnthit As DataGridView
    Friend WithEvents gridMaze As DataGridView
    Friend WithEvents btnRefresh As Button
End Class

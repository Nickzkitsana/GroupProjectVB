<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainmenu))
        Me.btnMaze = New System.Windows.Forms.Button()
        Me.btnAntHit = New System.Windows.Forms.Button()
        Me.btnSnake = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMaze
        '
        Me.btnMaze.BackColor = System.Drawing.Color.Peru
        Me.btnMaze.BackgroundImage = Global.GProject.My.Resources.Resources.logo
        Me.btnMaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaze.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaze.Location = New System.Drawing.Point(226, 320)
        Me.btnMaze.Name = "btnMaze"
        Me.btnMaze.Size = New System.Drawing.Size(242, 99)
        Me.btnMaze.TabIndex = 2
        Me.btnMaze.UseVisualStyleBackColor = False
        '
        'btnAntHit
        '
        Me.btnAntHit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAntHit.BackgroundImage = Global.GProject.My.Resources.Resources.ant_smasher
        Me.btnAntHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAntHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAntHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnAntHit.Location = New System.Drawing.Point(226, 176)
        Me.btnAntHit.Name = "btnAntHit"
        Me.btnAntHit.Size = New System.Drawing.Size(242, 99)
        Me.btnAntHit.TabIndex = 1
        Me.btnAntHit.UseVisualStyleBackColor = False
        '
        'btnSnake
        '
        Me.btnSnake.BackgroundImage = Global.GProject.My.Resources.Resources.snake_960x540
        Me.btnSnake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSnake.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSnake.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnSnake.Location = New System.Drawing.Point(226, 34)
        Me.btnSnake.Name = "btnSnake"
        Me.btnSnake.Size = New System.Drawing.Size(242, 99)
        Me.btnSnake.TabIndex = 0
        Me.btnSnake.UseVisualStyleBackColor = True
        '
        'Mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.BackgroundImage = Global.GProject.My.Resources.Resources.yo7TZq6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(704, 461)
        Me.Controls.Add(Me.btnMaze)
        Me.Controls.Add(Me.btnAntHit)
        Me.Controls.Add(Me.btnSnake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Mainmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mini Games"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSnake As Button
    Friend WithEvents btnAntHit As Button
    Friend WithEvents btnMaze As Button
End Class

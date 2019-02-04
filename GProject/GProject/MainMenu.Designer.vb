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
        Me.btnSnake = New System.Windows.Forms.Button()
        Me.btnAntHit = New System.Windows.Forms.Button()
        Me.btnMaze = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSnake
        '
        Me.btnSnake.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnSnake.Location = New System.Drawing.Point(301, 42)
        Me.btnSnake.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSnake.Name = "btnSnake"
        Me.btnSnake.Size = New System.Drawing.Size(323, 122)
        Me.btnSnake.TabIndex = 0
        Me.btnSnake.Text = "Snake"
        Me.btnSnake.UseVisualStyleBackColor = True
        '
        'btnAntHit
        '
        Me.btnAntHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnAntHit.Location = New System.Drawing.Point(301, 217)
        Me.btnAntHit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAntHit.Name = "btnAntHit"
        Me.btnAntHit.Size = New System.Drawing.Size(323, 122)
        Me.btnAntHit.TabIndex = 1
        Me.btnAntHit.Text = "Ant Hit"
        Me.btnAntHit.UseVisualStyleBackColor = True
        '
        'btnMaze
        '
        Me.btnMaze.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaze.Location = New System.Drawing.Point(302, 394)
        Me.btnMaze.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMaze.Name = "btnMaze"
        Me.btnMaze.Size = New System.Drawing.Size(323, 122)
        Me.btnMaze.TabIndex = 2
        Me.btnMaze.Text = "Maze"
        Me.btnMaze.UseVisualStyleBackColor = True
        '
        'Mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 567)
        Me.Controls.Add(Me.btnMaze)
        Me.Controls.Add(Me.btnAntHit)
        Me.Controls.Add(Me.btnSnake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
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

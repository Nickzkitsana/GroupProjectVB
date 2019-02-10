<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AntHitMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AntHitMenu))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightCoral
        Me.btnExit.BackgroundImage = Global.GProject.My.Resources.Resources.button_exit
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnExit.Location = New System.Drawing.Point(231, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(242, 60)
        Me.btnExit.TabIndex = 6
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRecord
        '
        Me.btnRecord.BackgroundImage = Global.GProject.My.Resources.Resources.button_leaderboards
        Me.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnRecord.Location = New System.Drawing.Point(231, 196)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(242, 60)
        Me.btnRecord.TabIndex = 5
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnStart.BackgroundImage = Global.GProject.My.Resources.Resources.button_start
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnStart.Location = New System.Drawing.Point(231, 71)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(242, 60)
        Me.btnStart.TabIndex = 4
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'AntHitMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.BackgroundImage = Global.GProject.My.Resources.Resources.yo7TZq6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(704, 461)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AntHitMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AntHit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnRecord As Button
    Friend WithEvents btnStart As Button
End Class

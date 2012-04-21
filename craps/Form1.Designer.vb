<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.imgDie1 = New System.Windows.Forms.PictureBox()
        Me.imgDie2 = New System.Windows.Forms.PictureBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblDiceRoll = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.imgDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgDie1
        '
        Me.imgDie1.Image = Global.craps.My.Resources.Resources.die1
        Me.imgDie1.Location = New System.Drawing.Point(855, 12)
        Me.imgDie1.Name = "imgDie1"
        Me.imgDie1.Size = New System.Drawing.Size(60, 60)
        Me.imgDie1.TabIndex = 0
        Me.imgDie1.TabStop = False
        '
        'imgDie2
        '
        Me.imgDie2.Image = Global.craps.My.Resources.Resources.die1
        Me.imgDie2.Location = New System.Drawing.Point(940, 12)
        Me.imgDie2.Name = "imgDie2"
        Me.imgDie2.Size = New System.Drawing.Size(60, 60)
        Me.imgDie2.TabIndex = 1
        Me.imgDie2.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(1024, 32)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblDiceRoll
        '
        Me.lblDiceRoll.AutoSize = True
        Me.lblDiceRoll.Location = New System.Drawing.Point(788, 12)
        Me.lblDiceRoll.Name = "lblDiceRoll"
        Me.lblDiceRoll.Size = New System.Drawing.Size(0, 13)
        Me.lblDiceRoll.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(791, 58)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.craps.My.Resources.Resources.crapsBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1175, 649)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiceRoll)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.imgDie2)
        Me.Controls.Add(Me.imgDie1)
        Me.Name = "frmMain"
        Me.Text = "Craps"
        CType(Me.imgDie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDie2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgDie1 As System.Windows.Forms.PictureBox
    Friend WithEvents imgDie2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents lblDiceRoll As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class

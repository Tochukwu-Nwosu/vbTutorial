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
        Me.lblMeaning = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picXO = New System.Windows.Forms.PictureBox()
        Me.picSRY = New System.Windows.Forms.PictureBox()
        Me.picLOL = New System.Windows.Forms.PictureBox()
        Me.picIDK = New System.Windows.Forms.PictureBox()
        Me.picBRB = New System.Windows.Forms.PictureBox()
        Me.picBFF = New System.Windows.Forms.PictureBox()
        CType(Me.picXO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSRY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLOL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIDK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBRB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBFF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMeaning
        '
        Me.lblMeaning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMeaning.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeaning.Location = New System.Drawing.Point(27, 148)
        Me.lblMeaning.Name = "lblMeaning"
        Me.lblMeaning.Size = New System.Drawing.Size(694, 73)
        Me.lblMeaning.TabIndex = 6
        Me.lblMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(743, 179)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 41)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picXO
        '
        Me.picXO.Image = Global.Texting_Project.My.Resources.Resources.XO
        Me.picXO.Location = New System.Drawing.Point(626, 27)
        Me.picXO.Name = "picXO"
        Me.picXO.Size = New System.Drawing.Size(96, 75)
        Me.picXO.TabIndex = 5
        Me.picXO.TabStop = False
        '
        'picSRY
        '
        Me.picSRY.Image = Global.Texting_Project.My.Resources.Resources.SRY
        Me.picSRY.Location = New System.Drawing.Point(506, 27)
        Me.picSRY.Name = "picSRY"
        Me.picSRY.Size = New System.Drawing.Size(96, 75)
        Me.picSRY.TabIndex = 4
        Me.picSRY.TabStop = False
        '
        'picLOL
        '
        Me.picLOL.Image = Global.Texting_Project.My.Resources.Resources.LOL
        Me.picLOL.Location = New System.Drawing.Point(387, 27)
        Me.picLOL.Name = "picLOL"
        Me.picLOL.Size = New System.Drawing.Size(96, 75)
        Me.picLOL.TabIndex = 3
        Me.picLOL.TabStop = False
        '
        'picIDK
        '
        Me.picIDK.Image = Global.Texting_Project.My.Resources.Resources.IDK
        Me.picIDK.Location = New System.Drawing.Point(266, 27)
        Me.picIDK.Name = "picIDK"
        Me.picIDK.Size = New System.Drawing.Size(96, 75)
        Me.picIDK.TabIndex = 2
        Me.picIDK.TabStop = False
        '
        'picBRB
        '
        Me.picBRB.Image = Global.Texting_Project.My.Resources.Resources.BRB
        Me.picBRB.Location = New System.Drawing.Point(146, 27)
        Me.picBRB.Name = "picBRB"
        Me.picBRB.Size = New System.Drawing.Size(96, 75)
        Me.picBRB.TabIndex = 1
        Me.picBRB.TabStop = False
        '
        'picBFF
        '
        Me.picBFF.Image = Global.Texting_Project.My.Resources.Resources.BFF
        Me.picBFF.Location = New System.Drawing.Point(26, 27)
        Me.picBFF.Name = "picBFF"
        Me.picBFF.Size = New System.Drawing.Size(96, 75)
        Me.picBFF.TabIndex = 0
        Me.picBFF.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 259)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMeaning)
        Me.Controls.Add(Me.picXO)
        Me.Controls.Add(Me.picSRY)
        Me.Controls.Add(Me.picLOL)
        Me.Controls.Add(Me.picIDK)
        Me.Controls.Add(Me.picBRB)
        Me.Controls.Add(Me.picBFF)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Message Symbols"
        CType(Me.picXO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSRY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLOL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIDK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBRB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBFF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBFF As PictureBox
    Friend WithEvents picBRB As PictureBox
    Friend WithEvents picIDK As PictureBox
    Friend WithEvents picLOL As PictureBox
    Friend WithEvents picSRY As PictureBox
    Friend WithEvents picXO As PictureBox
    Friend WithEvents lblMeaning As Label
    Friend WithEvents btnExit As Button
End Class

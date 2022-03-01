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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picCrying = New System.Windows.Forms.PictureBox()
        Me.picLove = New System.Windows.Forms.PictureBox()
        Me.picSad = New System.Windows.Forms.PictureBox()
        Me.picTired = New System.Windows.Forms.PictureBox()
        Me.picHappy = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picCrying, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCrying
        '
        Me.picCrying.Image = CType(resources.GetObject("picCrying.Image"), System.Drawing.Image)
        Me.picCrying.Location = New System.Drawing.Point(32, 43)
        Me.picCrying.Name = "picCrying"
        Me.picCrying.Size = New System.Drawing.Size(125, 105)
        Me.picCrying.TabIndex = 0
        Me.picCrying.TabStop = False
        '
        'picLove
        '
        Me.picLove.Image = CType(resources.GetObject("picLove.Image"), System.Drawing.Image)
        Me.picLove.Location = New System.Drawing.Point(314, 43)
        Me.picLove.Name = "picLove"
        Me.picLove.Size = New System.Drawing.Size(125, 105)
        Me.picLove.TabIndex = 1
        Me.picLove.TabStop = False
        '
        'picSad
        '
        Me.picSad.Image = CType(resources.GetObject("picSad.Image"), System.Drawing.Image)
        Me.picSad.Location = New System.Drawing.Point(454, 43)
        Me.picSad.Name = "picSad"
        Me.picSad.Size = New System.Drawing.Size(125, 105)
        Me.picSad.TabIndex = 2
        Me.picSad.TabStop = False
        '
        'picTired
        '
        Me.picTired.Image = CType(resources.GetObject("picTired.Image"), System.Drawing.Image)
        Me.picTired.Location = New System.Drawing.Point(596, 43)
        Me.picTired.Name = "picTired"
        Me.picTired.Size = New System.Drawing.Size(125, 105)
        Me.picTired.TabIndex = 3
        Me.picTired.TabStop = False
        '
        'picHappy
        '
        Me.picHappy.Image = CType(resources.GetObject("picHappy.Image"), System.Drawing.Image)
        Me.picHappy.Location = New System.Drawing.Point(173, 43)
        Me.picHappy.Name = "picHappy"
        Me.picHappy.Size = New System.Drawing.Size(125, 105)
        Me.picHappy.TabIndex = 4
        Me.picHappy.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Location = New System.Drawing.Point(33, 187)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(517, 91)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(567, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 51)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 325)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picHappy)
        Me.Controls.Add(Me.picTired)
        Me.Controls.Add(Me.picSad)
        Me.Controls.Add(Me.picLove)
        Me.Controls.Add(Me.picCrying)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monkey Emoji"
        CType(Me.picCrying, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picCrying As PictureBox
    Friend WithEvents picLove As PictureBox
    Friend WithEvents picSad As PictureBox
    Friend WithEvents picTired As PictureBox
    Friend WithEvents picHappy As PictureBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnExit As Button
End Class

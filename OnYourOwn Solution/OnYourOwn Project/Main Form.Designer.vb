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
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picArt3 = New System.Windows.Forms.PictureBox()
        Me.picArt2 = New System.Windows.Forms.PictureBox()
        Me.picArt1 = New System.Windows.Forms.PictureBox()
        CType(Me.picArt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(262, 398)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(464, 78)
        Me.lblText.TabIndex = 3
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(822, 435)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picArt3
        '
        Me.picArt3.Image = Global.OnYourOwn_Project.My.Resources.Resources.Art3
        Me.picArt3.Location = New System.Drawing.Point(673, 41)
        Me.picArt3.Name = "picArt3"
        Me.picArt3.Size = New System.Drawing.Size(265, 308)
        Me.picArt3.TabIndex = 2
        Me.picArt3.TabStop = False
        '
        'picArt2
        '
        Me.picArt2.Image = Global.OnYourOwn_Project.My.Resources.Resources.Art2
        Me.picArt2.Location = New System.Drawing.Point(355, 41)
        Me.picArt2.Name = "picArt2"
        Me.picArt2.Size = New System.Drawing.Size(265, 308)
        Me.picArt2.TabIndex = 1
        Me.picArt2.TabStop = False
        '
        'picArt1
        '
        Me.picArt1.Image = Global.OnYourOwn_Project.My.Resources.Resources.Art1
        Me.picArt1.Location = New System.Drawing.Point(39, 41)
        Me.picArt1.Name = "picArt1"
        Me.picArt1.Size = New System.Drawing.Size(265, 308)
        Me.picArt1.TabIndex = 0
        Me.picArt1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 528)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.picArt3)
        Me.Controls.Add(Me.picArt2)
        Me.Controls.Add(Me.picArt1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Art Work"
        CType(Me.picArt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picArt1 As PictureBox
    Friend WithEvents picArt2 As PictureBox
    Friend WithEvents picArt3 As PictureBox
    Friend WithEvents lblText As Label
    Friend WithEvents btnExit As Button
End Class

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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picHours = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        CType(Me.picHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(781, 453)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 43)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picHours
        '
        Me.picHours.Image = Global.Florist_Project.My.Resources.Resources.Hours
        Me.picHours.Location = New System.Drawing.Point(392, 142)
        Me.picHours.Name = "picHours"
        Me.picHours.Size = New System.Drawing.Size(520, 209)
        Me.picHours.TabIndex = 3
        Me.picHours.TabStop = False
        Me.picHours.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Florist_Project.My.Resources.Resources.Message
        Me.PictureBox2.Location = New System.Drawing.Point(392, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(520, 113)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Florist_Project.My.Resources.Resources.Florist
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 473)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(598, 453)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(128, 41)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "&Hide hours"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(409, 453)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(128, 41)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "&Show hours"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.picHours)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Florist Haven"
        CType(Me.picHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picHours As PictureBox
    Friend WithEvents btnHide As Button
    Friend WithEvents btnShow As Button
End Class

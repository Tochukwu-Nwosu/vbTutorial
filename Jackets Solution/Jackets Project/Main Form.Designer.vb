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
        Me.picJacket = New System.Windows.Forms.PictureBox()
        Me.btnSizeChart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picChart = New System.Windows.Forms.PictureBox()
        CType(Me.picJacket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picJacket
        '
        Me.picJacket.Image = CType(resources.GetObject("picJacket.Image"), System.Drawing.Image)
        Me.picJacket.Location = New System.Drawing.Point(36, 33)
        Me.picJacket.Name = "picJacket"
        Me.picJacket.Size = New System.Drawing.Size(411, 422)
        Me.picJacket.TabIndex = 0
        Me.picJacket.TabStop = False
        '
        'btnSizeChart
        '
        Me.btnSizeChart.Location = New System.Drawing.Point(479, 35)
        Me.btnSizeChart.Name = "btnSizeChart"
        Me.btnSizeChart.Size = New System.Drawing.Size(149, 57)
        Me.btnSizeChart.TabIndex = 1
        Me.btnSizeChart.Text = "&Size Chart"
        Me.btnSizeChart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(756, 35)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 57)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picChart
        '
        Me.picChart.Image = CType(resources.GetObject("picChart.Image"), System.Drawing.Image)
        Me.picChart.Location = New System.Drawing.Point(479, 114)
        Me.picChart.Name = "picChart"
        Me.picChart.Size = New System.Drawing.Size(426, 278)
        Me.picChart.TabIndex = 3
        Me.picChart.TabStop = False
        Me.picChart.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.picChart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSizeChart)
        Me.Controls.Add(Me.picJacket)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jackets and More"
        CType(Me.picJacket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picJacket As PictureBox
    Friend WithEvents btnSizeChart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picChart As PictureBox
End Class

' Name:               Colors Project
' Purpose:            Display colors and their name in Spanish
' Programmer:         Tochukwu Nwousu     2017/1/66008CT
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click

        Dim strColorName As String = "Azul"
        lblSpanish.Text = strColorName
        lblSpanish.BackColor = Color.Blue

    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click

        Dim strColorName As String = "Verde"
        lblSpanish.Text = strColorName
        lblSpanish.BackColor = Color.Green

    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click

        Dim strColorName As String = "Rojo"
        lblSpanish.Text = strColorName
        lblSpanish.BackColor = Color.Red

    End Sub

End Class

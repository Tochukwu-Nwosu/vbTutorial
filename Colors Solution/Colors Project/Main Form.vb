Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
    ' Name:               Colors Project
    ' Purpose:            Display color's name in Spanish
    ' Programmer:         Tochukwu Nwousu     2017/1/66008CT
    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click

        Dim strColorName As String = "Azul"
        lblSpanish.Text = strColorName

    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click

        Dim strColorName As String = "Verde"
        lblSpanish.Text = strColorName

    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click

        Dim strColorName As String = "Rojo"
        lblSpanish.Text = strColorName

    End Sub

End Class

' Name:                             Fixit Project
' Purpose:                          Display price of parrot
' Programmer:                       Tochukwu Nwosu    2017/1/66008CT
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click

        Dim strPrice As String = "£5.45"
        lblPrice.Text = strPrice

    End Sub

End Class

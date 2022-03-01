' Name:                Florist Project
' Purpose:             Display Store Information
' Programmer:          Tochukwu Nwosu 2017/1/66008CT

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        picHours.Visible = True

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        picHours.Visible = False

    End Sub
End Class

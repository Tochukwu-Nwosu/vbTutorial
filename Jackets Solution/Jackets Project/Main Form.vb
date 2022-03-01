' Name:          Jackets Project.
' Purpose:       Display Jacket Size Chart.
' Programmer:    Tochukwu Nwosu   2017/1/66008CT

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnSizeChart_Click(sender As Object, e As EventArgs) Handles btnSizeChart.Click

        picChart.Visible = True

    End Sub

End Class

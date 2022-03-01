' Name:          Jackets Project.
' Purpose:       Display Diferent Colors of Jacket and Size Chart.
' Programmer:    Tochukwu Nwosu   2017/1/66008CT

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnSizeChart_Click(sender As Object, e As EventArgs) Handles btnSizeChart.Click

        picChart.Visible = True

    End Sub

    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click

        picJacket.Image = My.Resources.Black

    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click

        picJacket.Image = My.Resources.Blue

    End Sub

    Private Sub btnBrown_Click(sender As Object, e As EventArgs) Handles btnBrown.Click

        picJacket.Image = My.Resources.Brown

    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click

        picJacket.Image = My.Resources.Red

    End Sub

End Class

' Name:                            Art Work Project
' Purpose:                         Display Art Work
' Programmer:                      Tochukwu Nwosu    2017/1/66008CT
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub picArt1_Click(sender As Object, e As EventArgs) Handles picArt1.Click

        Dim strText As String = "Image 1"
        lblText.Text = strText

    End Sub

    Private Sub picArt2_Click(sender As Object, e As EventArgs) Handles picArt2.Click

        Dim strText As String = "Image 2"
        lblText.Text = strText

    End Sub

    Private Sub picArt3_Click(sender As Object, e As EventArgs) Handles picArt3.Click

        Dim strText As String = "Image 3"
        lblText.Text = strText

    End Sub

End Class

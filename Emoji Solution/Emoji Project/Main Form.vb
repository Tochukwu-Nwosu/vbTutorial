Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub picCrying_Click(sender As Object, e As EventArgs) Handles picCrying.Click

        Dim strMessage As String = "I am Crying."
        lblMessage.Text = strMessage

    End Sub

    Private Sub picHappy_Click(sender As Object, e As EventArgs) Handles picHappy.Click

        Dim strMessage As String = "I am Happy."
        lblMessage.Text = strMessage

    End Sub
    ' Name:                     Emoji Project
    ' Purpose:                  Display Emoji Discription.
    ' Programmer:               Tochukwu Nwosu  2017/1/66008CT
    Private Sub picLove_Click(sender As Object, e As EventArgs) Handles picLove.Click

        Dim strMessage As String = "I am in Love."
        lblMessage.Text = strMessage

    End Sub

    Private Sub picSad_Click(sender As Object, e As EventArgs) Handles picSad.Click

        Dim strMessage As String = "I am Sad."
        lblMessage.Text = strMessage

    End Sub

    Private Sub picTired_Click(sender As Object, e As EventArgs) Handles picTired.Click

        Dim strMessage As String = "I am Tired."
        lblMessage.Text = strMessage

    End Sub

End Class

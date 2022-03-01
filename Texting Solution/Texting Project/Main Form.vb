' Name:                         Texting Project                             
' Purpose:                      Displays text meanings                
' Programmer:                   Tochukwu Nwosu   2017/1/66008CT     
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub picBFF_Click(sender As Object, e As EventArgs) Handles picBFF.Click

        Dim strMeaning As String = "Best friends forever"
        lblMeaning.Text = strMeaning

    End Sub

    Private Sub picBRB_Click(sender As Object, e As EventArgs) Handles picBRB.Click

        Dim strMeaning As String = "Be right back"
        lblMeaning.Text = strMeaning

    End Sub

    Private Sub picIDK_Click(sender As Object, e As EventArgs) Handles picIDK.Click

        Dim strMeaning As String = "I don't know"
        lblMeaning.Text = strMeaning

    End Sub

    Private Sub picLOL_Click(sender As Object, e As EventArgs) Handles picLOL.Click

        Dim strMeaning As String = "Laugh out loud"
        lblMeaning.Text = strMeaning

    End Sub

    Private Sub picSRY_Click(sender As Object, e As EventArgs) Handles picSRY.Click

        Dim strMeaning As String = "Sorry"
        lblMeaning.Text = strMeaning

    End Sub

    Private Sub picXO_Click(sender As Object, e As EventArgs) Handles picXO.Click

        Dim strMeaning As String = "Hugs and kisses"
        lblMeaning.Text = strMeaning

    End Sub

End Class

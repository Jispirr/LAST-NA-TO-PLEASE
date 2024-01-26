Public Class Form1

    Dim Attempts As Integer = 0

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim UserLogin As String = UserName.Text
        Dim UserPass As String = PassWord.Text

        If UserLogin = "a" And UserPass = "a" Then
            Me.Hide()
            Choices.Show()
            Attempts = 0
        Else
            Attempts += 1
            Label1.Text = "Wrong Credentials. Please try again!"


            If Attempts >= 5 Then
                LoginButton.Enabled = False
                Label1.Hide()
                Label2.Text = "Too many failed attempts. Access locked."
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

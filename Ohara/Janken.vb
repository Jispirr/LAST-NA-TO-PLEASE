Public Class Janken
    Private random As New Random()

    Private Sub Janken(playerChoice As String)

        Dim choices() As String = {"🏔️", "📜", "💇"}
        Dim computerChoice As String = choices(random.Next(choices.Length))

        ButtonUser.Text = playerChoice
        ButtonComputer.Text = computerChoice

        Winner(playerChoice, computerChoice)

    End Sub

    Private Sub Winner(playerChoice As String, computerChoice As String)

        If playerChoice = computerChoice Then

            LabelResult.Text = "It's a TIE!"
            ButtonScissor.Enabled = False
            ButtonRock.Enabled = False
            ButtonPaper.Enabled = False

        ElseIf (playerChoice = "🏔️" AndAlso computerChoice = "💇") OrElse
               (playerChoice = "💇" AndAlso computerChoice = "📜") OrElse
               (playerChoice = "📜" AndAlso computerChoice = "🏔️") Then

            LabelResult.Text = "You WIN!"
            ButtonScissor.Enabled = False
            ButtonRock.Enabled = False
            ButtonPaper.Enabled = False

        Else

            LabelResult.Text = "You LOSE!"
            ButtonScissor.Enabled = False
            ButtonRock.Enabled = False
            ButtonPaper.Enabled = False

        End If

    End Sub

    Private Sub ButtonRock_Click(sender As Object, e As EventArgs) Handles ButtonRock.Click
        Janken("🏔️")
    End Sub

    Private Sub ButtonPaper_Click(sender As Object, e As EventArgs) Handles ButtonPaper.Click
        Janken("📜")
    End Sub

    Private Sub ButtonScissor_Click(sender As Object, e As EventArgs) Handles ButtonScissor.Click
        Janken("💇")
    End Sub

    Private Sub ButtonTryAgain_Click(sender As Object, e As EventArgs) Handles ButtonTry.Click

        ButtonUser.Text = ""
        ButtonComputer.Text = ""
        LabelResult.Text = ""

        ButtonScissor.Enabled = True
        ButtonRock.Enabled = True
        ButtonPaper.Enabled = True

    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs)
        MessageBox.Show("ERROR: Choose Between the 3 choices below.")
    End Sub

    Private Sub ButtonComputer_Click(sender As Object, e As EventArgs)
        MessageBox.Show("ERROR: Choose Between the 3 choices below.")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Choices.Show()
        Me.Hide()
    End Sub

End Class
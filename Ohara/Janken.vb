Public Class Janken

    Private random As New Random()
    Private Sub Janken(playerChoice As String)

        Dim choices() As String = {"🏔️", "📜", "💇"}
        Dim computerChoice As String = choices(random.Next(choices.Length))

        ButtonUser.Text = playerChoice
        ButtonComputer.Text = computerChoice

        Winner(playerChoice, computerChoice)

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

    Private Sub Winner(playerChoice As String, computerChoice As String)

        If playerChoice = computerChoice Then

            LabelResult.Text = "It's a TIE!"


        ElseIf (playerChoice = "🏔️" AndAlso computerChoice = "💇") OrElse
               (playerChoice = "💇" AndAlso computerChoice = "📜") OrElse
               (playerChoice = "📜" AndAlso computerChoice = "🏔️") Then

            LabelResult.Text = "You WIN!"

            UserScore.Text += 1

        Else

            LabelResult.Text = "You LOSE!"

            ComputerScore.Text += 1

        End If

    End Sub


    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click

        ButtonUser.Text = ""
        ButtonComputer.Text = ""
        LabelResult.Text = ""
        UserScore.Text = "0"
        ComputerScore.Text = "0"


    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonUser.Click
        MessageBox.Show("ERROR: Choose Between the 3 choices below.")
    End Sub

    Private Sub ButtonComputer_Click(sender As Object, e As EventArgs) Handles ButtonComputer.Click
        MessageBox.Show("ERROR: Choose Between the 3 choices below.")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Choices.Show()
        Me.Hide()
    End Sub

    Private Sub Janken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
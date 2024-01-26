Public Class Choices
    Private Sub CalculatorButton_Click(sender As Object, e As EventArgs) Handles CalculatorButton.Click
        Calculator.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles JankenButton.Click
        Janken.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles GlassGameButton.Click
        Glassgame.Show()
        Me.Hide()

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()

    End Sub
End Class
Public Class Calculator

    Dim FirstNumber, SecondNumber As Double
    Dim ChoiceOperator As String

    Private Sub ButtonOne_Click(sender As Object, e As EventArgs) Handles ButtonOne.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub ButtonTwo_Click(sender As Object, e As EventArgs) Handles ButtonTwo.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub ButtonThree_Click(sender As Object, e As EventArgs) Handles ButtonThree.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub ButtonFour_Click(sender As Object, e As EventArgs) Handles ButtonFour.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub ButtonFive_Click(sender As Object, e As EventArgs) Handles ButtonFive.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub ButtonSix_Click(sender As Object, e As EventArgs) Handles ButtonSix.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub ButtonSeven_Click(sender As Object, e As EventArgs) Handles ButtonSeven.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub ButtonEight_Click(sender As Object, e As EventArgs) Handles ButtonEight.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub ButtonNine_Click(sender As Object, e As EventArgs) Handles ButtonNine.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonZero.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        FirstNumber = Val(TextBox1.Text)
        TextBox1.Text = ""

    End Sub
    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        Dim Result As Double
        SecondNumber = Val(TextBox1.Text)

        Select Case ChoiceOperator
            Case "+"
                Result = FirstNumber + SecondNumber
                TextBox1.Text = Result.ToString()
            Case "-"
                Result = FirstNumber - SecondNumber
                TextBox1.Text = Result.ToString()
            Case "/"
                Result = FirstNumber / SecondNumber
                TextBox1.Text = Result.ToString()
            Case "*"
                Result = FirstNumber * SecondNumber
                TextBox1.Text = Result.ToString()

        End Select

        TextBox1.Text = Result.ToString()
    End Sub

    Private Sub ButtonAddition_Click(sender As Object, e As EventArgs) Handles ButtonAddition.Click
        FirstNumber = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        ChoiceOperator = "+"

    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        FirstNumber = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        ChoiceOperator = "-"

    End Sub
    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiplication.Click
        FirstNumber = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        ChoiceOperator = "*"
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        FirstNumber = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        ChoiceOperator = "/"

    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Choices.Show()
        Close()

    End Sub
End Class

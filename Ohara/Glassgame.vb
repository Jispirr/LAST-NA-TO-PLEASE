Public Class Glassgame
    Dim random As New Random()
    Dim Mee As Integer = 1
    Dim EndGame As Boolean = False

    Private Sub Glass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetMee()
        DisableUpdate()

        LabelDIED.Visible = False
        ButtonTryAgain.Visible = False
    End Sub

    Private Sub SetMee()
        Me.Controls("tile" & Mee).Text = "🤸🏽‍"
    End Sub

    Private Sub MoveUser(nextPosition As Integer)

        Me.Controls("tile" & Mee).Text = ""
        Mee = nextPosition
        SetMee()
        DisableUpdate()
    End Sub

    Private Sub CheckEndGame()
        If Mee = 14 Then
            MessageBox.Show("PANALO KA")
            ResetGame()
        ElseIf random.Next(2) = 0 Then
            Me.Controls("tile" & Mee).Text = "☠️"
            For o As Integer = 1 To 14
                Me.Controls("tile" & o).Enabled = False

            Next
            LabelDIED.Text = "YOU DIED!"
            LabelDIED.Visible = True
            ButtonTryAgain.Visible = True
            EndGame = True
        End If
    End Sub

    Private Sub ResetGame()
        EndGame = False
        ButtonTryAgain.Visible = False
        LabelDIED.Visible = False

        For i As Integer = 1 To 14
            Me.Controls("tile" & i).Text = ""
        Next
        Mee = 1
        SetMee()
        DisableUpdate()
    End Sub

    Private Sub DisableUpdate()
        For i As Integer = 1 To 14
            Me.Controls("tile" & i).Enabled = False
        Next
        If Mee = 1 Then
            Tile2.Enabled = True
            Tile3.Enabled = True
        ElseIf Mee = 2 Or Mee = 3 Then
            Tile4.Enabled = True
            Tile5.Enabled = True
        ElseIf Mee = 4 Or Mee = 5 Then
            Tile6.Enabled = True
            Tile7.Enabled = True
        ElseIf Mee = 6 Or Mee = 7 Then
            Tile8.Enabled = True
            Tile9.Enabled = True
        ElseIf Mee = 8 Or Mee = 9 Then
            Tile10.Enabled = True
            Tile11.Enabled = True
        ElseIf Mee = 10 Or Mee = 11 Then
            Tile12.Enabled = True
            Tile13.Enabled = True
        ElseIf Mee = 12 Or Mee = 13 Then
            Tile14.Enabled = True
        End If

    End Sub

    Private Sub tile2_Click(sender As Object, e As EventArgs) Handles Tile2.Click
        If Not EndGame Then
            MoveUser(2)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile3_Click(sender As Object, e As EventArgs) Handles Tile3.Click
        If Not EndGame Then
            MoveUser(3)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile4_Click(sender As Object, e As EventArgs) Handles Tile4.Click
        If Not EndGame Then
            MoveUser(4)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile5_Click(sender As Object, e As EventArgs) Handles Tile5.Click
        If Not EndGame Then
            MoveUser(5)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile6_Click(sender As Object, e As EventArgs) Handles Tile6.Click
        If Not EndGame Then
            MoveUser(6)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile7_Click(sender As Object, e As EventArgs) Handles Tile7.Click
        If Not EndGame Then
            MoveUser(7)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile8_Click(sender As Object, e As EventArgs) Handles Tile8.Click
        If Not EndGame Then
            MoveUser(8)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile9_Click(sender As Object, e As EventArgs) Handles Tile9.Click
        If Not EndGame Then
            MoveUser(9)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile10_Click(sender As Object, e As EventArgs) Handles Tile10.Click
        If Not EndGame Then
            MoveUser(10)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile11_Click(sender As Object, e As EventArgs) Handles Tile11.Click
        If Not EndGame Then
            MoveUser(11)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile12_Click(sender As Object, e As EventArgs) Handles Tile12.Click
        If Not EndGame Then
            MoveUser(12)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile13_Click(sender As Object, e As EventArgs) Handles Tile13.Click
        If Not EndGame Then
            MoveUser(13)
            CheckEndGame()
        End If

    End Sub

    Private Sub tile14_Click(sender As Object, e As EventArgs) Handles Tile14.Click
        If Not EndGame Then
            MoveUser(14)
            CheckEndGame()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Choices.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonTryAgain_Click(sender As Object, e As EventArgs) Handles ButtonTryAgain.Click
        ResetGame()
    End Sub
End Class
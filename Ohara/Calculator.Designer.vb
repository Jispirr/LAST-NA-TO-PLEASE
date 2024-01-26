<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        ButtonSeven = New Button()
        ButtonEight = New Button()
        ButtonNine = New Button()
        ButtonAddition = New Button()
        ButtonFour = New Button()
        ButtonFive = New Button()
        ButtonSix = New Button()
        ButtonMinus = New Button()
        ButtonOne = New Button()
        ButtonTwo = New Button()
        ButtonThree = New Button()
        ButtonMultiplication = New Button()
        ButtonEquals = New Button()
        ButtonZero = New Button()
        ButtonDivision = New Button()
        ButtonClear = New Button()
        BackButton = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Black", 24F)
        TextBox1.Location = New Point(12, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(318, 51)
        TextBox1.TabIndex = 0
        ' 
        ' ButtonSeven
        ' 
        ButtonSeven.FlatStyle = FlatStyle.Popup
        ButtonSeven.Font = New Font("Segoe UI Black", 23F)
        ButtonSeven.Location = New Point(12, 113)
        ButtonSeven.Name = "ButtonSeven"
        ButtonSeven.Size = New Size(75, 66)
        ButtonSeven.TabIndex = 1
        ButtonSeven.Text = "7"
        ButtonSeven.UseVisualStyleBackColor = True
        ' 
        ' ButtonEight
        ' 
        ButtonEight.FlatStyle = FlatStyle.Popup
        ButtonEight.Font = New Font("Segoe UI Black", 23F)
        ButtonEight.Location = New Point(93, 113)
        ButtonEight.Name = "ButtonEight"
        ButtonEight.Size = New Size(75, 66)
        ButtonEight.TabIndex = 2
        ButtonEight.Text = "8"
        ButtonEight.UseVisualStyleBackColor = True
        ' 
        ' ButtonNine
        ' 
        ButtonNine.FlatStyle = FlatStyle.Popup
        ButtonNine.Font = New Font("Segoe UI Black", 23F)
        ButtonNine.Location = New Point(174, 113)
        ButtonNine.Name = "ButtonNine"
        ButtonNine.Size = New Size(75, 66)
        ButtonNine.TabIndex = 3
        ButtonNine.Text = "9"
        ButtonNine.UseVisualStyleBackColor = True
        ' 
        ' ButtonAddition
        ' 
        ButtonAddition.FlatStyle = FlatStyle.Popup
        ButtonAddition.Font = New Font("Segoe UI Black", 23F)
        ButtonAddition.Location = New Point(255, 113)
        ButtonAddition.Name = "ButtonAddition"
        ButtonAddition.Size = New Size(75, 66)
        ButtonAddition.TabIndex = 4
        ButtonAddition.Text = "+"
        ButtonAddition.UseVisualStyleBackColor = True
        ' 
        ' ButtonFour
        ' 
        ButtonFour.FlatStyle = FlatStyle.Popup
        ButtonFour.Font = New Font("Segoe UI Black", 23F)
        ButtonFour.Location = New Point(12, 185)
        ButtonFour.Name = "ButtonFour"
        ButtonFour.Size = New Size(75, 66)
        ButtonFour.TabIndex = 5
        ButtonFour.Text = "4"
        ButtonFour.UseVisualStyleBackColor = True
        ' 
        ' ButtonFive
        ' 
        ButtonFive.FlatStyle = FlatStyle.Popup
        ButtonFive.Font = New Font("Segoe UI Black", 23F)
        ButtonFive.Location = New Point(93, 185)
        ButtonFive.Name = "ButtonFive"
        ButtonFive.Size = New Size(75, 66)
        ButtonFive.TabIndex = 6
        ButtonFive.Text = "5"
        ButtonFive.UseVisualStyleBackColor = True
        ' 
        ' ButtonSix
        ' 
        ButtonSix.FlatStyle = FlatStyle.Popup
        ButtonSix.Font = New Font("Segoe UI Black", 23F)
        ButtonSix.Location = New Point(174, 185)
        ButtonSix.Name = "ButtonSix"
        ButtonSix.Size = New Size(75, 66)
        ButtonSix.TabIndex = 7
        ButtonSix.Text = "6"
        ButtonSix.UseVisualStyleBackColor = True
        ' 
        ' ButtonMinus
        ' 
        ButtonMinus.FlatStyle = FlatStyle.Popup
        ButtonMinus.Font = New Font("Segoe UI Black", 23F)
        ButtonMinus.Location = New Point(254, 185)
        ButtonMinus.Name = "ButtonMinus"
        ButtonMinus.Size = New Size(75, 66)
        ButtonMinus.TabIndex = 8
        ButtonMinus.Text = "-"
        ButtonMinus.UseVisualStyleBackColor = True
        ' 
        ' ButtonOne
        ' 
        ButtonOne.FlatStyle = FlatStyle.Popup
        ButtonOne.Font = New Font("Segoe UI Black", 23F)
        ButtonOne.Location = New Point(12, 257)
        ButtonOne.Name = "ButtonOne"
        ButtonOne.Size = New Size(75, 66)
        ButtonOne.TabIndex = 9
        ButtonOne.Text = "1"
        ButtonOne.UseVisualStyleBackColor = True
        ' 
        ' ButtonTwo
        ' 
        ButtonTwo.FlatStyle = FlatStyle.Popup
        ButtonTwo.Font = New Font("Segoe UI Black", 23F)
        ButtonTwo.Location = New Point(93, 257)
        ButtonTwo.Name = "ButtonTwo"
        ButtonTwo.Size = New Size(75, 66)
        ButtonTwo.TabIndex = 10
        ButtonTwo.Text = "2"
        ButtonTwo.UseVisualStyleBackColor = True
        ' 
        ' ButtonThree
        ' 
        ButtonThree.FlatStyle = FlatStyle.Popup
        ButtonThree.Font = New Font("Segoe UI Black", 23F)
        ButtonThree.Location = New Point(174, 257)
        ButtonThree.Name = "ButtonThree"
        ButtonThree.Size = New Size(75, 66)
        ButtonThree.TabIndex = 11
        ButtonThree.Text = "3"
        ButtonThree.UseVisualStyleBackColor = True
        ' 
        ' ButtonMultiplication
        ' 
        ButtonMultiplication.FlatStyle = FlatStyle.Popup
        ButtonMultiplication.Font = New Font("Segoe UI Black", 23F)
        ButtonMultiplication.Location = New Point(254, 257)
        ButtonMultiplication.Name = "ButtonMultiplication"
        ButtonMultiplication.Size = New Size(75, 66)
        ButtonMultiplication.TabIndex = 12
        ButtonMultiplication.Text = "x"
        ButtonMultiplication.UseVisualStyleBackColor = True
        ' 
        ' ButtonEquals
        ' 
        ButtonEquals.FlatStyle = FlatStyle.Popup
        ButtonEquals.Font = New Font("Segoe UI Black", 23F)
        ButtonEquals.Location = New Point(12, 329)
        ButtonEquals.Name = "ButtonEquals"
        ButtonEquals.Size = New Size(156, 66)
        ButtonEquals.TabIndex = 13
        ButtonEquals.Text = "="
        ButtonEquals.UseVisualStyleBackColor = True
        ' 
        ' ButtonZero
        ' 
        ButtonZero.FlatStyle = FlatStyle.Popup
        ButtonZero.Font = New Font("Segoe UI Black", 23F)
        ButtonZero.Location = New Point(174, 329)
        ButtonZero.Name = "ButtonZero"
        ButtonZero.Size = New Size(75, 66)
        ButtonZero.TabIndex = 15
        ButtonZero.Text = "0"
        ButtonZero.UseVisualStyleBackColor = True
        ' 
        ' ButtonDivision
        ' 
        ButtonDivision.FlatStyle = FlatStyle.Popup
        ButtonDivision.Font = New Font("Segoe UI Black", 23F)
        ButtonDivision.Location = New Point(254, 329)
        ButtonDivision.Name = "ButtonDivision"
        ButtonDivision.Size = New Size(75, 66)
        ButtonDivision.TabIndex = 16
        ButtonDivision.Text = "/"
        ButtonDivision.UseVisualStyleBackColor = True
        ' 
        ' ButtonClear
        ' 
        ButtonClear.FlatStyle = FlatStyle.Popup
        ButtonClear.Font = New Font("Segoe UI Black", 11F)
        ButtonClear.Location = New Point(255, 20)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(74, 30)
        ButtonClear.TabIndex = 17
        ButtonClear.Text = "Clear"
        ButtonClear.UseVisualStyleBackColor = True
        ' 
        ' BackButton
        ' 
        BackButton.FlatStyle = FlatStyle.Popup
        BackButton.Font = New Font("Segoe UI Black", 11F)
        BackButton.Location = New Point(12, 20)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(75, 30)
        BackButton.TabIndex = 18
        BackButton.Text = "Back"
        BackButton.UseVisualStyleBackColor = True
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(341, 404)
        Controls.Add(BackButton)
        Controls.Add(ButtonClear)
        Controls.Add(ButtonDivision)
        Controls.Add(ButtonZero)
        Controls.Add(ButtonEquals)
        Controls.Add(ButtonMultiplication)
        Controls.Add(ButtonThree)
        Controls.Add(ButtonTwo)
        Controls.Add(ButtonOne)
        Controls.Add(ButtonMinus)
        Controls.Add(ButtonSix)
        Controls.Add(ButtonFive)
        Controls.Add(ButtonFour)
        Controls.Add(ButtonAddition)
        Controls.Add(ButtonNine)
        Controls.Add(ButtonEight)
        Controls.Add(ButtonSeven)
        Controls.Add(TextBox1)
        Name = "Calculator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonSeven As Button
    Friend WithEvents ButtonEight As Button
    Friend WithEvents ButtonNine As Button
    Friend WithEvents ButtonAddition As Button
    Friend WithEvents ButtonFour As Button
    Friend WithEvents ButtonFive As Button
    Friend WithEvents ButtonSix As Button
    Friend WithEvents ButtonMinus As Button
    Friend WithEvents ButtonOne As Button
    Friend WithEvents ButtonTwo As Button
    Friend WithEvents ButtonThree As Button
    Friend WithEvents ButtonMultiplication As Button
    Friend WithEvents ButtonEquals As Button
    Friend WithEvents ButtonZero As Button
    Friend WithEvents ButtonDivision As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents BackButton As Button
End Class

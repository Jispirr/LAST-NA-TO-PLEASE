<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Janken
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Janken))
        Label1 = New Label()
        ButtonRock = New Button()
        ButtonPaper = New Button()
        ButtonScissor = New Button()
        ButtonUser = New Button()
        ButtonComputer = New Button()
        LabelUser = New Label()
        LabelComputer = New Label()
        LabelResult = New Label()
        ButtonTry = New Button()
        Button1 = New Button()
        UserScore = New Label()
        ComputerScore = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 50F)
        Label1.Location = New Point(241, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 89)
        Label1.TabIndex = 0
        Label1.Text = "JANKEN"
        ' 
        ' ButtonRock
        ' 
        ButtonRock.BackColor = SystemColors.ControlText
        ButtonRock.Font = New Font("Segoe UI Black", 24F)
        ButtonRock.ForeColor = SystemColors.HighlightText
        ButtonRock.Location = New Point(155, 297)
        ButtonRock.Name = "ButtonRock"
        ButtonRock.Size = New Size(134, 76)
        ButtonRock.TabIndex = 1
        ButtonRock.Text = "🏔️"
        ButtonRock.UseVisualStyleBackColor = False
        ' 
        ' ButtonPaper
        ' 
        ButtonPaper.BackColor = SystemColors.ControlText
        ButtonPaper.Font = New Font("Segoe UI Black", 24F)
        ButtonPaper.ForeColor = SystemColors.HighlightText
        ButtonPaper.Location = New Point(322, 288)
        ButtonPaper.Name = "ButtonPaper"
        ButtonPaper.Size = New Size(134, 76)
        ButtonPaper.TabIndex = 2
        ButtonPaper.Text = "📜"
        ButtonPaper.UseVisualStyleBackColor = False
        ' 
        ' ButtonScissor
        ' 
        ButtonScissor.BackColor = SystemColors.ControlText
        ButtonScissor.Font = New Font("Segoe UI Black", 24F)
        ButtonScissor.ForeColor = SystemColors.HighlightText
        ButtonScissor.Location = New Point(485, 297)
        ButtonScissor.Name = "ButtonScissor"
        ButtonScissor.Size = New Size(134, 76)
        ButtonScissor.TabIndex = 3
        ButtonScissor.Text = "💇"
        ButtonScissor.UseVisualStyleBackColor = False
        ' 
        ' ButtonUser
        ' 
        ButtonUser.BackColor = SystemColors.ControlText
        ButtonUser.Font = New Font("Segoe UI Black", 24F)
        ButtonUser.ForeColor = SystemColors.HighlightText
        ButtonUser.Location = New Point(247, 192)
        ButtonUser.Name = "ButtonUser"
        ButtonUser.Size = New Size(96, 59)
        ButtonUser.TabIndex = 4
        ButtonUser.UseVisualStyleBackColor = False
        ' 
        ' ButtonComputer
        ' 
        ButtonComputer.BackColor = SystemColors.ControlText
        ButtonComputer.Font = New Font("Segoe UI Black", 24F)
        ButtonComputer.ForeColor = SystemColors.HighlightText
        ButtonComputer.Location = New Point(439, 192)
        ButtonComputer.Name = "ButtonComputer"
        ButtonComputer.Size = New Size(96, 59)
        ButtonComputer.TabIndex = 5
        ButtonComputer.UseVisualStyleBackColor = False
        ' 
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.BackColor = Color.Transparent
        LabelUser.Font = New Font("Segoe UI Black", 9F)
        LabelUser.Location = New Point(277, 177)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(38, 15)
        LabelUser.TabIndex = 6
        LabelUser.Text = "User:"
        ' 
        ' LabelComputer
        ' 
        LabelComputer.AutoSize = True
        LabelComputer.BackColor = Color.Transparent
        LabelComputer.Font = New Font("Segoe UI Black", 9F)
        LabelComputer.Location = New Point(452, 177)
        LabelComputer.Name = "LabelComputer"
        LabelComputer.Size = New Size(71, 15)
        LabelComputer.TabIndex = 7
        LabelComputer.Text = "Computer:"
        ' 
        ' LabelResult
        ' 
        LabelResult.AutoSize = True
        LabelResult.BackColor = Color.Transparent
        LabelResult.Font = New Font("Segoe UI Black", 9F)
        LabelResult.Location = New Point(360, 270)
        LabelResult.Name = "LabelResult"
        LabelResult.Size = New Size(0, 15)
        LabelResult.TabIndex = 8
        ' 
        ' ButtonTry
        ' 
        ButtonTry.BackColor = SystemColors.ControlText
        ButtonTry.Font = New Font("Segoe UI Black", 9F)
        ButtonTry.ForeColor = SystemColors.HighlightText
        ButtonTry.Location = New Point(322, 386)
        ButtonTry.Name = "ButtonTry"
        ButtonTry.Size = New Size(134, 32)
        ButtonTry.TabIndex = 9
        ButtonTry.Text = "TRY AGAIN"
        ButtonTry.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlText
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Black", 9F)
        Button1.ForeColor = SystemColors.HighlightText
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 32)
        Button1.TabIndex = 10
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' UserScore
        ' 
        UserScore.AutoSize = True
        UserScore.BackColor = Color.Transparent
        UserScore.Font = New Font("Segoe UI Black", 11.0F)
        UserScore.Location = New Point(347, 217)
        UserScore.Name = "UserScore"
        UserScore.Size = New Size(18, 20)
        UserScore.TabIndex = 11
        UserScore.Text = "0"
        ' 
        ' ComputerScore
        ' 
        ComputerScore.AutoSize = True
        ComputerScore.BackColor = Color.Transparent
        ComputerScore.Font = New Font("Segoe UI Black", 11.0F)
        ComputerScore.Location = New Point(417, 218)
        ComputerScore.Name = "ComputerScore"
        ComputerScore.Size = New Size(18, 20)
        ComputerScore.TabIndex = 12
        ComputerScore.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 11.0F)
        Label3.Location = New Point(383, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(15, 20)
        Label3.TabIndex = 13
        Label3.Text = "-"
        ' 
        ' Janken
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(ComputerScore)
        Controls.Add(UserScore)
        Controls.Add(Button1)
        Controls.Add(ButtonTry)
        Controls.Add(LabelResult)
        Controls.Add(LabelComputer)
        Controls.Add(LabelUser)
        Controls.Add(ButtonComputer)
        Controls.Add(ButtonUser)
        Controls.Add(ButtonScissor)
        Controls.Add(ButtonPaper)
        Controls.Add(ButtonRock)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Janken"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Janken"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonRock As Button
    Friend WithEvents ButtonPaper As Button
    Friend WithEvents ButtonScissor As Button
    Friend WithEvents ButtonUser As Button
    Friend WithEvents ButtonComputer As Button
    Friend WithEvents LabelUser As Label
    Friend WithEvents LabelComputer As Label
    Friend WithEvents LabelResult As Label
    Friend WithEvents ButtonTry As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents UserScore As Label
    Friend WithEvents ComputerScore As Label
    Friend WithEvents Label3 As Label
End Class

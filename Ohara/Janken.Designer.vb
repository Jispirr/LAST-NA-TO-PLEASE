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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 50F)
        Label1.Location = New Point(247, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 89)
        Label1.TabIndex = 0
        Label1.Text = "JANKEN"
        ' 
        ' ButtonRock
        ' 
        ButtonRock.Location = New Point(155, 297)
        ButtonRock.Name = "ButtonRock"
        ButtonRock.Size = New Size(134, 76)
        ButtonRock.TabIndex = 1
        ButtonRock.Text = "🏔️"
        ButtonRock.UseVisualStyleBackColor = True
        ' 
        ' ButtonPaper
        ' 
        ButtonPaper.Location = New Point(322, 288)
        ButtonPaper.Name = "ButtonPaper"
        ButtonPaper.Size = New Size(134, 76)
        ButtonPaper.TabIndex = 2
        ButtonPaper.Text = "📜"
        ButtonPaper.UseVisualStyleBackColor = True
        ' 
        ' ButtonScissor
        ' 
        ButtonScissor.Location = New Point(485, 297)
        ButtonScissor.Name = "ButtonScissor"
        ButtonScissor.Size = New Size(134, 76)
        ButtonScissor.TabIndex = 3
        ButtonScissor.Text = "💇"
        ButtonScissor.UseVisualStyleBackColor = True
        ' 
        ' ButtonUser
        ' 
        ButtonUser.Location = New Point(247, 192)
        ButtonUser.Name = "ButtonUser"
        ButtonUser.Size = New Size(96, 59)
        ButtonUser.TabIndex = 4
        ButtonUser.UseVisualStyleBackColor = True
        ' 
        ' ButtonComputer
        ' 
        ButtonComputer.Location = New Point(439, 192)
        ButtonComputer.Name = "ButtonComputer"
        ButtonComputer.Size = New Size(96, 59)
        ButtonComputer.TabIndex = 5
        ButtonComputer.UseVisualStyleBackColor = True
        ' 
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.Location = New Point(280, 174)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(33, 15)
        LabelUser.TabIndex = 6
        LabelUser.Text = "User:"
        ' 
        ' LabelComputer
        ' 
        LabelComputer.AutoSize = True
        LabelComputer.Location = New Point(457, 174)
        LabelComputer.Name = "LabelComputer"
        LabelComputer.Size = New Size(64, 15)
        LabelComputer.TabIndex = 7
        LabelComputer.Text = "Computer:"
        ' 
        ' LabelResult
        ' 
        LabelResult.AutoSize = True
        LabelResult.Location = New Point(367, 270)
        LabelResult.Name = "LabelResult"
        LabelResult.Size = New Size(0, 15)
        LabelResult.TabIndex = 8
        ' 
        ' ButtonTry
        ' 
        ButtonTry.Location = New Point(322, 386)
        ButtonTry.Name = "ButtonTry"
        ButtonTry.Size = New Size(134, 32)
        ButtonTry.TabIndex = 9
        ButtonTry.Text = "TRY AGAIN"
        ButtonTry.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 32)
        Button1.TabIndex = 10
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Janken
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
End Class

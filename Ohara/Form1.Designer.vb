<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        UserName = New TextBox()
        PassWord = New TextBox()
        LoginButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' UserName
        ' 
        UserName.Location = New Point(145, 70)
        UserName.Name = "UserName"
        UserName.PlaceholderText = "Username"
        UserName.Size = New Size(158, 23)
        UserName.TabIndex = 0
        ' 
        ' PassWord
        ' 
        PassWord.Location = New Point(145, 99)
        PassWord.Name = "PassWord"
        PassWord.PasswordChar = "*"c
        PassWord.PlaceholderText = "Password"
        PassWord.Size = New Size(158, 23)
        PassWord.TabIndex = 1
        ' 
        ' LoginButton
        ' 
        LoginButton.Location = New Point(187, 128)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(75, 23)
        LoginButton.TabIndex = 2
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(137, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(131, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(444, 211)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LoginButton)
        Controls.Add(PassWord)
        Controls.Add(UserName)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UserName As TextBox
    Friend WithEvents PassWord As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class

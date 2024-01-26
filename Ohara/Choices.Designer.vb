<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choices
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
        CalculatorButton = New Button()
        JankenButton = New Button()
        GlassGameButton = New Button()
        CloseButton = New Button()
        SuspendLayout()
        ' 
        ' CalculatorButton
        ' 
        CalculatorButton.Font = New Font("Segoe UI Black", 24F)
        CalculatorButton.Location = New Point(205, 72)
        CalculatorButton.Name = "CalculatorButton"
        CalculatorButton.Size = New Size(391, 77)
        CalculatorButton.TabIndex = 0
        CalculatorButton.Text = "CALCULATOR"
        CalculatorButton.UseVisualStyleBackColor = True
        ' 
        ' JankenButton
        ' 
        JankenButton.Font = New Font("Segoe UI Black", 24F)
        JankenButton.Location = New Point(205, 155)
        JankenButton.Name = "JankenButton"
        JankenButton.Size = New Size(391, 77)
        JankenButton.TabIndex = 1
        JankenButton.Text = "JANKEN"
        JankenButton.UseVisualStyleBackColor = True
        ' 
        ' GlassGameButton
        ' 
        GlassGameButton.Font = New Font("Segoe UI Black", 24F)
        GlassGameButton.Location = New Point(205, 238)
        GlassGameButton.Name = "GlassGameButton"
        GlassGameButton.Size = New Size(391, 77)
        GlassGameButton.TabIndex = 2
        GlassGameButton.Text = "GLASS GAME"
        GlassGameButton.UseVisualStyleBackColor = True
        ' 
        ' CloseButton
        ' 
        CloseButton.Font = New Font("Segoe UI Black", 24F)
        CloseButton.Location = New Point(239, 321)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(327, 77)
        CloseButton.TabIndex = 3
        CloseButton.Text = "CLOSE"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' Choices
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CloseButton)
        Controls.Add(GlassGameButton)
        Controls.Add(JankenButton)
        Controls.Add(CalculatorButton)
        Name = "Choices"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Choices"
        ResumeLayout(False)
    End Sub

    Friend WithEvents CalculatorButton As Button
    Friend WithEvents JankenButton As Button
    Friend WithEvents GlassGameButton As Button
    Friend WithEvents CloseButton As Button
End Class

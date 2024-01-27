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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choices))
        CalculatorButton = New Button()
        JankenButton = New Button()
        GlassGameButton = New Button()
        CloseButton = New Button()
        SuspendLayout()
        ' 
        ' CalculatorButton
        ' 
        CalculatorButton.BackColor = SystemColors.HighlightText
        CalculatorButton.Font = New Font("Segoe UI Black", 24F)
        CalculatorButton.ForeColor = SystemColors.ControlText
        CalculatorButton.Location = New Point(205, 119)
        CalculatorButton.Name = "CalculatorButton"
        CalculatorButton.Size = New Size(391, 54)
        CalculatorButton.TabIndex = 0
        CalculatorButton.Text = "CALCULATOR"
        CalculatorButton.UseVisualStyleBackColor = False
        ' 
        ' JankenButton
        ' 
        JankenButton.BackColor = SystemColors.HighlightText
        JankenButton.Font = New Font("Segoe UI Black", 24F)
        JankenButton.ForeColor = SystemColors.ControlText
        JankenButton.Location = New Point(205, 179)
        JankenButton.Name = "JankenButton"
        JankenButton.Size = New Size(391, 53)
        JankenButton.TabIndex = 1
        JankenButton.Text = "JANKEN"
        JankenButton.UseVisualStyleBackColor = False
        ' 
        ' GlassGameButton
        ' 
        GlassGameButton.BackColor = SystemColors.HighlightText
        GlassGameButton.Font = New Font("Segoe UI Black", 24F)
        GlassGameButton.ForeColor = SystemColors.ControlText
        GlassGameButton.Location = New Point(205, 238)
        GlassGameButton.Name = "GlassGameButton"
        GlassGameButton.Size = New Size(391, 55)
        GlassGameButton.TabIndex = 2
        GlassGameButton.Text = "GLASS GAME"
        GlassGameButton.UseVisualStyleBackColor = False
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = SystemColors.HighlightText
        CloseButton.Font = New Font("Segoe UI Black", 24F)
        CloseButton.ForeColor = SystemColors.ControlText
        CloseButton.Location = New Point(282, 328)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(239, 55)
        CloseButton.TabIndex = 3
        CloseButton.Text = "CLOSE"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' Choices
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(CloseButton)
        Controls.Add(GlassGameButton)
        Controls.Add(JankenButton)
        Controls.Add(CalculatorButton)
        DoubleBuffered = True
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

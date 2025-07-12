<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        txtDisplay = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        btnLimpiar = New Button()
        btnSumar = New Button()
        btnIgual = New Button()
        btnDividir = New Button()
        btnRestar = New Button()
        btnMultiplicar = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(50, 72)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 40)
        Button1.TabIndex = 0
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Location = New Point(50, 20)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.Size = New Size(200, 23)
        txtDisplay.TabIndex = 1
        txtDisplay.TextAlign = HorizontalAlignment.Right
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(96, 72)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 40)
        Button2.TabIndex = 2
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(50, 118)
        Button3.Name = "Button3"
        Button3.Size = New Size(40, 40)
        Button3.TabIndex = 3
        Button3.Text = "4"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(142, 72)
        Button4.Name = "Button4"
        Button4.Size = New Size(40, 40)
        Button4.TabIndex = 4
        Button4.Text = "3"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(96, 118)
        Button5.Name = "Button5"
        Button5.Size = New Size(40, 40)
        Button5.TabIndex = 5
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(142, 118)
        Button6.Name = "Button6"
        Button6.Size = New Size(40, 40)
        Button6.TabIndex = 6
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(50, 164)
        Button7.Name = "Button7"
        Button7.Size = New Size(40, 40)
        Button7.TabIndex = 7
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(96, 164)
        Button8.Name = "Button8"
        Button8.Size = New Size(40, 40)
        Button8.TabIndex = 8
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(142, 164)
        Button9.Name = "Button9"
        Button9.Size = New Size(40, 40)
        Button9.TabIndex = 9
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(96, 210)
        Button10.Name = "Button10"
        Button10.Size = New Size(40, 40)
        Button10.TabIndex = 10
        Button10.Text = "0"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(50, 210)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(40, 40)
        btnLimpiar.TabIndex = 11
        btnLimpiar.Tag = ""
        btnLimpiar.Text = "c"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnSumar
        ' 
        btnSumar.Location = New Point(201, 72)
        btnSumar.Name = "btnSumar"
        btnSumar.Size = New Size(40, 40)
        btnSumar.TabIndex = 12
        btnSumar.Text = "+"
        btnSumar.UseVisualStyleBackColor = True
        ' 
        ' btnIgual
        ' 
        btnIgual.Location = New Point(201, 210)
        btnIgual.Name = "btnIgual"
        btnIgual.Size = New Size(40, 40)
        btnIgual.TabIndex = 13
        btnIgual.Text = "="
        btnIgual.UseVisualStyleBackColor = True
        ' 
        ' btnDividir
        ' 
        btnDividir.Location = New Point(142, 210)
        btnDividir.Name = "btnDividir"
        btnDividir.Size = New Size(40, 40)
        btnDividir.TabIndex = 14
        btnDividir.Text = "/"
        btnDividir.UseVisualStyleBackColor = True
        ' 
        ' btnRestar
        ' 
        btnRestar.Location = New Point(201, 118)
        btnRestar.Name = "btnRestar"
        btnRestar.Size = New Size(40, 40)
        btnRestar.TabIndex = 15
        btnRestar.Text = "-"
        btnRestar.UseVisualStyleBackColor = True
        ' 
        ' btnMultiplicar
        ' 
        btnMultiplicar.Location = New Point(201, 164)
        btnMultiplicar.Name = "btnMultiplicar"
        btnMultiplicar.Size = New Size(40, 40)
        btnMultiplicar.TabIndex = 16
        btnMultiplicar.Text = "*"
        btnMultiplicar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 361)
        Controls.Add(btnMultiplicar)
        Controls.Add(btnRestar)
        Controls.Add(btnDividir)
        Controls.Add(btnIgual)
        Controls.Add(btnSumar)
        Controls.Add(btnLimpiar)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(txtDisplay)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnDividir As Button

End Class

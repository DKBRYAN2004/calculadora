Public Class Form1
    Dim encendido As Boolean
    Dim operacion As Integer
    Dim numero1 As Double
    Dim numero2 As Double
    Dim resultado As Double
    Dim pantalla As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        encendido = True
        numero1 = 0
        numero2 = 0
        pantalla = "0"
        txtDisplay.Text = pantalla
    End Sub

    Private Sub btnEncender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If encendido Then
            pantalla = ""
            encendido = False
            txtDisplay.Text = ""
        Else
            encendido = True
            numero1 = 0
            numero2 = 0
            pantalla = "0"
            txtDisplay.Text = pantalla
        End If
    End Sub

    Private Sub btnNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        Dim btn As Button = CType(sender, Button)
        If encendido Then
            If pantalla = "0" Then
                pantalla = btn.Text
            Else
                pantalla &= btn.Text
            End If
            txtDisplay.Text = pantalla
        End If
    End Sub

    Private Sub btnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumar.Click
        If encendido Then
            operacion = 1
            numero1 = Double.Parse(pantalla)
            pantalla = "0"
        End If
        txtDisplay.Text = pantalla
    End Sub

    Private Sub btnIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgual.Click
        If encendido Then
            numero2 = Double.Parse(pantalla)
            pantalla = "0"
            If operacion = 1 Then
                resultado = numero1 + numero2
            End If
            pantalla = resultado.ToString()
            txtDisplay.Text = pantalla
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If encendido Then
            pantalla = "0"
            txtDisplay.Text = pantalla
        End If
    End Sub
End Class
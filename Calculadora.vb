Public Class Calculadora
    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fecha As Date
        fecha = Date.Now
        lblFecha.Text = fecha
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub lblSubtitulo_Click(sender As Object, e As EventArgs) Handles lblSubtitulo.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSubtitulo2.Click

    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        numero1 = txtNumero1.Text
        numero2 = txtNumero2.Text

        resultado = numero1 + numero2
        txtResultado.Text = resultado
    End Sub

    Private Sub txtResultado_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        numero1 = txtNumero1.Text
        numero2 = txtNumero2.Text

        resultado = numero1 - numero2
        txtResultado.Text = resultado
    End Sub

    Private Sub btnMultplicar_Click(sender As Object, e As EventArgs) Handles btnMultplicar.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        numero1 = txtNumero1.Text
        numero2 = txtNumero2.Text

        resultado = numero1 * numero2
        txtResultado.Text = resultado
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        numero1 = txtNumero1.Text
        numero2 = txtNumero2.Text

        resultado = numero1 / numero2
        txtResultado.Text = resultado
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        numero1 = txtNumero1.Text
        numero2 = txtNumero2.Text

        resultado = numero1 ^ numero2
        txtResultado.Text = resultado
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblNombreAutor.Click

    End Sub
End Class
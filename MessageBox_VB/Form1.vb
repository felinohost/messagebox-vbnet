Public Class Form1
    Private Sub btnProbar_Click(sender As Object, e As EventArgs) Handles btnProbar.Click

        MessageBox.Show("Hola Mundo!")
        MessageBox.Show("Hola Mundo!", "Mi Mensaje")
        MessageBox.Show("Hola Mundo!", "Mi Mensaje", MessageBoxButtons.OKCancel)
        MessageBox.Show("Hola Mundo!", "Mi Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        MessageBox.Show("Hola Mundo!", "Mi Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        MessageBox.Show("Hola Mundo!", "Mi Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        MessageBox.Show("Hola Mundo!", "Mi Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)


    End Sub

    Private Sub btnPregunta_Click(sender As Object, e As EventArgs) Handles btnPregunta.Click

        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("¿Desea Continaur?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Resultado = DialogResult.Yes Then MessageBox.Show("Presionaste SI")
        If Resultado = DialogResult.No Then MessageBox.Show("Presionaste NO")



    End Sub

    Private Sub btn_Modulo_Click(sender As Object, e As EventArgs) Handles btn_Modulo.Click
        MsgInformacion("Hola Mundo")
        MsgError("Ha ocurrido un Error")
        MsgWarning("El proceso se esta ejecuando")

        Dim Resultado As DialogResult
        Resultado = MsgPregunta("Esta operación no se puede reversar." & vbCrLf & "¿Deseas Continuar?")

        If Resultado = DialogResult.Yes Then MessageBox.Show("Presionaste SI")
        If Resultado = DialogResult.No Then MessageBox.Show("Presionaste NO")


    End Sub
End Class

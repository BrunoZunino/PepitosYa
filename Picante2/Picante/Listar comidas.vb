Public Class Listar_comidas

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        EditarComida.ShowDialog()
    End Sub

    Private Sub cerrarsesion_Click(sender As Object, e As EventArgs) Handles cerrarsesion.Click
        Application.Exit()
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        AgregarComida.ShowDialog()
    End Sub

    Private Sub cerrarsesion_MouseHover(sender As Object, e As EventArgs) Handles cerrarsesion.MouseHover
        cerrarsesion.BackColor = Color.DarkSlateGray
        cerrarsesion.ForeColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditarComida.ShowDialog()
    End Sub

    Private Sub Listar_comidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
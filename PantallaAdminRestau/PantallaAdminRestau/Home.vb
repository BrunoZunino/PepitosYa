Public Class Home
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub listComida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listComida.SelectedIndexChanged

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarComida.Show()
        AgregarComida.btnActualizar.Visible = False
        AgregarComida.BtnEliminar.Visible = False
        AgregarComida.BAgregar.Visible = True
    End Sub

    Private Sub lblComidas_Click(sender As Object, e As EventArgs) Handles lblComidas.Click
        AgregarComida.Show()
        AgregarComida.btnActualizar.Visible = True
        AgregarComida.BtnEliminar.Visible = True
        AgregarComida.BAgregar.Visible = False
    End Sub
End Class
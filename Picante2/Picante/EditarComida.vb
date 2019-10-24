Public Class EditarComida

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.DarkRed
        Button3.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.DarkSeaGreen
        Button1.ForeColor = Color.White
    End Sub

    Private Sub EditarComida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
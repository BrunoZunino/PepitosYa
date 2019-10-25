Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IniciarSesion.ShowDialog()

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub



    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove


        Button1.BackColor = Color.DarkSlateGray
        Button1.ForeColor = Color.White
    End Sub
End Class

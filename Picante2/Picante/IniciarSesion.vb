Imports Npgsql
Public Class IniciarSesion
    Dim correo As String
    Dim contrasena As String
    'BOTON INICIAR SESION
    Private Sub Sesion_Click(sender As Object, e As EventArgs) Handles Sesion.Click
        Try
            correo = TextBox1.Text
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

        Try
            Dim clasecnn = New conexionPGSQL
            Dim conexion As New NpgsqlConnection()
            conexion = clasecnn.AbrirConexion

            Dim cmd = New NpgsqlCommand()
            cmd.Connection = conexion

            Dim cadenaComando = "SELECT * FROM admin WHERE correo = @correo"

            cmd.CommandText = cadenaComando
            cmd.Parameters.AddWithValue("@correo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = correo

            'DESENCRIPTAR CONTRASEÑA
            'Dim DesCifrado as String
            'DesCifrado = Eramake.eCryptography.Decrypt(Cifrado)

            Dim lector As NpgsqlDataReader
            lector = cmd.ExecuteReader()

            If lector.HasRows Then
                lector.Read()
                'correo = lector(0).ToString
                password.Text = lector(1).ToString
            End If

            If (correo = correo) Then
                Listar_comidas.ShowDialog()
            End If


        Catch ex As Exception
            lblError.Text = ex.Message
        End Try


    End Sub

    'COLOR BOTONES
    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Sesion.MouseMove
        Sesion.BackColor = Color.DarkSlateGray
        Sesion.ForeColor = Color.White
    End Sub

    'BOTON IR ATRAS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub IniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

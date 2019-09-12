Imports Npgsql
Imports altaComida
Public Class AgregarComida
    Dim _altacomida As AltaComida
    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        NotificacionCS.ShowDialog()


        Dim _id As Integer
        Dim _nombre As String
        Dim _tipo As String
        Dim _precio As Integer
        Dim _tiempoPreparacion As Integer
        Dim _imagen As String
        Dim _ingredientes As String


        _nombre = TextBox1.Text
        _tipo = TextBox2.Text
        _precio = TextBox3.Text
        _tiempoPreparacion = TextBox4.Text
        _imagen = TextBox5.Text
        _ingredientes = TextBox6.Text


        Try
            Dim _altacomida As New AltaComida(_id, _nombre, _tipo, _precio, _tiempoPreparacion, _imagen, _ingredientes)

            Dim clasecnn = New conexionPGSQL
            Dim conexion As New Npgsql.NpgsqlConnection()
            conexion = clasecnn.AbrirConexion()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion

            Dim cadenaComando = "INSERT INTO COMIDA(_nombre, _tipo, _imagen)
            VALUES(@nombre, @tipo, @imagen)"
            cmd.CommandText = cadenaComando

            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = _nombre.Nombre
            cmd.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = _tipo.Tipo
            cmd.Parameters.Add("@imagen", NpgsqlTypes.NpgsqlDbType.Varchar, 500).Value = _imagen.Imagen

            'tabla restaurante_comida
            'cmd.Parameters.Add("@tiempoPreparacion", NpgsqlTypes.NpgsqlDbType.Varchar, 
            'cmd.Parameters.Add("@precio", NpgsqlTypes.NpgsqlDbType.Varchar, 



            cmd.Parameters.Clear()

        Catch ex As Exception



        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub AgregarComida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub agregar_MouseMove(sender As Object, e As MouseEventArgs) Handles agregar.MouseMove
        agregar.BackColor = Color.DarkSlateGray
        agregar.ForeColor = Color.White
    End Sub
End Class
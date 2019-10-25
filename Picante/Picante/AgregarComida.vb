Imports Npgsql
Imports altaComida
Public Class AgregarComida
    Dim _altacomida As AltaComida
    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click


        Dim _codigo As Integer
        Dim _nombre As String
        Dim _tipo As String
        Dim _precio As Integer
        Dim _tiempoPreparacion As Integer
        Dim _imagen As String
        Dim _ingredientes As String
        Dim _rut As Integer

        _codigo = TxbCodigo.Text
        _nombre = TextBox1.Text
        _tipo = TextBox2.Text
        _precio = TextBox3.Text
        _tiempoPreparacion = TextBox4.Text
        _imagen = TextBox5.Text
        _ingredientes = TextBox6.Text
        _rut = TextBoxRut.Text



        Try
            Dim _altacomida As New AltaComida(_codigo, _nombre, _tipo, _precio, _tiempoPreparacion, _imagen, _rut)

            Dim clasecnn = New conexionPGSQL
            Dim conexion As New Npgsql.NpgsqlConnection()
            conexion = clasecnn.AbrirConexion()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion

            Dim resultado As Integer

            Dim cadenaComando = "INSERT INTO comida (codigo, nombre, tipo, imagen) VALUES (@codigo, @nombre, @tipo, @imagen);"
            cmd.CommandText = cadenaComando

            cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = _altacomida.Codigo
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = _altacomida.Nombre
            cmd.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = _altacomida.Tipo
            cmd.Parameters.Add("@imagen", NpgsqlTypes.NpgsqlDbType.Varchar, 500).Value = _altacomida.Imagen


            resultado = cmd.ExecuteNonQuery()

            Dim cadenaComando2 = "INSERT INTO ingredientescomida (codigo, ingredientes) VALUES (@codigo, @ingredientes); "
            cmd.CommandText = cadenaComando2

            cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = _altacomida.Codigo
            cmd.Parameters.Add("@ingredientes", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = _altacomida.Ingredientes


            resultado = cmd.ExecuteNonQuery()

            Dim cadenaComando3 = "INSERT INTO restaurantecomida (rut, codigo, precio, tiempo_preparacion) VALUES (@rut, @codigo, @precio, @tiempo_preparacion); "
            cmd.CommandText = cadenaComando3

            cmd.Parameters.Add("@rut", NpgsqlTypes.NpgsqlDbType.Integer).Value = _altacomida.Rut
            cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = _altacomida.Codigo
            cmd.Parameters.Add("@precio", NpgsqlTypes.NpgsqlDbType.Integer).Value = _altacomida.Precio
            cmd.Parameters.Add("@tiempo_preparacion", NpgsqlTypes.NpgsqlDbType.Integer).Value = _altacomida.TiempoPreparacion

            resultado = cmd.ExecuteNonQuery()

            If resultado >= 0 Then
                LabelError.Text = "Alta exitosa"
                NotificacionCS.ShowDialog()
            Else
                LabelError.Text = "Error en la carga de datos"
            End If

            cmd.Parameters.Clear()

        Catch ex As Exception

            LabelError.Text = ex.Message

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
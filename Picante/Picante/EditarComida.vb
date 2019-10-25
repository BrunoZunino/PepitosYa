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

        Try
            Dim comida = Listar_comidas.comida_selecionada
            TbxNombre.Text = comida.Nombre
            TbxPrecio.Text = comida.Precio
            TbxTipo.Text = comida.Tipo
            TxbTiempo.Text = comida.TiempoPreparacion
            TxbImg.Text = comida.Imagen


            For i As Integer = 0 To (comida.Ingredientes.Count() - 1)

                ListView1.Items.Add(comida.Ingredientes(i))

            Next


        Catch ex As Exception

        End Try


    End Sub

    Private Sub ListView1_Layout(sender As Object, e As LayoutEventArgs) Handles ListView1.Layout
        Dim comida = Listar_comidas.comida_selecionada
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ingresado = TxbIngredientes.Text

        ListView1.Items.Add(ingresado)

        TxbIngredientes.Text = ""
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim item = ListView1.SelectedItems(0)

        ListView1.Items.Remove(item)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre = TbxNombre.Text
        Dim precio As Integer = TbxPrecio.Text
        Dim tipo = TbxTipo.Text
        Dim tiempo = TxbTiempo.Text
        Dim img = TxbImg.Text
        Dim lista_ing = New List(Of String)
        Dim _comidaEditar As New AltaComida

        Try
            For i As Integer = 0 To (ListView1.Items.Count() - 1)

                Dim ing As String
                ing = ListView1.Items(i).Text

                lista_ing.Add(ing)
            Next

            _comidaEditar.Nombre = nombre
            _comidaEditar.Precio = precio
            _comidaEditar.TiempoPreparacion = tiempo
            _comidaEditar.Ingredientes = lista_ing
            _comidaEditar.Imagen = img
            _comidaEditar.Rut = Listar_comidas.comida_selecionada.Rut
            _comidaEditar.Codigo = Listar_comidas.comida_selecionada.Codigo
            _comidaEditar.Tipo = tipo


            Dim clasecnn = New conexionPGSQL
            Dim conexion As New Npgsql.NpgsqlConnection()
            conexion = clasecnn.AbrirConexion()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion

            Dim resultado As Integer

            Dim cadenaComando = "UPDATE comida SET nombre = @nombre, tipo = @tipo, imagen = @imagen WHERE codigo = @codigo;"
            cmd.CommandText = cadenaComando

            cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = _comidaEditar.Codigo
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = nombre
            cmd.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = tipo
            cmd.Parameters.Add("@imagen", NpgsqlTypes.NpgsqlDbType.Varchar, 500).Value = img


            resultado = cmd.ExecuteNonQuery()

            If resultado < 0 Then
                Throw New Exception("Error en la carga de datos")
            End If

            Dim cadenaComando4 = "DELETE from ingredientescomida WHERE codigo = @codigo; "
            cmd.CommandText = cadenaComando4

            cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = _comidaEditar.Codigo

            resultado = cmd.ExecuteNonQuery()
            If resultado < 0 Then
                Throw New Exception("Error en la carga de datos")
            End If
            conexion.Close()
            For i As Integer = 0 To (lista_ing.Count() - 1)
                conexion = New Npgsql.NpgsqlConnection()
                conexion = clasecnn.AbrirConexion()

                cmd = New Npgsql.NpgsqlCommand()
                cmd.Connection = conexion

                Dim cadenaComando2 = "INSERT INTO ingredientescomida (codigo, ingredientes) VALUES (@codigo, @ingredientes); "
                cmd.CommandText = cadenaComando2

                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = _comidaEditar.Codigo
                cmd.Parameters.Add("@ingredientes", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = lista_ing(i)


                resultado = cmd.ExecuteNonQuery()

                If resultado < 0 Then
                    Throw New Exception("Error en la carga de datos")
                End If
                conexion.Close()
            Next

            conexion = New Npgsql.NpgsqlConnection()
            conexion = clasecnn.AbrirConexion()

            cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion

            Dim cadenaComando3 = "UPDATE restaurantecomida SET precio = @precio, tiempo_preparacion = @tiempo_preparacion WHERE codigo = @codigo and rut = @rut; "
            cmd.CommandText = cadenaComando3

            cmd.Parameters.Add("@rut", NpgsqlTypes.NpgsqlDbType.Integer).Value = _comidaEditar.Rut
            cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = _comidaEditar.Codigo
            cmd.Parameters.Add("@precio", NpgsqlTypes.NpgsqlDbType.Integer).Value = _comidaEditar.Precio
            cmd.Parameters.Add("@tiempo_preparacion", NpgsqlTypes.NpgsqlDbType.Integer).Value = _comidaEditar.TiempoPreparacion

            resultado = cmd.ExecuteNonQuery()

            If resultado >= 0 Then
                Label9.Text = "Modificacion exitosa"
                NotificacionCS.ShowDialog()
            Else
                Throw New Exception("Error en la carga de datos")
            End If

            cmd.Parameters.Clear()

        Catch ex As Exception
            Label9.Text = ex.Message
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim codigo = Listar_comidas.comida_selecionada.Codigo
        Dim rut = Listar_comidas.comida_selecionada.Rut
        Dim resultado As Integer

        Dim clasecnn = New conexionPGSQL
        Dim conexion As New Npgsql.NpgsqlConnection()
        conexion = clasecnn.AbrirConexion()

        Dim cmd = New Npgsql.NpgsqlCommand()
        cmd.Connection = conexion

        Dim cadenaComando = "DELETE from restaurantecomida WHERE rut = @rut and codigo = @codigo; "
        cmd.CommandText = cadenaComando

        cmd.Parameters.Add("@rut", NpgsqlTypes.NpgsqlDbType.Integer).Value = rut
        cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = codigo

        resultado = cmd.ExecuteNonQuery()

        If resultado < 0 Then
            Throw New Exception("Error en la carga de datos")
        End If

        Dim cadenaComando2 = "DELETE from ingredientescomida WHERE codigo = @codigo;"
        cmd.CommandText = cadenaComando2

        cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = codigo

        resultado = cmd.ExecuteNonQuery()

        If resultado < 0 Then
            Throw New Exception("Error en la carga de datos")
        End If

        Dim cadenaComando3 = "DELETE From comida Where codigo = @codigo;"

        cmd.CommandText = cadenaComando3

        cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = codigo

        resultado = cmd.ExecuteNonQuery()

        If resultado >= 0 Then
            Label9.Text = "Eliminacion exitosa"
            NotificacionCS.ShowDialog()
        Else
            Throw New Exception("Error en la carga de datos")
        End If

        cmd.Parameters.Clear()

    End Sub
End Class
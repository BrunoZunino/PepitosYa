Imports Npgsql
Public Class Listar_comidas
    Public lista_comidas As List(Of AltaComida)

    Public listado As List(Of String)

    Public comida_selecionada As AltaComida

    Public comida As AltaComida

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Edit.Click
        EditarComida.ShowDialog()
    End Sub

    Private Sub Listar_comidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListComidas.Items.Clear()
        listado = New List(Of String)
        lista_comidas = New List(Of AltaComida)

        Try
            Dim cadenaComando = (" SELECT * FROM comidasOrdenadas ")

            Dim clasecnn = New conexionPGSQL
            Dim conexion As New NpgsqlConnection()
            conexion = clasecnn.AbrirConexion()

            Dim cmd = New NpgsqlCommand(cadenaComando, conexion)

            Dim lector As NpgsqlDataReader
            lector = cmd.ExecuteReader()

            If lector.HasRows Then
                Dim i As Integer = 0
                Dim comida As AltaComida

                While lector.Read()

                    Dim codigo As Integer = lector(0).ToString
                    Dim nombre As String = lector(1).ToString
                    Dim tipo As String = lector(2).ToString
                    Dim precio As String = lector(3).ToString
                    Dim tiempo As String = lector(4).ToString
                    Dim ingrediente As String = lector(5).ToString
                    Dim imagen As String = lector(6).ToString

                    Dim counter = lista_comidas.Count()

                    If counter = 0 Then

                        comida = New AltaComida()
                        comida.Codigo = codigo
                        comida.Nombre = nombre
                        comida.Tipo = tipo
                        comida.Precio = precio
                        comida.TiempoPreparacion = tiempo

                        lista_comidas.Add(comida)

                        listado.Add(ingrediente)
                    ElseIf lista_comidas(counter - 1).codigo = codigo Then
                        listado.Add(ingrediente)
                    Else
                        lista_comidas(counter - 1).Ingredientes = listado

                        listado = New List(Of String)

                        comida = New AltaComida()
                        comida.Codigo = codigo
                        comida.Nombre = nombre
                        comida.Tipo = tipo
                        comida.Precio = precio
                        comida.TiempoPreparacion = tiempo

                        lista_comidas.Add(comida)

                        listado.Add(ingrediente)
                    End If

                    i += 1
                End While

                lista_comidas(lista_comidas.Count() - 1).Ingredientes = listado
                lector.Close()
                conexion.Close()
            End If

            For i As Integer = 0 To (lista_comidas.Count() - 1)
                ListComidas.Items.Add(lista_comidas(i).Codigo)
                ListComidas.Items(i).SubItems.Add(lista_comidas(i).Nombre)
                ListComidas.Items(i).SubItems.Add(lista_comidas(i).Tipo)
                ListComidas.Items(i).SubItems.Add(lista_comidas(i).Precio)
                ListComidas.Items(i).SubItems.Add(lista_comidas(i).TiempoPreparacion)
                ListComidas.Items(i).SubItems.Add(lista_comidas(i).Listar)
                ListComidas.Items(i).SubItems.Add(lista_comidas(i).Imagen)
            Next

        Catch ex As Exception
            LabelError.Text = ex.Message
        End Try
    End Sub

    Private Sub ListComidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListComidas.SelectedIndexChanged
        Dim item As Integer

        Try
            item = ListComidas.SelectedIndices.Item(0)

            Dim i As Integer = 0

            While (i < lista_comidas.Count())

                If lista_comidas(i).Codigo = item Then
                    comida_selecionada = lista_comidas(i + 1)
                    i = lista_comidas.Count()
                End If
                i = i + 1
            End While

            EditarComida.Show()

        Catch ex As Exception
            LabelError.Text = ex.Message
        End Try

    End Sub
End Class
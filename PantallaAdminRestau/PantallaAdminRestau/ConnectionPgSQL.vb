Public Class ConnectionPgSQL
    Public Function AbrirConexion() As Npgsql.NpgsqlConnection
        Dim conexion As Npgsql.NpgsqlConnection
        conexion = New Npgsql.NpgsqlConnection()

        Dim cadenaDeConexiones As String
        cadenaDeConexiones = "Server=127.0.0.1;Port=5432;User Id='postgres';Password='root';Database=Picante"

        Try
            conexion.ConnectionString = cadenaDeConexiones
            conexion.Open()

        Catch ex As Exception
            conexion.Close()
            Throw ex
        End Try

        Return conexion
    End Function
End Class

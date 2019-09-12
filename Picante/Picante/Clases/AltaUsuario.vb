Public Class AltaUsuario
    Private _correo As String
    Private _contrasena As String

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Constrasena As String
        Get
            Return _contrasena
        End Get
        Set(value As String)
            _contrasena = value
        End Set
    End Property

    Sub New(correo As String, contrasena As String)
        _correo = correo
        _contrasena = contrasena
    End Sub

End Class

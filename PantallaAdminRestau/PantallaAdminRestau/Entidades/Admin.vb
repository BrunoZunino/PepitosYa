Public Class Admin
    Dim _correo As String
    Dim _contrasena As String

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Contrasena As String
        Get
            Return _contrasena
        End Get
        Set(value As String)
            _contrasena = value
        End Set
    End Property

    'constructor
    Sub New(email As String, contra As String)
        Correo = email
        Contrasena = contra
    End Sub
End Class

Public Class Usuario
    Dim _correo As String
    Dim _nombre As String
    Dim _apellido As String
    Dim _contrasena As String
    Dim _pais As String

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property


    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
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

    Public Property Pais As String
        Get
            Return _pais
        End Get
        Set(value As String)
            _pais = value
        End Set
    End Property

    Sub New(corr As String, nom As String, apelli As String, contra As String, pai As String)
        corr = Correo
        nom = Nombre
        apelli = Apellido
        contra = Contrasena
        pai = Pais
    End Sub
End Class

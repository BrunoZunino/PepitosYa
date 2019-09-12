Public Class AltaComida
    Private _id As Integer
    Private _nombre As String
    Private _tipo As String
    Private _precio As Integer
    Private _tiempoPreparacion As String
    Private _imagen As String
    Private _ingredientes As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property TiempoPreparacion As Integer
        Get
            Return _tiempoPreparacion
        End Get
        Set(value As Integer)
            _tiempoPreparacion = value
        End Set
    End Property

    Public Property Imagen As String
        Get
            Return _imagen
        End Get
        Set(value As String)
            _imagen = value
        End Set
    End Property

    Public Property Ingredientes As String
        Get
            Return _ingredientes
        End Get
        Set(value As String)
            _ingredientes = value
        End Set
    End Property

    Sub New(id As Integer, nombre As String, tipo As String, precio As Integer, tiempoPreparacion As Integer, Imagen As String, Ingredientes As String)
        _id = id
        _nombre = nombre
        _tipo = tipo
        _precio = precio
        _tiempoPreparacion = tiempoPreparacion
        _imagen = Imagen
        _ingredientes = Ingredientes
    End Sub
End Class

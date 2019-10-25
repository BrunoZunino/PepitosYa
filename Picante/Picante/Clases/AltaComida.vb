Public Class AltaComida
    Private _codigo As Integer
    Private _nombre As String
    Private _tipo As String
    Private _precio As Integer
    Private _tiempoPreparacion As String
    Private _imagen As String
    Private _ingredientes As List(Of String)
    Private _rut As Integer

    Public Property Codigo As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
        End Set
    End Property

    Public Function Listar() As String
        Dim nro As Integer
        nro = 1
        Dim ing As String
        ing = _ingredientes(0)

        While (nro < _ingredientes.Count())
            ing = ing + ", " + _ingredientes(nro)
            nro = nro + 1
        End While

        Return ing

    End Function

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

    Public Property Precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            _precio = value
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

    Public Property Ingredientes As List(Of String)
        Get
            Return _ingredientes
        End Get
        Set(value As List(Of String))
            _ingredientes = value
        End Set
    End Property

    Public Property Rut As Integer
        Get
            Return _rut
        End Get
        Set(value As Integer)
            _rut = value
        End Set
    End Property

    Sub New(co As Integer, nom As String, ti As String, pre As Integer, tiempoPre As Integer, ima As String, ingre As List(Of String), rt As Integer)
        Codigo = co
        Nombre = nom
        Tipo = ti
        Precio = pre
        TiempoPreparacion = tiempoPre
        Imagen = ima
        Ingredientes = ingre
        Rut = rt
    End Sub

    Sub New(co As Integer, nom As String, ti As String, pre As Integer, tiempoPre As Integer, ima As String, rt As Integer)
        Codigo = co
        Nombre = nom
        Tipo = ti
        Precio = pre
        TiempoPreparacion = tiempoPre
        Imagen = ima
        Rut = rt
    End Sub

    Sub New()

    End Sub
End Class

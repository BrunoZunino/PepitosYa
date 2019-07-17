Public Class Comida
    Dim _codigo As Integer
    Dim _nombre As String
    Dim _precio As Integer
    Dim _tipo As String
    Dim _ingredientes As ArrayList

    Public Property Codigo As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
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

    Public Property Precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            _precio = value
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

    Public Property Ingredientes As ArrayList
        Get
            Return _ingredientes
        End Get
        Set(value As ArrayList)
            _ingredientes = value
        End Set
    End Property

    'constructor
    Sub New(code As Integer, nom As String, precio As Integer, tipo As String, ing As ArrayList)
        Codigo = code
        Nombre = nom
        precio = precio
        tipo = tipo
        Ingredientes = ing
    End Sub
End Class

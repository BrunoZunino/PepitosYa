Public Class Restaurante
    Dim _rut As Integer
    Dim _nombre As String
    Dim _barrio As String
    Dim _calle As String
    Dim _numero As Integer
    Dim _apertura As String
    Dim _cierre As String
    Dim _descripcion As String
    Dim _razon_social As String

    Public Property Rut As Integer
        Get
            Return _rut
        End Get
        Set(value As Integer)
            _rut = value
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

    Public Property Barrio As String
        Get
            Return _barrio
        End Get
        Set(value As String)
            _barrio = value
        End Set
    End Property

    Public Property Calle As String
        Get
            Return _calle
        End Get
        Set(value As String)
            _calle = value
        End Set
    End Property

    Public Property Numero As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property

    Public Property Apertura As String
        Get
            Return _apertura
        End Get
        Set(value As String)
            _apertura = value
        End Set
    End Property

    Public Property Cierre As String
        Get
            Return _cierre
        End Get
        Set(value As String)
            _cierre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Razon_Social As String
        Get
            Return _razon_social
        End Get
        Set(value As String)
            _razon_social = value
        End Set
    End Property

    'constructor
    Sub New(rt As Integer, nom As String, barr As String, ca As String, num As Integer, apr As String, cr As String, dscrip As String, rs As String)
        Rut = rt
        Nombre = nom
        Barrio = barr
        Calle = ca
        Numero = num
        Apertura = apr
        Cierre = cr
        Descripcion = dscrip
        Razon_Social = rs
    End Sub

End Class

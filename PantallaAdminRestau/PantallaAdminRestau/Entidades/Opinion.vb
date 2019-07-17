Public Class Opinion
    Dim _id As Integer
    Dim _ranking As Integer

    Public Property ID As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Ranking As String
        Get
            Return _ranking
        End Get
        Set(value As String)
            _ranking = value
        End Set
    End Property

    'constructor
    Sub New(i As Integer, rank As Integer)
        ID = i
        Ranking = rank
    End Sub
End Class

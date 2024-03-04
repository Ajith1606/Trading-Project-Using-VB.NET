Public Class ItemBO
    Private _ItemId As Long
    Private _ItemDescription As String
    Private _SalesPrice As Decimal

    Public Property ItemId() As Long
        Get
            Return _ItemId
        End Get
        Set(value As Long)
            _ItemId = value
        End Set
    End Property
    Public Property ItemDescription() As String
        Get
            Return _ItemDescription
        End Get
        Set(value As String)
            _ItemDescription = value
        End Set
    End Property
    Public Property SalesPrice() As Decimal
        Get
            Return _SalesPrice
        End Get
        Set(value As Decimal)
            _SalesPrice = value
        End Set
    End Property
End Class

Public Class CustomerBo
    Private _CustomerId As Long
    Private _CustomerName As String
    Private _Place As String
    Private _ContactNumber As String

    Public Property CustomerId() As Long
        Get
            Return _CustomerId
        End Get
        Set(value As Long)
            _CustomerId = value
        End Set
    End Property
    Public Property CustomerName() As String
        Get
            Return _CustomerName
        End Get
        Set(value As String)
            _CustomerName = value
        End Set
    End Property
    Public Property Place() As String
        Get
            Return _Place
        End Get
        Set(value As String)
            _Place = value
        End Set
    End Property
    Public Property ContactNumber() As String
        Get
            Return _ContactNumber
        End Get
        Set(value As String)
            _ContactNumber = value
        End Set
    End Property
End Class

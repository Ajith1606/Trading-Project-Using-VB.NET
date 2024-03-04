Public Class SupplierBO
    Private _SupplierId As Long
    Private _SupplierName As String
    Private _Place As String
    Private _ContactNumber As String

    Public Property SupplierId() As Long
        Get
            Return _SupplierId
        End Get
        Set(value As Long)
            _SupplierId = value
        End Set
    End Property
    Public Property SupplierName() As String
        Get
            Return _SupplierName
        End Get
        Set(value As String)
            _SupplierName = value
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

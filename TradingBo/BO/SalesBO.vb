Public Class SalesBO
    Private _SalesId As Long
    Private _SalesDate As Date
    Private _CustomerId As Long
    Private _BillNo As Long
    Private _NetAmount As Decimal
    Private _CustomerBo As New CustomerDAL
    Private _SalesDetail As DataTable

    Public Property SalesId() As Long
        Get
            Return _SalesId
        End Get
        Set(value As Long)
            _SalesId = value
        End Set
    End Property
    Public Property SalesDate() As Date
        Get
            Return _SalesDate
        End Get
        Set(value As Date)
            _SalesDate = value
        End Set
    End Property
    Public Property CustomerId() As Long
        Get
            Return _CustomerId
        End Get
        Set(value As Long)
            _CustomerId = value
            'Populate the Customer Releated Value
            _CustomerBo.Read(value)
        End Set
    End Property
    Public ReadOnly Property Customer() As CustomerDAL
        Get
            Return _CustomerBo
        End Get
    End Property
    Public Property BillNo() As Long
        Get
            Return _BillNo
        End Get
        Set(value As Long)
            _BillNo = value
        End Set
    End Property
    Public Property NetAmount() As Decimal
        Get
            Return _NetAmount
        End Get
        Set(value As Decimal)
            _NetAmount = value
        End Set
    End Property
    Public Property SalesDetail() As DataTable
        Get
            Return _SalesDetail
        End Get
        Set(value As DataTable)
            _SalesDetail = value
        End Set
    End Property
End Class

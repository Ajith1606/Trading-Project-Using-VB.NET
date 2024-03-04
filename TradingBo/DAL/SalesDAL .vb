Imports System.Data.SqlClient
Public Class SalesDAL
    Public BO As New SalesBO

    'Create
    'Read
    'Update
    'Delete

    Public Function Create() As Boolean
        Dim db As New SQLServer
        Try
            Dim lsql As String
            lsql = "Insert into Sales(SalesDate, CustomerId ,BillNo, NetAmount) values(@SalesDate, @CustomerId, @BillNo, @NetAmount)"

            'Get the Bill No
            BO.BillNo = GetNextBillNo()

            Dim cmd As New SqlCommand(lsql)
            cmd.Parameters.AddWithValue("@SalesDate", BO.SalesDate)
            cmd.Parameters.AddWithValue("@CustomerId", BO.CustomerId)
            cmd.Parameters.AddWithValue("@BillNo", BO.BillNo)
            cmd.Parameters.AddWithValue("@NetAmount", BO.NetAmount)
            db.ExecuteNonQuery(cmd, BO.SalesId)
            cmd.Dispose()

            UpdateDetailRecord()
            Return True
        Catch ex As Exception
            Throw
        Finally
            db = Nothing
        End Try
    End Function
    Private Function GetNextBillNo() As Long
        Try
            Dim lSql As String
            lSql = "Select Max(BillNo) from Sales"
            Dim lLastbillNo As Long = Val(TradingBo.SQLServer.ExecuteScaler(lSql))

            Return lLastbillNo + 1
        Catch ex As Exception
            Throw
        End Try
    End Function
    Private Sub UpdateDetailRecord()
        Try
            For Each dr As DataRow In BO.SalesDetail.Rows
                If dr.RowState = DataRowState.Added Then
                    dr("SalesId") = BO.SalesId
                End If
            Next
            TradingBo.SQLServer.UpdateDataTable(BO.SalesDetail, "SalesDetail")
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Function Read(ByVal SalesId As Long) As Boolean
        Dim db As New SQLServer
        Try
            Dim cmd As New SqlCommand
            cmd.CommandText = "Select *from Sales where SalesId = @SalesId"
            cmd.Parameters.AddWithValue("@SalesId", SalesId)

            Dim dt As DataTable = db.GetDataTable(cmd)

            If dt.Rows.Count = 1 Then
                Dim dr As DataRow = dt.Rows(0)
                BO.SalesId = dr("SalesId")
                BO.SalesDate = dr("SalesDate")
                BO.CustomerId = dr("CustomerId")
                BO.BillNo = dr("BillNo")
                BO.NetAmount = dr("NetAmount")

                cmd.CommandText = "Select * from SalesDetail where SalesId=@SalesId"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@SalesId", SalesId)
                BO.SalesDetail = db.GetDataTable(cmd)
            Else
                Throw New Exception("No matching record found for the SalesId : " & SalesId)
            End If
            dt.Dispose()
            Return True
        Catch ex As Exception
            Throw
        Finally
            db = Nothing
        End Try
    End Function
    Public Function List() As DataTable
        Dim db As New SQLServer
        Try
            Dim cmd As New SqlCommand
            cmd.CommandText = "Select *from Sales Order By BillNo"

            Return db.GetDataTable(cmd)
        Catch ex As Exception
            Throw
        Finally
            db = Nothing
        End Try
    End Function
    Public Function Update() As Boolean
        Dim db As New SQLServer
        Try
            Dim lsql As String
            lsql = "Update Sales Set SalesDate = @SalesDate, CustomerId = @CustomerId, 
                    BillNo = @BillNo, NetAmount = @NetAmount where SalesId = @SalesId"
            Dim cmd As New SqlCommand(lsql)

            cmd.Parameters.AddWithValue("@SalesDate", BO.SalesDate)
            cmd.Parameters.AddWithValue("@CustomerId", BO.CustomerId)
            cmd.Parameters.AddWithValue("@BillNo", BO.BillNo)
            cmd.Parameters.AddWithValue("@NetAmount", BO.NetAmount)
            cmd.Parameters.AddWithValue("@SalesId", BO.SalesId)
            db.ExecuteNonQuery(cmd)
            cmd.Dispose()
            Return True
        Catch ex As Exception
            Throw
        Finally
            db = Nothing
        End Try
    End Function
    Public Function Delete(ByRef SalesId As Long) As Boolean
        Dim db As New SQLServer
        Try
            Dim lsql As String
            lsql = "Delete Sales where SalesId = @SalesId"
            Dim cmd As New SqlCommand(lsql)

            cmd.Parameters.AddWithValue("@SalesId", SalesId)
            db.ExecuteNonQuery(cmd)
            cmd.Dispose()
            Return True
        Catch ex As Exception
            Throw
        Finally
            db = Nothing
        End Try
    End Function
End Class

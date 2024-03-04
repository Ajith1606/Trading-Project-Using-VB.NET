Imports System.Data.SqlClient
Public Class CustomerDAL
    Public BO As New CustomerBo

    Public Function Create() As Boolean
        Dim db As New SQLServer
        Try
            Dim lSql As String
            lSql = "Insert Into Customer(CustomerName, Place, ContactNumber) Values(@CustomerName, @Place, @ContactNumber)"

            Dim cmd As New SqlCommand(lSql)
            cmd.Parameters.AddWithValue("@CustomerName", BO.CustomerName)
            cmd.Parameters.AddWithValue("@Place", BO.Place)
            cmd.Parameters.AddWithValue("@ContactNumber", BO.ContactNumber)
            db.ExecuteNonQuery(cmd)
            cmd.Dispose()
            Return True
        Catch ex As Exception
            Throw
        Finally
            db = Nothing
        End Try
    End Function

    Public Function Read(ByVal CustomerId As Long) As Boolean
        Dim db As New SQLServer
        Try
            Dim cmd As New SqlCommand
            cmd.CommandText = "Select * From Customer Where CustomerId = @CustomerId"
            cmd.Parameters.AddWithValue("@CustomerId", CustomerId)

            Dim dt As DataTable = db.GetDataTable(cmd)
            If dt.Rows.Count = 1 Then
                Dim dr As DataRow = dt.Rows(0)
                BO.CustomerId = dr("CustomerId")
                BO.CustomerName = dr("CustomerName") & ""
                BO.Place = dr("Place") & ""
                BO.ContactNumber = dr("ContactNumber") & ""
            Else
                Throw New Exception("No matching record found for the Customer Id " & CustomerId)
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
            cmd.CommandText = "Select * From Customer Order By CustomerName"

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
            Dim lSql As String
            lSql = "Update Customer Set CustomerName = @CustomerName, Place = @Place, ContactNumber = @ContactNumber Where CustomerId = @CustomerId"

            Dim cmd As New SqlCommand(lSql)
            cmd.Parameters.AddWithValue("@CustomerName", BO.CustomerName)
            cmd.Parameters.AddWithValue("@Place", BO.Place)
            cmd.Parameters.AddWithValue("@ContactNumber", BO.ContactNumber)
            cmd.Parameters.AddWithValue("@CustomerId", BO.CustomerId)
            db.ExecuteNonQuery(cmd)
            cmd.Dispose()
            Return True
        Catch ex As Exception
            Throw
        Finally
            db = Nothing
        End Try
    End Function

    Public Function Delete(ByVal CustomerId As Long) As Boolean
        Dim db As New SQLServer
        Try
            Dim lSql As String
            lSql = "Delete Customer where CustomerId = @CustomerId"

            Dim cmd As New SqlCommand(lSql)
            cmd.Parameters.AddWithValue("@CustomerId", CustomerId)
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

Imports System.Data.SqlClient
Public Class SupplierDAL
    Public BO As New SupplierBO

    'Create
    'Read
    'Update
    'Delete

    Public Function Create() As Boolean
        Dim db As New SQLServer
        Try
            Dim lsql As String
            lsql = "Insert into Supplier(SupplierName, Place, Contactnumber) values(@SupplierName, @Place, @ContactNumber)"
            Dim cmd As New SqlCommand(lsql)

            cmd.Parameters.AddWithValue("@Suppliername", BO.SupplierName)
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
    Public Function Read(ByVal SupplierId As Long) As Boolean
        Dim db As New SQLServer
        Try
            Dim cmd As New SqlCommand
            cmd.CommandText = "Select *from Supplier where SupplierId = @SupplierId"
            cmd.Parameters.AddWithValue("@SupplierId", SupplierId)

            Dim dt As DataTable = db.GetDataTable(cmd)
            If dt.Rows.Count = 1 Then
                Dim dr As DataRow = dt.Rows(0)
                BO.SupplierId = dr("SupplierId")
                BO.SupplierName = dr("SupplierName") & ""
                BO.Place = dr("Place") & ""
                BO.ContactNumber = dr("ContactNumber") & ""
            Else
                Throw New Exception("No matching record found for the SupplierId : " & SupplierId)
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
            cmd.CommandText = "Select *from Supplier Order By SupplierName"

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
            lsql = "Update Supplier Set SupplierName = @SupplierName, Place = @Place, 
                    ContactNumber = @ContactNumber where SupplierId = @SupplierId"
            Dim cmd As New SqlCommand(lsql)

            cmd.Parameters.AddWithValue("@Suppliername", BO.SupplierName)
            cmd.Parameters.AddWithValue("@Place", BO.Place)
            cmd.Parameters.AddWithValue("@ContactNumber", BO.ContactNumber)
            cmd.Parameters.AddWithValue("@SupplierId", BO.SupplierId)
            db.ExecuteNonQuery(cmd)
            cmd.Dispose()
            Return True
        Catch ex As Exception
            Throw
        Finally
            db = Nothing
        End Try
    End Function
    Public Function Delete(ByRef SupplierId As Long) As Boolean
        Dim db As New SQLServer
        Try
            Dim lsql As String
            lsql = "Delete Supplier where SupplierId = @SupplierId"
            Dim cmd As New SqlCommand(lsql)

            cmd.Parameters.AddWithValue("@SupplierId", SupplierId)
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

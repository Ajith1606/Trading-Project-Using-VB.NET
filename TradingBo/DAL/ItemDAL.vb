Imports System.Data.SqlClient

Public Class ItemDAL
    Public BO As New ItemBO
    Public Function Create() As Boolean
        Dim db As New SQLServer
        Try
            Dim lsql As String
            lsql = "Insert Into Item(ItemId, ItemDescription, SalesPrice) values(@ItemId, @ItemDescription, @SalesPrice)"

            Dim cmd As New SqlCommand
            cmd.Parameters.AddWithValue("@ItemId", BO.ItemId)
            cmd.Parameters.AddWithValue("@ItemDescription", BO.ItemDescription)
            cmd.Parameters.AddWithValue("@SalesPrice", BO.SalesPrice)
            db.ExecuteNonQuery(cmd)
            cmd.Dispose()

            Return True
        Catch ex As Exception
            Throw
        Finally
            db = Nothing
        End Try
    End Function
    Public Function Read(ByVal ItemId As Long) As Boolean
        Dim db As New SQLServer
        Try
            Dim cmd As New SqlCommand
            cmd.CommandText = "Select * From Item where ItemId = @ItemId"
            cmd.Parameters.AddWithValue("@ItemId", ItemId)

            Dim dt As DataTable = db.GetDataTable(cmd)
            If dt.Rows.Count = 1 Then
                Dim dr As DataRow = dt.Rows(0)
                BO.ItemId = dr("ItemId")
                BO.ItemDescription = dr("ItemDescription") & ""
                BO.SalesPrice = dr("SalesPrice")
            Else
                Throw New Exception("No matching record found for the Item Id" & ItemId)
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
            cmd.CommandText = "Select * From Item Order By ItemDescription"

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
            lSql = "Update Item Set ItemDescription = @ItemDescription, SalesPrice = @SalesPrice Where ItemId = @ItemId"

            Dim cmd As New SqlCommand(lSql)
            cmd.Parameters.AddWithValue("@ItemDescription", BO.ItemDescription)
            cmd.Parameters.AddWithValue("@SalesPrice", BO.SalesPrice)
            cmd.Parameters.AddWithValue("@ItemId", BO.ItemId)
            db.ExecuteNonQuery(cmd)
            cmd.Dispose()
            Return True
        Catch ex As Exception
            Throw
        Finally
            db = Nothing
        End Try
    End Function
    Public Function Delete(ByVal ItemId As Long) As Boolean
        Dim db As New SQLServer
        Try
            Dim lSql As String
            lSql = "Delete Item Where ItemId = @ItemId"

            Dim cmd As New SqlCommand(lSql)
            cmd.Parameters.AddWithValue("@ItemId", ItemId)
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

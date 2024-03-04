Imports System.Data.SqlClient
Public Class SQLServer
    Private Shared Function AppSetting(ByVal SettingName As String) As String
        Return Configuration.ConfigurationManager.AppSettings(SettingName)
    End Function
    Public Shared Function ConnectionString() As String
        Return AppSetting("ConnectionString")
    End Function
    Public Function GetDataTable(ByVal SQL As String) As DataTable
        Dim con As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim DA As SqlDataAdapter = Nothing

        Dim Dt As New DataTable
        Try
            con = New SqlConnection(ConnectionString)
            cmd = New SqlCommand(SQL, con)
            DA = New SqlDataAdapter(cmd)

            DA.Fill(Dt)
            Return Dt
        Catch ex As Exception
            Throw
        Finally
            DA.Dispose()
            cmd.Dispose()
            con.Dispose()
        End Try
    End Function
    Public Function GetDataTable(ByVal cmd As SqlCommand) As DataTable
        Dim con As SqlConnection = Nothing
        Dim DA As SqlDataAdapter = Nothing

        Dim Dt As New DataTable
        Try
            con = New SqlConnection(ConnectionString)
            cmd.Connection = con

            DA = New SqlDataAdapter(cmd)
            DA.Fill(Dt)
            Return Dt
        Catch ex As Exception
            Throw
        Finally
            DA.Dispose()
            cmd.Dispose()
            con.Dispose()
        End Try
    End Function
    Public Function ExecuteNonQuery(ByVal SQL As String, Optional ByRef KeyValue As Long = Nothing) As Long
        Dim con As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim DA As SqlDataAdapter = Nothing

        Dim Dt As New DataTable
        Try
            Dim lAffectedRecords As Integer
            con = New SqlConnection(ConnectionString)
            cmd = New SqlCommand(SQL, con)
            lAffectedRecords = cmd.ExecuteNonQuery

            If KeyValue <> Nothing Then
                If KeyValue <= 0 Then
                    'The user execute insert query hence need to find the primary key value
                    KeyValue = GetIdentityValue(con)
                End If
            End If
            Return lAffectedRecords
        Catch ex As Exception
            Throw
        Finally
            DA.Dispose()
            cmd.Dispose()
            con.Dispose()
        End Try
    End Function

    Public Function ExecuteNonQuery(ByVal cmd As SqlCommand, Optional ByRef KeyValue As Long = Nothing) As Long
        Dim con As SqlConnection = Nothing
        Dim DA As SqlDataAdapter = Nothing

        Try
            Dim lAffectedRecords As Integer
            con = New SqlConnection(ConnectionString)
            cmd.Connection = con
            con.Open()
            lAffectedRecords = cmd.ExecuteNonQuery

            If KeyValue <> Nothing Then
                If KeyValue <= 0 Then
                    'The user execute insert query hence need to find the primary key value
                    KeyValue = GetIdentityValue(con)
                End If
            End If
            Return lAffectedRecords
        Catch ex As Exception
            Throw
        Finally
            cmd.Dispose()
            con.Dispose()
        End Try
    End Function
    Public Shared Function ExecuteScaler(ByVal SQL As String) As Long
        Dim con As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            con = New SqlConnection(ConnectionString)
            con.Open()
            cmd = New SqlCommand(SQL, con)
            Return cmd.ExecuteScalar
        Catch ex As Exception
            Throw
        Finally
            cmd.Dispose()
            con.Dispose()
        End Try
    End Function
    Public Shared Function ExecuteScaler(ByVal cmd As SqlCommand) As Long
        Dim con As SqlConnection = Nothing

        Try
            con = New SqlConnection(ConnectionString)
            con.Open()
            cmd.Connection = con

            Return cmd.ExecuteScalar
        Catch ex As Exception
            Throw
        Finally
            cmd.Connection = Nothing
            con.Dispose()
        End Try
    End Function
    Private Function GetIdentityValue(ByRef con As SqlConnection) As Long
        Dim cmd As SqlCommand = Nothing
        Try
            cmd = New SqlCommand
            cmd.CommandText = "Select @@Identity"
            cmd.Connection = con


            Return cmd.ExecuteScalar
        Catch ex As Exception
            Throw
        Finally
            If cmd IsNot Nothing Then
                cmd.Connection = Nothing
                cmd.Dispose()
            End If
            cmd = Nothing
        End Try
    End Function
    Public Shared Function UpdateDataTable(ByVal dt As DataTable, ByVal TableName As String) As Boolean
        Dim con As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim da As SqlDataAdapter = Nothing
        Dim cb As SqlCommandBuilder = Nothing
        Try
            con = New SqlConnection(ConnectionString)
            con.Open()
            Dim lsql As String = "Select * From " & TableName
            cmd = New SqlCommand(lsql, con)
            da = New SqlDataAdapter(cmd)
            cb = New SqlCommandBuilder(da)

            da.Update(dt)
            Return True
        Catch ex As Exception
            Throw
        Finally
            If con IsNot Nothing Then con.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
            If da IsNot Nothing Then da.Dispose()
            If cb IsNot Nothing Then cb.Dispose()
            con = Nothing : da = Nothing : cb = Nothing : cmd = Nothing
        End Try
    End Function
End Class

Public Class frmComboTesting
    Private Sub frmComboTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim o As New TradingBo.SQLServer
        Try
            Dim lsql As String
            lsql = "Select * From Item"
            Dim dt As DataTable = o.GetDataTable(lsql)
            cboItem.DataSource = dt

            dt = Nothing
        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        MsgBox(cboItem.SelectedValue)
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        cboItem.SelectedValue = 2
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
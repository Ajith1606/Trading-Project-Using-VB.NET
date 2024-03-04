Public Class frmGridView
    Private Sub frmGridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim o As New TradingBo.SQLServer
        Try
            Dim lsql As String
            lsql = "Select * From Item"
            Dim dt As DataTable = o.GetDataTable(lsql)

            dgvItemList.AutoGenerateColumns = False
            dgvItemList.DataSource = dt
            dt = Nothing
        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub dgvItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub

    Private Sub dgvItemList_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellEnter
        If Not dgvItemList.Focused Then Exit Sub

        'MsgBox(dgvItemList.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        'MsgBox(dgvItemList.CurrentCell.Value)
    End Sub

    Private Sub dgvItemList_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvItemList.CellValidating
        dgvItemList.Rows(e.RowIndex).ErrorText = ""
        Select Case dgvItemList.Columns(e.ColumnIndex).HeaderText
            Case "Sales Price"
                Dim lSalesPrice As Decimal
                lSalesPrice = CDec("0" & e.FormattedValue)
                If lSalesPrice <= 0 Then
                    dgvItemList.Rows(e.RowIndex).ErrorText = "Invalid Sales Price!"
                    e.Cancel = True
                End If
        End Select
    End Sub

    Private Sub dgvItemList_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvItemList.RowValidating
        Dim lSalesPrice As Decimal
        Dim lItemDescription As String

        lSalesPrice = "0" & dgvItemList.Rows(e.RowIndex).Cells("dcSalesPrice").FormattedValue
        lItemDescription = dgvItemList.Rows(e.RowIndex).Cells("dcItemDescription").FormattedValue
        dgvItemList.Rows(e.RowIndex).ErrorText = ""

        If lItemDescription.Trim.Length = 0 Then
            dgvItemList.Rows(e.RowIndex).ErrorText = "Invalid Item Description!"
            e.Cancel = True
            Exit Sub
        End If

        If lSalesPrice <= 0 Then
            dgvItemList.Rows(e.RowIndex).ErrorText = "Invalid Sales Price!"
            e.Cancel = True
            Exit Sub
        End If
    End Sub
End Class
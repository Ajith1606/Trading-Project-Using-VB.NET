Public Class ItemListView
    Private Sub ItemListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim o As New TradingBo.SQLServer
        Try
            Dim lsql As String
            lsql = "Select * From Item"
            Dim dt As DataTable = o.GetDataTable(lsql)

            'Fill the list View
            Dim lvi As ListViewItem
            Dim dr As DataRow

            Dim lItemName As String
            Dim lSalesPrice As String

            For Each dr In dt.Rows
                lItemName = dr("ItemDescription")
                lSalesPrice = dr("SalesPrice")

                lvi = New ListViewItem(lItemName)
                lvi.SubItems.Add(lSalesPrice)
                lvItem.Items.Add(lvi)
            Next
            dt = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub
End Class
Public Class DataTableResearch

    Dim o As New TradingBo.SQLServer
    Dim dt As DataTable = o.GetDataTable("Select * From Item")

    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnColumns_Click(sender As Object, e As EventArgs) Handles btnColumns.Click
        Dim lColumnNames As String = ""
        Dim dc As DataColumn

        For Each dc In dt.Columns
            If lColumnNames.Length > 0 Then
                lColumnNames &= ", "
            End If
            lColumnNames &= dc.Caption
        Next
        MsgBox(lColumnNames)
    End Sub

    Private Sub btnSumLooping_Click(sender As Object, e As EventArgs) Handles btnSumLooping.Click
        Dim lAmount As Decimal = 0
        For Each dr As DataRow In dt.Rows
            lAmount += dr("SalesPrice")
        Next
        MsgBox("Total Sales Price : " & lAmount)
    End Sub

    Private Sub btnSumComputing_Click(sender As Object, e As EventArgs) Handles btnSumComputing.Click
        Dim lAmount As Decimal = dt.Compute("Sum(SalesPrice)", "SalesPrice > 100")
        MsgBox("Total Sales Price : " & lAmount)
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim dv As New DataView(dt)
        dv.RowFilter = "SalesPrice > 100"

        DataGridView1.DataSource = dv
    End Sub

    Private Sub btnSumDVLooping_Click(sender As Object, e As EventArgs) Handles btnSumDVLooping.Click
        Dim dv As New DataView(dt)
        Try
            Dim lAmount As Decimal = 0
            For Each dr As DataRowView In dv
                lAmount += dr("SalesPrice")
            Next
            MsgBox("Total Sales Price : " & lAmount)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dv.Dispose()
        End Try
    End Sub

    Private Sub btnDVFindItemName_Click(sender As Object, e As EventArgs) Handles btnDVFindItemName.Click
        Dim dv As New DataView(dt)
        dv.Sort = "ItemId"
        Try
            Dim lItemId As Long = InputBox("Item Id : ")
            Dim lPos As Long = dv.Find(lItemId)

            If lPos = -1 Then
                MsgBox("Invalid Input!")
            Else
                MsgBox("Item Name : " & dv(lPos)("ItemDescription"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dv.Dispose()
        End Try
    End Sub
End Class
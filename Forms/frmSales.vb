Public Class frmSales
    Dim SalesId As Long = 0
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim o As New TradingBo.CustomerDAL
        cboCustomerName.DataSource = o.List
        o = Nothing
        cboCustomerName.SelectedValue = DBNull.Value

        Dim oI As New TradingBo.ItemDAL
        dcItemId.DataSource = oI.List
        oI = Nothing
        dcItemId.DisplayMember = "ItemDescription"
        dcItemId.ValueMember = "ItemId"
        oI = Nothing

        LoadRecords()
    End Sub
    Private Sub LoadRecords()
        Dim o As New TradingBo.SalesDAL
        Try
            CrudControl.DataTable = o.List

            cboCustomerName.DataSource = o.BO.Customer.List
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub CrudControl_Load(sender As Object, e As EventArgs) Handles CrudControl.Load

    End Sub

    Private Sub CrudControl_DisplayRecord(dr As DataRow) Handles CrudControl.DisplayRecord
        Dim o As New TradingBo.SalesDAL
        Try
            Dim lSalesId As Long = dr("SalesId")
            o.Read(lSalesId)

            With o.BO
                dtpSalesDate.Value = .SalesDate
                lblBillNo.Text = .BillNo
                cboCustomerName.SelectedValue = .CustomerId
                SalesId = .SalesId

                dgvSalesDetail.AutoGenerateColumns = False
                dgvSalesDetail.DataSource = .SalesDetail
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub CrudControl_FindRecord(Cancel As Boolean, ByRef CurRec As Integer) Handles CrudControl.FindRecord
        'Dim frm As New frmSupplierFind
        'Dim ldt As DataTable
        'ldt = CrudControl.DataTable

        'frm.dgvList.AutoGenerateColumns = False
        'frm.dgvList.DataSource = ldt

        'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Dim lSupplierId As Long = frm.SupplierId
        '    CurRec = 0
        '    Do While True
        '        If ldt.Rows(CurRec)("SupplierId") = lSupplierId Then
        '            Exit Do
        '        End If
        '        CurRec += 1
        '    Loop
        'Else
        '    Cancel = True
        'End If
        'frm.Dispose()
    End Sub

    Private Sub CrudControl_NewButtonClicked() Handles CrudControl.NewButtonClicked
        Try
            'Clear the Fields
            dtpSalesDate.Value = Today
            lblBillNo.Text = "(Auto)"
            cboCustomerName.SelectedValue = DBNull.Value
            SalesId = -1
            dtpSalesDate.Focus()

            Dim o As New TradingBo.SalesDAL
            o.Read(SalesId)
            dgvSalesDetail.DataSource = o.BO.SalesDetail
            o = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CrudControl_ModifyButtonClicked(dr As DataRow) Handles CrudControl.ModifyButtonClicked
        'No Need to do Nothing
    End Sub

    Private Function ValidEntry() As Boolean
        Try
            If Val(cboCustomerName.SelectedValue & "") = 0 Then
                MsgBox("Please enter the Customer Name")
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
    Private Sub CrudControl_SaveButtonClicked() Handles CrudControl.SaveButtonClicked
        Dim o As New TradingBo.SalesDAL

        Try
            'Validation
            If Not ValidEntry() Then
                Exit Sub
            End If
            'Store the Information
            o.BO.SalesDate = dtpSalesDate.Value
            o.BO.CustomerId = cboCustomerName.SelectedValue
            o.BO.SalesId = SalesId
            o.BO.SalesDetail = dgvSalesDetail.DataSource

            If SalesId = -1 Then
                o.Create()
            Else
                o.Update()
            End If

            LoadRecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CrudControl_CancelButtonClicked() Handles CrudControl.CancelButtonClicked
        'No need to do Nothing
    End Sub

    Private Sub CrudControl_DeleteButtonClicked(dr As DataRow) Handles CrudControl.DeleteButtonClicked
        Try
            If MsgBox("Are you sure you want to Delete?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim o As New TradingBo.SalesDAL
            o.Delete(SalesId)
            o = Nothing

            LoadRecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvSalesDetail_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvSalesDetail.CellBeginEdit

    End Sub
    Private Sub UpdateAmount()
        Try
            Dim lQty, lRate As Decimal
            lQty = Val(dgvSalesDetail.CurrentRow.Cells(1).FormattedValue & "")
            lRate = Val(dgvSalesDetail.CurrentRow.Cells(2).FormattedValue & "")
            dgvSalesDetail.CurrentRow.Cells(3).Value = lRate * lQty
        Catch ex As Exception
            'Ignore Error
        End Try

    End Sub

    Private Sub dgvSalesDetail_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesDetail.CellValueChanged
        Select Case e.ColumnIndex
            Case 1 'Qty
                UpdateAmount()
            Case 2 'Rate
                UpdateAmount()
        End Select
    End Sub
End Class
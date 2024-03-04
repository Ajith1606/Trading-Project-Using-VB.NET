Public Class FrmSupplierV2
    Dim SupplierId As Long = 0
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmSupplierV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecords()
    End Sub
    Private Sub LoadRecords()
        Dim o As New TradingBo.SupplierDAL
        Try
            CrudControl.DataTable = o.List

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub CrudControl_Load(sender As Object, e As EventArgs) Handles CrudControl.Load

    End Sub

    Private Sub CrudControl_DisplayRecord(dr As DataRow) Handles CrudControl.DisplayRecord
        Dim o As New TradingBo.SupplierDAL
        Try
            Dim lSupplierId As Long = dr("SupplierId")
            o.Read(lSupplierId)

            With o.BO
                txtSupplierName.Text = .SupplierName
                txtPlace.Text = .Place
                txtContactnumber.Text = .ContactNumber
                SupplierId = .SupplierId
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub CrudControl_FindRecord(Cancel As Boolean, ByRef CurRec As Integer) Handles CrudControl.FindRecord
        Dim frm As New frmSupplierFind
        Dim ldt As DataTable
        ldt = CrudControl.DataTable

        frm.dgvList.AutoGenerateColumns = False
        frm.dgvList.DataSource = ldt

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim lSupplierId As Long = frm.SupplierId
            CurRec = 0
            Do While True
                If ldt.Rows(CurRec)("SupplierId") = lSupplierId Then
                    Exit Do
                End If
                CurRec += 1
            Loop
        Else
            Cancel = True
        End If
        frm.Dispose()
    End Sub

    Private Sub CrudControl_NewButtonClicked() Handles CrudControl.NewButtonClicked
        Try
            'Clear the Fields
            txtSupplierName.Text = ""
            txtPlace.Text = ""
            txtContactnumber.Text = ""
            SupplierId = -1
            txtSupplierName.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CrudControl_ModifyButtonClicked(dr As DataRow) Handles CrudControl.ModifyButtonClicked
        'No Need to do Anything
    End Sub
    Private Function ValidEntry() As Boolean
        Try
            If txtSupplierName.Text.Trim.Length = 0 Then
                MsgBox("Please enter the Supplier Name")
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub CrudControl_SaveButtonClicked() Handles CrudControl.SaveButtonClicked
        Dim o As New TradingBo.SupplierDAL

        Try
            'Validation
            If Not ValidEntry() Then
                Exit Sub
            End If
            'Store the Information
            o.BO.SupplierName = txtSupplierName.Text
            o.BO.Place = txtPlace.Text
            o.BO.ContactNumber = txtContactnumber.Text
            o.BO.SupplierId = SupplierId

            If SupplierId = -1 Then
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
        'No need to do Anything
    End Sub

    Private Sub CrudControl_DeleteButtonClicked(dr As DataRow) Handles CrudControl.DeleteButtonClicked
        Try
            If MsgBox("Are you sure you want to Delete?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim o As New TradingBo.SupplierDAL
            o.Delete(SupplierId)
            o = Nothing

            LoadRecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
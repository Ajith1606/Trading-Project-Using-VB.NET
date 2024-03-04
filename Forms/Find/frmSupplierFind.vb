Public Class frmSupplierFind
    Public SupplierId As Long
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If dgvList.CurrentRow Is Nothing Then
            MsgBox("Please choose the Supplier Name!")
            Exit Sub
        End If
        SupplierId = dgvList.CurrentRow.DataBoundItem("SupplierId")
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmSupplierFind_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class frmItemFind
    Public ItemId As Long

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If dgvList.CurrentRow Is Nothing Then
            MsgBox("Please choose the Item Description!")
        End If
        ItemId = dgvList.CurrentRow.DataBoundItem("ItemId")
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
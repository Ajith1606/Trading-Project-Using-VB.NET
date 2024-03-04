Public Class frmSupplier
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o As New TradingBo.SupplierDAL

        Try
            o.BO.SupplierName = "Test"
            o.BO.Place = "Chennai"
            o.BO.ContactNumber = "123"

            o.Create()
            MsgBox("Sucessfully Created!")
            List()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim o As New TradingBo.SupplierDAL

        Try
            If o.Read(txtSupplierId.Text) Then
                Label1.Text = o.BO.SupplierName
            End If

            o.Create()
            MsgBox("Sucessfully Readed!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        List()
    End Sub
    Private Sub List()
        Dim o As New TradingBo.SupplierDAL

        Try
            dgvSupplier.AutoGenerateColumns = False
            dgvSupplier.DataSource = o.List

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub
End Class
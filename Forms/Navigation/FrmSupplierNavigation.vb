Public Class FrmSupplierNavigation

    Dim dt As DataTable = Nothing
    Dim CurRec As Integer = -1
    Dim SupplierId As Integer = 0
    Private Sub btnClosse_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmSupplierNavigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
        DisplayRecord()
    End Sub
    Private Sub LoadRecord()
        Dim o As New TradingBo.SupplierDAL
        Try
            dt = o.List
            If CurRec = -1 Then
                CurRec = dt.Rows.Count - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub
    Private Sub DisplayRecord()
        Dim o As New TradingBo.SupplierDAL
        Try
            Dim lSupplierId As Long = dt.Rows(CurRec)("SupplierId")
            o.Read(lSupplierId)

            With o.BO
                txtSupplierName.Text = .SupplierName
                txtPlace.Text = .Place
                txtContactnumber.Text = .ContactNumber
                SupplierId = .SupplierId
            End With
            lblStatus.Text = (CurRec + 1) & " / " & dt.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub llFirst_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llFirst.LinkClicked
        Try
            CurRec = 0
            DisplayRecord()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llLast_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llLast.LinkClicked
        Try
            CurRec = dt.Rows.Count - 1
            DisplayRecord()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llPrevious_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPrevious.LinkClicked
        Try
            If CurRec > 0 Then
                CurRec -= 1
                DisplayRecord()
            Else
                MsgBox("You are in First Record")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llNext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llNext.LinkClicked
        Try
            If CurRec < (dt.Rows.Count - 1) Then
                CurRec += 1
                DisplayRecord()
            Else
                MsgBox("You are in Last Record")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llFind_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llFind.LinkClicked
        Dim frm As New frmSupplierFind

        frm.dgvList.AutoGenerateColumns = False
        frm.dgvList.DataSource = dt

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim lSupplierId As Long = frm.SupplierId
            CurRec = 0
            Do While True
                If dt.Rows(CurRec)("SupplierId") = lSupplierId Then
                    Exit Do
                End If
                CurRec += 1
            Loop
        End If
        frm.Dispose()
        DisplayRecord()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        EnableSaveCancelButtons(True)
    End Sub
    Private Sub EnableSaveCancelButtons(ByVal Enabled As Boolean)
        btnSave.Enabled = Enabled
        btnSave.Visible = Visible

        btnCancel.Enabled = Enabled
        btnCancel.Visible = Visible

        btnNew.Enabled = Not Enabled
        btnNew.Visible = Not Visible
        btnModify.Enabled = Not Enabled
        btnModify.Visible = Not Visible
        btnDelete.Enabled = Not Enabled
        btnDelete.Visible = Not Visible
        btnClose.Enabled = Not Enabled
        btnClose.Visible = Not Visible
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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


            LoadRecord()
            DisplayRecord()

            EnableSaveCancelButtons(False)
            btnNew.Visible = Visible
            btnModify.Visible = Visible
            btnDelete.Visible = Visible
            btnClose.Visible = Visible
            ''
            btnSave.Visible = Not Visible
            btnCancel.Visible = Not Visible
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click


        EnableSaveCancelButtons(False)
        btnNew.Visible = Visible
        btnModify.Visible = Visible
        btnDelete.Visible = Visible
        btnClose.Visible = Visible

        DisplayRecord()
        ''
        btnSave.Visible = Not Visible
        btnCancel.Visible = Not Visible
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Are you sure you want to Delete?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim o As New TradingBo.SupplierDAL
            o.Delete(SupplierId)
            o = Nothing

            LoadRecord()
            If CurRec > (dt.Rows.Count - 1) Then
                CurRec = dt.Rows.Count - 1
            End If
            DisplayRecord()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        Try
            'Clear the Fields
            txtSupplierName.Text = ""
            txtPlace.Text = ""
            txtContactnumber.Text = ""
            SupplierId = -1
            txtSupplierName.Focus()
            'Enable Save & Cancel Button
            EnableSaveCancelButtons(True)
            btnSave.Visible = Visible
            btnCancel.Visible = Visible
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSupplierName_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierName.TextChanged

    End Sub
End Class
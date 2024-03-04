Public Class frmItemNavigation

    Dim dt As DataTable = Nothing
    Dim CurRec As Integer = -1
    Dim ItemId As Long = 0

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmItemNavigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
        DisplayRecord()
    End Sub
    Private Sub LoadRecord()
        Dim o As New TradingBo.ItemDAL
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
        Dim o As New TradingBo.ItemDAL
        Try
            Dim lItemId As Long = dt.Rows(CurRec)("ItemId")
            o.Read(lItemId)

            With o.BO
                txtItemId.Text = .ItemId
                txtItemDescription.Text = .ItemDescription
                txtSalesPrice.Text = .SalesPrice
                ItemId = .ItemId
            End With
            lblStatus.Text = (CurRec + 1) & " / " & dt.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub llPrevious_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPrevious.LinkClicked
        Try
            If CurRec > 0 Then
                CurRec -= 1
                DisplayRecord()
            Else
                MsgBox("You're in first record!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub llNext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llNext.LinkClicked
        Try
            If CurRec < (dt.Rows.Count - 1) Then
                CurRec += 1
                DisplayRecord()
            Else
                MsgBox("You're in last record!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            If txtItemDescription.Text.Trim.Length = 0 Then
                MsgBox("Please enter the Item Description")
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim o As New TradingBo.ItemDAL
        Try
            'Validation
            If Not ValidEntry() Then
                Exit Sub
            End If
            'Store the Information

            o.BO.ItemDescription = txtItemDescription.Text
            o.BO.SalesPrice = txtSalesPrice.Text
            o.BO.ItemId = ItemId

            If ItemId = -1 Then
                o.Create()
            Else
                o.Update()
            End If

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
            Dim o As New TradingBo.ItemDAL
            o.Delete(ItemId)
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
            txtItemId.Text = ""
            txtItemDescription.Text = ""
            txtSalesPrice.Text = ""
            ItemId = -1
            txtItemDescription.Focus()
            'Enable Save & Cancel Button
            EnableSaveCancelButtons(True)
            btnSave.Visible = Visible
            btnCancel.Visible = Visible
        Catch ex As Exception

        End Try
    End Sub

    Private Sub llFind_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llFind.LinkClicked
        Dim frm As New frmItemFind

        frm.dgvList.AutoGenerateColumns = False
        frm.dgvList.DataSource = dt

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim lItemId As Long = frm.ItemId
            CurRec = 0
            Do While True
                If dt.Rows(CurRec)("ItemId") = lItemId Then
                    Exit Do
                End If
                CurRec += 1
            Loop
        End If
        frm.Dispose()
        DisplayRecord()
    End Sub
End Class
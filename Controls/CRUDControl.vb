Public Class CRUDControl
    Dim dt As DataTable = Nothing
    Dim CurRec As Integer = -1

    Event DisplayRecord(ByVal dr As DataRow)
    Event FindRecord(ByVal Cancel As Boolean, ByRef CurRec As Integer)
    Event NewButtonClicked()
    Event ModifyButtonClicked(ByVal dr As DataRow)
    Event SaveButtonClicked()
    Event CancelButtonClicked()
    Event DeleteButtonClicked(ByVal dr As DataRow)

    Public Property CurrentRecord() As Long
        Get
            Return CurRec
        End Get
        Set(value As Long)
            CurRec = value

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                llFirst.Enabled = False
                llPrevious.Enabled = False
                llLast.Enabled = False
                llNext.Enabled = False

                UpdateStatus()
                Exit Property
            End If

            'Disable First and Previous links. I the record in First Position
            If CurRec = 0 Then
                llFirst.Enabled = False
                llPrevious.Enabled = False
            Else
                llFirst.Enabled = True
                llPrevious.Enabled = True
            End If
            'Disable Last and Next links. I the record in Last Position
            If CurRec = (dt.Rows.Count - 1) Then
                llLast.Enabled = False
                llNext.Enabled = False
            Else
                llLast.Enabled = True
                llNext.Enabled = True
            End If

            UpdateStatus()
            RaiseEvent DisplayRecord(dt.Rows(CurRec))
        End Set
    End Property

    Public Property DataTable() As DataTable
        Get
            Return dt
        End Get
        Set(value As DataTable)
            dt = value

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                CurrentRecord = -1
                Exit Property
            End If

            'Position the Pointer to the last record
            If CurRec = -1 AndAlso dt.Rows.Count > 0 Then
                CurrentRecord = dt.Rows.Count - 1
            End If
            If CurRec <> -1 Then
                UpdateStatus()
                RaiseEvent DisplayRecord(dt.Rows(CurRec))
            End If
        End Set
    End Property

    Private Sub UpdateStatus()
        Try
            If CurRec = -1 Then
                lblStatus.Text = "*"
            Else
                lblStatus.Text = (CurRec + 1) & " / " & dt.Rows.Count
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llFirst_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llFirst.LinkClicked
        Try
            CurrentRecord = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llPrevious_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPrevious.LinkClicked
        Try
            If CurRec > 0 Then
                CurrentRecord -= 1
            Else
                MsgBox("You are in First Record!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llNext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llNext.LinkClicked
        Try
            If CurRec < (dt.Rows.Count - 1) Then
                CurrentRecord += 1
            Else
                MsgBox("You are in Last Record!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llLast_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llLast.LinkClicked
        Try
            CurrentRecord = dt.Rows.Count - 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llFind_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llFind.LinkClicked
        Try
            Dim lCancel As Boolean = False
            Dim lCurRec As Long = 0
            RaiseEvent FindRecord(lCancel, lCurRec)

            If Not lCancel Then
                CurrentRecord = lCurRec
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ChangeText(ByVal NewButtonClicked As Boolean)

        'Raise Appropriate Events.
        If NewButtonClicked Then
            If btnNew.Text = "New" Then
                RaiseEvent NewButtonClicked()
            Else
                RaiseEvent SaveButtonClicked()
            End If
        Else
            If btnModify.Text = "Modify" Then
                RaiseEvent ModifyButtonClicked(dt.Rows(CurRec))
            Else
                RaiseEvent CancelButtonClicked()
                RaiseEvent DisplayRecord(dt.Rows(CurRec))
            End If
        End If

        If btnNew.Text = "Save" Then
            'Take action for Save
            btnNew.Text = "New"
            btnModify.Text = "Modify"
            btnDelete.Enabled = True
        Else
            'Take Action for New/Modify
            btnNew.Text = "Save"
            btnModify.Text = "Cancel"
            btnDelete.Enabled = False
        End If

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            ChangeText(True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Try
            ChangeText(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        RaiseEvent DeleteButtonClicked(dt.Rows(CurRec))
        If CurRec > (dt.Rows.Count - 1) Then
            CurRec = dt.Rows.Count - 1
        End If
    End Sub

    Private Sub CRUDControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

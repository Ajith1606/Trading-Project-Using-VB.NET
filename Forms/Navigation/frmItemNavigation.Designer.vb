<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmItemNavigation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSalesPrice = New System.Windows.Forms.TextBox()
        Me.lblSalesPrice = New System.Windows.Forms.Label()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.lblItemDescription = New System.Windows.Forms.Label()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.lblItemId = New System.Windows.Forms.Label()
        Me.llFind = New System.Windows.Forms.LinkLabel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.llLast = New System.Windows.Forms.LinkLabel()
        Me.llNext = New System.Windows.Forms.LinkLabel()
        Me.llPrevious = New System.Windows.Forms.LinkLabel()
        Me.llFirst = New System.Windows.Forms.LinkLabel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSalesPrice)
        Me.GroupBox1.Controls.Add(Me.lblSalesPrice)
        Me.GroupBox1.Controls.Add(Me.txtItemDescription)
        Me.GroupBox1.Controls.Add(Me.lblItemDescription)
        Me.GroupBox1.Controls.Add(Me.txtItemId)
        Me.GroupBox1.Controls.Add(Me.lblItemId)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 244)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtSalesPrice
        '
        Me.txtSalesPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesPrice.Location = New System.Drawing.Point(309, 167)
        Me.txtSalesPrice.Name = "txtSalesPrice"
        Me.txtSalesPrice.Size = New System.Drawing.Size(291, 34)
        Me.txtSalesPrice.TabIndex = 11
        '
        'lblSalesPrice
        '
        Me.lblSalesPrice.AutoSize = True
        Me.lblSalesPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesPrice.Location = New System.Drawing.Point(23, 167)
        Me.lblSalesPrice.Name = "lblSalesPrice"
        Me.lblSalesPrice.Size = New System.Drawing.Size(244, 29)
        Me.lblSalesPrice.TabIndex = 10
        Me.lblSalesPrice.Text = "Sales Prices          : "
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDescription.Location = New System.Drawing.Point(309, 100)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(291, 34)
        Me.txtItemDescription.TabIndex = 9
        '
        'lblItemDescription
        '
        Me.lblItemDescription.AutoSize = True
        Me.lblItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDescription.Location = New System.Drawing.Point(23, 100)
        Me.lblItemDescription.Name = "lblItemDescription"
        Me.lblItemDescription.Size = New System.Drawing.Size(245, 29)
        Me.lblItemDescription.TabIndex = 8
        Me.lblItemDescription.Text = "Item Description    : "
        '
        'txtItemId
        '
        Me.txtItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemId.Location = New System.Drawing.Point(309, 26)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(291, 34)
        Me.txtItemId.TabIndex = 7
        '
        'lblItemId
        '
        Me.lblItemId.AutoSize = True
        Me.lblItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemId.Location = New System.Drawing.Point(23, 26)
        Me.lblItemId.Name = "lblItemId"
        Me.lblItemId.Size = New System.Drawing.Size(246, 29)
        Me.lblItemId.TabIndex = 6
        Me.lblItemId.Text = "Item Id                    : "
        '
        'llFind
        '
        Me.llFind.AutoSize = True
        Me.llFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llFind.Location = New System.Drawing.Point(455, 303)
        Me.llFind.Name = "llFind"
        Me.llFind.Size = New System.Drawing.Size(65, 29)
        Me.llFind.TabIndex = 24
        Me.llFind.TabStop = True
        Me.llFind.Text = "Find"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(212, 303)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(20, 29)
        Me.lblStatus.TabIndex = 23
        Me.lblStatus.Text = "."
        '
        'llLast
        '
        Me.llLast.AutoSize = True
        Me.llLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llLast.Location = New System.Drawing.Point(381, 303)
        Me.llLast.Name = "llLast"
        Me.llLast.Size = New System.Drawing.Size(43, 29)
        Me.llLast.TabIndex = 22
        Me.llLast.TabStop = True
        Me.llLast.Text = ">>"
        '
        'llNext
        '
        Me.llNext.AutoSize = True
        Me.llNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llNext.Location = New System.Drawing.Point(303, 303)
        Me.llNext.Name = "llNext"
        Me.llNext.Size = New System.Drawing.Size(28, 29)
        Me.llNext.TabIndex = 21
        Me.llNext.TabStop = True
        Me.llNext.Text = ">"
        '
        'llPrevious
        '
        Me.llPrevious.AutoSize = True
        Me.llPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llPrevious.Location = New System.Drawing.Point(132, 303)
        Me.llPrevious.Name = "llPrevious"
        Me.llPrevious.Size = New System.Drawing.Size(28, 29)
        Me.llPrevious.TabIndex = 20
        Me.llPrevious.TabStop = True
        Me.llPrevious.Text = "<"
        '
        'llFirst
        '
        Me.llFirst.AutoSize = True
        Me.llFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llFirst.Location = New System.Drawing.Point(39, 303)
        Me.llFirst.Name = "llFirst"
        Me.llFirst.Size = New System.Drawing.Size(43, 29)
        Me.llFirst.TabIndex = 19
        Me.llFirst.TabStop = True
        Me.llFirst.Text = "<<"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(544, 455)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 47)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(137, 455)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(134, 47)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(44, 388)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(134, 47)
        Me.btnNew.TabIndex = 27
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(197, 388)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(134, 47)
        Me.btnModify.TabIndex = 28
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Lime
        Me.btnSave.Location = New System.Drawing.Point(408, 388)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 47)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(548, 388)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(134, 47)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'frmItemNavigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 514)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.llFind)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.llLast)
        Me.Controls.Add(Me.llNext)
        Me.Controls.Add(Me.llPrevious)
        Me.Controls.Add(Me.llFirst)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmItemNavigation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSalesPrice As TextBox
    Friend WithEvents lblSalesPrice As Label
    Friend WithEvents txtItemDescription As TextBox
    Friend WithEvents lblItemDescription As Label
    Friend WithEvents txtItemId As TextBox
    Friend WithEvents lblItemId As Label
    Friend WithEvents llFind As LinkLabel
    Friend WithEvents lblStatus As Label
    Friend WithEvents llLast As LinkLabel
    Friend WithEvents llNext As LinkLabel
    Friend WithEvents llPrevious As LinkLabel
    Friend WithEvents llFirst As LinkLabel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUDControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.llFind = New System.Windows.Forms.LinkLabel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.llLast = New System.Windows.Forms.LinkLabel()
        Me.llNext = New System.Windows.Forms.LinkLabel()
        Me.llPrevious = New System.Windows.Forms.LinkLabel()
        Me.llFirst = New System.Windows.Forms.LinkLabel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'llFind
        '
        Me.llFind.AutoSize = True
        Me.llFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llFind.Location = New System.Drawing.Point(368, 11)
        Me.llFind.Name = "llFind"
        Me.llFind.Size = New System.Drawing.Size(65, 29)
        Me.llFind.TabIndex = 13
        Me.llFind.TabStop = True
        Me.llFind.Text = "Find"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(154, 11)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(20, 29)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "."
        '
        'llLast
        '
        Me.llLast.AutoSize = True
        Me.llLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llLast.Location = New System.Drawing.Point(294, 11)
        Me.llLast.Name = "llLast"
        Me.llLast.Size = New System.Drawing.Size(43, 29)
        Me.llLast.TabIndex = 11
        Me.llLast.TabStop = True
        Me.llLast.Text = ">>"
        '
        'llNext
        '
        Me.llNext.AutoSize = True
        Me.llNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llNext.Location = New System.Drawing.Point(235, 11)
        Me.llNext.Name = "llNext"
        Me.llNext.Size = New System.Drawing.Size(28, 29)
        Me.llNext.TabIndex = 10
        Me.llNext.TabStop = True
        Me.llNext.Text = ">"
        '
        'llPrevious
        '
        Me.llPrevious.AutoSize = True
        Me.llPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llPrevious.Location = New System.Drawing.Point(85, 11)
        Me.llPrevious.Name = "llPrevious"
        Me.llPrevious.Size = New System.Drawing.Size(28, 29)
        Me.llPrevious.TabIndex = 9
        Me.llPrevious.TabStop = True
        Me.llPrevious.Text = "<"
        '
        'llFirst
        '
        Me.llFirst.AutoSize = True
        Me.llFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llFirst.Location = New System.Drawing.Point(14, 11)
        Me.llFirst.Name = "llFirst"
        Me.llFirst.Size = New System.Drawing.Size(43, 29)
        Me.llFirst.TabIndex = 8
        Me.llFirst.TabStop = True
        Me.llFirst.Text = "<<"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(299, 55)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(134, 47)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(159, 55)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(134, 44)
        Me.btnModify.TabIndex = 15
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(19, 55)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(134, 44)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'CRUDControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.llFind)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.llLast)
        Me.Controls.Add(Me.llNext)
        Me.Controls.Add(Me.llPrevious)
        Me.Controls.Add(Me.llFirst)
        Me.Name = "CRUDControl"
        Me.Size = New System.Drawing.Size(446, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents llFind As LinkLabel
    Friend WithEvents lblStatus As Label
    Friend WithEvents llLast As LinkLabel
    Friend WithEvents llNext As LinkLabel
    Friend WithEvents llPrevious As LinkLabel
    Friend WithEvents llFirst As LinkLabel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnNew As Button
End Class

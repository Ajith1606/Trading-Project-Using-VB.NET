<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.txtSupplierId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.dcSupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(246, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.Location = New System.Drawing.Point(416, 135)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(114, 42)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'txtSupplierId
        '
        Me.txtSupplierId.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierId.Location = New System.Drawing.Point(416, 87)
        Me.txtSupplierId.Name = "txtSupplierId"
        Me.txtSupplierId.Size = New System.Drawing.Size(193, 34)
        Me.txtSupplierId.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "."
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToAddRows = False
        Me.dgvSupplier.AllowUserToDeleteRows = False
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dcSupplierName, Me.dcContactNumber})
        Me.dgvSupplier.Location = New System.Drawing.Point(79, 261)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.RowTemplate.Height = 24
        Me.dgvSupplier.Size = New System.Drawing.Size(659, 254)
        Me.dgvSupplier.TabIndex = 4
        '
        'dcSupplierName
        '
        Me.dcSupplierName.DataPropertyName = "SupplierName"
        Me.dcSupplierName.HeaderText = "Supplier Name"
        Me.dcSupplierName.Name = "dcSupplierName"
        '
        'dcContactNumber
        '
        Me.dcContactNumber.DataPropertyName = "ContactNumber"
        Me.dcContactNumber.HeaderText = "Contact Number"
        Me.dcContactNumber.Name = "dcContactNumber"
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 527)
        Me.Controls.Add(Me.dgvSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSupplierId)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier"
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents txtSupplierId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents dcSupplierName As DataGridViewTextBoxColumn
    Friend WithEvents dcContactNumber As DataGridViewTextBoxColumn
End Class

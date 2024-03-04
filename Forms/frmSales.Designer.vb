<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCustomerName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBillNo = New System.Windows.Forms.Label()
        Me.dtpSalesDate = New System.Windows.Forms.DateTimePicker()
        Me.lblPlace = New System.Windows.Forms.Label()
        Me.lblSuppliername = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvSalesDetail = New System.Windows.Forms.DataGridView()
        Me.dcItemId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dcQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrudControl = New Trading.CRUDControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSalesDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblBillNo)
        Me.GroupBox1.Controls.Add(Me.dtpSalesDate)
        Me.GroupBox1.Controls.Add(Me.lblPlace)
        Me.GroupBox1.Controls.Add(Me.lblSuppliername)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 249)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'cboCustomerName
        '
        Me.cboCustomerName.DisplayMember = "CustomerName"
        Me.cboCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomerName.FormattingEnabled = True
        Me.cboCustomerName.Location = New System.Drawing.Point(318, 178)
        Me.cboCustomerName.Name = "cboCustomerName"
        Me.cboCustomerName.Size = New System.Drawing.Size(511, 37)
        Me.cboCustomerName.TabIndex = 9
        Me.cboCustomerName.ValueMember = "CustomerId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(618, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bill No : "
        '
        'lblBillNo
        '
        Me.lblBillNo.AutoSize = True
        Me.lblBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNo.Location = New System.Drawing.Point(746, 37)
        Me.lblBillNo.Name = "lblBillNo"
        Me.lblBillNo.Size = New System.Drawing.Size(83, 29)
        Me.lblBillNo.TabIndex = 7
        Me.lblBillNo.Text = "(Auto)"
        '
        'dtpSalesDate
        '
        Me.dtpSalesDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSalesDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpSalesDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSalesDate.Location = New System.Drawing.Point(318, 104)
        Me.dtpSalesDate.Name = "dtpSalesDate"
        Me.dtpSalesDate.Size = New System.Drawing.Size(511, 34)
        Me.dtpSalesDate.TabIndex = 6
        '
        'lblPlace
        '
        Me.lblPlace.AutoSize = True
        Me.lblPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlace.Location = New System.Drawing.Point(32, 182)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Size = New System.Drawing.Size(236, 29)
        Me.lblPlace.TabIndex = 2
        Me.lblPlace.Text = "Customer Name   : "
        '
        'lblSuppliername
        '
        Me.lblSuppliername.AutoSize = True
        Me.lblSuppliername.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppliername.Location = New System.Drawing.Point(32, 107)
        Me.lblSuppliername.Name = "lblSuppliername"
        Me.lblSuppliername.Size = New System.Drawing.Size(235, 29)
        Me.lblSuppliername.TabIndex = 0
        Me.lblSuppliername.Text = "Date                      : "
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(515, 632)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 47)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvSalesDetail
        '
        Me.dgvSalesDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dcItemId, Me.dcQuantity, Me.dcRate, Me.dcAmount})
        Me.dgvSalesDetail.Location = New System.Drawing.Point(18, 290)
        Me.dgvSalesDetail.Name = "dgvSalesDetail"
        Me.dgvSalesDetail.RowTemplate.Height = 24
        Me.dgvSalesDetail.Size = New System.Drawing.Size(835, 274)
        Me.dgvSalesDetail.TabIndex = 7
        '
        'dcItemId
        '
        Me.dcItemId.DataPropertyName = "ItemId"
        Me.dcItemId.HeaderText = "Item Name"
        Me.dcItemId.Name = "dcItemId"
        Me.dcItemId.Width = 200
        '
        'dcQuantity
        '
        Me.dcQuantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dcQuantity.DefaultCellStyle = DataGridViewCellStyle1
        Me.dcQuantity.HeaderText = "Quantity"
        Me.dcQuantity.Name = "dcQuantity"
        Me.dcQuantity.Width = 120
        '
        'dcRate
        '
        Me.dcRate.DataPropertyName = "Rate"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dcRate.DefaultCellStyle = DataGridViewCellStyle2
        Me.dcRate.HeaderText = "Rate"
        Me.dcRate.Name = "dcRate"
        Me.dcRate.Width = 120
        '
        'dcAmount
        '
        Me.dcAmount.DataPropertyName = "Amount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dcAmount.DefaultCellStyle = DataGridViewCellStyle3
        Me.dcAmount.HeaderText = "Amount"
        Me.dcAmount.Name = "dcAmount"
        Me.dcAmount.ReadOnly = True
        Me.dcAmount.Width = 120
        '
        'CrudControl
        '
        Me.CrudControl.CurrentRecord = CType(-1, Long)
        Me.CrudControl.DataTable = Nothing
        Me.CrudControl.Location = New System.Drawing.Point(18, 578)
        Me.CrudControl.Name = "CrudControl"
        Me.CrudControl.Size = New System.Drawing.Size(446, 113)
        Me.CrudControl.TabIndex = 6
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 703)
        Me.Controls.Add(Me.dgvSalesDetail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrudControl)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSalesDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPlace As Label
    Friend WithEvents lblSuppliername As Label
    Friend WithEvents CrudControl As CRUDControl
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBillNo As Label
    Friend WithEvents dtpSalesDate As DateTimePicker
    Friend WithEvents cboCustomerName As ComboBox
    Friend WithEvents dgvSalesDetail As DataGridView
    Friend WithEvents dcItemId As DataGridViewComboBoxColumn
    Friend WithEvents dcQuantity As DataGridViewTextBoxColumn
    Friend WithEvents dcRate As DataGridViewTextBoxColumn
    Friend WithEvents dcAmount As DataGridViewTextBoxColumn
End Class

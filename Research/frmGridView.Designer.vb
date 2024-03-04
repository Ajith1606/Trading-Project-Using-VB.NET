<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGridView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvItemList = New System.Windows.Forms.DataGridView()
        Me.dcItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcSalesPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvItemList
        '
        Me.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dcItemDescription, Me.dcSalesPrice})
        Me.dgvItemList.Location = New System.Drawing.Point(50, 38)
        Me.dgvItemList.Name = "dgvItemList"
        Me.dgvItemList.RowTemplate.Height = 24
        Me.dgvItemList.Size = New System.Drawing.Size(655, 315)
        Me.dgvItemList.TabIndex = 0
        '
        'dcItemDescription
        '
        Me.dcItemDescription.DataPropertyName = "ItemDescription"
        Me.dcItemDescription.HeaderText = "Item Description"
        Me.dcItemDescription.Name = "dcItemDescription"
        Me.dcItemDescription.Width = 250
        '
        'dcSalesPrice
        '
        Me.dcSalesPrice.DataPropertyName = "SalesPrice"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red
        Me.dcSalesPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.dcSalesPrice.HeaderText = "Sales Price"
        Me.dcSalesPrice.Name = "dcSalesPrice"
        '
        'frmGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvItemList)
        Me.Name = "frmGridView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grid View Sample"
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvItemList As DataGridView
    Friend WithEvents dcItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents dcSalesPrice As DataGridViewTextBoxColumn
End Class

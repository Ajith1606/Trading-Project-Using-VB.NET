<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataTableResearch
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.btnColumns = New System.Windows.Forms.Button()
        Me.btnSumLooping = New System.Windows.Forms.Button()
        Me.btnSumComputing = New System.Windows.Forms.Button()
        Me.lblDataTable = New System.Windows.Forms.Label()
        Me.btnDataView = New System.Windows.Forms.Label()
        Me.btnDVFindItemName = New System.Windows.Forms.Button()
        Me.btnSumDVLooping = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1193, 200)
        Me.DataGridView1.TabIndex = 0
        '
        'btnFetch
        '
        Me.btnFetch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetch.ForeColor = System.Drawing.Color.Lime
        Me.btnFetch.Location = New System.Drawing.Point(29, 47)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(136, 93)
        Me.btnFetch.TabIndex = 1
        Me.btnFetch.Text = "Fetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'btnColumns
        '
        Me.btnColumns.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColumns.Location = New System.Drawing.Point(362, 38)
        Me.btnColumns.Name = "btnColumns"
        Me.btnColumns.Size = New System.Drawing.Size(153, 41)
        Me.btnColumns.TabIndex = 2
        Me.btnColumns.Text = "Columns"
        Me.btnColumns.UseVisualStyleBackColor = True
        '
        'btnSumLooping
        '
        Me.btnSumLooping.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumLooping.Location = New System.Drawing.Point(594, 38)
        Me.btnSumLooping.Name = "btnSumLooping"
        Me.btnSumLooping.Size = New System.Drawing.Size(225, 41)
        Me.btnSumLooping.TabIndex = 3
        Me.btnSumLooping.Text = "Sum - Looping"
        Me.btnSumLooping.UseVisualStyleBackColor = True
        '
        'btnSumComputing
        '
        Me.btnSumComputing.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumComputing.Location = New System.Drawing.Point(914, 32)
        Me.btnSumComputing.Name = "btnSumComputing"
        Me.btnSumComputing.Size = New System.Drawing.Size(272, 41)
        Me.btnSumComputing.TabIndex = 4
        Me.btnSumComputing.Text = "Sum - Computing"
        Me.btnSumComputing.UseVisualStyleBackColor = True
        '
        'lblDataTable
        '
        Me.lblDataTable.AutoSize = True
        Me.lblDataTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataTable.Location = New System.Drawing.Point(183, 38)
        Me.lblDataTable.Name = "lblDataTable"
        Me.lblDataTable.Size = New System.Drawing.Size(162, 29)
        Me.lblDataTable.TabIndex = 5
        Me.lblDataTable.Text = "Data Table : "
        '
        'btnDataView
        '
        Me.btnDataView.AutoSize = True
        Me.btnDataView.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataView.Location = New System.Drawing.Point(183, 111)
        Me.btnDataView.Name = "btnDataView"
        Me.btnDataView.Size = New System.Drawing.Size(151, 29)
        Me.btnDataView.TabIndex = 9
        Me.btnDataView.Text = "Data View : "
        '
        'btnDVFindItemName
        '
        Me.btnDVFindItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDVFindItemName.Location = New System.Drawing.Point(891, 105)
        Me.btnDVFindItemName.Name = "btnDVFindItemName"
        Me.btnDVFindItemName.Size = New System.Drawing.Size(310, 41)
        Me.btnDVFindItemName.TabIndex = 8
        Me.btnDVFindItemName.Text = "DV - Find Item Name"
        Me.btnDVFindItemName.UseVisualStyleBackColor = True
        '
        'btnSumDVLooping
        '
        Me.btnSumDVLooping.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumDVLooping.Location = New System.Drawing.Point(594, 105)
        Me.btnSumDVLooping.Name = "btnSumDVLooping"
        Me.btnSumDVLooping.Size = New System.Drawing.Size(276, 41)
        Me.btnSumDVLooping.TabIndex = 7
        Me.btnSumDVLooping.Text = "Sum - DV Looping"
        Me.btnSumDVLooping.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(362, 105)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(199, 41)
        Me.btnFilter.TabIndex = 6
        Me.btnFilter.Text = "Filter>Rs.100/-"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'DataTableResearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 397)
        Me.Controls.Add(Me.btnDataView)
        Me.Controls.Add(Me.btnDVFindItemName)
        Me.Controls.Add(Me.btnSumDVLooping)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.lblDataTable)
        Me.Controls.Add(Me.btnSumComputing)
        Me.Controls.Add(Me.btnSumLooping)
        Me.Controls.Add(Me.btnColumns)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DataTableResearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Table Research"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnFetch As Button
    Friend WithEvents btnColumns As Button
    Friend WithEvents btnSumLooping As Button
    Friend WithEvents btnSumComputing As Button
    Friend WithEvents lblDataTable As Label
    Friend WithEvents btnDataView As Label
    Friend WithEvents btnDVFindItemName As Button
    Friend WithEvents btnSumDVLooping As Button
    Friend WithEvents btnFilter As Button
End Class

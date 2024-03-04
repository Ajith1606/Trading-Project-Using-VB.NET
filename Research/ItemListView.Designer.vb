<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemListView
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
        Me.lvItem = New System.Windows.Forms.ListView()
        Me.chItemDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSalesPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvItem
        '
        Me.lvItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chItemDescription, Me.chSalesPrice})
        Me.lvItem.HideSelection = False
        Me.lvItem.Location = New System.Drawing.Point(12, 30)
        Me.lvItem.Name = "lvItem"
        Me.lvItem.Size = New System.Drawing.Size(776, 158)
        Me.lvItem.TabIndex = 0
        Me.lvItem.UseCompatibleStateImageBehavior = False
        Me.lvItem.View = System.Windows.Forms.View.Details
        '
        'chItemDescription
        '
        Me.chItemDescription.Text = "Item Description"
        Me.chItemDescription.Width = 100
        '
        'chSalesPrice
        '
        Me.chSalesPrice.Text = "Sales Price"
        Me.chSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chSalesPrice.Width = 100
        '
        'ItemListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lvItem)
        Me.Name = "ItemListView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemListView"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvItem As ListView
    Friend WithEvents chItemDescription As ColumnHeader
    Friend WithEvents chSalesPrice As ColumnHeader
End Class

Public Class Form1
    Private Sub Rorm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DataTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTableToolStripMenuItem.Click
        Dim o As New TradingBo.SQLServer
        Dim lsql As String = "Select * From Item"

        Dim dt As DataTable = o.GetDataTable(lsql)
        o = Nothing
    End Sub

    Private Sub ItemListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemListToolStripMenuItem.Click
        Dim frm As New ItemListView
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DataGridViewSampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataGridViewSampleToolStripMenuItem.Click
        Dim frm As New frmGridView
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ComboBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComboBoxToolStripMenuItem.Click
        Dim frm As New frmComboTesting
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim frm As New FrmSupplierNavigation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem1.Click
        Dim frm As New frmSupplier
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem.Click
        Dim frm As New frmItemNavigation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim frm As New frmCustomerNavigation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DataResearchAnalysisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataResearchAnalysisToolStripMenuItem.Click
        Dim frm As New DataTableResearch
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SupplierV2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierV2ToolStripMenuItem.Click
        Dim frm As New FrmSupplierV2
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SalesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem1.Click
        Dim frm As New frmSales
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class

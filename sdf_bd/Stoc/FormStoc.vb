Public Class FormStoc
    Private Sub FormStoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.STOC' table. You can move, or remove it, as needed.
        Me.STOCTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.STOC)

    End Sub

    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim addStoc As New AddStoc
        addStoc.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.STOCTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.STOC)
        DataGridViewStoc.DataSource = STOCBindingSource
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbStoc.Search(txtCauta.Text, DataGridViewStoc)
    End Sub

    Private Sub DataGridViewStoc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStoc.CellClick
        If (e.ColumnIndex = 3) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbStoc.DeleteStoc(DataGridViewStoc.Rows(e.RowIndex).Cells(0).Value, DataGridViewStoc.Rows(e.RowIndex).Cells(1).Value)
            End If
        End If
        If (e.ColumnIndex = 4) Then
            'Edit
            Dim formModifica As New AddStoc(DataGridViewStoc.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub
End Class
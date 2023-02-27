Public Class FormAntrenor
    Private Sub FormAntrenor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.ANTRENOR' table. You can move, or remove it, as needed.
        Me.ANTRENORTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.ANTRENOR)

    End Sub

    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim addAntrenor As New AddAntrenor
        addAntrenor.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.ANTRENORTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.ANTRENOR)
        DataGridViewAntrenor.DataSource = ANTRENORBindingSource
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbAntrenor.Search(txtCauta.Text, DataGridViewAntrenor)
    End Sub

    Private Sub DataGridViewAntrenor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAntrenor.CellClick
        If (e.ColumnIndex = 5) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbAntrenor.DeleteAntrenor(DataGridViewAntrenor.Rows(e.RowIndex).Cells(0).Value)
            End If
        End If
        If (e.ColumnIndex = 6) Then
            'Edit
            Dim formModifica As New AddAntrenor(DataGridViewAntrenor.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub
End Class
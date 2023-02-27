Public Class FormSupliment
    Private Sub FormSupliment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.SUPLIMENT' table. You can move, or remove it, as needed.
        Me.SUPLIMENTTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.SUPLIMENT)

    End Sub

    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim addSupliment As New AddSupliment
        addSupliment.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.SUPLIMENTTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.SUPLIMENT)
        DataGridViewSup.DataSource = SUPLIMENTBindingSource
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbSupliment.Search(txtCauta.Text, DataGridViewSup)
    End Sub

    Private Sub DataGridViewSup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSup.CellClick
        If (e.ColumnIndex = 4) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbSupliment.DeleteSupliment(DataGridViewSup.Rows(e.RowIndex).Cells(0).Value)
            End If
        End If
        If (e.ColumnIndex = 5) Then
            'Edit
            Dim formModifica As New AddSupliment(DataGridViewSup.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub
End Class
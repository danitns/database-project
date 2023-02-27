Public Class FormTranzactie
    Private Sub FormTranzactie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.TRANZACTIE' table. You can move, or remove it, as needed.
        Me.TRANZACTIETableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.TRANZACTIE)

    End Sub

    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim addTranzactie As New AddTranzactie
        addTranzactie.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.TRANZACTIETableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.TRANZACTIE)
        DataGridViewTranz.DataSource = TRANZACTIEBindingSource
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbTranzactie.Search(txtCauta.Text, DataGridViewTranz)
    End Sub

    Private Sub DataGridViewTranz_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTranz.CellClick
        If (e.ColumnIndex = 4) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbTranzactie.DeleteTranzactie(DataGridViewTranz.Rows(e.RowIndex).Cells(0).Value)
            End If
        End If
        If (e.ColumnIndex = 5) Then
            'Edit
            Dim formModifica As New AddTranzactie(DataGridViewTranz.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub
End Class
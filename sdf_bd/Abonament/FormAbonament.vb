Public Class FormAbonament
    Private Sub FormAbonament_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.ABONAMENT' table. You can move, or remove it, as needed.
        Me.ABONAMENTTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.ABONAMENT)

    End Sub

    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim addAbonament As New AddAbonament
        addAbonament.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.ABONAMENTTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.ABONAMENT)
        DataGridViewAbonament.DataSource = ABONAMENTBindingSource
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbAbonament.Search(txtCauta.Text, DataGridViewAbonament)
    End Sub

    Private Sub DataGridViewAbonament_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAbonament.CellClick
        If (e.ColumnIndex = 6) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbAbonament.DeleteAbonament(DataGridViewAbonament.Rows(e.RowIndex).Cells(0).Value.ToString)
            End If
        End If
        If (e.ColumnIndex = 7) Then
            'Edit
            Dim formModifica As New AddAbonament(DataGridViewAbonament.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub
End Class
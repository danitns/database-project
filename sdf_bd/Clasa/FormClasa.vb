Public Class FormClasa
    Private Sub FormClasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.CLASA' table. You can move, or remove it, as needed.
        Me.CLASATableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.CLASA)

    End Sub

    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim addClasa As New AddClasa
        addClasa.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.CLASATableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.CLASA)
        DataGridViewClasa.DataSource = CLASABindingSource
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbClasa.Search(txtCauta.Text, DataGridViewClasa)
    End Sub

    Private Sub DataGridViewClasa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClasa.CellClick
        If (e.ColumnIndex = 4) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbClasa.DeleteClasa(DataGridViewClasa.Rows(e.RowIndex).Cells(0).Value)
            End If
        End If
        If (e.ColumnIndex = 5) Then
            'Edit
            Dim formModifica As New AddClasa(DataGridViewClasa.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub
End Class
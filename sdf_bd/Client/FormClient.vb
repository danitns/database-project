Public Class FormClient
    Private Sub FormClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.CLIENT' table. You can move, or remove it, as needed.
        Me.CLIENTTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.CLIENT)

    End Sub

    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim addClient As New AddClient
        addClient.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.CLIENTTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.CLIENT)
        DataGridViewClienti.DataSource = CLIENTBindingSource
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbClient.Search(txtCauta.Text, DataGridViewClienti)
    End Sub

    Private Sub DataGridViewClienti_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClienti.CellClick
        If (e.ColumnIndex = 6) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbClient.DeleteClient(DataGridViewClienti.Rows(e.RowIndex).Cells(0).Value)
            End If
        End If
        If (e.ColumnIndex = 7) Then
            'Edit
            Dim formModifica As New AddClient(DataGridViewClienti.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub
End Class
Public Class FormMentenanta
    Private Sub FormMentenanta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.MENTENANTA' table. You can move, or remove it, as needed.
        Me.MENTENANTATableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.MENTENANTA)

    End Sub
    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim formAdauga As New AddMentenanta
        formAdauga.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.MENTENANTATableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.MENTENANTA)
        DataGridViewMentenanta.DataSource = MENTENANTABindingSource
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbMentenanta.Search(txtCauta.Text, DataGridViewMentenanta)
    End Sub

    Private Sub DataGridViewMentenanta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMentenanta.CellClick
        If (e.ColumnIndex = 6) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbMentenanta.DeleteMentenanta(DataGridViewMentenanta.Rows(e.RowIndex).Cells(0).Value)
            End If
        End If
        If (e.ColumnIndex = 7) Then
            'Edit
            Dim formModifica As New AddMentenanta(DataGridViewMentenanta.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub
End Class
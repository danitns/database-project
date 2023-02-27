Public Class FormProgram
    Private Sub FormProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.PROGRAM' table. You can move, or remove it, as needed.
        Me.PROGRAMTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.PROGRAM)

    End Sub

    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim addProgram As New AddProgram
        addProgram.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.PROGRAMTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.PROGRAM)
        DataGridViewProgram.DataSource = PROGRAMBindingSource
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbProgram.Search(txtCauta.Text, DataGridViewProgram)
    End Sub

    Private Sub DataGridViewProgram_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProgram.CellClick
        If (e.ColumnIndex = 3) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbProgram.DeleteProgram(DataGridViewProgram.Rows(e.RowIndex).Cells(0).Value, DataGridViewProgram.Rows(e.RowIndex).Cells(1).Value)
            End If
        End If
        If (e.ColumnIndex = 4) Then
            'Edit
            Dim formModifica As New AddProgram(DataGridViewProgram.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub
End Class
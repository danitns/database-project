Public Class FormVizComp
    Private Sub FormVizComp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet1.V_SALA_ANTRENOR' table. You can move, or remove it, as needed.
        Me.V_SALA_ANTRENORTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet1.V_SALA_ANTRENOR)
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet1.V_SUPLIMENT_SALA' table. You can move, or remove it, as needed.

    End Sub

    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim addVizComp As New AddVizComp
        addVizComp.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.V_SALA_ANTRENORTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet1.V_SALA_ANTRENOR)
        DataGridViewViz.DataSource = VSALAANTRENORBindingSource1
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbVizComp.Search(txtCauta.Text, DataGridViewViz)
    End Sub

    Private Sub DataGridViewViz_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewViz.CellClick
        If (e.ColumnIndex = 10) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbVizComp.DeleteAntrenor(DataGridViewViz.Rows(e.RowIndex).Cells(0).Value)
            End If
        End If
        If (e.ColumnIndex = 9) Then
            'Edit
            Dim formModifica As New AddVizComp(DataGridViewViz.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub
End Class
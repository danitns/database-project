Imports System.Security.Cryptography

Public Class FormSala
    Private Sub FormSala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.SALA' table. You can move, or remove it, as needed.
        Me.SALATableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.SALA)
    End Sub

    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        Dim formAdauga As AddSala = New AddSala()
        formAdauga.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.SALATableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.SALA)
        DataGridViewSala.DataSource = SALABindingSource
    End Sub

    Private Sub txtCauta_TextChanged(sender As Object, e As EventArgs) Handles txtCauta.TextChanged
        DbSala.Search(txtCauta.Text, DataGridViewSala)
    End Sub

    Private Sub DataGridViewSala_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSala.CellClick
        If (e.ColumnIndex = 5) Then
            'Delete
            If (MessageBox.Show("Doresti sa stergi acest element?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                DbSala.DeleteSala(DataGridViewSala.Rows(e.RowIndex).Cells(0).Value.ToString)
            End If
        End If
        If (e.ColumnIndex = 6) Then
            'Edit
            Dim formModifica As New AddSala(DataGridViewSala.Rows(e.RowIndex))
            formModifica.ShowDialog()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
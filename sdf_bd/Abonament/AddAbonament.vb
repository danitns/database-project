Public Class AddAbonament

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(row As DataGridViewRow)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Label1.Text = "Modifica"
        btnSalveaza.Text = "Modifica"
        txtTip.Text = row.Cells(0).Value.ToString
        NumericPret.Value = row.Cells(1).Value
        NumericDurata.Value = row.Cells(2).Value
        CheckSauna.Checked = row.Cells(3).Value
        CheckSpa.Checked = row.Cells(4).Value
        CheckPiscina.Checked = row.Cells(5).Value
    End Sub

    Public Sub Clear()
        txtTip.Text = ""
        NumericPret.Value = 1
        NumericDurata.Value = 1
        CheckSauna.Checked = False
        CheckSpa.Checked = False
        CheckPiscina.Checked = False
    End Sub
    Private Sub btnSalveaza_Click(sender As Object, e As EventArgs) Handles btnSalveaza.Click
        If (txtTip.Text.Trim.Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (btnSalveaza.Text = "Salveaza") Then
            Dim abonament As New Abonament(txtTip.Text.Trim, NumericDurata.Value, NumericPret.Value, CheckSauna.Checked, CheckSpa.Checked, CheckPiscina.Checked)
            DbAbonament.AddAbonament(abonament)
            Clear()
        End If
        If (btnSalveaza.Text = "Modifica") Then
            Dim abonament As New Abonament(txtTip.Text.Trim, NumericDurata.Value, NumericPret.Value, CheckSauna.Checked, CheckSpa.Checked, CheckPiscina.Checked)
            DbAbonament.UpdateAbonament(abonament, txtTip.Text.Trim)
            Clear()
        End If
    End Sub
End Class
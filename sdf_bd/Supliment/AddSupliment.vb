Public Class AddSupliment

    Private ID_Supliment = 0
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
        ID_Supliment = row.Cells(0).Value
        txtBrand.Text = row.Cells(1).Value.ToString
        txtNume.Text = row.Cells(2).Value.ToString
        NumericUpDownPret.Value = row.Cells(3).Value
    End Sub

    Public Sub Clear()
        txtBrand.Text = ""
        txtNume.Text = ""
        NumericUpDownPret.Value = 0
    End Sub

    Private Sub btnSalveaza_Click(sender As Object, e As EventArgs) Handles btnSalveaza.Click
        If (txtBrand.Text.Trim().Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (txtNume.Text.Trim().Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (btnSalveaza.Text = "Salveaza") Then
            Dim supliment As New Supliment(txtBrand.Text, txtNume.Text, NumericUpDownPret.Value)
            DbSupliment.AddSupliment(supliment)
            Clear()
        End If
        If (btnSalveaza.Text = "Modifica") Then
            Dim supliment As New Supliment(txtBrand.Text, txtNume.Text, NumericUpDownPret.Value)
            DbSupliment.UpdateSupliment(supliment, ID_Supliment)
            Clear()
        End If
    End Sub
End Class
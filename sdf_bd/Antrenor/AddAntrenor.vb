Public Class AddAntrenor

    Private ID_Antrenor = 0
    Private Sub AddAntrenor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.SALA' table. You can move, or remove it, as needed.
        Me.SALATableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.SALA)

    End Sub

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
        ID_Antrenor = row.Cells(0).Value
        ComboBoxIdSala.Text = row.Cells(1).Value.ToString
        txtNume.Text = row.Cells(2).Value.ToString
        txtPrenume.Text = row.Cells(3).Value.ToString
        NumericUpDownSalariu.Value = row.Cells(4).Value
    End Sub

    Public Sub Clear()
        txtNume.Text = ""
        txtPrenume.Text = ""
        NumericUpDownSalariu.Value = 0
    End Sub

    Private Sub btnSalveaza_Click(sender As Object, e As EventArgs) Handles btnSalveaza.Click
        If (txtNume.Text.Trim().Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (txtPrenume.Text.Trim().Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (btnSalveaza.Text = "Salveaza") Then
            Dim antrenor As New Antrenor(ComboBoxIdSala.Text, txtNume.Text, txtPrenume.Text, NumericUpDownSalariu.Value)
            DbAntrenor.AddAntrenor(antrenor)
            Clear()
        End If
        If (btnSalveaza.Text = "Modifica") Then
            Dim antrenor As New Antrenor(ComboBoxIdSala.Text, txtNume.Text, txtPrenume.Text, NumericUpDownSalariu.Value)
            DbAntrenor.UpdateAntrenor(antrenor, ID_Antrenor)
            Clear()
        End If
    End Sub
End Class
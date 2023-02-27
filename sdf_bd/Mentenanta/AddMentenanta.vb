Public Class AddMentenanta

    Private ID_Angajat = 0
    Private Sub AddMentenanta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ID_Angajat = row.Cells(0).Value
        ComboBoxIdSala.Text = row.Cells(1).Value.ToString
        txtNume.Text = row.Cells(2).Value.ToString
        txtPrenume.Text = row.Cells(3).Value.ToString
        NumericUpDownSalariu.Value = row.Cells(4).Value
        txtOcupatie.Text = row.Cells(5).Value.ToString
    End Sub

    Public Sub Clear()
        txtNume.Text = ""
        txtPrenume.Text = ""
        NumericUpDownSalariu.Value = 0
        txtOcupatie.Text = ""
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
        If (txtOcupatie.Text.Trim().Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (btnSalveaza.Text = "Salveaza") Then
            Dim mentenanta As New Mentenanta(ComboBoxIdSala.Text, txtNume.Text, txtPrenume.Text, NumericUpDownSalariu.Value, txtOcupatie.Text)
            DbMentenanta.AddMentenanta(mentenanta)
            Clear()
        End If
        If (btnSalveaza.Text = "Modifica") Then
            Dim mentenanta As New Mentenanta(ComboBoxIdSala.Text, txtNume.Text, txtPrenume.Text, NumericUpDownSalariu.Value, txtOcupatie.Text)
            DbMentenanta.UpdateMentenanta(mentenanta, ID_Angajat)
            Clear()
        End If
    End Sub
End Class
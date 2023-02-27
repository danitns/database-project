Public Class AddTranzactie
    Private ID_Tranzactie As Integer = 0
    Private Sub AddTranzactie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.CLIENT' table. You can move, or remove it, as needed.
        Me.CLIENTTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.CLIENT)
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.ABONAMENT' table. You can move, or remove it, as needed.
        Me.ABONAMENTTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.ABONAMENT)

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
        ID_Tranzactie = row.Cells(0).Value
    End Sub

    Private Sub btnSalveaza_Click(sender As Object, e As EventArgs) Handles btnSalveaza.Click
        If (btnSalveaza.Text = "Salveaza") Then
            Dim tranzactie As New Tranzactie(ComboTip.Text, ComboIdClient.Text, DateData.Value)
            DbTranzactie.AddTranzactie(tranzactie)
        End If
        If (btnSalveaza.Text = "Modifica") Then
            Dim tranzactie As New Tranzactie(ComboTip.Text, ComboIdClient.Text, DateData.Value)
            DbTranzactie.UpdateTranzactie(tranzactie, ID_Tranzactie)
        End If
    End Sub
End Class
Public Class AddClient
    Private ID_Client = 0

    Private Sub AddClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.TRANZACTIE' table. You can move, or remove it, as needed.
        Me.TRANZACTIETableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.TRANZACTIE)

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
        ID_Client = row.Cells(0).Value
        txtNume.Text = row.Cells(2).Value.ToString
        txtPrenume.Text = row.Cells(3).Value.ToString
        txtEmail.Text = row.Cells(4).Value.ToString
        txtTelefon.Text = row.Cells(5).Value.ToString
    End Sub

    Public Sub Clear()
        txtNume.Text = ""
        txtPrenume.Text = ""
        txtEmail.Text = ""
        txtTelefon.Text = ""
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
        If (txtEmail.Text.Trim().Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (txtTelefon.Text.Trim().Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (btnSalveaza.Text = "Salveaza") Then
            Dim client As New Client(ComboIDTr.Text, txtNume.Text, txtPrenume.Text, txtEmail.Text, txtTelefon.Text)
            DbClient.AddClient(client)
            Clear()
        End If
        If (btnSalveaza.Text = "Modifica") Then
            Dim client As New Client(ComboIDTr.Text, txtNume.Text, txtPrenume.Text, txtEmail.Text, txtTelefon.Text)
            DbClient.UpdateClient(client, ID_Client)
            Clear()
        End If
    End Sub
End Class
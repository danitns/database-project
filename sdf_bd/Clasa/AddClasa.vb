Public Class AddClasa
    Private Sub AddClasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.ANTRENOR' table. You can move, or remove it, as needed.
        Me.ANTRENORTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.ANTRENOR)

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
        txtIdClasa.Text = row.Cells(0).Value.ToString
        ComboBoxIdAntr.Text = row.Cells(1).Value
        txtNume.Text = row.Cells(2).Value.ToString
    End Sub

    Public Sub Clear()
        txtIdClasa.Text = ""
        txtNume.Text = ""
        DateTimeDurata.Value = New Date(2000, 1, 1, 0, 0, 0)
    End Sub

    Private Sub btnSalveaza_Click(sender As Object, e As EventArgs) Handles btnSalveaza.Click
        If (txtIdClasa.Text.Trim.Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (txtNume.Text.Trim.Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (btnSalveaza.Text = "Salveaza") Then
            Dim clasa As New Clasa(txtIdClasa.Text, ComboBoxIdAntr.Text, txtNume.Text, DateTimeDurata.Value)
            DbClasa.AddClasa(clasa)
            Clear()
        End If
        If (btnSalveaza.Text = "Modifica") Then
            Dim clasa As New Clasa(txtIdClasa.Text, ComboBoxIdAntr.Text, txtNume.Text, DateTimeDurata.Value)
            DbClasa.UpdateClasa(clasa, txtIdClasa.Text)
            Clear()
        End If
    End Sub
End Class
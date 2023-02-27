Imports System.Security.AccessControl
Imports sdf_bd.SALA_DE_FITNESSDataSetTableAdapters

Public Class AddSala
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(row As DataGridViewRow)
        InitializeComponent()
        Label1.Text = "Modifica"
        btnSalveaza.Text = "Modifica"
        txtIdSala.Text = row.Cells(0).Value.ToString
        txtNume.Text = row.Cells(1).Value.ToString
        txtAdresa.Text = row.Cells(2).Value.ToString
        txtEmail.Text = row.Cells(3).Value.ToString
        txtTelefon.Text = row.Cells(4).Value.ToString
    End Sub

    Public Sub Clear()
        txtIdSala.Text = ""
        txtNume.Text = ""
        txtAdresa.Text = ""
        txtEmail.Text = ""
        txtTelefon.Text = ""
    End Sub
    Private Sub btnSalveaza_Click(sender As Object, e As EventArgs) Handles btnSalveaza.Click
        If (txtIdSala.Text.Trim().Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (txtNume.Text.Trim().Length < 1) Then
            MessageBox.Show("Completati toate campurile.")
            Return
        End If
        If (txtAdresa.Text.Trim().Length < 1) Then
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
            Dim sala As New Sala(txtIdSala.Text.Trim(), txtNume.Text.Trim(), txtAdresa.Text.Trim(), txtEmail.Text.Trim(), txtTelefon.Text.Trim())
            DbSala.AddSala(sala)
            Clear()
        End If
        If (btnSalveaza.Text = "Modifica") Then
            Dim sala As New Sala(txtIdSala.Text.Trim(), txtNume.Text.Trim(), txtAdresa.Text.Trim(), txtEmail.Text.Trim(), txtTelefon.Text.Trim())
            DbSala.UpdateSala(sala, txtIdSala.Text.Trim())
            Clear()
        End If
    End Sub
End Class
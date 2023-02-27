Public Class AddStoc
    Private Sub AddStoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.STOC' table. You can move, or remove it, as needed.
        Me.STOCTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.STOC)
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.SALA' table. You can move, or remove it, as needed.
        Me.SALATableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.SALA)
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.SUPLIMENT' table. You can move, or remove it, as needed.
        Me.SUPLIMENTTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.SUPLIMENT)

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
        ComboBoxSup.Text = row.Cells(0).Value.ToString
        ComboBoxSala.Text = row.Cells(1).Value.ToString
        NumericUpDown1.Value = row.Cells(2).Value
    End Sub

    Public Sub Clear()
        NumericUpDown1.Value = 0
    End Sub

    Private Sub btnSalveaza_Click(sender As Object, e As EventArgs) Handles btnSalveaza.Click
        If (btnSalveaza.Text = "Salveaza") Then
            Dim stoc As New Stoc(ComboBoxSup.Text, ComboBoxSala.Text, NumericUpDown1.Value)
            DbStoc.AddStoc(stoc)
            Clear()
        End If
        If (btnSalveaza.Text = "Modifica") Then
            Dim stoc As New Stoc(ComboBoxSup.Text, ComboBoxSala.Text, NumericUpDown1.Value)
            DbStoc.UpdateStoc(stoc, ComboBoxSup.Text, ComboBoxSala.Text)
            Clear()
        End If
    End Sub
End Class
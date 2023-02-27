Public Class AddProgram
    Private Sub AddProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.CLIENT' table. You can move, or remove it, as needed.
        Me.CLIENTTableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.CLIENT)
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet.CLASA' table. You can move, or remove it, as needed.
        Me.CLASATableAdapter.Fill(Me.SALA_DE_FITNESSDataSet.CLASA)

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
    End Sub

    Private Sub btnSalveaza_Click(sender As Object, e As EventArgs) Handles btnSalveaza.Click
        If (btnSalveaza.Text = "Salveaza") Then
            Dim program As New Program(ComboBoxIdCls.Text, ComboBoxIdClient.Text, DateTimeziora.Value)
            DbProgram.AddProgram(program)
        End If
        If (btnSalveaza.Text = "Modifica") Then
            Dim program As New Program(ComboBoxIdCls.Text, ComboBoxIdClient.Text, DateTimeziora.Value)
            DbProgram.UpdateProgram(program, ComboBoxIdCls.Text, ComboBoxIdClient.Text)
        End If
    End Sub
End Class
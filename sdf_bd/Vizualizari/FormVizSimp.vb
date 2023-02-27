Public Class FormVizSimp
    Private Sub FormVizSimp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet1.V_MENTENANTA' table. You can move, or remove it, as needed.
        Me.V_MENTENANTATableAdapter.Fill(Me.SALA_DE_FITNESSDataSet1.V_MENTENANTA)
        'TODO: This line of code loads data into the 'SALA_DE_FITNESSDataSet1.V_TRANZACTII' table. You can move, or remove it, as needed.


    End Sub
End Class
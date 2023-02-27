Public Class Tranzactie
    Public TIP_ABONAMENT As String
    Public ID_CLIENT As Integer
    Public DATA_INCEPUT As Date

    Public Sub New(tIP_ABONAMENT As String, iD_CLIENT As Integer, dATA_INCEPUT As Date)
        Me.TIP_ABONAMENT = tIP_ABONAMENT
        Me.ID_CLIENT = iD_CLIENT
        Me.DATA_INCEPUT = dATA_INCEPUT
    End Sub
End Class

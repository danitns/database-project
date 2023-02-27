Public Class Client
    Public ID_TRANZACTIE As Integer
    Public NUME As String
    Public PRENUME As String
    Public EMAIL As String
    Public TELEFON As String

    Public Sub New(iD_TRANZACTIE As Integer, nUME As String, pRENUME As String, eMAIL As String, tELEFON As String)
        Me.ID_TRANZACTIE = iD_TRANZACTIE
        Me.NUME = nUME
        Me.PRENUME = pRENUME
        Me.EMAIL = eMAIL
        Me.TELEFON = tELEFON
    End Sub
End Class

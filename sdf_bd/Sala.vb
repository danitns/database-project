Public Class Sala
    Public ID_SALA As String
    Public NUME As String
    Public ADRESA As String
    Public EMAIL As String
    Public TELEFON As String

    Public Sub New(iD_SALA As String, nUME As String, aDRESA As String, eMAIL As String, tELEFON As String)
        Me.ID_SALA = iD_SALA
        Me.NUME = nUME
        Me.ADRESA = aDRESA
        Me.EMAIL = eMAIL
        Me.TELEFON = tELEFON
    End Sub
End Class

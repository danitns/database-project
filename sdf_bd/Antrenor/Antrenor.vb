Public Class Antrenor
    Public ID_SALA As String
    Public NUME As String
    Public PRENUME As String
    Public SALARIU As Integer

    Public Sub New(iD_SALA As String, nUME As String, pRENUME As String, sALARIU As Integer)
        Me.ID_SALA = iD_SALA
        Me.NUME = nUME
        Me.PRENUME = pRENUME
        Me.SALARIU = sALARIU
    End Sub
End Class

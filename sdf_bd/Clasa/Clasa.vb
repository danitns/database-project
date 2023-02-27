Imports Microsoft.VisualBasic.Devices

Public Class Clasa
    Public ID_CLASA As String
    Public ID_ANTRENOR As Integer
    Public NUME As String
    Public DURATA As Date

    Public Sub New(iD_CLASA As String, iD_ANTRENOR As Integer, nUME As String, dURATA As Date)
        Me.ID_CLASA = iD_CLASA
        Me.ID_ANTRENOR = iD_ANTRENOR
        Me.NUME = nUME
        Me.DURATA = dURATA
    End Sub
End Class

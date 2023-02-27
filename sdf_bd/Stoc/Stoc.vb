Public Class Stoc
    Public ID_SUPLIMENT As Integer
    Public ID_SALA As String
    Public CANTITATE As Integer

    Public Sub New(iD_SUPLIMENT As Integer, iD_SALA As String, cANTITATE As Integer)
        Me.ID_SUPLIMENT = iD_SUPLIMENT
        Me.ID_SALA = iD_SALA
        Me.CANTITATE = cANTITATE
    End Sub
End Class

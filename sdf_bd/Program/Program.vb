Public Class Program
    Public ID_CLASA As String
    Public ID_CLIENT As Integer
    Public ZI_ORA As Date

    Public Sub New(iD_CLASA As String, iD_CLIENT As Integer, zI_ORA As Date)
        Me.ID_CLASA = iD_CLASA
        Me.ID_CLIENT = iD_CLIENT
        Me.ZI_ORA = zI_ORA
    End Sub
End Class

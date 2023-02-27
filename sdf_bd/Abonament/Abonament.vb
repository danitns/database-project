Public Class Abonament
    Public TIP_ABONAMENT As String
    Public PRET As Integer
    Public DURATA As Integer
    Public SAUNA As Boolean
    Public SPA As Boolean
    Public PISCINA As Boolean

    Public Sub New(tIP_ABONAMENT As String, pRET As Integer, dURATA As Integer, sAUNA As Boolean, sPA As Boolean, pISCINA As Boolean)
        Me.TIP_ABONAMENT = tIP_ABONAMENT
        Me.PRET = pRET
        Me.DURATA = dURATA
        Me.SAUNA = sAUNA
        Me.SPA = sPA
        Me.PISCINA = pISCINA
    End Sub
End Class

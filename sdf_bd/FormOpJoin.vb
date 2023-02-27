Imports System.Data.SqlClient

Public Class FormOpJoin
    Private Sub DateTabel()
        Dim sql As String = "SELECT C.NUME, C.PRENUME, A.TIP_ABONAMENT, A.DURATA, T.DATA_INCEPUT
        FROM CLIENT C
        JOIN TRANZACTIE T ON C.ID_TRANZACTIE = T.ID_TRANZACTIE
        JOIN ABONAMENT A ON T.TIP_ABONAMENT = A.TIP_ABONAMENT
        WHERE DATEADD(DD, A.DURATA, T.DATA_INCEPUT) > SYSDATETIME() 
        AND A.TIP_ABONAMENT LIKE 'GOLD%'"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql

        Dim adp As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        adp.Fill(tbl)
        DataGridViewJoin.DataSource = tbl
        con.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTabel()
    End Sub
End Class
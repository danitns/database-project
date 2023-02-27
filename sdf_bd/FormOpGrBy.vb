Imports System.Data.SqlClient

Public Class FormOpGrBy
    Private Sub DateTabel()
        Dim sql As String = "SELECT S.ID_SALA, AVG(A.SALARIU) SalMediu
        From SALA S
        Left Join ANTRENOR A ON S.ID_SALA = A.ID_SALA
        GROUP BY S.ID_SALA
        HAVING S.ID_SALA Like 'S6%'"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql

        Dim adp As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        adp.Fill(tbl)
        DataGridViewGrBy.DataSource = tbl
        con.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTabel()
    End Sub
End Class
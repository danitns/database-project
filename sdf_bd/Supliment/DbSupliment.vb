Imports System.Data.SqlClient

Public Class DbSupliment
    Public Shared Sub AddSupliment(supliment As Supliment)
        Dim sql As String = "INSERT INTO SUPLIMENT (BRAND, NUME, PRET) VALUES (@SupBRAND, @SupNUME, @SupPRET)"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@SupBRAND", SqlDbType.VarChar).Value = supliment.BRAND
        cmd.Parameters.Add("@SupNUME", SqlDbType.VarChar).Value = supliment.NUME
        cmd.Parameters.Add("@SupPRET", SqlDbType.Int).Value = supliment.PRET

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost inserat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost inserat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub UpdateSupliment(supliment As Supliment, id As String)
        Dim sql As String = "UPDATE SUPLIMENT SET BRAND=@SupBRAND, NUME=@SupNUME, PRET=@SupPRET WHERE ID_SUPLIMENT=@ID"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@SupBRAND", SqlDbType.VarChar).Value = supliment.BRAND
        cmd.Parameters.Add("@SupNUME", SqlDbType.VarChar).Value = supliment.NUME
        cmd.Parameters.Add("@SupPRET", SqlDbType.Int).Value = supliment.PRET
        cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost modificat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost modificat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub DeleteSupliment(id As String)
        Dim sql As String = "DELETE SUPLIMENT WHERE ID_SUPLIMENT=@ID"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost sters.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost sters..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub Search(text As String, dgv As DataGridView)
        Dim sql As String = "SELECT ID_SUPLIMENT, BRAND, NUME, PRET FROM SUPLIMENT WHERE ID_SUPLIMENT LIKE '%" + text + "%'"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql

        Dim adp As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        adp.Fill(tbl)
        dgv.DataSource = tbl
        con.Close()
    End Sub
End Class

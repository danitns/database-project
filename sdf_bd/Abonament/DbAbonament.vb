Imports System.Data.SqlClient

Public Class DbAbonament
    Public Shared Sub AddAbonament(abonament As Abonament)
        Dim sql As String = "INSERT INTO ABONAMENT VALUES(@TIP, @PRET, @DURATA, @SAUNA, @SPA, @PISCINA)"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@TIP", SqlDbType.VarChar).Value = abonament.TIP_ABONAMENT
        cmd.Parameters.Add("@PRET", SqlDbType.Int).Value = abonament.PRET
        cmd.Parameters.Add("@DURATA", SqlDbType.Int).Value = abonament.DURATA
        cmd.Parameters.Add("@SAUNA", SqlDbType.Bit).Value = abonament.SAUNA
        cmd.Parameters.Add("@SPA", SqlDbType.Bit).Value = abonament.SPA
        cmd.Parameters.Add("@PISCINA", SqlDbType.VarChar).Value = abonament.PISCINA

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost inserat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost inserat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub UpdateAbonament(abonament As Abonament, id As String)
        Dim sql As String = "UPDATE ABONAMENT SET TIP_ABONAMENT=@TIP, PRET=@PRET, DURATA=@DURATA, SAUNA=@SAUNA, SPA=@SPA, PISCINA=@PISCINA WHERE TIP_ABONAMENT=@ID"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@TIP", SqlDbType.VarChar).Value = abonament.TIP_ABONAMENT
        cmd.Parameters.Add("@PRET", SqlDbType.Int).Value = abonament.PRET
        cmd.Parameters.Add("@DURATA", SqlDbType.Int).Value = abonament.DURATA
        cmd.Parameters.Add("@SAUNA", SqlDbType.Bit).Value = abonament.SAUNA
        cmd.Parameters.Add("@SPA", SqlDbType.Bit).Value = abonament.SPA
        cmd.Parameters.Add("@PISCINA", SqlDbType.VarChar).Value = abonament.PISCINA
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

    Public Shared Sub DeleteAbonament(id As String)
        Dim sql As String = "DELETE ABONAMENT WHERE TIP_ABONAMENT=@ID"
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
        Dim sql As String = "SELECT TIP_ABONAMENT, PRET, DURATA, SAUNA, SPA, PISCINA FROM ABONAMENT WHERE TIP_ABONAMENT LIKE '%" + text + "%'"
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

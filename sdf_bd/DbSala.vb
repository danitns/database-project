Imports System.Data.SqlClient

Public Class DbSala
    Public Shared Sub AddSala(sala As Sala)
        Dim sql As String = "INSERT INTO SALA VALUES(@SalaID_SALA, @SalaNUME, @SalaADRESA, @SalaEMAIL, @SalaTELEFON)"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@SalaID_SALA", SqlDbType.VarChar).Value = sala.ID_SALA
        cmd.Parameters.Add("@SalaNUME", SqlDbType.VarChar).Value = sala.NUME
        cmd.Parameters.Add("@SalaADRESA", SqlDbType.VarChar).Value = sala.ADRESA
        cmd.Parameters.Add("@SalaEMAIL", SqlDbType.VarChar).Value = sala.EMAIL
        cmd.Parameters.Add("@SalaTELEFON", SqlDbType.VarChar).Value = sala.TELEFON

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost inserat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost inserat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub UpdateSala(sala As Sala, id As String)
        Dim sql As String = "UPDATE SALA SET ID_SALA=@SalaID_SALA, NUME=@SalaNUME, ADRESA=@SalaADRESA, EMAIL=@SalaEMAIL, TELEFON=@SalaTELEFON WHERE ID_SALA = @ID"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@SalaID_SALA", SqlDbType.VarChar).Value = sala.ID_SALA
        cmd.Parameters.Add("@SalaNUME", SqlDbType.VarChar).Value = sala.NUME
        cmd.Parameters.Add("@SalaADRESA", SqlDbType.VarChar).Value = sala.ADRESA
        cmd.Parameters.Add("@SalaEMAIL", SqlDbType.VarChar).Value = sala.EMAIL
        cmd.Parameters.Add("@SalaTELEFON", SqlDbType.VarChar).Value = sala.TELEFON
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

    Public Shared Sub DeleteSala(id As String)
        Dim sql As String = "DELETE SALA WHERE ID_SALA = @ID"
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
        Dim sql As String = "SELECT ID_SALA, NUME, ADRESA, EMAIL, TELEFON FROM SALA WHERE ID_SALA LIKE '%" + text + "%'"
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

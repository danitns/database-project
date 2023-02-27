Imports System.Data.SqlClient

Public Class DbVizComp
    Public Shared Sub AddAntrenor(antrenor As Antrenor)
        Dim sql As String = "INSERT INTO V_SALA_ANTRENOR (ID_SALA, NUME, PRENUME, SALARIU) VALUES
        (@ID_SALA, @NUME, @PRENUME, @SALARIU)"

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@ID_SALA", SqlDbType.VarChar).Value = antrenor.ID_SALA
        cmd.Parameters.Add("@NUME", SqlDbType.VarChar).Value = antrenor.NUME
        cmd.Parameters.Add("@PRENUME", SqlDbType.VarChar).Value = antrenor.PRENUME
        cmd.Parameters.Add("@SALARIU", SqlDbType.Int).Value = antrenor.SALARIU

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost inserat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost inserat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub UpdateAntrenor(antrenor As Antrenor, id As String)
        Dim sql As String = "UPDATE V_SALA_ANTRENOR SET ID_SALA=@ID_SALA, NUME=@NUME, PRENUME=@PRENUME, SALARIU=@SALARIU
        WHERE ID_ANTRENOR=@ID"

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@ID_SALA", SqlDbType.VarChar).Value = antrenor.ID_SALA
        cmd.Parameters.Add("@NUME", SqlDbType.VarChar).Value = antrenor.NUME
        cmd.Parameters.Add("@PRENUME", SqlDbType.VarChar).Value = antrenor.PRENUME
        cmd.Parameters.Add("@SALARIU", SqlDbType.Int).Value = antrenor.SALARIU
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

    Public Shared Sub DeleteAntrenor(id As String)
        Dim sql As String = "DELETE ANTRENOR WHERE ID_ANTRENOR=@ID"

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
        Dim sql As String = "SELECT * FROM V_SALA_ANTRENOR WHERE NUME LIKE '%" + text + "%'"
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

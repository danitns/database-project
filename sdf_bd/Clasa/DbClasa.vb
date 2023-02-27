Imports System.Data.SqlClient

Public Class DbClasa
    Public Shared Sub AddClasa(clasa As Clasa)
        Dim sql As String = "INSERT INTO CLASA VALUES(@ID_CLASA, @ID_ANTRENOR, @NUME, CAST(@DURATA AS time(0)))"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@ID_CLASA", SqlDbType.VarChar).Value = clasa.ID_CLASA
        cmd.Parameters.Add("@ID_ANTRENOR", SqlDbType.Int).Value = clasa.ID_ANTRENOR
        cmd.Parameters.Add("@NUME", SqlDbType.VarChar).Value = clasa.NUME
        cmd.Parameters.Add("@DURATA", SqlDbType.Time).Value = clasa.DURATA.ToString.Substring(10)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost inserat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost inserat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub UpdateClasa(clasa As Clasa, id As String)
        Dim sql As String = "UPDATE CLASA SET ID_CLASA=@ID_CLASA, ID_ANTRENOR=@ID_ANTRENOR, NUME=@NUME, DURATA=CAST(@DURATA AS time(0)) WHERE ID_CLASA=@ID"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@ID_CLASA", SqlDbType.VarChar).Value = clasa.ID_CLASA
        cmd.Parameters.Add("@ID_ANTRENOR", SqlDbType.Int).Value = clasa.ID_ANTRENOR
        cmd.Parameters.Add("@NUME", SqlDbType.VarChar).Value = clasa.NUME
        cmd.Parameters.Add("@DURATA", SqlDbType.Time).Value = clasa.DURATA.ToString.Substring(10)
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

    Public Shared Sub DeleteClasa(id As String)
        Dim sql As String = "DELETE CLASA WHERE ID_CLASA=@ID"
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
        Dim sql As String = "SELECT ID_CLASA, ID_ANTRENOR, NUME, DURATA FROM CLASA WHERE ID_CLASA LIKE '%" + text + "%'"
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

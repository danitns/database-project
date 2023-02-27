Imports System.Data.SqlClient

Public Class DbProgram
    Public Shared Sub AddProgram(program As Program)
        Dim sql As String = "INSERT INTO PROGRAM VALUES(@ID_CLASA, @ID_CLIENT, CAST(@ZI_ORA AS SMALLDATETIME))"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@ID_CLASA", SqlDbType.VarChar).Value = program.ID_CLASA
        cmd.Parameters.Add("@ID_CLIENT", SqlDbType.VarChar).Value = program.ID_CLIENT
        cmd.Parameters.Add("@ZI_ORA", SqlDbType.SmallDateTime).Value = program.ZI_ORA

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost inserat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost inserat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub UpdateProgram(program As Program, id1 As String, id2 As String)
        Dim sql As String = "UPDATE PROGRAM SET ID_CLASA=@ID_CLASA, ID_CLIENT=@ID_CLIENT, ZI_ORA=CAST(@ZI_ORA AS SMALLDATETIME) WHERE ID_CLASA=@ID1 AND ID_CLIENT=@ID2"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@ID_CLASA", SqlDbType.VarChar).Value = program.ID_CLASA
        cmd.Parameters.Add("@ID_CLIENT", SqlDbType.VarChar).Value = program.ID_CLIENT
        cmd.Parameters.Add("@ZI_ORA", SqlDbType.SmallDateTime).Value = program.ZI_ORA
        cmd.Parameters.Add("@ID1", SqlDbType.VarChar).Value = id1
        cmd.Parameters.Add("@ID2", SqlDbType.VarChar).Value = id2

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost modificat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost modificat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub DeleteProgram(id1 As String, id2 As String)
        Dim sql As String = "DELETE PROGRAM WHERE ID_CLASA=@ID1 AND ID_CLIENT=@ID2"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@ID1", SqlDbType.VarChar).Value = id1
        cmd.Parameters.Add("@ID2", SqlDbType.VarChar).Value = id2

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
        Dim sql As String = "SELECT ID_CLASA, ID_CLIENT, ZI_ORA FROM PROGRAM WHERE ID_CLASA LIKE '%" + text + "%'"
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

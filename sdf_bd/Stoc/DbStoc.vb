Imports System.Data.SqlClient

Public Class DbStoc
    Public Shared Sub AddStoc(stoc As Stoc)
        Dim sql As String = "INSERT INTO STOC VALUES(@StocID_SUPLIMENT, @StocID_SALA, @StocCANTITATE)"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@StocID_SUPLIMENT", SqlDbType.Int).Value = stoc.ID_SUPLIMENT
        cmd.Parameters.Add("@StocID_SALA", SqlDbType.VarChar).Value = stoc.ID_SALA
        cmd.Parameters.Add("@StocCANTITATE", SqlDbType.Int).Value = stoc.CANTITATE

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost inserat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost inserat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub UpdateStoc(stoc As Stoc, id1 As String, id2 As String)
        Dim sql As String = "UPDATE STOC SET 
        ID_SUPLIMENT=@StocID_SUPLIMENT, ID_SALA=@StocID_SALA, CANTITATE=@StocCANTITATE WHERE ID_SUPLIMENT=@ID1 AND ID_SALA=@ID2"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@StocID_SUPLIMENT", SqlDbType.Int).Value = stoc.ID_SUPLIMENT
        cmd.Parameters.Add("@StocID_SALA", SqlDbType.VarChar).Value = stoc.ID_SALA
        cmd.Parameters.Add("@StocCANTITATE", SqlDbType.Int).Value = stoc.CANTITATE
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

    Public Shared Sub DeleteStoc(id1 As String, id2 As String)
        Dim sql As String = "DELETE STOC WHERE ID_SUPLIMENT=@ID1 AND ID_SALA=@ID2"
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
        Dim sql As String = "SELECT ID_SUPLIMENT, ID_SALA, CANTITATE FROM STOC WHERE ID_SUPLIMENT LIKE '%" + text + "%'"
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

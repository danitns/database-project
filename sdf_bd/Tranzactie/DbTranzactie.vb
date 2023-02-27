Imports System.Data.SqlClient

Public Class DbTranzactie
    Public Shared Sub AddTranzactie(tranzactie As Tranzactie)
        Dim sql As String
        If tranzactie.ID_CLIENT = 0 Then
            sql = "INSERT INTO TRANZACTIE(TIP_ABONAMENT, DATA_INCEPUT) VALUES (@TIP, CAST(@DATA_INCEPUT AS DATE))"
        Else
            sql = "INSERT INTO TRANZACTIE(TIP_ABONAMENT, ID_CLIENT, DATA_INCEPUT) VALUES (@TIP, @ID_CLIENT, CAST(@DATA_INCEPUT AS DATE))"
        End If

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        If tranzactie.ID_CLIENT <> 0 Then
            cmd.Parameters.Add("@ID_CLIENT", SqlDbType.VarChar).Value = tranzactie.ID_CLIENT
        End If
        cmd.Parameters.Add("@TIP", SqlDbType.VarChar).Value = tranzactie.TIP_ABONAMENT
        cmd.Parameters.Add("@DATA_INCEPUT", SqlDbType.Date).Value = tranzactie.DATA_INCEPUT.Date.ToString

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost inserat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost inserat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub UpdateTranzactie(tranzactie As Tranzactie, id As String)
        Dim sql As String
        If tranzactie.ID_CLIENT = 0 Then
            sql = "UPDATE TRANZACTIE SET TIP_ABONAMENT=@TIP, ID_CLIENT=NULL, DATA_INCEPUT=CAST(@DATA_INCEPUT AS DATE) WHERE ID_TRANZACTIE=@ID"
        Else
            sql = "UPDATE TRANZACTIE SET TIP_ABONAMENT=@TIP, ID_CLIENT=@ID_CLIENT, DATA_INCEPUT=CAST(@DATA_INCEPUT AS DATE) WHERE ID_TRANZACTIE=@ID"
        End If

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        If tranzactie.ID_CLIENT <> 0 Then
            cmd.Parameters.Add("@ID_CLIENT", SqlDbType.VarChar).Value = tranzactie.ID_CLIENT
        End If
        cmd.Parameters.Add("@TIP", SqlDbType.VarChar).Value = tranzactie.TIP_ABONAMENT
        cmd.Parameters.Add("@DATA_INCEPUT", SqlDbType.Date).Value = tranzactie.DATA_INCEPUT.Date.ToString
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

    Public Shared Sub DeleteTranzactie(id As String)
        Dim sql = "DELETE TRANZACTIE WHERE ID_TRANZACTIE=@ID"

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
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

    Public Shared Sub Search(text As String, dgv As DataGridView)
        Dim sql As String = "SELECT ID_TRANZACTIE, TIP_ABONAMENT, ID_CLIENT, DATA_INCEPUT FROM CLIENT WHERE NUME LIKE '%" + text + "%'"
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

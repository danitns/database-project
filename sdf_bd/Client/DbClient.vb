Imports System.Data.SqlClient

Public Class DbClient
    Public Shared Sub AddClient(client As Client)
        Dim sql As String
        If client.ID_TRANZACTIE = 0 Then
            sql = "INSERT INTO CLIENT(NUME, PRENUME, EMAIL, TELEFON) VALUES(@NUME, @PRENUME, @EMAIL, @TELEFON)"
        Else
            sql = "INSERT INTO CLIENT(ID_TRANZACTIE, NUME, PRENUME, EMAIL, TELEFON) VALUES(@ID, @NUME, @PRENUME, @EMAIL, @TELEFON)"
        End If

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        If client.ID_TRANZACTIE <> 0 Then
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = client.ID_TRANZACTIE
        End If
        cmd.Parameters.Add("@NUME", SqlDbType.VarChar).Value = client.NUME
        cmd.Parameters.Add("@PRENUME", SqlDbType.VarChar).Value = client.PRENUME
        cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = client.EMAIL
        cmd.Parameters.Add("@TELEFON", SqlDbType.VarChar).Value = client.TELEFON

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost inserat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost inserat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub UpdateClient(client As Client, id As String)
        Dim sql As String
        If client.ID_TRANZACTIE = 0 Then
            sql = "UPDATE CLIENT SET ID_TRANZACTIE=NULL, NUME=@NUME, PRENUME=@PRENUME, EMAIL=@EMAIL, TELEFON=@TELEFON WHERE ID_CLIENT=@ID2"
        Else
            sql = "UPDATE CLIENT SET ID_TRANZACTIE=@ID, NUME=@NUME, PRENUME=@PRENUME, EMAIL=@EMAIL, TELEFON=@TELEFON WHERE ID_CLIENT=@ID2"
        End If

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        If client.ID_TRANZACTIE <> 0 Then
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = client.ID_TRANZACTIE
        End If
        cmd.Parameters.Add("@NUME", SqlDbType.VarChar).Value = client.NUME
        cmd.Parameters.Add("@PRENUME", SqlDbType.VarChar).Value = client.PRENUME
        cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = client.EMAIL
        cmd.Parameters.Add("@TELEFON", SqlDbType.VarChar).Value = client.TELEFON
        cmd.Parameters.Add("@ID2", SqlDbType.VarChar).Value = id

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost modificat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost modificat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub DeleteClient(id As String)
        Dim sql As String = "DELETE CLIENT WHERE ID_CLIENT=@ID2"

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@ID2", SqlDbType.VarChar).Value = id

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
        Dim sql As String = "SELECT ID_CLIENT, ID_TRANZACTIE, NUME, PRENUME, EMAIL, TELEFON FROM CLIENT WHERE NUME LIKE '%" + text + "%'"
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

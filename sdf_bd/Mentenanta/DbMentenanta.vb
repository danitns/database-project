Imports System.Data.SqlClient

Public Class DbMentenanta
    Public Shared Sub AddMentenanta(mentenanta As Mentenanta)
        Dim sql As String = "INSERT INTO MENTENANTA (ID_SALA, NUME, PRENUME, SALARIU, OCUPATIE)
        VALUES(@MentenantaID_SALA, @MentenantaNUME, @MentenantaPRENUME, @MentenantaSALARIU, @MentenantaOCUPATIE)"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@MentenantaID_SALA", SqlDbType.VarChar).Value = mentenanta.ID_SALA
        cmd.Parameters.Add("@MentenantaNUME", SqlDbType.VarChar).Value = mentenanta.NUME
        cmd.Parameters.Add("@MentenantaPRENUME", SqlDbType.VarChar).Value = mentenanta.PRENUME
        cmd.Parameters.Add("@MentenantaSALARIU", SqlDbType.Int).Value = mentenanta.SALARIU
        cmd.Parameters.Add("@MentenantaOCUPATIE", SqlDbType.VarChar).Value = mentenanta.OCUPATIE

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost inserat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost inserat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub UpdateMentenanta(mentenanta As Mentenanta, id As Integer)
        Dim sql As String = "UPDATE MENTENANTA SET ID_SALA=@MentenantaID_SALA,
        NUME=@MentenantaNUME, PRENUME=@MentenantaPRENUME, SALARIU=@MentenantaSALARIU, OCUPATIE=@MentenantaOCUPATIE WHERE ID_ANGAJAT=@ID"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@MentenantaID_SALA", SqlDbType.VarChar).Value = mentenanta.ID_SALA
        cmd.Parameters.Add("@MentenantaNUME", SqlDbType.VarChar).Value = mentenanta.NUME
        cmd.Parameters.Add("@MentenantaPRENUME", SqlDbType.VarChar).Value = mentenanta.PRENUME
        cmd.Parameters.Add("@MentenantaSALARIU", SqlDbType.Int).Value = mentenanta.SALARIU
        cmd.Parameters.Add("@MentenantaOCUPATIE", SqlDbType.VarChar).Value = mentenanta.OCUPATIE
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Elementul a fost modificat.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Elementul nu a fost modificat..." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Sub DeleteMentenanta(id As Integer)
        Dim sql As String = "DELETE MENTENANTA WHERE ID_ANGAJAT=@ID"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = Configuration.ConfigurationManager.ConnectionStrings("sdf_bd.My.MySettings.SALA_DE_FITNESSConnectionString").ToString()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id

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
        Dim sql As String = "SELECT ID_ANGAJAT, ID_SALA, NUME, PRENUME, SALARIU, OCUPATIE FROM MENTENANTA WHERE ID_ANGAJAT LIKE '%" + text + "%'"
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

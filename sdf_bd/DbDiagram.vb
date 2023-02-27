Public Class DbDiagram
    Private Sub btnSala_Click(sender As Object, e As EventArgs) Handles btnSala.Click
        Try
            Dim formSala As New FormSala
            formSala.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try

    End Sub

    Private Sub btnMentenanta_Click(sender As Object, e As EventArgs) Handles btnMentenanta.Click
        Try
            Dim formMentenanta As New FormMentenanta
            formMentenanta.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try

    End Sub

    Private Sub btnSupliment_Click(sender As Object, e As EventArgs) Handles btnSupliment.Click
        Try
            Dim formSupliment As New FormSupliment
            formSupliment.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try

    End Sub

    Private Sub btnStoc_Click(sender As Object, e As EventArgs) Handles btnStoc.Click
        Try
            Dim formStoc As New FormStoc
            formStoc.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try

    End Sub

    Private Sub btnAntrenor_Click(sender As Object, e As EventArgs) Handles btnAntrenor.Click
        Try
            Dim formAntrenor As New FormAntrenor
            formAntrenor.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try
    End Sub

    Private Sub btnClasa_Click(sender As Object, e As EventArgs) Handles btnClasa.Click
        Try
            Dim formClasa As New FormClasa
            formClasa.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try
    End Sub

    Private Sub btnAbonament_Click(sender As Object, e As EventArgs) Handles btnAbonament.Click
        Try
            Dim formAbonament As New FormAbonament
            formAbonament.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try
    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        Try
            Dim formClient As New FormClient
            formClient.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try
    End Sub

    Private Sub btnTranzactie_Click(sender As Object, e As EventArgs) Handles btnTranzactie.Click
        Try
            Dim formTranzactie As New FormTranzactie
            formTranzactie.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try
    End Sub

    Private Sub btnProgram_Click(sender As Object, e As EventArgs) Handles btnProgram.Click
        Try
            Dim formProgram As New FormProgram
            formProgram.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try
    End Sub

    Private Sub btnOpJoin_Click(sender As Object, e As EventArgs) Handles btnOpJoin.Click
        Try
            Dim formOpJoing As New FormOpJoin
            formOpJoing.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try
    End Sub

    Private Sub btnOpGrBy_Click(sender As Object, e As EventArgs) Handles btnOpGrBy.Click
        Try
            Dim formOpGrBy As New FormOpGrBy
            formOpGrBy.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try
    End Sub

    Private Sub vizSimpl_Click(sender As Object, e As EventArgs) Handles vizSimpl.Click
        Try
            Dim formVizSimp As New FormVizSimp
            formVizSimp.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try
    End Sub

    Private Sub vizComp_Click(sender As Object, e As EventArgs) Handles vizComp.Click
        Try
            Dim formVizComp As New FormVizComp
            formVizComp.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Datele se actualizeaza")
        End Try
    End Sub
End Class

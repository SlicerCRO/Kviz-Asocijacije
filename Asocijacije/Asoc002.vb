Imports System.Data.SqlClient
Public Class Asoc002


    Private Sub Unesi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unesi.Click
        Dim tr As SqlTransaction
        Dim veza As New SqlConnection(My.Settings.veza)
        veza.Open()
        tr = veza.BeginTransaction

        Dim komanda As SqlCommand


        komanda = New SqlCommand("insert into Tablice (brojTablice, A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4, D1, D2, D3, D4, stupacA, stupacB, stupacC, stupacD, konacnoRjesenje, iskoristena) " & _
                                 " values (@brojTablice, @A1 , @A2, @A3, @A4, @B1, @B2, @B3, @B4, @C1, @C2, @C3, @C4, @D1, @D2, @D3, @D4, @stupacA, @stupacB, @stupacC, @stupacD, @konacnoRjesenje, @iskoristena)", veza, tr)
        komanda.Parameters.Add("@brojTablice", SqlDbType.Int).Value = 2
        komanda.Parameters.Add("@A1", SqlDbType.NVarChar, 100).Value = Me.A1.Text
        komanda.Parameters.Add("@A2", SqlDbType.NVarChar, 100).Value = Me.A2.Text
        komanda.Parameters.Add("@A3", SqlDbType.NVarChar, 100).Value = Me.A3.Text
        komanda.Parameters.Add("@A4", SqlDbType.NVarChar, 100).Value = Me.A4.Text
        komanda.Parameters.Add("@B1", SqlDbType.NVarChar, 100).Value = Me.B1.Text
        komanda.Parameters.Add("@B2", SqlDbType.NVarChar, 100).Value = Me.B2.Text
        komanda.Parameters.Add("@B3", SqlDbType.NVarChar, 100).Value = Me.B3.Text
        komanda.Parameters.Add("@B4", SqlDbType.NVarChar, 100).Value = Me.B4.Text
        komanda.Parameters.Add("@C1", SqlDbType.NVarChar, 100).Value = Me.C1.Text
        komanda.Parameters.Add("@C2", SqlDbType.NVarChar, 100).Value = Me.C2.Text
        komanda.Parameters.Add("@C3", SqlDbType.NVarChar, 100).Value = Me.C3.Text
        komanda.Parameters.Add("@C4", SqlDbType.NVarChar, 100).Value = Me.C4.Text
        komanda.Parameters.Add("@D1", SqlDbType.NVarChar, 100).Value = Me.D1.Text
        komanda.Parameters.Add("@D2", SqlDbType.NVarChar, 100).Value = Me.D2.Text
        komanda.Parameters.Add("@D3", SqlDbType.NVarChar, 100).Value = Me.D3.Text
        komanda.Parameters.Add("@D4", SqlDbType.NVarChar, 100).Value = Me.D4.Text
        komanda.Parameters.Add("@stupacA", SqlDbType.NVarChar, 30).Value = Me.SA.Text
        komanda.Parameters.Add("@stupacB", SqlDbType.NVarChar, 30).Value = Me.SB.Text
        komanda.Parameters.Add("@stupacC", SqlDbType.NVarChar, 30).Value = Me.SC.Text
        komanda.Parameters.Add("@stupacD", SqlDbType.NVarChar, 30).Value = Me.SD.Text
        komanda.Parameters.Add("@konacnoRjesenje", SqlDbType.NVarChar, 100).Value = Me.KON.Text
        komanda.Parameters.Add("@iskoristena", SqlDbType.NVarChar, 100).Value = 0

        komanda.ExecuteNonQuery()

        tr.Commit()
        veza.Close()

        MessageBox.Show("Tablica je unesena")
        Me.Show()
        Me.Close()
    End Sub

    Private Sub Provjeri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Provjeri.Click
        Dim veza As New SqlConnection(My.Settings.veza)
        Dim komanda As New SqlCommand("select A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4, D1, D2, D3, D4, stupacA as 'SA', stupacB as 'SB', stupacC as 'SC', stupacD as 'SD', konacnoRjesenje as 'KON' from Tablice where brojTablice=2", veza)
        veza.Open()
        Dim rs As SqlDataReader = komanda.ExecuteReader

        While rs.Read
            Me.A1.Text = rs.Item("A1")
            Me.A2.Text = rs.Item("A2")
            Me.A3.Text = rs.Item("A3")
            Me.A4.Text = rs.Item("A4")
            Me.B1.Text = rs.Item("B1")
            Me.B2.Text = rs.Item("B2")
            Me.B3.Text = rs.Item("B3")
            Me.B4.Text = rs.Item("B4")
            Me.C1.Text = rs.Item("C1")
            Me.C2.Text = rs.Item("C2")
            Me.C3.Text = rs.Item("C3")
            Me.C4.Text = rs.Item("C4")
            Me.D1.Text = rs.Item("D1")
            Me.D2.Text = rs.Item("D2")
            Me.D3.Text = rs.Item("D3")
            Me.D4.Text = rs.Item("D4")
            Me.SA.Text = rs.Item("SA")
            Me.SB.Text = rs.Item("SB")
            Me.SC.Text = rs.Item("SC")
            Me.SD.Text = rs.Item("SD")
            Me.KON.Text = rs.Item("KON")
        End While


        'Dim tr As SqlTransaction
        'tr = veza.BeginTransaction
        'tr.Commit()
        veza.Close()


    End Sub

End Class


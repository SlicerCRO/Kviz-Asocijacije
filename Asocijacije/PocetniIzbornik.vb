Public Class PocetniIzbornik

    Private Sub Label1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Navy
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Izlaz.MouseEnter
        Izlaz.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Navy
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Izlaz.MouseLeave
        Izlaz.ForeColor = Color.Navy
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Dim LjN As New LjestvicaNajboljih
        LjN.MdiParent = Me
        LjN.Show()
        Label1.Hide()
        Label2.Hide()
        Izlaz.Hide()
        Naslov.Hide()
        GroupBox1.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Bodovanje.AsocBroj = 0
        Dim f7 As New Form7
        f7.MdiParent = Me
        f7.Show()
        Label1.Hide()
        Label2.Hide()
        Izlaz.Hide()
        Naslov.Hide()
        GroupBox1.Hide()
    End Sub

    Private Sub Izlaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Izlaz.Click
        Me.Close()
    End Sub

    Private Sub Label4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.DarkRed
    End Sub

    Private Sub Label4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Navy
    End Sub

    Private Sub UnosTablice_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnosTablice.MouseEnter
        UnosTablice.ForeColor = Color.DarkRed
    End Sub

    Private Sub UnosTablice_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnosTablice.MouseLeave
        UnosTablice.ForeColor = Color.Navy
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim PDN As New PromjenaDetaljaNatjecatelja
        PDN.MdiParent = Me
        PDN.Show()
        Label1.Hide()
        Label2.Hide()
        Izlaz.Hide()
        Naslov.Hide()
        GroupBox1.Hide()
    End Sub

    Private Sub UnosTablice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnosTablice.Click
        Dim unostab As New Asoc003
        unostab.MdiParent = Me
        unostab.Show()
        Label1.Hide()
        Label2.Hide()
        Izlaz.Hide()
        Naslov.Hide()
        GroupBox1.Hide()
    End Sub

    Private Sub IzlazToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IzlazToolStripMenuItem1.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("Jeste li sigurni da želite izići iz programa?", "Potvrdite izlaz", _
                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If Result = System.Windows.Forms.DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub PocetniIzbornik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class
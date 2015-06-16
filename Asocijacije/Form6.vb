Imports Asocijacije.Form1
Public Class Form6
    'Dim f1 As New Form1

    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        Dim odg As String
        odg = Me.TextBox1.Text
        If e.KeyCode = Keys.Enter Then
            If Me.TextBox1.Text Like Asoc1.KON.Text Then
                T.KON.BackColor = Color.Red
                T.KON.Text = Asoc1.KON.Text
                T.KON_Change()
            Else
                provdalj = False
                'dalj()
            End If
            Me.Hide()
            'f1.x1()
        End If
    End Sub

    Private Sub Odustani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Odustani.Click
        rjesava = True
        Me.Hide()
    End Sub
End Class
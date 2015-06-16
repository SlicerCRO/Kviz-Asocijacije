
Public Class Form8

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim F1 As New Form1
        If Bodovanje.AsocBroj <> 4 Then
            F1.Show()
            Bodovanje.AsocBroj = Bodovanje.AsocBroj + 1
        End If
        Me.Close()
    End Sub

End Class
﻿Imports Asocijacije.Form1
Public Class Form4
    'Dim f1 As New Form1


    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        Dim odg As String
        odg = Me.TextBox1.Text
        If e.KeyCode = Keys.Enter Then
            If Me.TextBox1.Text Like Asoc1.SC.Text Then
                T.SC.BackColor = Color.Green
                T.SC.Text = Asoc1.SC.Text
                T.SC_Change()
            Else
                provdalj = False
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
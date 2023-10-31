Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nom As String
        Dim pw As String
        nom = txt_nom.Text
        pw = txt_pw.Text
        If nom = "admin" And pw = "1234" Then
            Me.Hide()
            frm_gestion.Show()
        Else
            MsgBox("Accès refusé", MessageBoxIcon.Error)
            txt_nom.Clear()
            txt_pw.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_nom.Clear()
        txt_pw.Clear()
    End Sub
End Class

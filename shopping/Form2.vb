Public Class frm_gestion
    Private Sub cmb_produit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_produit.SelectedIndexChanged
        If cmb_produit.Text = "clavier" Then
            txt_prixU.Text = "30"
        End If
        If cmb_produit.Text = "ordinateur" Then
            txt_prixU.Text = "1000"
        End If
        If cmb_produit.Text = "imprimante" Then
            txt_prixU.Text = "500"
        End If
        If cmb_produit.Text = "souris" Then
            txt_prixU.Text = "15"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim q As String
        Dim p As Single
        Dim i As Integer
        Dim ch As String
        If cmb_produit.SelectedIndex = -1 Then
            MsgBox("produit obligatoire", MessageBoxIcon.Error)
            txt_prixU.Clear()
            num_quantite.Value = 0
            txt_HT.Clear()
        Else
            q = num_quantite.Value
            p = txt_prixU.Text
            If q <= 0 Then
                MsgBox("quantite doit etre > 0", MessageBoxIcon.Error)

            Else
                ch = (p * q).ToString()
                lst_MHT.Items.Add(ch)
                ch = cmb_produit.SelectedItem
                lst_produit.Items.Add(ch)
                ch = q.ToString()
                lst_Quantite.Items.Add(ch)
                ch = p.ToString()
                i = lst_produit.Items.Count
                lst_numprod.Items.Add(i.ToString())
                lst_prixU.Items.Add(ch)
                num_quantite.Value = 0
                txt_prixU.Clear()
                cmb_produit.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub calcul()
        Dim total As Single
        Dim tva As Single
        Dim remise As Single
        For Each Str As String In lst_Quantite.Items
            total = total + CInt(Str)
        Next
        txt_totalq.Text = total
        total = 0
        For Each Str As String In lst_prixU.Items
            total = total + CInt(Str)
        Next
        txt_totalp.Text = total
        total = 0
        For Each Str As String In lst_MHT.Items
            total = total + CInt(Str)
        Next
        txt_totalmht.Text = total
        tva = total + (total * (20 / 100))
        txt_tva.Text = tva
        remise = tva
        If total > 1000 Then
            remise = tva - (total * (1 / 100))
        End If
        txt_remise.Text = remise
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_calculer.Click
        calcul()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        End
    End Sub
    Private Sub btn_sup_Click(sender As Object, e As EventArgs) Handles btn_sup.Click
        Dim x As Integer
        Dim y As Integer
        If num_sup.Value = 0 Then
            MsgBox("merci de selectionne un num du produit pour supprimer", MessageBoxIcon.Error)
        Else
            x = num_sup.Value
            y = lst_produit.Items.Count
            If x > y Then
                MsgBox("il y a " & y & " produit", MessageBoxIcon.Error)
            Else
                x = x - 1
                lst_produit.Items.RemoveAt(x)
                lst_Quantite.Items.RemoveAt(x)
                lst_MHT.Items.RemoveAt(x)
                lst_prixU.Items.RemoveAt(x)
                If x + 1 = lst_produit.Items.Count + 1 Then
                    lst_numprod.Items.RemoveAt(x)
                Else
                    lst_numprod.Items.RemoveAt(x)
                    Do
                        lst_numprod.Items(x) = lst_numprod.Items(x) - 1
                        x = x + 1
                    Loop Until x = lst_produit.Items.Count
                End If
                num_sup.Value = 0
                If txt_remise.Text <> "" Then
                    calcul()
                End If
            End If
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        Dim x As Integer
        Dim q As String
        Dim y As Integer
        If num_mod.Value = 0 Then
            MsgBox("merci de selectionne un num de produit pour modifier", MessageBoxIcon.Error)
        Else
            x = num_mod.Value
            y = lst_produit.Items.Count
            If x > y Then
                MsgBox("il y a " & y & " produit", MessageBoxIcon.Error)
            Else
                If cmb_produit.SelectedIndex <> -1 Then
                    MsgBox("seule la quantité du produit est modifiable", MessageBoxIcon.Error)
                    cmb_produit.SelectedIndex = -1
                    txt_prixU.Clear()
                    num_quantite.Value = 0
                    txt_HT.Clear()
                Else
                    q = num_quantite.Value
                    If q <= 0 Then
                        MsgBox("quantite doit etre > 0", MessageBoxIcon.Error)
                    Else
                        x = x - 1
                        lst_Quantite.Items.RemoveAt(x)
                        lst_MHT.Items(x) = lst_prixU.Items(x) * q
                        lst_Quantite.Items.Insert(x, num_quantite.Value)
                        num_mod.Value = 0
                        num_quantite.Value = 0
                        txt_prixU.Clear()
                        cmb_produit.SelectedIndex = -1
                        If txt_remise.Text <> "" Then
                            calcul()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub num_quantite_ValueChanged(sender As Object, e As EventArgs) Handles num_quantite.ValueChanged
        Dim q As String
        Dim p As Single
        If txt_prixU.Text <> "" Then
            q = num_quantite.Value
            p = txt_prixU.Text
            txt_HT.Text = p * q
        End If
    End Sub
End Class
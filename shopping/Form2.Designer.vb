<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_ajout = New System.Windows.Forms.Button()
        Me.btn_calculer = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.btn_sup = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.txt_prixU = New System.Windows.Forms.TextBox()
        Me.txt_HT = New System.Windows.Forms.TextBox()
        Me.txt_remise = New System.Windows.Forms.TextBox()
        Me.txt_totalmht = New System.Windows.Forms.TextBox()
        Me.txt_totalq = New System.Windows.Forms.TextBox()
        Me.txt_tva = New System.Windows.Forms.TextBox()
        Me.txt_totalp = New System.Windows.Forms.TextBox()
        Me.cmb_produit = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lst_produit = New System.Windows.Forms.ListBox()
        Me.lst_prixU = New System.Windows.Forms.ListBox()
        Me.lst_Quantite = New System.Windows.Forms.ListBox()
        Me.lst_MHT = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.num_quantite = New System.Windows.Forms.NumericUpDown()
        Me.num_mod = New System.Windows.Forms.NumericUpDown()
        Me.num_sup = New System.Windows.Forms.NumericUpDown()
        Me.lst_numprod = New System.Windows.Forms.ListBox()
        CType(Me.num_quantite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_mod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_sup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ajout
        '
        Me.btn_ajout.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajout.Location = New System.Drawing.Point(535, 15)
        Me.btn_ajout.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(123, 44)
        Me.btn_ajout.TabIndex = 0
        Me.btn_ajout.Text = "Ajouter"
        Me.btn_ajout.UseVisualStyleBackColor = False
        '
        'btn_calculer
        '
        Me.btn_calculer.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_calculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculer.Location = New System.Drawing.Point(933, 250)
        Me.btn_calculer.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_calculer.Name = "btn_calculer"
        Me.btn_calculer.Size = New System.Drawing.Size(120, 50)
        Me.btn_calculer.TabIndex = 1
        Me.btn_calculer.Text = "Calculer"
        Me.btn_calculer.UseVisualStyleBackColor = False
        '
        'btn_quitter
        '
        Me.btn_quitter.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitter.Location = New System.Drawing.Point(933, 329)
        Me.btn_quitter.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(120, 48)
        Me.btn_quitter.TabIndex = 2
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = False
        '
        'btn_sup
        '
        Me.btn_sup.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_sup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sup.Location = New System.Drawing.Point(535, 62)
        Me.btn_sup.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sup.Name = "btn_sup"
        Me.btn_sup.Size = New System.Drawing.Size(123, 50)
        Me.btn_sup.TabIndex = 3
        Me.btn_sup.Text = "Supprimer"
        Me.btn_sup.UseVisualStyleBackColor = False
        '
        'btn_mod
        '
        Me.btn_mod.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod.Location = New System.Drawing.Point(535, 118)
        Me.btn_mod.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(123, 44)
        Me.btn_mod.TabIndex = 4
        Me.btn_mod.Text = "Modifier"
        Me.btn_mod.UseVisualStyleBackColor = False
        '
        'txt_prixU
        '
        Me.txt_prixU.BackColor = System.Drawing.Color.YellowGreen
        Me.txt_prixU.Enabled = False
        Me.txt_prixU.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prixU.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_prixU.Location = New System.Drawing.Point(205, 56)
        Me.txt_prixU.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_prixU.Name = "txt_prixU"
        Me.txt_prixU.Size = New System.Drawing.Size(165, 27)
        Me.txt_prixU.TabIndex = 5
        '
        'txt_HT
        '
        Me.txt_HT.BackColor = System.Drawing.Color.YellowGreen
        Me.txt_HT.Enabled = False
        Me.txt_HT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_HT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_HT.Location = New System.Drawing.Point(205, 129)
        Me.txt_HT.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_HT.Name = "txt_HT"
        Me.txt_HT.Size = New System.Drawing.Size(165, 27)
        Me.txt_HT.TabIndex = 6
        '
        'txt_remise
        '
        Me.txt_remise.BackColor = System.Drawing.Color.YellowGreen
        Me.txt_remise.Enabled = False
        Me.txt_remise.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remise.Location = New System.Drawing.Point(489, 520)
        Me.txt_remise.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_remise.Name = "txt_remise"
        Me.txt_remise.Size = New System.Drawing.Size(395, 27)
        Me.txt_remise.TabIndex = 7
        '
        'txt_totalmht
        '
        Me.txt_totalmht.BackColor = System.Drawing.Color.YellowGreen
        Me.txt_totalmht.Enabled = False
        Me.txt_totalmht.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalmht.Location = New System.Drawing.Point(721, 413)
        Me.txt_totalmht.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_totalmht.Name = "txt_totalmht"
        Me.txt_totalmht.Size = New System.Drawing.Size(163, 27)
        Me.txt_totalmht.TabIndex = 8
        '
        'txt_totalq
        '
        Me.txt_totalq.BackColor = System.Drawing.Color.YellowGreen
        Me.txt_totalq.Enabled = False
        Me.txt_totalq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalq.Location = New System.Drawing.Point(505, 413)
        Me.txt_totalq.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_totalq.Name = "txt_totalq"
        Me.txt_totalq.Size = New System.Drawing.Size(163, 27)
        Me.txt_totalq.TabIndex = 9
        '
        'txt_tva
        '
        Me.txt_tva.BackColor = System.Drawing.Color.YellowGreen
        Me.txt_tva.Enabled = False
        Me.txt_tva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tva.Location = New System.Drawing.Point(489, 474)
        Me.txt_tva.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tva.Name = "txt_tva"
        Me.txt_tva.Size = New System.Drawing.Size(395, 27)
        Me.txt_tva.TabIndex = 10
        '
        'txt_totalp
        '
        Me.txt_totalp.BackColor = System.Drawing.Color.YellowGreen
        Me.txt_totalp.Enabled = False
        Me.txt_totalp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalp.Location = New System.Drawing.Point(283, 413)
        Me.txt_totalp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_totalp.Name = "txt_totalp"
        Me.txt_totalp.Size = New System.Drawing.Size(163, 27)
        Me.txt_totalp.TabIndex = 11
        '
        'cmb_produit
        '
        Me.cmb_produit.BackColor = System.Drawing.Color.YellowGreen
        Me.cmb_produit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_produit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmb_produit.FormattingEnabled = True
        Me.cmb_produit.Items.AddRange(New Object() {"clavier", "souris", "imprimante", "ordinateur"})
        Me.cmb_produit.Location = New System.Drawing.Point(205, 15)
        Me.cmb_produit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_produit.Name = "cmb_produit"
        Me.cmb_produit.Size = New System.Drawing.Size(165, 28)
        Me.cmb_produit.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Produit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Prix Unitaire"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Info
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Quantité"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Info
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Montant HT"
        '
        'lst_produit
        '
        Me.lst_produit.BackColor = System.Drawing.Color.YellowGreen
        Me.lst_produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_produit.FormattingEnabled = True
        Me.lst_produit.ItemHeight = 20
        Me.lst_produit.Location = New System.Drawing.Point(75, 221)
        Me.lst_produit.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_produit.Name = "lst_produit"
        Me.lst_produit.Size = New System.Drawing.Size(163, 184)
        Me.lst_produit.TabIndex = 18
        '
        'lst_prixU
        '
        Me.lst_prixU.BackColor = System.Drawing.Color.YellowGreen
        Me.lst_prixU.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_prixU.FormattingEnabled = True
        Me.lst_prixU.ItemHeight = 20
        Me.lst_prixU.Location = New System.Drawing.Point(283, 221)
        Me.lst_prixU.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_prixU.Name = "lst_prixU"
        Me.lst_prixU.Size = New System.Drawing.Size(163, 184)
        Me.lst_prixU.TabIndex = 19
        '
        'lst_Quantite
        '
        Me.lst_Quantite.BackColor = System.Drawing.Color.YellowGreen
        Me.lst_Quantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Quantite.FormattingEnabled = True
        Me.lst_Quantite.ItemHeight = 20
        Me.lst_Quantite.Location = New System.Drawing.Point(505, 221)
        Me.lst_Quantite.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_Quantite.Name = "lst_Quantite"
        Me.lst_Quantite.Size = New System.Drawing.Size(163, 184)
        Me.lst_Quantite.TabIndex = 20
        '
        'lst_MHT
        '
        Me.lst_MHT.BackColor = System.Drawing.Color.YellowGreen
        Me.lst_MHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_MHT.FormattingEnabled = True
        Me.lst_MHT.ItemHeight = 20
        Me.lst_MHT.Location = New System.Drawing.Point(721, 216)
        Me.lst_MHT.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_MHT.Name = "lst_MHT"
        Me.lst_MHT.Size = New System.Drawing.Size(163, 184)
        Me.lst_MHT.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Info
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 192)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Produit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Info
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(501, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Quantité"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Info
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 192)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Prix Unitaire"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Info
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(717, 192)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Montant HT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Info
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(257, 478)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "TVA(20%)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Info
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(120, 420)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Info
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(257, 524)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Remise"
        '
        'num_quantite
        '
        Me.num_quantite.BackColor = System.Drawing.Color.YellowGreen
        Me.num_quantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_quantite.ForeColor = System.Drawing.SystemColors.WindowText
        Me.num_quantite.Location = New System.Drawing.Point(205, 94)
        Me.num_quantite.Margin = New System.Windows.Forms.Padding(4)
        Me.num_quantite.Name = "num_quantite"
        Me.num_quantite.Size = New System.Drawing.Size(165, 27)
        Me.num_quantite.TabIndex = 34
        '
        'num_mod
        '
        Me.num_mod.BackColor = System.Drawing.Color.YellowGreen
        Me.num_mod.ForeColor = System.Drawing.SystemColors.WindowText
        Me.num_mod.Location = New System.Drawing.Point(666, 128)
        Me.num_mod.Margin = New System.Windows.Forms.Padding(4)
        Me.num_mod.Name = "num_mod"
        Me.num_mod.Size = New System.Drawing.Size(165, 27)
        Me.num_mod.TabIndex = 35
        '
        'num_sup
        '
        Me.num_sup.BackColor = System.Drawing.Color.YellowGreen
        Me.num_sup.ForeColor = System.Drawing.SystemColors.WindowText
        Me.num_sup.Location = New System.Drawing.Point(666, 75)
        Me.num_sup.Margin = New System.Windows.Forms.Padding(4)
        Me.num_sup.Name = "num_sup"
        Me.num_sup.Size = New System.Drawing.Size(165, 27)
        Me.num_sup.TabIndex = 36
        '
        'lst_numprod
        '
        Me.lst_numprod.BackColor = System.Drawing.Color.YellowGreen
        Me.lst_numprod.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lst_numprod.FormattingEnabled = True
        Me.lst_numprod.ItemHeight = 20
        Me.lst_numprod.Location = New System.Drawing.Point(21, 221)
        Me.lst_numprod.Name = "lst_numprod"
        Me.lst_numprod.Size = New System.Drawing.Size(30, 184)
        Me.lst_numprod.TabIndex = 37
        '
        'frm_gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1100, 562)
        Me.Controls.Add(Me.lst_numprod)
        Me.Controls.Add(Me.num_sup)
        Me.Controls.Add(Me.num_mod)
        Me.Controls.Add(Me.num_quantite)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lst_MHT)
        Me.Controls.Add(Me.lst_Quantite)
        Me.Controls.Add(Me.lst_prixU)
        Me.Controls.Add(Me.lst_produit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_produit)
        Me.Controls.Add(Me.txt_totalp)
        Me.Controls.Add(Me.txt_tva)
        Me.Controls.Add(Me.txt_totalq)
        Me.Controls.Add(Me.txt_totalmht)
        Me.Controls.Add(Me.txt_remise)
        Me.Controls.Add(Me.txt_HT)
        Me.Controls.Add(Me.txt_prixU)
        Me.Controls.Add(Me.btn_mod)
        Me.Controls.Add(Me.btn_sup)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.btn_calculer)
        Me.Controls.Add(Me.btn_ajout)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_gestion"
        Me.Text = "te"
        CType(Me.num_quantite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_mod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_sup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_calculer As Button
    Friend WithEvents btn_quitter As Button
    Friend WithEvents btn_sup As Button
    Friend WithEvents btn_mod As Button
    Friend WithEvents txt_prixU As TextBox
    Friend WithEvents txt_HT As TextBox
    Friend WithEvents txt_remise As TextBox
    Friend WithEvents txt_totalmht As TextBox
    Friend WithEvents txt_totalq As TextBox
    Friend WithEvents txt_tva As TextBox
    Friend WithEvents txt_totalp As TextBox
    Friend WithEvents cmb_produit As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lst_produit As ListBox
    Friend WithEvents lst_prixU As ListBox
    Friend WithEvents lst_Quantite As ListBox
    Friend WithEvents lst_MHT As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents num_quantite As NumericUpDown
    Friend WithEvents num_mod As NumericUpDown
    Friend WithEvents num_sup As NumericUpDown
    Friend WithEvents lst_numprod As ListBox
End Class

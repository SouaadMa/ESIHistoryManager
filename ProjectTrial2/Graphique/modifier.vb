﻿Imports System.Text.RegularExpressions
Public Class modifier

    Public worning_format As Boolean
    Dim esistselect As Etudiant ' letudiant selection f affichresult
    Private ArabicInput As InputLanguage
    Private LatinInput As InputLanguage

    Public Sub New(ByVal e As Etudiant)

        ' This call is required by the designer.
        InitializeComponent()
        esistselect = e
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub modifier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'initialisation generale
        Worning.Visible = False
        BT_GENERALINFO.Checked = True
        CompletLabel.Visible = False

        ' Set the default as the current Inputlanguage
        ArabicInput = InputLanguage.CurrentInputLanguage
        LatinInput = InputLanguage.CurrentInputLanguage
        'Iterate to find the available Arabic and latin Keyboards
        Dim count As Integer = InputLanguage.InstalledInputLanguages.Count
        For j As Integer = 0 To (count - 1)
            If InputLanguage.InstalledInputLanguages(j).LayoutName.Contains("Arabic") = True Then
                'Found an Arabic Keyboard
                ArabicInput = InputLanguage.InstalledInputLanguages(j)
            Else
                If InputLanguage.InstalledInputLanguages(j).LayoutName.Contains("French") Or InputLanguage.InstalledInputLanguages(j).LayoutName.Contains("English") = True Then
                    'Found an latin Keyboard
                    LatinInput = InputLanguage.InstalledInputLanguages(j)
                End If
            End If
        Next j

        'initialiser les criteres de laffichage avant modification

        'initialiser :

        'inisialiser les wilayas combobox


        Me.CB_WILAYA.DisplayMember = Login.Infosgenerale.wilayaactuelle.Columns(0).ToString
        Me.CB_WILAYAN.DisplayMember = Login.Infosgenerale.codewilayaN.Columns(0).ToString
        Me.CB_WILAYANA.DisplayMember = Login.Infosgenerale.wilayaNaissanceArabe.Columns(0).ToString


        Me.CB_WILAYA.ValueMember = Login.Infosgenerale.wilayaactuelle.Columns(0).ToString
        Me.CB_WILAYAN.ValueMember = Login.Infosgenerale.codewilayaN.Columns(0).ToString
        Me.CB_WILAYANA.ValueMember = Login.Infosgenerale.wilayaNaissanceArabe.Columns(0).ToString


        Me.CB_WILAYA.DataSource = Login.Infosgenerale.wilayaactuelle
        Me.CB_WILAYAN.DataSource = Login.Infosgenerale.codewilayaN
        Me.CB_WILAYANA.DataSource = Login.Infosgenerale.wilayaNaissanceArabe

        'inisialize sexe combobox 

        For Each Critere As String In InfosGenerales.sexe
            Me.CB_SEXE.Items.Add(Critere)
        Next





        'initialiser etudiant


        Me.TXT_ADR.Text = esistselect.GetInfoChamps(BDD.champsADRESSE)
        Me.TXT_CODEPOS.Text = esistselect.GetInfoChamps(BDD.champsCODEPOS)
        Me.TXT_DATENAIS.Text = esistselect.GetInfoChamps(BDD.champsDateNais)
        Me.TXT_ETDE.Text = esistselect.GetInfoChamps(BDD.champsET_DE)
        Me.TXT_FILSDE.Text = esistselect.GetInfoChamps(BDD.champsFILS_DE)
        Me.TXT_LIEUNA.Text = esistselect.GetInfoChamps(BDD.champsLieuNaisA)
        Me.TXT_LIEUN.Text = esistselect.GetInfoChamps(BDD.champsLieuNais)
        Me.TXT_NomEtud.Text = esistselect.GetInfoChamps(BDD.champsNomEtud)
        Me.TXT_NomEtudA.Text = esistselect.GetInfoChamps(BDD.champsNomEtudA)
        Me.TXT_Prenoms.Text = esistselect.GetInfoChamps(BDD.champsPrenoms)
        Me.TXT_PrenomsA.Text = esistselect.GetInfoChamps(BDD.champsPrenomsA)
        Me.CB_SEXE.Text = InfosGenerales.sexe(CInt(esistselect.GetInfoChamps(BDD.champsSEXE)))
        Me.TXT_VILLE.Text = esistselect.GetInfoChamps(BDD.champsVILLE)
        Me.CB_WILAYA.Text = esistselect.GetInfoChamps(BDD.champsWILAYA)
        Me.CB_WILAYAN.Text = esistselect.GetInfoChamps(BDD.champsWILNAIS)
        Me.CB_WILAYANA.Text = esistselect.GetInfoChamps(BDD.champsWilayaNaisA)


        Me.DTP_DATENAIS.Visible = False


        'boutton modifier 
        BT_MODIFIER.Enabled = False

    End Sub

    Private Sub BT_GENERALINFO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_GENERALINFO.CheckedChanged
        If Me.BT_GENERALINFO.Checked Then
            Me.BT_GENERALINFO.ForeColor = Color.MidnightBlue
            Me.BT_GENERALINFO.BackgroundImage = My.Resources.backBTcheked
            TAB_PAGES.SelectTab(0)

        Else
            Me.BT_GENERALINFO.ForeColor = Color.Gray
            Me.BT_GENERALINFO.BackgroundImage = My.Resources.backBTchekedNone

        End If
    End Sub

    Private Sub BT_INFORESIDENCE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_INFORESIDENCE.CheckedChanged
        If Me.BT_INFORESIDENCE.Checked Then
            Me.BT_INFORESIDENCE.ForeColor = Color.MidnightBlue
            Me.BT_INFORESIDENCE.BackgroundImage = My.Resources.backBTcheked
            TAB_PAGES.SelectTab(1)
        Else
            Me.BT_INFORESIDENCE.ForeColor = Color.Gray
            Me.BT_INFORESIDENCE.BackgroundImage = My.Resources.backBTchekedNone

        End If
    End Sub

    Private Sub TXT_NOM_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ADR.Enter, TXT_FILSDE.Enter, TXT_ETDE.Enter, TXT_LIEUN.Enter, TXT_NomEtud.Enter, TXT_Prenoms.Enter, TXT_VILLE.Enter
        InputLanguage.CurrentInputLanguage = LatinInput
    End Sub

    Private Sub TXT_NOMA_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUNA.Enter, TXT_NomEtudA.Enter, TXT_PrenomsA.Enter
        InputLanguage.CurrentInputLanguage = ArabicInput
    End Sub

    Private Sub TXT_NOMA_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ADR.Leave, TXT_FILSDE.Leave, TXT_ETDE.Leave, TXT_LIEUN.Leave, TXT_NomEtud.Leave, TXT_Prenoms.Leave, TXT_VILLE.Leave, TXT_LIEUNA.Leave, TXT_NomEtudA.Leave, TXT_PrenomsA.Leave
        InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage
    End Sub

    Private Sub TXT_NOM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ADR.KeyPress, TXT_FILSDE.KeyPress, TXT_ETDE.KeyPress, TXT_LIEUN.KeyPress, TXT_NomEtud.KeyPress, TXT_Prenoms.KeyPress, TXT_VILLE.KeyPress, TXT_LIEUNA.KeyPress, TXT_NomEtudA.KeyPress, TXT_PrenomsA.KeyPress
        Dim c As Char = e.KeyChar


        'If  Char.IsDigit(c) And Not AscW(c) = 8 And Not AscW(c) = 32 Then
        '    e.Handled = True
        'Else
          
            If (Not Regex.IsMatch(c.ToString, "\p{L}") Or Regex.IsMatch(c.ToString, "\p{IsArabic}")) And Not AscW(c) = 8 And Not AscW(c) = 32 Then
                e.Handled = True
                'generalesGroupBox.Controls.OfType(Of PictureBox).First(Function(x As PictureBox) (x.Name.Equals(CType(sender, Control).Name + "_ALERT"))).Visible = True
            Else
                'generalesGroupBox.Controls.OfType(Of PictureBox).First(Function(x As PictureBox) (x.Name.Equals(CType(sender, Control).Name + "_ALERT"))).Visible = False
            End If

        'End If
        'If Char.IsPunctuation(c) Then
        'e.Handled = True
        'End If

    End Sub

    Private Sub TXT_NOM_KeyPressA(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_LIEUNA.KeyPress, TXT_NomEtudA.KeyPress, TXT_PrenomsA.KeyPress
        Dim c As Char = e.KeyChar


        'If  Char.IsDigit(c) And Not AscW(c) = 8 And Not AscW(c) = 32 Then
        '    e.Handled = True
        'Else
            If Not Regex.IsMatch(c.ToString, "\p{IsArabic}") And Not AscW(c) = 8 And Not AscW(c) = 32 Then
                e.Handled = True
                'generalesGroupBox.Controls.OfType(Of PictureBox).First(Function(x As PictureBox) (x.Name.Equals(CType(sender, Control).Name + "_ALERT"))).Visible = True
            Else
                'generalesGroupBox.Controls.OfType(Of PictureBox).First(Function(x As PictureBox) (x.Name.Equals(CType(sender, Control).Name + "_ALERT"))).Visible = False
            End If
        
        'End If
        'If Char.IsPunctuation(c) Then
        'e.Handled = True
        'End If

    End Sub




    Private Sub BT_MODIFIER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MODIFIER.Click
        Dim j As Integer
        worning_format = False

        'no research if he had fill the long fealds with des chaines de char

        'exeption pour le code postal
        If Me.TXT_CODEPOS.Text <> "" And Me.TXT_CODEPOS.Text <> esistselect.GetInfoChamps(BDD.champsCODEPOS) Then
            j = 0
            While j < TXT_CODEPOS.Text.Length
                If Me.TXT_CODEPOS.Text(j) > "9" Or Me.TXT_CODEPOS.Text(j) < "0" Then
                    Me.TXT_CODEPOS.Text = "Format invalide !"
                    Me.TXT_CODEPOS.ForeColor = Color.Firebrick
                    worning_format = True
                End If
                j = j + 1
            End While
        End If

        Dim dialog As DialogResult
        dialog = MsgBox("Voulez-vous sauvegarder vos modifications ?", MessageBoxButtons.YesNo, "Confirmation")
        If (dialog = Windows.Forms.DialogResult.Yes) Then

            'filling la collections des critere
            If worning_format = False Then
                Dim collection_critere As New List(Of Critere)

                If TXT_ADR.Text <> esistselect.GetInfoChamps(BDD.champsADRESSE) And Me.TXT_ADR.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsADRESSE, TXT_ADR.Text, BDD.nomTableEtudiant))
                End If

                If Me.TXT_CODEPOS.Text <> esistselect.GetInfoChamps(BDD.champsCODEPOS) And Me.TXT_CODEPOS.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsCODEPOS, Me.TXT_CODEPOS.Text, BDD.nomTableEtudiant))
                End If

                If Me.TXT_DATENAIS.Text <> esistselect.GetInfoChamps(BDD.champsDateNais) And Me.TXT_DATENAIS.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsDateNais, Me.TXT_DATENAIS.Text, BDD.nomTableEtudiant))
                End If

                If Me.TXT_ETDE.Text <> esistselect.GetInfoChamps(BDD.champsET_DE) And Me.TXT_ETDE.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsET_DE, Me.TXT_ETDE.Text, BDD.nomTableEtudiant))
                End If

                If Me.TXT_FILSDE.Text <> esistselect.GetInfoChamps(BDD.champsFILS_DE) And Me.TXT_FILSDE.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsFILS_DE, Me.TXT_FILSDE.Text, BDD.nomTableEtudiant))
                End If

                If Me.TXT_LIEUNA.Text <> esistselect.GetInfoChamps(BDD.champsLieuNaisA) And Me.TXT_LIEUNA.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsLieuNaisA, Me.TXT_LIEUNA.Text, BDD.nomTableEtudiant))
                End If

                If Me.TXT_LIEUN.Text <> esistselect.GetInfoChamps(BDD.champsLieuNais) And Me.TXT_LIEUN.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsLieuNais, Me.TXT_LIEUN.Text, BDD.nomTableEtudiant))
                End If

                If Me.TXT_NomEtud.Text <> esistselect.GetInfoChamps(BDD.champsNomEtud) And Me.TXT_NomEtud.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsNomEtud, Me.TXT_NomEtud.Text, BDD.nomTableEtudiant))
                End If

                If Me.TXT_NomEtudA.Text <> esistselect.GetInfoChamps(BDD.champsNomEtudA) And Me.TXT_NomEtudA.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsNomEtudA, Me.TXT_NomEtudA.Text, BDD.nomTableEtudiant))
                End If

                If Me.TXT_Prenoms.Text <> esistselect.GetInfoChamps(BDD.champsPrenoms) And Me.TXT_Prenoms.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsPrenoms, Me.TXT_Prenoms.Text, BDD.nomTableEtudiant))
                End If

                If Me.TXT_PrenomsA.Text <> esistselect.GetInfoChamps(BDD.champsPrenomsA) And Me.TXT_PrenomsA.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsPrenomsA, Me.TXT_PrenomsA.Text, BDD.nomTableEtudiant))
                End If

                If Me.CB_SEXE.Text <> esistselect.GetInfoChamps(BDD.champsSEXE) And Me.CB_SEXE.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsSEXE, Me.CB_SEXE.SelectedIndex, BDD.nomTableEtudiant))
                End If

                If Me.TXT_VILLE.Text <> esistselect.GetInfoChamps(BDD.champsVILLE) And Me.TXT_VILLE.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsVILLE, Me.TXT_VILLE.Text, BDD.nomTableEtudiant))
                End If

                If Me.CB_WILAYA.Text <> esistselect.GetInfoChamps(BDD.champsWILAYA) And Me.CB_WILAYA.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsWILAYA, Me.CB_WILAYA.Text, BDD.nomTableEtudiant))
                    If (Login.Infosgenerale.wilayaactuelle.Rows.Contains(Me.CB_WILAYA.Text) = False) Then

                        Login.Infosgenerale.wilayaactuelle.LoadDataRow({Me.CB_WILAYA.Text}, LoadOption.Upsert)

                    End If
                End If

                If Me.CB_WILAYAN.Text <> esistselect.GetInfoChamps(BDD.champsWILNAIS) And Me.CB_WILAYAN.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsWILNAIS, Me.CB_WILAYAN.Text, BDD.nomTableEtudiant))
                    If (Login.Infosgenerale.codewilayaN.Rows.Contains(Me.CB_WILAYAN.Text) = False) Then

                        Login.Infosgenerale.codewilayaN.LoadDataRow({Me.CB_WILAYAN.Text}, LoadOption.Upsert)

                    End If
                End If

                If Me.CB_WILAYANA.Text <> esistselect.GetInfoChamps(BDD.champsWilayaNaisA) And Me.CB_WILAYANA.Text <> "" Then
                    collection_critere.Add(New Critere(BDD.champsWilayaNaisA, Me.CB_WILAYANA.Text, BDD.nomTableEtudiant))
                    If (Login.Infosgenerale.wilayaNaissanceArabe.Rows.Contains(Me.CB_WILAYANA.Text) = False) Then
                        Login.Infosgenerale.wilayaNaissanceArabe.LoadDataRow({Me.CB_WILAYANA.Text}, LoadOption.Upsert)
                    End If
                End If

                If collection_critere.Any = False Then
                    BT_MODIFIER.Enabled = False
                    Worning.Visible = True
                Else

                    Modification.traitModifier(collection_critere, esistselect)

                    For Each Critere As Critere In collection_critere
                        CType(Home.f, affichResearchResult).StudentTable.Rows.Item(CType(Home.f, affichResearchResult).SelectedStudent - 1)(Critere.getChamps) = Critere.getValeur


                    Next
                    CType(Home.f, affichResearchResult).StudentList.Clear()
                    CType(Home.f, affichResearchResult).affich_pageResult()
                    CType(Home.f, affichResearchResult).TableLayoutPanel1_Leave(TableLayoutPanel1, New EventArgs())
                End If
            End If
            BT_MODIFIER.Enabled = False
            modifier_Load(Me, e)
            CompletLabel.Visible = True

        Else
            modifier_Load(Me, e)
        End If



    End Sub

    Private Sub TXT_NomEtud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NomEtud.Click
        TXT_NomEtud.Text = ""
        Worning.Visible = False
        TXT_NomEtud.BackColor = Color.White
        TXT_NomEtud.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_Prenoms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_Prenoms.Click
        TXT_Prenoms.Text = ""
        Worning.Visible = False
        TXT_Prenoms.BackColor = Color.White
        TXT_Prenoms.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_NomEtudA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NomEtudA.Click
        TXT_NomEtudA.Text = ""
        Worning.Visible = False
        TXT_NomEtudA.BackColor = Color.White
        TXT_NomEtudA.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_PrenomsA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PrenomsA.Click
        TXT_PrenomsA.Text = ""
        Worning.Visible = False
        TXT_PrenomsA.BackColor = Color.White
        TXT_PrenomsA.ForeColor = Color.DarkGray
    End Sub

    Private Sub CB_SEXE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SEXE.Click
        CB_SEXE.Text = ""
        Worning.Visible = False
        CB_SEXE.BackColor = Color.White
        CB_SEXE.ForeColor = Color.DarkGray
    End Sub

    Private Sub CB_SEXE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CB_SEXE.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_FILSDE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_FILSDE.Click
        TXT_FILSDE.Text = ""
        Worning.Visible = False
        TXT_FILSDE.BackColor = Color.White
        TXT_FILSDE.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_ETDE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ETDE.Click
        TXT_ETDE.Text = ""
        Worning.Visible = False
        TXT_ETDE.BackColor = Color.White
        TXT_ETDE.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_LIEUNA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUN.Click
        TXT_LIEUNA.Text = ""
        Worning.Visible = False
        TXT_LIEUNA.BackColor = Color.White
        TXT_LIEUNA.ForeColor = Color.DarkGray
    End Sub

    Private Sub CB_WILAYAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYAN.Click
        CB_WILAYAN.Text = ""
        Worning.Visible = False
        CB_WILAYAN.BackColor = Color.White
        CB_WILAYAN.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_LIEUN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUNA.Click
        TXT_LIEUN.Text = ""
        Worning.Visible = False
        TXT_LIEUN.BackColor = Color.White
        TXT_LIEUN.ForeColor = Color.DarkGray
    End Sub

    Private Sub CB_WILAYANA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYANA.Click
        CB_WILAYANA.Text = ""
        Worning.Visible = False
        CB_WILAYANA.BackColor = Color.White
        CB_WILAYANA.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_ADR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ADR.Click
        TXT_ADR.Text = ""
        Worning.Visible = False
        TXT_ADR.BackColor = Color.White
        TXT_ADR.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_VILLE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_VILLE.Click
        TXT_VILLE.Text = ""
        Worning.Visible = False
        TXT_VILLE.BackColor = Color.White
        TXT_VILLE.ForeColor = Color.DarkGray
    End Sub

    Private Sub CB_WILAYA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYA.Click
        CB_WILAYA.Text = ""
        Worning.Visible = False
        CB_WILAYA.BackColor = Color.White
        CB_WILAYA.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_CODEPOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CODEPOS.Click
        TXT_CODEPOS.Text = ""
        Worning.Visible = False
        TXT_CODEPOS.BackColor = Color.White
        TXT_CODEPOS.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_DATENAIS_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DATENAIS.Click
        TXT_DATENAIS.Visible = False
        DTP_DATENAIS.Visible = True
        Worning.Visible = False
        TXT_DATENAIS.BackColor = Color.White
        TXT_DATENAIS.ForeColor = Color.DarkGray
        TXT_DATENAIS.ForeColor = Color.White
    End Sub

    Private Sub TXT_NomEtud_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NomEtud.MouseLeave
        If TXT_NomEtud.Text <> "" And TXT_NomEtud.Text <> esistselect.GetInfoChamps(BDD.champsNomEtud) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_NomEtud.ForeColor = Color.DimGray
        Else
            Me.TXT_NomEtud.Text = esistselect.GetInfoChamps(BDD.champsNomEtud)
        End If
        TXT_NomEtud.BackColor = Color.White
    End Sub

    Private Sub TXT_Prenoms_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_Prenoms.MouseLeave
        If TXT_Prenoms.Text <> "" And TXT_Prenoms.Text <> esistselect.GetInfoChamps(BDD.champsPrenoms) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_Prenoms.ForeColor = Color.DimGray
        Else
            Me.TXT_Prenoms.Text = esistselect.GetInfoChamps(BDD.champsPrenoms)
        End If
        TXT_Prenoms.BackColor = Color.White
    End Sub

    Private Sub TXT_NomEtudA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NomEtudA.MouseLeave
        If TXT_NomEtudA.Text <> "" And TXT_NomEtudA.Text <> esistselect.GetInfoChamps(BDD.champsNomEtudA) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_NomEtudA.ForeColor = Color.DimGray
        Else
            Me.TXT_NomEtudA.Text = esistselect.GetInfoChamps(BDD.champsNomEtudA)
        End If
        TXT_NomEtudA.BackColor = Color.White
    End Sub

    Private Sub TXT_PrenomsA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PrenomsA.MouseLeave
        If TXT_PrenomsA.Text <> "" And TXT_PrenomsA.Text <> esistselect.GetInfoChamps(BDD.champsPrenomsA) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_PrenomsA.ForeColor = Color.DimGray
        Else
            Me.TXT_PrenomsA.Text = esistselect.GetInfoChamps(BDD.champsPrenomsA)
        End If
        TXT_PrenomsA.BackColor = Color.White
    End Sub

    Private Sub CB_SEXE_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SEXE.MouseLeave
        If CB_SEXE.Text <> "" And CB_SEXE.Text <> InfosGenerales.sexe(CInt(esistselect.GetInfoChamps(BDD.champsSEXE))) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            CB_SEXE.ForeColor = Color.DimGray
        Else
            Me.CB_SEXE.Text = InfosGenerales.sexe(CInt(esistselect.GetInfoChamps(BDD.champsSEXE)))
        End If
        CB_SEXE.BackColor = Color.White
    End Sub

    Private Sub TXT_FILSDE_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_FILSDE.MouseLeave
        If TXT_FILSDE.Text <> "" And TXT_FILSDE.Text <> esistselect.GetInfoChamps(BDD.champsFILS_DE) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_FILSDE.ForeColor = Color.DimGray
        Else
            Me.TXT_FILSDE.Text = esistselect.GetInfoChamps(BDD.champsFILS_DE)
        End If
        TXT_FILSDE.BackColor = Color.White
    End Sub

    Private Sub TXT_ETDE_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ETDE.MouseLeave
        If TXT_ETDE.Text <> "" And TXT_ETDE.Text <> esistselect.GetInfoChamps(BDD.champsET_DE) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_ETDE.ForeColor = Color.DimGray
        Else
            Me.TXT_ETDE.Text = esistselect.GetInfoChamps(BDD.champsET_DE)
        End If
        TXT_ETDE.BackColor = Color.White
    End Sub

    Private Sub TXT_LIEUNA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUN.MouseLeave
        If TXT_LIEUNA.Text <> "" And TXT_LIEUNA.Text <> esistselect.GetInfoChamps(BDD.champsLieuNaisA) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_LIEUNA.ForeColor = Color.DimGray
        Else
            Me.TXT_LIEUNA.Text = esistselect.GetInfoChamps(BDD.champsLieuNaisA)
        End If
        TXT_LIEUNA.BackColor = Color.White
    End Sub

    Private Sub CB_WILAYAN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYAN.MouseLeave
        If CB_WILAYAN.Text <> "" And CB_WILAYAN.Text <> esistselect.GetInfoChamps(BDD.champsLieuNaisA) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            CB_WILAYAN.ForeColor = Color.DimGray
        Else
            Me.CB_WILAYAN.Text = esistselect.GetInfoChamps(BDD.champsLieuNaisA)
        End If
        CB_WILAYAN.BackColor = Color.White
    End Sub

    Private Sub TXT_LIEUN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUNA.MouseLeave
        If TXT_LIEUN.Text <> "" And TXT_LIEUN.Text <> esistselect.GetInfoChamps(BDD.champsLieuNais) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_LIEUN.ForeColor = Color.DimGray
        Else
            Me.TXT_LIEUN.Text = esistselect.GetInfoChamps(BDD.champsLieuNais)
        End If
        TXT_LIEUN.BackColor = Color.White
    End Sub

    Private Sub CB_WILAYANA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYANA.MouseLeave
        If CB_WILAYANA.Text <> "" And CB_WILAYANA.Text <> esistselect.GetInfoChamps(BDD.champsWilayaNaisA) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            CB_WILAYANA.ForeColor = Color.DimGray
        Else
            Me.CB_WILAYANA.Text = esistselect.GetInfoChamps(BDD.champsWilayaNaisA)
        End If
        CB_WILAYANA.BackColor = Color.White
    End Sub

    Private Sub TXT_ADR_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ADR.MouseLeave
        If TXT_ADR.Text <> "" And TXT_ADR.Text <> esistselect.GetInfoChamps(BDD.champsADRESSE) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_ADR.ForeColor = Color.DimGray
        Else
            Me.TXT_ADR.Text = esistselect.GetInfoChamps(BDD.champsADRESSE)
        End If
        TXT_ADR.BackColor = Color.White
    End Sub

    Private Sub TXT_VILLE_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_VILLE.MouseLeave
        If TXT_VILLE.Text <> "" And TXT_VILLE.Text <> esistselect.GetInfoChamps(BDD.champsVILLE) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_VILLE.ForeColor = Color.DimGray
        Else
            Me.TXT_VILLE.Text = esistselect.GetInfoChamps(BDD.champsVILLE)
        End If
        TXT_VILLE.BackColor = Color.White
    End Sub

    Private Sub CB_WILAYA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYA.MouseLeave
        If CB_WILAYA.Text <> "" And CB_WILAYA.Text <> esistselect.GetInfoChamps(BDD.champsWILAYA) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            CB_WILAYA.ForeColor = Color.DimGray
        Else
            Me.CB_WILAYA.Text = esistselect.GetInfoChamps(BDD.champsWILAYA)
        End If
        CB_WILAYA.BackColor = Color.White
    End Sub

    Private Sub TXT_CODEPOS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CODEPOS.MouseLeave
        If TXT_CODEPOS.Text <> "" And TXT_CODEPOS.Text <> esistselect.GetInfoChamps(BDD.champsCODEPOS) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_CODEPOS.ForeColor = Color.DimGray
        Else
            Me.TXT_CODEPOS.Text = esistselect.GetInfoChamps(BDD.champsCODEPOS)
        End If
        TXT_CODEPOS.BackColor = Color.White
    End Sub

    Private Sub DTP_DATENAIS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_DATENAIS.MouseLeave
        If DTP_DATENAIS.Text <> "" And Me.DTP_DATENAIS.Text <> esistselect.GetInfoChamps(BDD.champsDateNais) Then
            BT_MODIFIER.Enabled = True
            CompletLabel.Visible = False
            TXT_DATENAIS.Text = DTP_DATENAIS.Text
            DTP_DATENAIS.ForeColor = Color.DimGray
        Else
            TXT_DATENAIS.Text = esistselect.GetInfoChamps(BDD.champsDateNais)
        End If
        DTP_DATENAIS.BackColor = Color.White
    End Sub

    Private Sub TXT_NomEtud_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NomEtud.MouseHover
        TXT_NomEtud.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_Prenoms_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_Prenoms.MouseHover
        TXT_Prenoms.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_NomEtudA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NomEtudA.MouseHover
        TXT_NomEtudA.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_PrenomsA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PrenomsA.MouseHover
        TXT_PrenomsA.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub CB_SEXE_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SEXE.MouseHover
        CB_SEXE.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_FILSDE_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_FILSDE.MouseHover
        TXT_FILSDE.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_ETDE_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ETDE.MouseHover
        TXT_ETDE.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_LIEUNA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUN.MouseHover
        TXT_LIEUNA.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub CB_WILAYAN_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYAN.MouseHover
        CB_WILAYAN.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_LIEUN_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUNA.MouseHover
        TXT_LIEUN.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub CB_WILAYANA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYANA.MouseHover
        CB_WILAYANA.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_ADR_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ADR.MouseHover
        TXT_ADR.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_VILLE_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_VILLE.MouseHover
        TXT_VILLE.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub CB_WILAYA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYA.MouseHover
        CB_WILAYA.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_CODEPOS_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CODEPOS.MouseHover
        TXT_CODEPOS.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub txt_DATENAIS_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DATENAIS.MouseHover
        TXT_DATENAIS.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BT_RATRAP_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_INFORESIDENCE.MouseHover, BT_GENERALINFO.MouseHover
        For Each ctrl In Panel3.Controls
            CType(ctrl, Control).Padding = New Padding(5, 0, 0, 0)
        Next
        CType(sender, Control).Padding = New Padding(25, 0, 0, 0)
    End Sub

    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortirButton.Click
        Me.Close()
        'Home.f.Show()

        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub
End Class
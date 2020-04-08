Public Class modifier

    Dim worning_format As Boolean
    Dim esistselect As Etudiant ' letudiant selection f affichresult

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
        'initialiser les criteres de laffichage avant modification

        'For Each critere As String In esistselect.getannees()
        '    CB_ANNEEIN.Items.Add(critere)
        '    CB_ANNEEGRP.Items.Add(critere)
        '    CB_ANNEESEC.Items.Add(critere)
        '    CB_ANNEEPROMO.Items.Add(critere)
        'Next

        'For Each critere As String In esistselect.getcodeMat()
        '    CB_CodeMatMAT.Items.Add(critere)
        '    CB_CodeMatNOTE.Items.Add(critere)
        'Next

        'For Each critere As String In esistselect.getcodeRattrap()
        '    CB_CODERATNOT.Items.Add(critere)
        '    CB_CODERATRAT.Items.Add(critere)
        'Next

        'initialiser etudiant

        Me.TXT_ADR.Text = esistselect.GetInfoChamps("ADRESSE")
        'Me.CB_ANNEEB.Text = esistselect.GetInfoChamps("ANNEEBAC")
        Me.TXT_CODEPOS.Text = esistselect.GetInfoChamps("CODPOST")
        Me.TXT_DATENAIS.Text = esistselect.GetInfoChamps("DateNais")
        Me.TXT_ETDE.Text = esistselect.GetInfoChamps("ET_DE")
        Me.TXT_FILSDE.Text = esistselect.GetInfoChamps("FILS_DE")
        Me.TXT_LIEUNA.Text = esistselect.GetInfoChamps("LieuNaisA")
        Me.TXT_LIEUN.Text = esistselect.GetInfoChamps("LieuNais")
        Me.TXT_MATRIN.Text = esistselect.GetInfoChamps("MATRIN")
        Me.TXT_MATRIC_INS.Text = esistselect.GetInfoChamps("MATRIC_INS")
        'Me.TXT_MOYBAC.Text = esistselect.GetInfoChamps("MOYBAC")
        Me.TXT_NomEtud.Text = esistselect.GetInfoChamps("NomEtud")
        Me.TXT_NomEtudA.Text = esistselect.GetInfoChamps("NomEtudA")
        Me.TXT_Prenoms.Text = esistselect.GetInfoChamps("Prenoms")
        Me.TXT_PrenomsA.Text = esistselect.GetInfoChamps("PrenomsA")
        'Me.CB_SERI.Text = esistselect.GetInfoChamps("SERIEBAC")
        Me.CB_SEXE.Text = esistselect.GetInfoChamps("SEXE")
        Me.TXT_VILLE.Text = esistselect.GetInfoChamps("VILLE")
        Me.CB_WILAYA.Text = esistselect.GetInfoChamps("WILAYA")
        'Me.CB_WILAYAB.Text = esistselect.GetInfoChamps("WILBAC")
        Me.CB_WILAYAN.Text = esistselect.GetInfoChamps("WILNAIS")
        Me.CB_WILAYANA.Text = esistselect.GetInfoChamps("WILNAISA")

        Me.DTP_DATENAIS.Visible = False

        'initialiser :

        'inisialiser les wilayas combobox
        For Each Critere As String In InfosGenerales.wilaya
            'Me.CB_WILAYAB.Items.Add(Critere)
            Me.CB_WILAYA.Items.Add(Critere)
        Next

        For Each Critere As String In InfosGenerales.wilayaarabe
            Me.CB_WILAYANA.Items.Add(Critere)
        Next

        For i = 1 To InfosGenerales.wilaya.Count
            Me.CB_WILAYAN.Items.Add(i)
        Next

        'inisialize sexe combobox 

        For Each Critere As String In InfosGenerales.sexe
            Me.CB_SEXE.Items.Add(Critere)
        Next

        'inisialize seri de bac combobox 

        'For Each Critere As String In InfosGenerales.seribac
        '    Me.CB_SERI.Items.Add(Critere)
        'Next

        'inisialize annee de bac combobox 

        'For i = InfosGenerales.firstYear To InfosGenerales.lastYear
        '    Me.CB_ANNEEB.Items.Add(i)
        'Next

        'inisialize les champs des autres categories a enable  

        'inscription
        'TXT_MOYEIN.Visible = False
        'CB_DEC.Visible = False
        'CB_DECIIN.Visible = False
        'CB_RANGIN.Visible = False
        'CB_MENTIN.Visible = False
        'CB_ELIMININ.Visible = False
        'CB_RATRIN.Visible = False
        'CB_ADM.Visible = False

        ''groupe
        'TXT_CB_codeGroupe.Visible = False
        'CB_NG.Visible = False

        ''section 
        'TXT_CodeSection.Visible = False
        'CB_NS.Visible = False

        ''promo
        'TXT_CodePromo.Visible = False
        'CB_Niveau.Visible = False
        'CB_Option.Visible = False
        'CB_Annee.Visible = False
        'TXT_NbreEtudiant.Visible = False
        'TXT_Moypromo.Visible = False

        ''note

        'TXT_NOJUNO.Visible = False
        'TXT_NOSYNO.Visible = False
        'TXT_NORANO.Visible = False
        'CB_ELIMNO.Visible = False
        'CB_RATRNO.Visible = False

        ''matiere
        'CB_ANSCMA.Visible = False
        'CB_ANETMA.Visible = False
        'CB_OPTIMA.Visible = False
        'CB_TYPEMA.Visible = False
        'TXT_COMAMA.Visible = False
        'TXT_LIBEMA.Visible = False
        'CB_COEFMA.Visible = False
        'TXT_MOYMAT.Visible = False
        'CB_CYCLMA.Visible = False

        ''note rattrapage

        'TXT_MOYERA.Visible = False
        'CB_MENTRA.Visible = False
        'CB_ELIMRA.Visible = False
        'CB_RATRRA.Visible = False

        ''ratrrapage

        'CB_ANSCRA.Visible = False
        'CB_ANETRA.Visible = False
        'CB_CYCLRA.Visible = False
        'CB_OPTIRA.Visible = False

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

    'Private Sub CB_ANNEEIN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ANNEEIN.Text <> "" Then
    '        'collecter le critere
    '        Dim critere As Critere = New Critere("ANETIN", CB_ANNEEIN.Text, "PROMO")
    'esistselect.chargementInfoInscription(critere)

    'TXT_MOYEIN.Visible = True
    'CB_DEC.Visible = True
    'CB_DECIIN.Visible = True
    'CB_RANGIN.Visible = True
    'CB_MENTIN.Visible = True
    'CB_ELIMININ.Visible = True
    'CB_RATRIN.Visible = True
    'CB_ADM.Visible = True

    'initializer les champs

    'TXT_MOYEIN.Text = esistselect.GetInfoChamps("MOYEIN")
    'CB_DEC.Text = esistselect.GetInfoChamps("DEC")
    'CB_DECIIN.Text = esistselect.GetInfoChamps("DECIIN")
    'CB_RANGIN.Text = esistselect.GetInfoChamps("RANGIN")
    'CB_MENTIN.Text = esistselect.GetInfoChamps("MENTIN")
    'CB_ELIMININ.Text = esistselect.GetInfoChamps("ELIMININ")
    'CB_RATRIN.Text = esistselect.GetInfoChamps("RATRIN")
    'CB_ADM.Text = esistselect.GetInfoChamps("ADM")

    '        'initializer RANGIN
    '        For i As Integer = 0 To esistselect.GetInfoChamps("RANGIN")
    '            CB_RANGIN.Items.Add(i)
    '        Next

    '        'initializer MENTIN
    '        For i As Integer = 0 To InfosGenerales.Maxmention
    '            CB_MENTIN.Items.Add(i)
    '        Next

    '        'initializer ELIMININ
    '        For i As Integer = 0 To InfosGenerales.nb_module
    '            CB_ELIMININ.Items.Add(i)
    '        Next

    '        'initializer RATRIN
    '        For i As Integer = 0 To InfosGenerales.nb_module
    '            CB_RATRIN.Items.Add(i)
    '        Next

    '        'initializer DECIIN
    '        For i As Integer = 0 To InfosGenerales.nb_DECIIN
    '            CB_DECIIN.Items.Add(i)
    '        Next

    '        'initializer DEC
    '        For Each val As String In InfosGenerales.dec
    '            CB_DEC.Items.Add(val)
    '        Next

    '    End If
    'End Sub

    ''Private Sub CB_ANNEEGRP_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    If CB_ANNEEGRP.Text <> "" Then

    ''        'collecter le critere
    ''        Dim critere As Critere = New Critere("ANETIN", CB_ANNEEIN.Text, "PROMO")
    ''        'esistselect.chargementInfoInscription(critere)

    ''        TXT_CB_codeGroupe.Visible = True
    ''        CB_NG.Visible = True

    ''        'inisializer les champs
    ''        TXT_CB_codeGroupe.Text = esistselect.GetInfoChamps("codeGroupe")
    ''        CB_NG.Text = esistselect.GetInfoChamps("NG")

    ''        'inisializer NG
    ''        For Each val As String In InfosGenerales.ng
    ''            CB_NG.Items.Add(val)
    ''        Next

    ''    End If
    ''End Sub

    'Private Sub CB_ANNEESEC_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ANNEESEC.Text <> "" Then

    '        'collecter le critere
    '        Dim critere As Critere = New Critere("ANETIN", CB_ANNEEIN.Text, "PROMO")
    '        'esistselect.chargementInfoInscription(critere)

    '        TXT_CodeSection.Visible = True
    '        CB_NS.Visible = True

    '        'inisializer les champs
    '        TXT_CodeSection.Text = esistselect.GetInfoChamps("CodeSection")
    '        CB_NS.Text = esistselect.GetInfoChamps("NS")

    '        'inisializer ns
    '        For Each val As String In InfosGenerales.ns
    '            CB_DEC.Items.Add(val)
    '        Next
    '    End If
    'End Sub

    'Private Sub CB_ANNEEPROMO_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ANNEEPROMO.Text <> "" Then
    '        'collecter le critere
    '        Dim critere As Critere = New Critere("ANETIN", CB_ANNEEIN.Text, "PROMO")
    'esistselect.chargementInfoInscription(critere)

    'TXT_CodePromo.Visible = True
    'CB_Niveau.Visible = True
    'CB_Option.Visible = True
    'CB_Annee.Visible = True
    'TXT_NbreEtudiant.Visible = True
    'TXT_Moypromo.Visible = True

    'inisializer les champs

    'TXT_CodePromo.Text = esistselect.GetInfoChamps("CodePromo")
    'CB_Niveau.Text = esistselect.GetInfoChamps("Niveau")
    'CB_Option.Text = esistselect.GetInfoChamps("Option")
    'CB_Annee.Text = esistselect.GetInfoChamps("Annee")
    'TXT_NbreEtudiant.Text = esistselect.GetInfoChamps("NbreEtudiant")
    'TXT_Moypromo.Text = esistselect.GetInfoChamps("Moypromo")

    ''inisializer Niveau
    '        For i As Integer = 0 To InfosGenerales.niveau_max
    '            CB_Niveau.Items.Add(i)
    '        Next

    ''inisializer option
    '        For i As Integer = 0 To InfosGenerales.optione.Length - 1
    '            CB_Option.Items.Add(InfosGenerales.optione(i))
    '        Next

    ''inisializer annee
    ''For i = 0 To InfosGenerales.Annee.Length
    ''    Me.CB_Annee.Items.Add(InfosGenerales.Annee(i))
    ''Next

    ''    End If

    ''End Sub

    ''Private Sub CB_CodeMatNOTE_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    If CB_CodeMatNOTE.Text <> "" Then
    ''        'collecter le critere
    ''        Dim critere As Critere = New Critere("CodeMat", CB_ANNEEIN.Text, "NOTE")
    ''        'esistselect.chargementInfoInscription(critere)

    ''        TXT_NOJUNO.Visible = True
    ''        TXT_NOSYNO.Visible = True
    ''        TXT_NORANO.Visible = True
    ''        CB_ELIMNO.Visible = True
    ''        CB_RATRNO.Visible = True
    ''inisializer les champs

    '        TXT_NOJUNO.Text = esistselect.GetInfoChamps("NOJUNO")
    '        TXT_NOSYNO.Text = esistselect.GetInfoChamps("NOSYNO")
    '        TXT_NORANO.Text = esistselect.GetInfoChamps("NORANO")
    '        CB_ELIMNO.Text = esistselect.GetInfoChamps("ELIMNO")
    '        CB_RATRNO.Text = esistselect.GetInfoChamps("RATRNO")

    ''inisializer ELIMNO
    '        For i As Integer = 0 To InfosGenerales.elimno.Length - 1
    '            Me.CB_ELIMNO.Items.Add(InfosGenerales.elimno(i))
    '        Next

    ''inisializer RATRNO
    '        For i = 0 To 2
    '            Me.CB_RATRNO.Items.Add(i)
    '        Next

    '    End If
    'End Sub

    'Private Sub CB_CodeMatMAT_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_CodeMatMAT.Text <> "" Then

    '        'collecter le critere
    '        Dim critere As Critere = New Critere("CodeMat", CB_ANNEEIN.Text, "MATIERE")
    'esistselect.chargementInfoInscription(critere)

    'CB_ANSCMA.Visible = True
    'CB_ANETMA.Visible = True
    'CB_OPTIMA.Visible = True
    'CB_TYPEMA.Visible = True
    'TXT_COMAMA.Visible = True
    'TXT_LIBEMA.Visible = True
    'CB_COEFMA.Visible = True
    'TXT_MOYMAT.Visible = True
    'CB_CYCLMA.Visible = True

    'inisializer les champs
    'CB_ANSCMA.Text = esistselect.GetInfoChamps("ANSCMA")
    'CB_ANETMA.Text = esistselect.GetInfoChamps("ANETMA")
    'CB_OPTIMA.Text = esistselect.GetInfoChamps("OPTIMA")
    'CB_TYPEMA.Text = esistselect.GetInfoChamps("TYPEMA")
    'TXT_COMAMA.Text = esistselect.GetInfoChamps("COMAMA")
    'TXT_LIBEMA.Text = esistselect.GetInfoChamps("LIBEMA")
    'CB_COEFMA.Text = esistselect.GetInfoChamps("COEFMA")
    'TXT_MOYMAT.Text = esistselect.GetInfoChamps("MOYMAT")
    'CB_CYCLMA.Text = esistselect.GetInfoChamps("CYCLMA")

    ''inisializer ANSCMA
    'For i = 0 To InfosGenerales.Annee.Length
    '    Me.CB_ANSCMA.Items.Add(InfosGenerales.Annee(i))
    'Next

    ''inisializer ANETMA
    'For i As Integer = 0 To InfosGenerales.niveau_max
    '    CB_ANETMA.Items.Add(i)
    'Next

    ''inisializer OPTIMA
    'For i As Integer = 0 To InfosGenerales.optione.Length - 1
    '    CB_OPTIMA.Items.Add(InfosGenerales.optione(i))
    'Next

    ''inisializer TYPEMA
    '        For i As Integer = 0 To InfosGenerales.typemat.Length - 1
    '            CB_TYPEMA.Items.Add(InfosGenerales.typemat(i))
    '        Next

    ''inisializer COEFMA
    '        For i As Integer = 1 To InfosGenerales.coeif_max
    '            CB_COEFMA.Items.Add(i)
    '        Next

    ''inisializer CYCLMA
    '        For Each val As String In InfosGenerales.cycle
    '            CB_CYCLMA.Items.Add(val)
    '        Next

    '    End If
    'End Sub

    ''Private Sub CB_CODERATNOT_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    If CB_CODERATNOT.Text <> "" Then
    ''        'collecter le critere
    ''        Dim critere As Critere = New Critere("CodeRat", CB_ANNEEIN.Text, "NoteRATRAP")
    ''        'esistselect.chargementInfoInscription(critere)

    ''        TXT_MOYERA.Visible = True
    ''        CB_MENTRA.Visible = True
    ''        CB_ELIMRA.Visible = True
    ''        CB_RATRRA.Visible = True

    ''inisializer les champs
    ''        TXT_MOYERA.Text = esistselect.GetInfoChamps("MOYERA")
    ''        CB_MENTRA.Text = esistselect.GetInfoChamps("MENTRA")
    ''        CB_ELIMRA.Text = esistselect.GetInfoChamps("ELIMRA")
    ''        CB_RATRRA.Text = esistselect.GetInfoChamps("RATRRA")

    ' ''inisializer MENTRA
    ''        For i As Integer = 1 To InfosGenerales.Maxmention
    ''            CB_MENTRA.Items.Add(i)
    ''        Next

    ' ''inisializer ELIMRA
    ''        For i As Integer = 1 To InfosGenerales.nb_module
    ''            CB_MENTRA.Items.Add(i)
    ''        Next

    ' ''inisializer RATRRA
    ''        For Each val As String In InfosGenerales.Ratrra
    ''            CB_RATRRA.Items.Add(val)
    ''        Next

    ''    End If
    ''End Sub

    ''Private Sub CB_CODERATRAT_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    If CB_CODERATRAT.Text <> "" Then
    ''        'collecter le critere
    ''        Dim critere As Critere = New Critere("CodeRat", CB_ANNEEIN.Text, "RATRAP")
    ''esistselect.chargementInfoInscription(critere)

    ''CB_ANSCRA.Visible = True
    ''CB_ANETRA.Visible = True
    ''CB_CYCLRA.Visible = True
    ''CB_OPTIRA.Visible = True
    ''inisializer les champs

    ''CB_ANSCRA.Text = esistselect.GetInfoChamps("ANSCRA")
    ''CB_ANETRA.Text = esistselect.GetInfoChamps("ANETRA")
    ''CB_CYCLRA.Text = esistselect.GetInfoChamps("CYCLRA")
    ''CB_OPTIRA.Text = esistselect.GetInfoChamps("OPTIRA")

    ''inisializer ANSCRA
    '        For i = 0 To InfosGenerales.Annee.Length
    '            Me.CB_ANSCRA.Items.Add(InfosGenerales.Annee(i))
    '        Next

    ''inisializer ANETRA
    ''For i As Integer = 0 To InfosGenerales.niveau_max
    ''    CB_ANETRA.Items.Add(i)
    ''Next

    ''inisializer CYCLRA
    '        For Each val As String In InfosGenerales.cycle
    '            CB_CYCLRA.Items.Add(val)
    '        Next

    ''inisializer OPTIRA
    '        For i As Integer = 0 To InfosGenerales.optione.Length - 1
    '            CB_OPTIRA.Items.Add(InfosGenerales.optione(i))
    '        Next

    '    End If
    'End Sub

    Private Sub BT_MODIFIER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MODIFIER.Click
        Dim j As Integer
        worning_format = False
        'no research if he had fill the long fealds with des chaines de char

        'exeption pour le matricule

        If Me.TXT_MATRIN.Text <> "" And Me.TXT_MATRIN.Text <> esistselect.GetInfoChamps("MATRIN") Then
            j = 0
            While j < TXT_MATRIN.Text.Length
                If Me.TXT_MATRIN.Text(j) > "9" Or Me.TXT_MATRIN.Text(j) < "0" Then
                    If Me.TXT_MATRIN.Text(j) <> "/" Then
                        Me.TXT_MATRIN.Text = "Format invalide !"
                        Me.TXT_MATRIN.ForeColor = Color.Firebrick
                        worning_format = True
                    End If
                End If
                j = j + 1
            End While
        End If

        'exeption pour le matricul du bac
        If Me.TXT_MATRIC_INS.Text <> "" And Me.TXT_MATRIC_INS.Text <> esistselect.GetInfoChamps("MATRIC_INS") Then
            j = 0
            While j < TXT_MATRIC_INS.Text.Length
                If Me.TXT_MATRIC_INS.Text(j) > "9" Or Me.TXT_MATRIC_INS.Text(j) < "0" Then
                    If Me.TXT_MATRIC_INS.Text(j) <> "/" Then
                        Me.TXT_MATRIC_INS.Text = "Format invalide !"
                        Me.TXT_MATRIC_INS.ForeColor = Color.Firebrick
                        worning_format = True
                    End If
                End If
                j = j + 1
            End While
        End If

        'exeption pour la moyenne du bac
        'If Me.TXT_MOYBAC.Text <> "" And Me.TXT_MOYBAC.Text <> esistselect.GetInfoChamps("MOYBAC") Then
        '    j = 0
        '    While j < TXT_MOYBAC.Text.Length
        '        If Me.TXT_MOYBAC.Text(j) > "9" Or Me.TXT_MOYBAC.Text(j) < "0" Then
        '            If Me.TXT_MOYBAC.Text(j) <> "." Then
        '                Me.TXT_MOYBAC.Text = "Format invalide !"
        '                Me.TXT_MOYBAC.ForeColor = Color.Firebrick
        '                worning_format = True
        '            End If
        '        End If
        '        j = j + 1
        '    End While
        'End If

        'exeption pour le code postal
        If Me.TXT_CODEPOS.Text <> "" And Me.TXT_CODEPOS.Text <> esistselect.GetInfoChamps("CODPOST") Then
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

        'exeption pour MOYEIN
        'If TXT_MOYEIN.Visible And TXT_MOYEIN.Text <> esistselect.GetInfoChamps("MOYEIN") And TXT_MOYEIN.Text <> "" Then
        '    j = 0
        '    While j < TXT_MOYEIN.Text.Length
        '        If Me.TXT_MOYEIN.Text(j) > "9" Or Me.TXT_MOYEIN.Text(j) < "0" Then
        '            If Me.TXT_MOYEIN.Text(j) <> "." Then
        '                Me.TXT_MOYEIN.Text = "Format invalide !"
        '                Me.TXT_MOYEIN.ForeColor = Color.Firebrick
        '                worning_format = True
        '            End If
        '        End If
        '        j = j + 1
        '    End While
        'End If

        'exeption pour  MOYMAT
        'If TXT_MOYMAT.Visible And TXT_MOYMAT.Text <> esistselect.GetInfoChamps("MOYMAT") And TXT_MOYMAT.Text <> "" Then
        '    j = 0
        '    While j < TXT_MOYMAT.Text.Length
        '        If Me.TXT_MOYMAT.Text(j) > "9" Or Me.TXT_MOYMAT.Text(j) < "0" Then
        '            If Me.TXT_MOYMAT.Text(j) <> "." Then
        '                Me.TXT_MOYMAT.Text = "Format invalide !"
        '                Me.TXT_MOYMAT.ForeColor = Color.Firebrick
        '                worning_format = True
        '            End If
        '        End If
        '        j = j + 1
        '    End While
        'End If

        'exeption pour  NOJUNO
        'If TXT_NOJUNO.Visible And TXT_NOJUNO.Text <> esistselect.GetInfoChamps("NOJUNO") And TXT_NOJUNO.Text <> "" Then
        '    j = 0
        '    While j < TXT_NOJUNO.Text.Length
        '        If Me.TXT_NOJUNO.Text(j) > "9" Or Me.TXT_NOJUNO.Text(j) < "0" Then
        '            If Me.TXT_NOJUNO.Text(j) <> "." Then
        '                Me.TXT_NOJUNO.Text = "Format invalide !"
        '                Me.TXT_NOJUNO.ForeColor = Color.Firebrick
        '                worning_format = True
        '            End If
        '        End If
        '        j = j + 1
        '    End While
        'End If

        'exeption pour  NOSYNO
        'If TXT_NOSYNO.Visible And TXT_NOSYNO.Text <> esistselect.GetInfoChamps("NOSYNO") And TXT_NOSYNO.Text <> "" Then
        '    j = 0
        '    While j < TXT_NOSYNO.Text.Length
        '        If Me.TXT_NOSYNO.Text(j) > "9" Or Me.TXT_NOSYNO.Text(j) < "0" Then
        '            If Me.TXT_NOSYNO.Text(j) <> "." Then
        '                Me.TXT_NOSYNO.Text = "Format invalide !"
        '                Me.TXT_NOSYNO.ForeColor = Color.Firebrick
        '                worning_format = True
        '            End If
        '        End If
        '        j = j + 1
        '    End While
        'End If

        'exeption pour  NORANO
        'If TXT_NORANO.Visible And TXT_NORANO.Text <> esistselect.GetInfoChamps("NORANO") And TXT_NORANO.Text <> "" Then
        '    j = 0
        '    While j < TXT_NORANO.Text.Length
        '        If Me.TXT_NORANO.Text(j) > "9" Or Me.TXT_NORANO.Text(j) < "0" Then
        '            If Me.TXT_NORANO.Text(j) <> "." Then
        '                Me.TXT_NORANO.Text = "Format invalide !"
        '                Me.TXT_NORANO.ForeColor = Color.Firebrick
        '                worning_format = True
        '            End If
        '        End If
        '        j = j + 1
        '    End While
        'End If

        'exeption pour  MOYERA
        'If TXT_MOYERA.Visible And TXT_MOYERA.Text <> esistselect.GetInfoChamps("MOYERA") And TXT_MOYERA.Text <> "" Then
        '    j = 0
        '    While j < TXT_MOYERA.Text.Length
        '        If Me.TXT_MOYERA.Text(j) > "9" Or Me.TXT_NORANO.Text(j) < "0" Then
        '            If Me.TXT_MOYERA.Text(j) <> "." Then
        '                Me.TXT_MOYERA.Text = "Format invalide !"
        '                Me.TXT_MOYERA.ForeColor = Color.Firebrick
        '                worning_format = True
        '            End If
        '        End If
        '        j = j + 1
        '    End While
        'End If

        'exeption pour  Moyenne
        'If TXT_Moypromo.Visible And TXT_Moypromo.Text <> esistselect.GetInfoChamps("Moyenne") And TXT_Moypromo.Text <> "" Then
        '    j = 0
        '    While j < TXT_Moypromo.Text.Length
        '        If Me.TXT_Moypromo.Text(j) > "9" Or Me.TXT_Moypromo.Text(j) < "0" Then
        '            If Me.TXT_Moypromo.Text(j) <> "." Then
        '                Me.TXT_Moypromo.Text = "Format invalide !"
        '                Me.TXT_Moypromo.ForeColor = Color.Firebrick
        '                worning_format = True
        '            End If
        '        End If
        '        j = j + 1
        '    End While
        'End If



        'filling la collections des crietere
        If worning_format = False Then
            Dim collection_critere As New List(Of Critere)

            If TXT_ADR.Text <> esistselect.GetInfoChamps("ADRESSE") And Me.TXT_ADR.Text <> "" Then
                collection_critere.Add(New Critere("ADRESSE", TXT_ADR.Text, "ETUDIANT"))
            End If

            'If Me.CB_ANNEEB.Text <> esistselect.GetInfoChamps("ANNEEBAC") And Me.CB_ANNEEB.Text <> "" Then
            '    collection_critere.Add(New Critere("ANNEEBAC", Me.CB_ANNEEB.Text, "ETUDIANT"))
            'End If

            If Me.TXT_CODEPOS.Text <> esistselect.GetInfoChamps("CODPOST") And Me.TXT_CODEPOS.Text <> "" Then
                collection_critere.Add(New Critere("CODPOST", Me.TXT_CODEPOS.Text, "ETUDIANT"))
            End If

            If Me.TXT_DATENAIS.Text <> esistselect.GetInfoChamps("DateNais") And Me.TXT_DATENAIS.Text <> "" Then
                collection_critere.Add(New Critere("DateNais", Me.TXT_DATENAIS.Text, "ETUDIANT"))
            End If

            If Me.TXT_ETDE.Text <> esistselect.GetInfoChamps("ET_DE") And Me.TXT_ETDE.Text <> "" Then
                collection_critere.Add(New Critere("ET_DE", Me.TXT_ETDE.Text, "ETUDIANT"))
            End If

            If Me.TXT_FILSDE.Text <> esistselect.GetInfoChamps("FILS_DE") And Me.TXT_FILSDE.Text <> "" Then
                collection_critere.Add(New Critere("FILS_DE", Me.TXT_FILSDE.Text, "ETUDIANT"))
            End If

            If Me.TXT_LIEUNA.Text <> esistselect.GetInfoChamps("LieuNaisA") And Me.TXT_LIEUNA.Text <> "" Then
                collection_critere.Add(New Critere("LieuNaisA", Me.TXT_LIEUNA.Text, "ETUDIANT"))
            End If

            If Me.TXT_LIEUN.Text <> esistselect.GetInfoChamps("LieuNais") And Me.TXT_LIEUN.Text <> "" Then
                collection_critere.Add(New Critere("LieuNais", Me.TXT_LIEUN.Text, "ETUDIANT"))
            End If

            If Me.TXT_MATRIN.Text <> esistselect.GetInfoChamps("MATRIN") And Me.TXT_MATRIN.Text <> "" Then
                collection_critere.Add(New Critere("MATRIN", Me.TXT_MATRIN.Text, "ETUDIANT"))
            End If

            If Me.TXT_MATRIC_INS.Text <> esistselect.GetInfoChamps("MATRIC_INS") And Me.TXT_MATRIC_INS.Text <> "" Then
                collection_critere.Add(New Critere("MATRIC_INS", Me.TXT_MATRIC_INS.Text, "ETUDIANT"))
            End If

            'If Me.TXT_MOYBAC.Text <> esistselect.GetInfoChamps("MOYBAC") And Me.TXT_MOYBAC.Text <> "" Then
            '    collection_critere.Add(New Critere("MOYBAC", Me.TXT_MOYBAC.Text, "ETUDIANT"))
            'End If

            If Me.TXT_NomEtud.Text <> esistselect.GetInfoChamps("NomEtud") And Me.TXT_NomEtud.Text <> "" Then
                collection_critere.Add(New Critere("NomEtud", Me.TXT_NomEtud.Text, "ETUDIANT"))
            End If

            If Me.TXT_NomEtudA.Text <> esistselect.GetInfoChamps("NomEtudA") And Me.TXT_NomEtudA.Text <> "" Then
                collection_critere.Add(New Critere("NomEtudA", Me.TXT_NomEtudA.Text, "ETUDIANT"))
            End If

            If Me.TXT_Prenoms.Text <> esistselect.GetInfoChamps("Prenoms") And Me.TXT_Prenoms.Text <> "" Then
                collection_critere.Add(New Critere("Prenoms", Me.TXT_Prenoms.Text, "ETUDIANT"))
            End If

            If Me.TXT_PrenomsA.Text <> esistselect.GetInfoChamps("PrenomsA") And Me.TXT_PrenomsA.Text <> "" Then
                collection_critere.Add(New Critere("PrenomsA", Me.TXT_PrenomsA.Text, "ETUDIANT"))
            End If

            'If Me.CB_SERI.Text <> esistselect.GetInfoChamps("SERIEBAC") And Me.CB_SERI.Text <> "" Then
            '    collection_critere.Add(New Critere("SERIEBAC", Me.CB_SERI.Text, "ETUDIANT"))
            'End If

            If Me.CB_SEXE.Text <> esistselect.GetInfoChamps("SEXE") And Me.CB_SEXE.Text <> "" Then
                collection_critere.Add(New Critere("SEXE", Me.CB_SEXE.Text, "ETUDIANT"))
            End If

            If Me.TXT_VILLE.Text <> esistselect.GetInfoChamps("VILLE") And Me.TXT_VILLE.Text <> "" Then
                collection_critere.Add(New Critere("VILLE", Me.TXT_VILLE.Text, "ETUDIANT"))
            End If

            If Me.CB_WILAYA.Text <> esistselect.GetInfoChamps("WILAYA") And Me.CB_WILAYA.Text <> "" Then
                collection_critere.Add(New Critere("WILAYA", Me.CB_WILAYA.Text, "ETUDIANT"))
            End If


            'If Me.CB_WILAYAB.Text <> esistselect.GetInfoChamps("WILBAC") And Me.CB_WILAYAB.Text <> "" Then
            '    collection_critere.Add(New Critere("WILBAC", Me.CB_WILAYAB.Text, "ETUDIANT"))
            'End If

            If Me.CB_WILAYAN.Text <> esistselect.GetInfoChamps("WILNAIS") And Me.CB_WILAYAN.Text <> "" Then
                collection_critere.Add(New Critere("WILNAIS", Me.CB_WILAYAN.Text, "ETUDIANT"))
            End If

            If Me.CB_WILAYANA.Text <> esistselect.GetInfoChamps("WILNAISA") And Me.CB_WILAYANA.Text <> "" Then
                collection_critere.Add(New Critere("WILNAISA", Me.CB_WILAYANA.Text, "ETUDIANT"))
            End If


            'If TXT_MOYEIN.Visible Then

            'If TXT_MOYEIN.Text <> esistselect.GetInfoChamps("MOYEIN") And TXT_MOYEIN.Text <> "" Then
            '    collection_critere.Add(New Critere("MOYEIN", Me.TXT_MOYEIN.Text, "INSCRITION"))
            'End If

            'If CB_DEC.Text <> esistselect.GetInfoChamps("DEC") And CB_DEC.Text <> "" Then
            '    collection_critere.Add(New Critere("DEC", Me.CB_DEC.Text, "INSCRITION"))
            'End If

            'If CB_DECIIN.Text <> esistselect.GetInfoChamps("DECIIN") And CB_DECIIN.Text <> "" Then
            '    collection_critere.Add(New Critere("DECIIN", Me.CB_DECIIN.Text, "INSCRITION"))
            'End If

            'If CB_RANGIN.Text <> esistselect.GetInfoChamps("RANGIN") And CB_RANGIN.Text <> "" Then
            '    collection_critere.Add(New Critere("RANGIN", Me.CB_RANGIN.Text, "INSCRITION"))
            'End If

            'If CB_MENTIN.Text <> esistselect.GetInfoChamps("RANGIN") And CB_MENTIN.Text <> "" Then
            '    collection_critere.Add(New Critere("RANGIN", Me.CB_MENTIN.Text, "INSCRITION"))
            'End If

            'If CB_ELIMININ.Text <> esistselect.GetInfoChamps("ELIMININ") And CB_ELIMININ.Text <> "" Then
            '    collection_critere.Add(New Critere("ELIMININ", Me.CB_ELIMININ.Text, "INSCRITION"))
            'End If

            'If CB_RATRIN.Text <> esistselect.GetInfoChamps("RATRIN") And CB_RATRIN.Text <> "" Then
            '    collection_critere.Add(New Critere("RATRIN", Me.CB_RATRIN.Text, "INSCRITION"))
            'End If

            'If CB_ADM.Text <> esistselect.GetInfoChamps("ADM") And CB_ADM.Text <> "" Then
            '    collection_critere.Add(New Critere("ADM", Me.CB_ADM.Text, "INSCRITION"))
            'End If

            'End If

            'If TXT_CB_codeGroupe.Visible Then
            '    If TXT_CB_codeGroupe.Text <> esistselect.GetInfoChamps("codeGroupe") And TXT_CB_codeGroupe.Text <> "" Then
            '        collection_critere.Add(New Critere("codeGroupe", Me.TXT_CB_codeGroupe.Text, "GROUP"))
            '    End If

            '    If CB_NG.Text <> esistselect.GetInfoChamps("NG") And CB_NG.Text <> "" Then
            '        collection_critere.Add(New Critere("NG", Me.CB_NG.Text, "GROUP"))
            '    End If
            'End If

            'If TXT_CodeSection.Visible Then

            '    If TXT_CodeSection.Text <> esistselect.GetInfoChamps("CodeSection") And TXT_CodeSection.Text <> "" Then
            '        collection_critere.Add(New Critere("CodeSection", Me.TXT_CodeSection.Text, "Section"))
            '    End If

            '    If CB_NS.Text <> esistselect.GetInfoChamps("NS") And CB_NS.Text <> "" Then
            '        collection_critere.Add(New Critere("NS", Me.CB_NG.Text, "Section"))
            '    End If

            'End If

            'If TXT_CodePromo.Visible Then

            '    'If TXT_CodePromo.Text <> esistselect.GetInfoChamps("CodePromo") And TXT_CodePromo.Text <> "" Then
            '    '    collection_critere.Add(New Critere("CodePromo", Me.TXT_CodePromo.Text, "PROMO"))
            '    'End If

            '    'If CB_Niveau.Text <> esistselect.GetInfoChamps("Niveau") And CB_Niveau.Text <> "" Then
            '    '    collection_critere.Add(New Critere("Niveau", Me.CB_Niveau.Text, "PROMO"))
            '    'End If

            '    'If CB_Option.Text <> esistselect.GetInfoChamps("Option") And CB_Option.Text <> "" Then
            '    '    collection_critere.Add(New Critere("Option", Me.CB_Option.Text, "PROMO"))
            '    'End If

            '    If CB_Annee.Text <> esistselect.GetInfoChamps("Annee") And CB_NS.Text <> "" Then
            '        collection_critere.Add(New Critere("Annee", Me.CB_NS.Text, "PROMO"))
            '    End If

            '    If TXT_NbreEtudiant.Text <> esistselect.GetInfoChamps("NbreEtudiant") And TXT_NbreEtudiant.Text <> "" Then
            '        collection_critere.Add(New Critere("NbreEtudiant", Me.TXT_NbreEtudiant.Text, "PROMO"))
            '    End If

            '    If TXT_Moypromo.Text <> esistselect.GetInfoChamps("Moypromo") And TXT_Moypromo.Text <> "" Then
            '        collection_critere.Add(New Critere("Moypromo", Me.TXT_Moypromo.Text, "PROMO"))
            '    End If
            'End If

            'If TXT_NOJUNO.Visible Then

            '    If TXT_NOJUNO.Text <> esistselect.GetInfoChamps("NOJUNO") And TXT_NOJUNO.Text <> "" Then
            '        collection_critere.Add(New Critere("NOJUNO", Me.TXT_NOJUNO.Text, "NOTE"))
            '    End If
            '    If TXT_NOSYNO.Text <> esistselect.GetInfoChamps("NOSYNO") And TXT_NOSYNO.Text <> "" Then
            '        collection_critere.Add(New Critere("NOSYNO", Me.TXT_NOSYNO.Text, "NOTE"))
            '    End If
            '    If TXT_NORANO.Text <> esistselect.GetInfoChamps("NORANO") And TXT_NORANO.Text <> "" Then
            '        collection_critere.Add(New Critere("NORANO", Me.TXT_NORANO.Text, "NOTE"))
            '    End If

            '    If CB_ELIMNO.Text <> esistselect.GetInfoChamps("ELIMNO") And CB_ELIMNO.Text <> "" Then
            '        collection_critere.Add(New Critere("ELIMNO", Me.CB_ELIMNO.Text, "NOTE"))
            '    End If

            '    If CB_RATRNO.Text <> esistselect.GetInfoChamps("RATRNO") And CB_RATRNO.Text <> "" Then
            '        collection_critere.Add(New Critere("RATRNO", Me.CB_RATRNO.Text, "NOTE"))
            '    End If

            'End If

            'If CB_ANSCMA.Visible Then

            '    If CB_ANSCMA.Text <> esistselect.GetInfoChamps("ANSCMA") And CB_ANSCMA.Text <> "" Then
            '        collection_critere.Add(New Critere("ANSCMA", Me.CB_ANSCMA.Text, "MATIERE"))
            '    End If

            '    If CB_ANETMA.Text <> esistselect.GetInfoChamps("ANETMA") And CB_ANETMA.Text <> "" Then
            '        collection_critere.Add(New Critere("ANETMA", Me.CB_ANETMA.Text, "MATIERE"))
            '    End If

            '    If CB_OPTIMA.Text <> esistselect.GetInfoChamps("OPTIMA") And CB_OPTIMA.Text <> "" Then
            '        collection_critere.Add(New Critere("OPTIMA", Me.CB_OPTIMA.Text, "MATIERE"))
            '    End If

            '    If CB_TYPEMA.Text <> esistselect.GetInfoChamps("TYPEMA") And CB_TYPEMA.Text <> "" Then
            '        collection_critere.Add(New Critere("TYPEMA", Me.CB_TYPEMA.Text, "MATIERE"))
            '    End If

            '    If TXT_COMAMA.Text <> esistselect.GetInfoChamps("COMAMA") And TXT_COMAMA.Text <> "" Then
            '        collection_critere.Add(New Critere("COMAMA", Me.TXT_COMAMA.Text, "MATIERE"))
            '    End If

            '    If TXT_LIBEMA.Text <> esistselect.GetInfoChamps("LIBEMA") And TXT_LIBEMA.Text <> "" Then
            '        collection_critere.Add(New Critere("LIBEMA", Me.TXT_LIBEMA.Text, "MATIERE"))
            '    End If

            '    If CB_COEFMA.Text <> esistselect.GetInfoChamps("COEFMA") And CB_COEFMA.Text <> "" Then
            '        collection_critere.Add(New Critere("COEFMA", Me.CB_COEFMA.Text, "MATIERE"))
            '    End If

            '    If TXT_MOYMAT.Text <> esistselect.GetInfoChamps("MOYMAT") And TXT_MOYMAT.Text <> "" Then
            '        collection_critere.Add(New Critere("MOYMAT", Me.TXT_MOYMAT.Text, "MATIERE"))
            '    End If

            '    If CB_CYCLMA.Text <> esistselect.GetInfoChamps("CYCLMA") And CB_CYCLMA.Text <> "" Then
            '        collection_critere.Add(New Critere("CYCLMA", Me.CB_CYCLMA.Text, "MATIERE"))
            '    End If

            'End If

            'If TXT_MOYERA.Visible Then

            '    If TXT_MOYERA.Text <> esistselect.GetInfoChamps("MOYERA") And TXT_MOYERA.Text <> "" Then
            '        collection_critere.Add(New Critere("MOYERA", Me.TXT_MOYERA.Text, "NoteRATRAP"))
            '    End If

            '    If CB_MENTRA.Text <> esistselect.GetInfoChamps("MENTRA") And CB_MENTRA.Text <> "" Then
            '        collection_critere.Add(New Critere("MENTRA", Me.CB_MENTRA.Text, "NoteRATRAP"))
            '    End If

            '    If CB_ELIMRA.Text <> esistselect.GetInfoChamps("ELIMRA") And CB_ELIMRA.Text <> "" Then
            '        collection_critere.Add(New Critere("ELIMRA", Me.CB_ELIMRA.Text, "NoteRATRAP"))
            '    End If

            '    If CB_RATRRA.Text <> esistselect.GetInfoChamps("RATRRA") And CB_RATRRA.Text <> "" Then
            '        collection_critere.Add(New Critere("RATRRA", Me.CB_RATRRA.Text, "NoteRATRAP"))
            '    End If

            'End If

            'If CB_CODERATRAT.Text <> "" Then

            '    If CB_ANSCRA.Text <> esistselect.GetInfoChamps("ANSCRA") And CB_ANSCRA.Text <> "" Then
            '        collection_critere.Add(New Critere("ANSCRA", Me.CB_ANSCRA.Text, "RATRAP"))
            '    End If

            '    If CB_ANETRA.Text <> esistselect.GetInfoChamps("ANETRA") And CB_ANETRA.Text <> "" Then
            '        collection_critere.Add(New Critere("ANETRA", Me.CB_ANETRA.Text, "RATRAP"))
            '    End If

            '    If CB_CYCLRA.Text <> esistselect.GetInfoChamps("CYCLRA") And CB_CYCLRA.Text <> "" Then
            '        collection_critere.Add(New Critere("CYCLRA", Me.CB_CYCLRA.Text, "RATRAP"))
            '    End If

            '    If CB_OPTIRA.Text <> esistselect.GetInfoChamps("OPTIRA") And CB_OPTIRA.Text <> "" Then
            '        collection_critere.Add(New Critere("OPTIRA", Me.CB_OPTIRA.Text, "RATRAP"))
            '    End If

            'End If

            If collection_critere.Any = False Then
                BT_MODIFIER.Enabled = False
                Worning.Visible = True
            End If
        End If

    End Sub

    Private Sub TXT_MATRIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MATRIN.Click
        TXT_MATRIN.Text = ""
        Worning.Visible = False
        TXT_MATRIN.BackColor = Color.White
        TXT_MATRIN.ForeColor = Color.DarkGray
    End Sub

    Private Sub TXT_MATRIC_INS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_MATRIC_INS.Click
        TXT_MATRIC_INS.Text = ""
        Worning.Visible = False
        TXT_MATRIC_INS.BackColor = Color.White
        TXT_MATRIC_INS.ForeColor = Color.DarkGray
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

    'Private Sub CB_WILAYAB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_WILAYAB.Text = ""
    '    Worning.Visible = False
    '    CB_WILAYAB.BackColor = Color.White
    '    CB_WILAYAB.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_MOYBAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_MOYBAC.Text = ""
    '    Worning.Visible = False
    '    TXT_MOYBAC.BackColor = Color.White
    '    TXT_MOYBAC.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_SERI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_SERI.Text = ""
    '    Worning.Visible = False
    '    CB_SERI.BackColor = Color.White
    '    CB_SERI.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_ANNEEB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ANNEEB.Text = ""
    '    Worning.Visible = False
    '    CB_ANNEEB.BackColor = Color.White
    '    CB_ANNEEB.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_MOYEIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_MOYEIN.Text = ""
    '    Worning.Visible = False
    '    TXT_MOYEIN.BackColor = Color.White
    '    TXT_MOYEIN.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_RANGIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_RANGIN.Text = ""
    '    Worning.Visible = False
    '    CB_RANGIN.BackColor = Color.White
    '    CB_RANGIN.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_MENTIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'CB_MENTIN.Text = ""
    '    Worning.Visible = False
    '    CB_MENTIN.BackColor = Color.White
    '    CB_MENTIN.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_ELIMININ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ELIMININ.Text = ""
    '    Worning.Visible = False
    '    CB_ELIMININ.BackColor = Color.White
    '    CB_ELIMININ.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_RATRIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_RATRIN.Text = ""
    '    Worning.Visible = False
    '    CB_RATRIN.BackColor = Color.White
    '    CB_RATRIN.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_DEC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_DEC.Text = ""
    '    Worning.Visible = False
    '    CB_DEC.BackColor = Color.White
    '    CB_DEC.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_DECIIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_DECIIN.Text = ""
    '    Worning.Visible = False
    '    CB_DECIIN.BackColor = Color.White
    '    CB_DECIIN.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_ADM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ADM.Text = ""
    '    Worning.Visible = False
    '    CB_ADM.BackColor = Color.White
    '    CB_ADM.ForeColor = Color.DarkGray
    'End Sub

    Private Sub TXT_CB_codeGroupe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TXT_CB_codeGroupe.Text = ""
        Worning.Visible = False
        'TXT_CB_codeGroupe.BackColor = Color.White
        'TXT_CB_codeGroupe.ForeColor = Color.DarkGray
    End Sub

    'Private Sub CB_NG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'CB_NG.Text = ""
    '    'Worning.Visible = False
    '    'CB_NG.BackColor = Color.White
    '    'CB_NG.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_CodeSection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_CodeSection.Text = ""
    '    Worning.Visible = False
    '    TXT_CodeSection.BackColor = Color.White
    '    TXT_CodeSection.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_NS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_NS.Text = ""
    '    Worning.Visible = False
    '    CB_NS.BackColor = Color.White
    '    CB_NS.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_CodePromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_CodePromo.Text = ""
    '    Worning.Visible = False
    '    TXT_CodePromo.BackColor = Color.White
    '    TXT_CodePromo.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_Niveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_Niveau.Text = ""
    '    Worning.Visible = False
    '    CB_Niveau.BackColor = Color.White
    '    CB_Niveau.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_Option_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_Option.Text = ""
    '    Worning.Visible = False
    '    CB_Option.BackColor = Color.White
    '    CB_Option.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_Annee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_Annee.Text = ""
    '    Worning.Visible = False
    '    CB_Annee.BackColor = Color.White
    '    CB_Annee.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_NbreEtudiant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_NbreEtudiant.Text = ""
    '    Worning.Visible = False
    '    TXT_NbreEtudiant.BackColor = Color.White
    '    TXT_NbreEtudiant.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_Moypromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_Moypromo.Text = ""
    '    Worning.Visible = False
    '    TXT_Moypromo.BackColor = Color.White
    '    TXT_Moypromo.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_NOJUNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_NOJUNO.Text = ""
    '    Worning.Visible = False
    '    TXT_NOJUNO.BackColor = Color.White
    '    TXT_NOJUNO.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_NOSYNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_NOSYNO.Text = ""
    '    Worning.Visible = False
    '    TXT_NOSYNO.BackColor = Color.White
    '    TXT_NOSYNO.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_NORANO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_NORANO.Text = ""
    '    Worning.Visible = False
    '    TXT_NORANO.BackColor = Color.White
    '    TXT_NORANO.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_ELIMNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ELIMNO.Text = ""
    '    Worning.Visible = False
    '    CB_ELIMNO.BackColor = Color.White
    '    CB_ELIMNO.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_RATRNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_RATRNO.Text = ""
    '    Worning.Visible = False
    '    CB_RATRNO.BackColor = Color.White
    '    CB_RATRNO.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_ANSCMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ANSCMA.Text = ""
    '    Worning.Visible = False
    '    CB_ANSCMA.BackColor = Color.White
    '    CB_ANSCMA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_ANETMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ANETMA.Text = ""
    '    Worning.Visible = False
    '    CB_ANETMA.BackColor = Color.White
    '    CB_ANETMA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_OPTIMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_OPTIMA.Text = ""
    '    Worning.Visible = False
    '    CB_OPTIMA.BackColor = Color.White
    '    CB_OPTIMA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_COMAMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_COMAMA.Text = ""
    '    Worning.Visible = False
    '    TXT_COMAMA.BackColor = Color.White
    '    TXT_COMAMA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_LIBEMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_LIBEMA.Text = ""
    '    Worning.Visible = False
    '    TXT_LIBEMA.BackColor = Color.White
    '    TXT_LIBEMA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_TYPEMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_TYPEMA.Text = ""
    '    Worning.Visible = False
    '    CB_TYPEMA.BackColor = Color.White
    '    CB_TYPEMA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_COEFMA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_COEFMA.Text = ""
    '    Worning.Visible = False
    '    CB_COEFMA.BackColor = Color.White
    '    CB_COEFMA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_MOYMAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_MOYMAT.Text = ""
    '    Worning.Visible = False
    '    TXT_MOYMAT.BackColor = Color.White
    '    TXT_MOYMAT.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_CYCLMA_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_CYCLMA.Text = ""
    '    Worning.Visible = False
    '    CB_CYCLMA.BackColor = Color.White
    '    CB_CYCLMA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub TXT_MOYERA_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_MOYERA.Text = ""
    '    Worning.Visible = False
    '    TXT_MOYERA.BackColor = Color.White
    '    TXT_MOYERA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_MENTRA_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_MENTRA.Text = ""
    '    Worning.Visible = False
    '    CB_MENTRA.BackColor = Color.White
    '    CB_MENTRA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_ELIMRA_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ELIMRA.Text = ""
    '    Worning.Visible = False
    '    CB_ELIMRA.BackColor = Color.White
    '    CB_ELIMRA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_RATRRA_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_RATRRA.Text = ""
    '    Worning.Visible = False
    '    CB_RATRRA.BackColor = Color.White
    '    CB_RATRRA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_ANSCRA_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ANSCRA.Text = ""
    '    Worning.Visible = False
    '    CB_ANSCRA.BackColor = Color.White
    '    CB_ANSCRA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_ANETRA_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ANETRA.Text = ""
    '    Worning.Visible = False
    '    CB_ANETRA.BackColor = Color.White
    '    CB_ANETRA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_CYCLRA_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_CYCLRA.Text = ""
    '    Worning.Visible = False
    '    CB_CYCLRA.BackColor = Color.White
    '    CB_CYCLRA.ForeColor = Color.DarkGray
    'End Sub

    'Private Sub CB_OPTIRA_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_OPTIRA.Text = ""
    '    Worning.Visible = False
    '    CB_OPTIRA.BackColor = Color.White
    '    CB_OPTIRA.ForeColor = Color.DarkGray
    'End Sub


    Private Sub TXT_DATENAIS_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DATENAIS.Click
        TXT_DATENAIS.Visible = False
        DTP_DATENAIS.Visible = True
        Worning.Visible = False
        TXT_DATENAIS.BackColor = Color.White
        TXT_DATENAIS.ForeColor = Color.DarkGray
        DTP_DATENAIS.ForeColor = Color.DarkGray
    End Sub


    Private Sub TXT_MATRIN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MATRIN.MouseLeave
        If TXT_MATRIN.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_MATRIN.Text = esistselect.GetInfoChamps("MATRIN")
        End If
        TXT_MATRIN.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_MATRIC_INS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_MATRIC_INS.MouseLeave
        If TXT_MATRIC_INS.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_MATRIC_INS.Text = esistselect.GetInfoChamps("MATRIC_INS")
        End If
        TXT_MATRIC_INS.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_NomEtud_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NomEtud.MouseLeave
        If TXT_NomEtud.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_NomEtud.Text = esistselect.GetInfoChamps("NomEtud")
        End If
        TXT_NomEtud.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_Prenoms_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_Prenoms.MouseLeave
        If TXT_Prenoms.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_Prenoms.Text = esistselect.GetInfoChamps("Prenoms")
        End If
        TXT_Prenoms.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_NomEtudA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NomEtudA.MouseLeave
        If TXT_NomEtudA.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_NomEtudA.Text = esistselect.GetInfoChamps("NomEtudA")
        End If
        TXT_NomEtudA.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_PrenomsA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PrenomsA.MouseLeave
        If TXT_PrenomsA.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_PrenomsA.Text = esistselect.GetInfoChamps("PrenomsA")
        End If
        TXT_PrenomsA.ForeColor = Color.DimGray
    End Sub

    Private Sub CB_SEXE_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SEXE.MouseLeave
        If CB_SEXE.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.CB_SEXE.Text = esistselect.GetInfoChamps("SEXE")
        End If
        CB_SEXE.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_FILSDE_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_FILSDE.MouseLeave
        If TXT_FILSDE.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_FILSDE.Text = esistselect.GetInfoChamps("FILS_DE")
        End If
        TXT_FILSDE.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_ETDE_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ETDE.MouseLeave
        If TXT_ETDE.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_ETDE.Text = esistselect.GetInfoChamps("ET_DE")
        End If
        TXT_ETDE.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_LIEUNA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUN.MouseLeave
        If TXT_LIEUNA.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_LIEUNA.Text = esistselect.GetInfoChamps("LieuNaisA")
        End If
        TXT_LIEUNA.ForeColor = Color.DimGray
    End Sub

    Private Sub CB_WILAYAN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYAN.MouseLeave
        If CB_WILAYAN.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.CB_WILAYAN.Text = esistselect.GetInfoChamps("WILNAIS")
        End If
        CB_WILAYAN.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_LIEUN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUNA.MouseLeave
        If TXT_LIEUN.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_LIEUN.Text = esistselect.GetInfoChamps("LieuNais")
        End If
        TXT_LIEUN.ForeColor = Color.DimGray
    End Sub

    Private Sub CB_WILAYANA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYANA.MouseLeave
        If CB_WILAYANA.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.CB_WILAYANA.Text = esistselect.GetInfoChamps("WILNAISA")
        End If
        CB_WILAYANA.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_ADR_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ADR.MouseLeave
        If TXT_ADR.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_ADR.Text = esistselect.GetInfoChamps("ADRESSE")
        End If
        TXT_ADR.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_VILLE_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_VILLE.MouseLeave
        If TXT_VILLE.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_VILLE.Text = esistselect.GetInfoChamps("VILLE")
        End If
        TXT_VILLE.ForeColor = Color.DimGray
    End Sub

    Private Sub CB_WILAYA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYA.MouseLeave
        If CB_WILAYA.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.CB_WILAYA.Text = esistselect.GetInfoChamps("WILAYA")
        End If
        CB_WILAYA.ForeColor = Color.DimGray
    End Sub

    Private Sub TXT_CODEPOS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CODEPOS.MouseLeave
        If TXT_CODEPOS.Text <> "" Then
            BT_MODIFIER.Enabled = True
        Else
            Me.TXT_CODEPOS.Text = esistselect.GetInfoChamps("CODPOST")
        End If
        TXT_CODEPOS.ForeColor = Color.DimGray
    End Sub

    'Private Sub CB_WILAYAB_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_WILAYAB.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        Me.CB_WILAYAB.Text = esistselect.GetInfoChamps("WILBAC")
    '    End If
    '    CB_WILAYAB.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_MOYBAC_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_MOYBAC.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        Me.TXT_MOYBAC.Text = esistselect.GetInfoChamps("MOYBAC")
    '    End If
    '    TXT_MOYBAC.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_SERI_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_SERI.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        Me.CB_SERI.Text = esistselect.GetInfoChamps("SERIEBAC")
    '    End If
    '    CB_SERI.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_ANNEEB_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ANNEEB.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        Me.CB_ANNEEB.Text = esistselect.GetInfoChamps("ANNEEBAC")
    '    End If
    '    CB_ANNEEB.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_MOYEIN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_MOYEIN.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_MOYEIN.Text = esistselect.GetInfoChamps("MOYEIN")
    '    End If
    '    TXT_MOYEIN.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_RANGIN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_RANGIN.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_RANGIN.Text = esistselect.GetInfoChamps("RANGIN")
    '    End If
    '    CB_RANGIN.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_MENTIN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_MENTIN.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_MENTIN.Text = esistselect.GetInfoChamps("MENTIN")
    '    End If
    '    CB_MENTIN.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_ELIMININ_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ELIMININ.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_ELIMININ.Text = esistselect.GetInfoChamps("ELIMININ")
    '    End If
    '    CB_ELIMININ.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_RATRIN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_RATRIN.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_RATRIN.Text = esistselect.GetInfoChamps("RATRIN")
    '    End If
    '    CB_RATRIN.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_DEC_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_DEC.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_DEC.Text = esistselect.GetInfoChamps("DEC")
    '    End If
    '    CB_DEC.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_DECIIN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_DECIIN.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_DECIIN.Text = esistselect.GetInfoChamps("DECIIN")
    '    End If
    '    CB_DECIIN.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_ADM_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ADM.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_ADM.Text = esistselect.GetInfoChamps("ADM")
    '    End If
    '    CB_ADM.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_CB_codeGroupe_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_CB_codeGroupe.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_CB_codeGroupe.Text = esistselect.GetInfoChamps("CB")
    '    End If
    '    TXT_CB_codeGroupe.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_NG_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_NG.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_CB_codeGroupe.Text = esistselect.GetInfoChamps("CB")
    '    End If
    '    TXT_CB_codeGroupe.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_CodeSection_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_CodeSection.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_CodeSection.Text = esistselect.GetInfoChamps("CodeSection")
    '    End If
    '    TXT_CodeSection.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_NS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_NS.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_NS.Text = esistselect.GetInfoChamps("NS")
    '    End If
    '    CB_NS.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_CodePromo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_CodePromo.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_CodePromo.Text = esistselect.GetInfoChamps("CodePromo")
    '    End If
    '    TXT_CodePromo.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_Niveau_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_Niveau.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_Niveau.Text = esistselect.GetInfoChamps("Niveau")
    '    End If
    '    CB_Niveau.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_Option_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_Option.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_Option.Text = esistselect.GetInfoChamps("Option")
    '    End If
    '    CB_Option.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_Annee_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_Annee.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_Annee.Text = esistselect.GetInfoChamps("Annee")
    '    End If
    '    CB_Annee.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_NbreEtudiant_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_NbreEtudiant.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_NbreEtudiant.Text = esistselect.GetInfoChamps("NbreEtudiant")
    '    End If
    '    TXT_NbreEtudiant.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_Moypromo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_Moypromo.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_Moypromo.Text = esistselect.GetInfoChamps("Moypromo")
    '    End If
    '    TXT_Moypromo.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_NOJUNO_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_NOJUNO.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_NOJUNO.Text = esistselect.GetInfoChamps("NOJUNO")
    '    End If
    '    TXT_NOJUNO.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_NOSYNO_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_NOSYNO.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_NOSYNO.Text = esistselect.GetInfoChamps("NOSYNO")
    '    End If
    '    TXT_NOSYNO.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_NORANO_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_NORANO.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_NORANO.Text = esistselect.GetInfoChamps("NORANO")
    '    End If
    '    TXT_NORANO.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_ELIMNO_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ELIMNO.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_ELIMNO.Text = esistselect.GetInfoChamps("ELIMNO")
    '    End If
    '    CB_ELIMNO.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_RATRNO_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_RATRNO.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_RATRNO.Text = esistselect.GetInfoChamps("RATRNO")
    '    End If
    '    CB_RATRNO.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_ANSCMA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ANSCMA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_ANSCMA.Text = esistselect.GetInfoChamps("ANSCMA")
    '    End If
    '    CB_ANSCMA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_ANETMA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ANETMA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_ANETMA.Text = esistselect.GetInfoChamps("ANETMA")
    '    End If
    '    CB_ANETMA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_OPTIMA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_OPTIMA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_OPTIMA.Text = esistselect.GetInfoChamps("OPTIMA")
    '    End If
    '    CB_OPTIMA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_COMAMA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_COMAMA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_COMAMA.Text = esistselect.GetInfoChamps("COMAMA")
    '    End If
    '    TXT_COMAMA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_LIBEMA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_LIBEMA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_LIBEMA.Text = esistselect.GetInfoChamps("LIBEMA")
    '    End If
    '    TXT_LIBEMA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_TYPEMA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_TYPEMA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_TYPEMA.Text = esistselect.GetInfoChamps("TYPEMA")
    '    End If
    '    CB_TYPEMA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_COEFMA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_COEFMA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_COEFMA.Text = esistselect.GetInfoChamps("COEFMA")
    '    End If
    '    CB_COEFMA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_MOYMAT_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_MOYMAT.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_MOYMAT.Text = esistselect.GetInfoChamps("MOYMAT")
    '    End If
    '    TXT_MOYMAT.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_CYCLMA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_CYCLMA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_CYCLMA.Text = esistselect.GetInfoChamps("CYCLMA")
    '    End If
    '    CB_CYCLMA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub TXT_MOYERA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TXT_MOYERA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        TXT_MOYERA.Text = esistselect.GetInfoChamps("MOYERA")
    '    End If
    '    TXT_MOYERA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_MENTRA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_MENTRA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_MENTRA.Text = esistselect.GetInfoChamps("MENTRA")
    '    End If
    '    CB_MENTRA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_ELIMRA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ELIMRA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_ELIMRA.Text = esistselect.GetInfoChamps("ELIMRA")
    '    End If
    '    CB_ELIMRA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_RATRRA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_RATRRA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_RATRRA.Text = esistselect.GetInfoChamps("RATRRA")
    '    End If
    '    CB_RATRRA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_ANSCRA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ANSCRA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_ANSCRA.Text = esistselect.GetInfoChamps("ANSCRA")
    '    End If
    '    CB_ANSCRA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_ANETRA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_ANETRA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_ANETRA.Text = esistselect.GetInfoChamps("ANETRA")
    '    End If
    '    CB_ANETRA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_CYCLRA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_CYCLRA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_CYCLRA.Text = esistselect.GetInfoChamps("CYCLRA")
    '    End If
    '    CB_CYCLRA.ForeColor = Color.DimGray
    'End Sub

    'Private Sub CB_OPTIRA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CB_OPTIRA.Text <> "" Then
    '        BT_MODIFIER.Enabled = True
    '    Else
    '        CB_OPTIRA.Text = esistselect.GetInfoChamps("OPTIRA")
    '    End If
    '    CB_OPTIRA.ForeColor = Color.DimGray
    'End Sub

    Private Sub DTP_DATENAIS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_DATENAIS.MouseLeave
        If DTP_DATENAIS.Text <> "" And Me.DTP_DATENAIS.Text <> esistselect.GetInfoChamps("DateNais") Then
            BT_MODIFIER.Enabled = True
            TXT_DATENAIS.Text = DTP_DATENAIS.Text
        Else
            TXT_DATENAIS.Text = esistselect.GetInfoChamps("DateNais")
        End If
        DTP_DATENAIS.Visible = False
        TXT_DATENAIS.Visible = True
        'CB_OPTIRA.ForeColor = Color.DimGray
    End Sub


    Private Sub TXT_MATRIN_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MATRIN.MouseHover
        TXT_MATRIN.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TXT_MATRIC_INS_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_MATRIC_INS.MouseHover
        TXT_MATRIC_INS.BackColor = Color.WhiteSmoke
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

    'Private Sub CB_WILAYAB_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_WILAYAB.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_MOYBAC_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_MOYBAC.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_SERI_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_SERI.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_ANNEEB_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ANNEEB.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_MOYEIN_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_MOYEIN.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_RANGIN_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_RANGIN.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_MENTIN_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_MENTIN.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_ELIMININ_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ELIMININ.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_RATRIN_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_RATRIN.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_DEC_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_DEC.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_DECIIN_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_DECIIN.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_ADM_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ADM.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_CB_codeGroupe_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_CB_codeGroupe.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_NG_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_NG.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_CodeSection_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_CodeSection.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_NS_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_NS.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_CodePromo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_CodePromo.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_Niveau_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_Niveau.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_Option_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_Option.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_Annee_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_Annee.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_NbreEtudiant_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_NbreEtudiant.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_Moypromo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_Moypromo.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_NOJUNO_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_NOJUNO.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_NOSYNO_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_NOSYNO.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_NORANO_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_NORANO.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_ELIMNO_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ELIMNO.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_RATRNO_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_RATRNO.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_ANSCMA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ANSCMA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_ANETMA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ANETMA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_OPTIMA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_OPTIMA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_COMAMA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_COMAMA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_LIBEMA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_LIBEMA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_TYPEMA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_TYPEMA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_COEFMA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_COEFMA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_MOYMAT_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_MOYMAT.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_CYCLMA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_CYCLMA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub TXT_MOYERA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TXT_MOYERA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_MENTRA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_MENTRA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_ELIMRA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ELIMRA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_RATRRA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_RATRRA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_ANSCRA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ANSCRA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_ANETRA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_ANETRA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_CYCLRA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_CYCLRA.BackColor = Color.WhiteSmoke
    'End Sub

    'Private Sub CB_OPTIRA_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CB_OPTIRA.BackColor = Color.WhiteSmoke
    'End Sub

    Private Sub txt_DATENAIS_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DATENAIS.MouseHover
        TXT_DATENAIS.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BT_RATRAP_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_INFORESIDENCE.MouseHover, BT_GENERALINFO.MouseHover
        For Each ctrl In Panel3.Controls
            CType(ctrl, Control).Padding = New Padding(5, 0, 0, 0)
        Next
        CType(sender, Control).Padding = New Padding(25, 0, 0, 0)
    End Sub

    Private Sub BT_SORTIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SORTIR.Click
        Me.Close()
        'Home.f.Show()
        Home.MainContainer2.Visible = False
        Home.MainContainer1.Visible = True
    End Sub
End Class
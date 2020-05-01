Public Class RechercherPage

    Private dtp_changed As Boolean

    Private Sub recherche_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i As Integer

        'insialize the worning messages
        Me.worningrech.Visible = False
        'Me.IMG_ALERTCODPOS.Visible = False
        Me.IMG_ALERTMAT.Visible = False
        Me.IMG_ALERTMOY.Visible = False
        Me.IMG_ALERTMTB.Visible = False

        'insialize the date time picker to not checked
        Me.dtp_changed = False

        ' initilize recherche form

        splitermain.splitterdistance = 25

        ' make the two containers collapse at the beginning
        With splitcontainer1
            .panel1collapsed = False
            .panel2collapsed = True
        End With

        With splitcontainer2
            .panel1collapsed = False
            .panel2collapsed = True
        End With
        ' make the arabic flanuge checked at the beggining
        RechButtons.Location = New System.Drawing.Point(25, 605)

        Me.PN_FORUMRECH.Dock = DockStyle.Fill   ' dock the seach form in the parent container

        'initialiser :

        'inisialiser les wilayas combobox


        Me.CB_WILAYAB.DisplayMember = Login.Infosgenerale.wilaya.Columns(0).ToString
        Me.CB_WILAYA.DisplayMember = Login.Infosgenerale.wilaya.Columns(0).ToString
        Me.CB_WILAYAN.DisplayMember = Login.Infosgenerale.codewilaya.Columns(0).ToString
        Me.CB_WILAYANA.DisplayMember = Login.Infosgenerale.wilaya.Columns(0).ToString


        Me.CB_WILAYAB.ValueMember = Login.Infosgenerale.wilaya.Columns(0).ToString
        Me.CB_WILAYA.ValueMember = Login.Infosgenerale.wilaya.Columns(0).ToString
        Me.CB_WILAYAN.ValueMember = Login.Infosgenerale.codewilaya.Columns(0).ToString
        Me.CB_WILAYANA.ValueMember = Login.Infosgenerale.wilaya.Columns(0).ToString

        Me.CB_WILAYAB.DataSource = Login.Infosgenerale.wilaya
        Me.CB_WILAYA.DataSource = Login.Infosgenerale.wilaya
        Me.CB_WILAYAN.DataSource = Login.Infosgenerale.codewilaya
        Me.CB_WILAYANA.DataSource = Login.Infosgenerale.wilaya


        'inisialize sexe combobox 

        For Each Critere As String In InfosGenerales.sexe
            Me.CB_SEXE.Items.Add(Critere)
        Next

        'inisialize seri de bac combobox 

        Me.CB_SERI.ValueMember = Login.Infosgenerale.seribac.Columns(0).ToString
        Me.CB_SERI.DisplayMember = Login.Infosgenerale.seribac.Columns(0).ToString
        Me.CB_SERI.DataSource = Login.Infosgenerale.seribac

        'inisialize annee de bac combobox 

        'For Each Critere As String In Login.Infosgenerale.anneebac
        '    Me.CB_ANNEEB.Items.Add(Critere)
        'Next
        For i = InfosGenerales.firstYear To InfosGenerales.lastYear
            Me.CB_ANNEEB.Items.Add(i)
        Next

        ' fin initilize recherche form
    End Sub

    Private Sub BT_LANCERRECH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LANCERRECH.Click

        Dim i As Integer


        'les exeptions possibles

        'no research if he had fill nothing

        If Me.TXT_MATRICUL.Text = "" And Me.TXT_MATRICULB.Text = "" And Me.TXT_MOYBAC.Text = "" And Me.TXT_NOM.Text = "" And Me.TXT_NOMA.Text = "" And Me.TXT_PRENOM.Text = "" And Me.TXT_PRENOMA.Text = "" And Me.CB_ANNEEB.Text = "" And Me.CB_SERI.Text = "" And Me.CB_SEXE.Text = "" And Me.CB_WILAYA.Text = "" And Me.CB_WILAYAB.Text = "" And Me.CB_WILAYAN.Text = "" And Me.CB_WILAYANA.Text = "" And Me.dtp_changed = False And TXT_MERE.Text = "" And TXT_PERE.Text = "" Then
            Me.worningrech.Visible = True
            Me.worningrech.Text = "Vous devez remplir en mois un champs !"
        Else

            'no research if he had fill the long fealds with des chaines de char

            'exeption pour le matricule

            If Me.TXT_MATRICUL.Text <> "" Then
                i = 0
                While i < TXT_MATRICUL.Text.Length And Me.worningrech.Visible = False
                    If Me.TXT_MATRICUL.Text(i) > "9" Or Me.TXT_MATRICUL.Text(i) < "0" Then
                        If Me.TXT_MATRICUL.Text(i) <> "/" Then
                            Me.worningrech.Visible = True
                            Me.worningrech.Text = "Vous devez remplir les champs correctement !"
                            Me.IMG_ALERTMAT.Visible = True
                        End If
                    End If
                    i = i + 1
                End While
            End If

            'exeption pour le matricul du bac
            If Me.TXT_MATRICULB.Text <> "" Then
                i = 0
                While i < TXT_MATRICULB.Text.Length And Me.worningrech.Visible = False
                    If Me.TXT_MATRICULB.Text(i) > "9" Or Me.TXT_MATRICULB.Text(i) < "0" Then
                        If Me.TXT_MATRICULB.Text(i) <> "/" Then
                            Me.worningrech.Visible = True
                            Me.worningrech.Text = "Vous devez remplir les champs correctement !"
                            Me.IMG_ALERTMTB.Visible = True
                        End If
                    End If
                    i = i + 1
                End While
            End If

            'exeption pour la moyenne du bac
            If Me.TXT_MOYBAC.Text <> "" Then
                i = 0
                While i < TXT_MOYBAC.Text.Length And Me.worningrech.Visible = False
                    If Me.TXT_MOYBAC.Text(i) > "9" Or Me.TXT_MOYBAC.Text(i) < "0" Then
                        If Me.TXT_MOYBAC.Text(i) <> "." Then
                            Me.worningrech.Visible = True
                            Me.worningrech.Text = "Vous devez remplir les champs correctement !"
                            Me.IMG_ALERTMOY.Visible = True
                        End If
                    End If
                    i = i + 1
                End While
            End If

            'exeption pour le code postal
            'If Me.TXT_CODEPOS.Text <> "" Then
            'i = 0
            'While i < TXT_CODEPOS.Text.Length And Me.worningrech.Visible = False
            'If Me.TXT_CODEPOS.Text(i) > "9" Or Me.TXT_CODEPOS.Text(i) < "0" Then
            'Me.worningrech.Visible = True
            ' Me.worningrech.Text = "Vous devez remplir les champs correctement !"
            'Me.IMG_ALERTCODPOS.Visible = True
            'End If
            'i = i + 1
            'End While
            'End If

            'filling la collections des crietere

            Dim collection_critere As New List(Of Critere)

            If (Me.worningrech.Visible = False And Me.IMG_ALERTMOY.Visible = False And Me.IMG_ALERTMTB.Visible = False And Me.IMG_ALERTMAT.Visible = False) Then

                If Me.TXT_NOM.Text <> "" Then
                    collection_critere.Add(New Critere("NomEtud", Me.TXT_NOM.Text))
                End If

                If Me.TXT_NOMA.Text <> "" Then
                    collection_critere.Add(New Critere("NomEtudA", Me.TXT_NOMA.Text))
                End If

                If Me.TXT_PRENOMA.Text <> "" Then
                    collection_critere.Add(New Critere("PrenomsA", Me.TXT_PRENOMA.Text))
                End If

                If Me.TXT_PRENOM.Text <> "" Then
                    collection_critere.Add(New Critere("Prenoms", Me.TXT_PRENOM.Text))
                End If

                If Me.TXT_MATRICULB.Text <> "" Then
                    collection_critere.Add(New Critere("MATRIC_INS", Me.TXT_MATRICULB.Text))
                End If

                If Me.TXT_MATRICUL.Text <> "" Then
                    collection_critere.Add(New Critere("MATRIN", Me.TXT_MATRICUL.Text))
                End If

                If dtp_changed = True Then
                    Label1.Text = Me.DTP_DATEN.Text
                    collection_critere.Add(New Critere("DateNais", Me.DTP_DATEN.Text))


                End If

                'If Me.TXT_LIEUNA.Text <> "" Then
                '    collection_critere.Add(New Critere("LieuNaisA", Me.TXT_LIEUNA.Text))
                'End If

                'If Me.TXT_LIEUN.Text <> "" Then
                '    collection_critere.Add(New Critere("LieuNais", Me.TXT_LIEUN.Text))
                'End If

                If Me.CB_WILAYANA.Text <> "" Then
                    collection_critere.Add(New Critere("WilayaNaisA", Me.CB_WILAYANA.Text))
                End If

                If Me.CB_WILAYAN.Text <> "" Then
                    collection_critere.Add(New Critere("WILNAIS", Me.CB_WILAYAN.Text)) ' numerique
                End If

                'If  <> "" Then
                '    collection_critere.Add(New Critere("ADRESSE", Me.TXT_ADR.Text))
                'End If

                'If Me.TXT_VILLE.Text <> "" Then
                '    collection_critere.Add(New Critere("VILLE", Me.TXT_VILLE.Text))
                'End If

                If Me.CB_WILAYA.Text <> "" Then
                    collection_critere.Add(New Critere("WILAYA", Me.CB_WILAYA.Text))
                End If

                'If Me.TXT_CODEPOS.Text <> "" Then
                '    collection_critere.Add(New Critere("CODEPOS", Me.TXT_CODEPOS.Text))
                'End If

                If Me.CB_SEXE.Text <> "" Then
                    collection_critere.Add(New Critere("SEXE", (Me.CB_SEXE.SelectedIndex + 1).ToString))
                End If

                If Me.CB_SERI.Text <> "" Then
                    collection_critere.Add(New Critere("SERIEBAC", Me.CB_SERI.Text))
                End If

                If Me.TXT_MOYBAC.Text <> "" Then
                    collection_critere.Add(New Critere("MOYBAC", Me.TXT_MOYBAC.Text))
                End If

                If Me.CB_ANNEEB.Text <> "" Then
                    collection_critere.Add(New Critere("ANNEEBAC", CB_ANNEEB.Text))
                End If

                If Me.CB_WILAYAB.Text <> "" Then
                    collection_critere.Add(New Critere("WILBAC", Me.CB_WILAYAB.Text))
                End If

                If Me.TXT_MERE.Text <> "" Then
                    collection_critere.Add(New Critere("ET_DE", Me.TXT_MERE.Text))
                End If

                If Me.TXT_PERE.Text <> "" Then
                    collection_critere.Add(New Critere("FILS_DE", Me.TXT_PERE.Text))
                End If

                'handling the appearnce of the affichage form
                Home.PictureBox2.Size = Home.PictureBox2.MinimumSize
                'PN_FORUMRECH
                PN_FORUMRECH.Visible = False
                Home.PictureBox2.Size = New System.Drawing.Size(226, 0)
                Home.ProgressPanel.Visible = True

                ' backgroundWorker1
                BackgroundWorker1.WorkerReportsProgress = True
                BackgroundWorker1.WorkerSupportsCancellation = True
                BackgroundWorker1.RunWorkerAsync(collection_critere)

            End If
            ' appel a traite rechercher

        End If
    End Sub

    Private Sub ResidenceLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResidenceLabel.Click
        'handle the residence caterorie label click
        SpliterMain.SplitterDistance = IIf(SplitContainer1.Panel2Collapsed, 190, 25)    'adjust the spliter distance
        SplitContainer1.Panel2Collapsed = Not SplitContainer1.Panel2Collapsed           'reverse the collapse state
        ResidenceLabel.ImageIndex = IIf(SplitContainer1.Panel2Collapsed, 0, 1)          'change the arrow image
        RechButtons.Location = New Point(25, RechButtons.Location.Y + IIf(SplitContainer1.Panel2Collapsed, -180, 180)) 'adjust the search button position
    End Sub

    'handle the residence caterorie label click
    Private Sub BACLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACLabel.Click
        SplitContainer2.Panel2Collapsed = Not SplitContainer2.Panel2Collapsed
        BACLabel.ImageIndex = IIf(SplitContainer2.Panel2Collapsed, 0, 1)
        RechButtons.Location = New Point(25, RechButtons.Location.Y + IIf(SplitContainer2.Panel2Collapsed, -200, 200))
        'RechButtons.Location = New Point(25, SplitContainer2.Panel2.ClientRectangle.Bottom)
    End Sub

    Private Sub DTP_DATEN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_DATEN.ValueChanged, DTP_DATEN.GotFocus, DTP_DATEN.Click
        Me.dtp_changed = True
    End Sub

    Private Sub TXT_LIEUN_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_MATRICUL_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MATRICUL.GotFocus, TXT_MATRICUL.TextChanged, TXT_MATRICUL.Click
        Me.worningrech.Visible = False
        Me.IMG_ALERTMAT.Visible = False
    End Sub

    Private Sub TXT_LIEUNA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_MATRICULB_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MATRICULB.GotFocus, TXT_MATRICULB.TextChanged, TXT_MATRICULB.Click
        Me.worningrech.Visible = False
        Me.IMG_ALERTMTB.Visible = False
    End Sub

    Private Sub TXT_NOM_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NOM.GotFocus, TXT_NOM.TextChanged, TXT_NOM.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_PRENOM_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PRENOM.GotFocus, TXT_PRENOM.TextChanged, TXT_PRENOM.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_NOMA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NOMA.GotFocus, TXT_NOMA.TextChanged, TXT_NOMA.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_PRENOMA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PRENOMA.GotFocus, TXT_PRENOMA.TextChanged, TXT_PRENOMA.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub CB_SEXE_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SEXE.GotFocus, CB_SEXE.TextChanged, CB_SEXE.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub CB_WILAYANA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYANA.GotFocus, CB_WILAYANA.TextChanged, CB_WILAYANA.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub CB_WILAYAN_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYAN.GotFocus, CB_WILAYAN.TextChanged, CB_WILAYAN.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_ADR_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_VILLE_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.worningrech.Visible = False
    End Sub

    Private Sub CB_WILAYA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYA.GotFocus, CB_WILAYA.TextChanged, CB_WILAYA.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_CODEPOS_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.worningrech.Visible = False
        'Me.IMG_ALERTCODPOS.Visible = False
    End Sub

    Private Sub CB_WILAYAB_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYAB.GotFocus, CB_WILAYAB.TextChanged, CB_WILAYAB.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_MOYBAC_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MOYBAC.GotFocus, TXT_MOYBAC.TextChanged, TXT_MOYBAC.Click
        Me.worningrech.Visible = False
        Me.IMG_ALERTMOY.Visible = False
    End Sub

    Private Sub CB_SERI_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SERI.GotFocus, CB_SERI.TextChanged, CB_SERI.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub CB_ANNEEB_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ANNEEB.GotFocus, CB_ANNEEB.TextChanged, CB_ANNEEB.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ' Do some time-consuming work on this thread.
        Dim worker As System.ComponentModel.BackgroundWorker = DirectCast(sender, System.ComponentModel.BackgroundWorker)
        Dim collection_critere As List(Of Critere) = CType(e.Argument, List(Of Critere))
        Try
            e.Result = search_inBackground(worker, e, collection_critere)
        Catch ex As NullReferenceException
            e.Cancel = True
        End Try
        If worker.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ' Called when the BackgroundWorker is completed.
        If e.Cancelled Then
            Home.ProgressPanel.Visible = False
            PN_FORUMRECH.Visible = True
        Else
            'Form1.DataGridView1.DataSource = e.Result
            'Form1.Activate()
            'Form1.Show()
            Me.Close()
            Home.f = New affichResearchResult(e.Result)         ' assign the search form to  the f form
        End If

        Home.f.TopLevel = False
        Home.f.TopMost = True
        Home.f.WindowState = FormWindowState.Normal
        Home.MainContainer1.Controls.Add(Home.f)        ' add the controlers of the searche page to the main form f 
        Home.f.Show()                                ' show the form f in the middle of the home page
        
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'ProgressLabel.Text = e.ProgressPercentage.ToString + "%"
        'PictureBox2.Size = New System.Drawing.Size(226, (e.ProgressPercentage * (PictureBox2.MaximumSize.Height)) \ 100)
    End Sub

    Private Function search_inBackground(ByVal bw As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs, ByVal collection_critere As List(Of Critere)) As DataTable
        Dim table As DataTable = Recherche.traitRechercher(collection_critere, bw, e)
        Return table
    End Function

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With BackgroundWorker1
            If .WorkerSupportsCancellation Then
                .CancelAsync()
            End If
            'End If
        End With
    End Sub

    Private Sub Panel1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.PN_FORUMRECH.Visible = Not Home.ProgressPanel.Visible
    End Sub

    'Private Function watch_inBackground(ByVal bw As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As System.ComponentModel.DoWorkEventArgs
    '    If bw.CancellationPending Then
    '        e.Cancel = True
    '    End If
    '    Return e
    'End Function

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    PictureBox2.Size = New System.Drawing.Size(226, (((PictureBox2.Size.Height + 1) Mod PictureBox2.MaximumSize.Height)))

    '    'System.ComponentModel.DoWorkEventArgs 
    'End Sub

    'Delegate Sub takeWorkerArguments(ByVal bw As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs)

    'Delegate Sub SetLabelTextDelegate(ByVal [Label] As Label, ByVal [text] As String)

    'Private Sub UpdateProgressLabel(ByVal [Label] As Label, ByVal [text] As String)
    '    If [Label].InvokeRequired Then
    '        Dim myDelegate As New SetLabelTextDelegate(AddressOf UpdateProgressLabel)
    '        Me.Invoke(myDelegate, New Object() {[Label], [text]})
    '    Else
    '        [Label].Text = [text]
    '    End If
    'End Sub

    
End Class
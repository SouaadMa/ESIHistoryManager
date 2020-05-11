'Imports DataVisualization.Charting.SeriesChartType


Public Class StatistiquePage


    Private chart_kind As List(Of String) = System.Enum.GetNames(GetType(DataVisualization.Charting.SeriesChartType)).ToList '{"Spline", "bar", "column", "pie doughnut"}
    Private DomainCrit As New List(Of Critere)
    Private RepartCrit As String
    Private EtudCrit As Critere
    Private i As Integer '= chart_kind(chart_kind.IndexOf("Column"))
    Private RepartSpliter As New List(Of SplitContainer)
    Private DomainSpliter As New Dictionary(Of SplitContainer, String)
    Private Domain2Spliter As New Dictionary(Of SplitContainer, String)
    Private Obligatoryinput As New List(Of CheckedListBox)
    Private AlertPicture As New Dictionary(Of PictureBox, String)
    Private CritCombList As List(Of List(Of Critere))
    Private NonCompareChart() = {"Pie", "Doughnut", "Funnel", "Pyramid"}
    Private inclusive As Boolean = True
    Private stat As Statistiques

    Private Sub StatistiquePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'BDD_APPLICATIONDataSet.NOTES' table. You can move, or remove it, as needed.
        i = chart_kind.IndexOf("Column")
        'DataVisualization.Charting.SeriesChartType.Pyramid()
        chart_kind.Remove("PointAndFigure")
        chart_kind.Remove("Stock")
        chart_kind.Remove("Polar")
        chart_kind.Remove("ErrorBar")
        chart_kind.Remove("Renko")
        chart_kind.Remove("FastLine")
        chart_kind.Remove("Kagi")
        chart_kind.Remove("ThreeLineBreak")
        chart_kind.Remove("FastPoint")
        chart_kind.Remove("Rang")


        chart_kind.Remove("Pie")
        chart_kind.Remove("Doughnut")
        chart_kind.Remove("Funnel")
        chart_kind.Remove("Pyramid")



        DomainSpliter.Add(NiveauSpliter, BDD.champsNiveau) ', SpecialiteSpliter, AnneeSpliter, SectionSpliter, GroupeSpliter})
        DomainSpliter.Add(SpecialiteSpliter, BDD.champsOption)
        DomainSpliter.Add(AnneeSpliter, BDD.champsAnnee)

        Domain2Spliter.Add(SectionSpliter, BDD.champsCodeSection)
        Domain2Spliter.Add(GroupeSpliter, BDD.champsCodeGroupe)

        RepartSpliter.AddRange({SexeSpliter, MatiereSpliter})

        AlertPicture.Add(SexeAlert, "Vous devez remplir ce champs !")
        AlertPicture.Add(MatiereAlert, "Vous devez remplir ce champs !")
        AlertPicture.Add(PictureBox3, "Vous devez saisir La seuil du moyenne !")
        AlertPicture.Add(NiveauAlert, "Vous devez remplir ce champs !")
        AlertPicture.Add(SpecialiteAlert, "Vous devez remplir ce champs !")
        AlertPicture.Add(AnneeAlert, "Vous devez remplir ce champs !")
        AlertPicture.Add(SectionAlert, "Vous devez remplir ce champs !")
        AlertPicture.Add(GroupeAlert, "Vous devez remplir ce champs !")

        AvertTip.Active = False
        AvertTip.ShowAlways = True

        For Each picture As PictureBox In AlertPicture.Keys
            picture.Visible = False
        Next

        'initializer boutton chart kind 
        BT_CHARTLOAD.Visible = True
        BT_CHARTLOAD.Enabled = False

        'add the sub menus to the lable click handler
        For Each tool As ToolStripItem In CB_CRITERE.DropDownItems
            If tool.GetType.ToString.Equals("System.Windows.Forms.ToolStripMenuItem") Then
                For Each itm As ToolStripMenuItem In CType(tool, ToolStripMenuItem).DropDownItems
                    AddHandler itm.Click, AddressOf ToolStripMenuItem1_Click
                Next
            End If
        Next

        'initialize all the spliters
        For Each spliter As Control In StatistiquesPanel.Controls
            If spliter.GetType.ToString.Equals("System.Windows.Forms.SplitContainer") Then
                With CType(spliter, SplitContainer)
                    .IsSplitterFixed = True
                    .FixedPanel = System.Windows.Forms.FixedPanel.Panel1
                    .Panel2Collapsed = True
                    CType(.Panel1.Controls.Item(0), Label).ImageIndex = 0
                    .SplitterDistance = 21
                    .Height = 21
                    .Enabled = False
                End With
            End If
        Next

        'initialiser sexe
        CHB_SEXE.Items.AddRange(InfosGenerales.sexe)
        CHB_SEXE.Height = 21 * CHB_SEXE.Items.Count
        Console.WriteLine(CHB_SEXE.Height.ToString)
        'initialiser de matiere
        CHB_MAT.Items.AddRange(Login.Infosgenerale.matiere.AsEnumerable.Select(Function(dr) dr(0).ToString).ToArray)
        CHB_MAT.Height = 21 * CHB_MAT.Items.Count
        'disable the seuil textbox
        TXT_MOYSEUIL.Enabled = False

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'initialiser niveau
        CHB_NIVEAU.Items.AddRange(InfosGenerales.promo)
        CHB_NIVEAU.Height = 21 * CHB_NIVEAU.Items.Count
        'initialiser specialite
        CHB_SPECIALITE.Items.AddRange(InfosGenerales.specialite)
        CHB_SPECIALITE.Height = 21 * CHB_SPECIALITE.Items.Count
        'initialiser lannee
        For i As Integer = InfosGenerales.firstYear To InfosGenerales.lastYear Step 1
            CHB_ANNEE.Items.Add(i)
        Next
        CHB_ANNEE.Height = 21 * CHB_ANNEE.Items.Count
        'initialiser de groupe
        'CHB_GROUPE.Items.AddRange(Login.Infosgenerale.groupe.AsEnumerable().Select(Function(dr) dr(0).ToString).ToArray)
        CHB_GROUPE.Items.Clear()
        CHB_GROUPE.Height = 21 * CHB_GROUPE.Items.Count
        'initialiser de section
        'CHB_SECTION.Items.AddRange(Login.Infosgenerale.section.AsEnumerable().Select(Function(dr) dr(0).ToString).ToArray)
        CHB_SECTION.Items.Clear()
        CHB_SECTION.Height = 21 * CHB_SECTION.Items.Count

        BT_PREV.Enabled = False
        BT_NEXT.Enabled = False
        'initialiser le chart

    End Sub

    Private Sub BT_CHARTLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CHARTLOAD.Click
        DomainCrit.Clear()
        If TXT_MOYSEUIL.Enabled Then
            EtudCrit.setValeur(TXT_MOYSEUIL.Text)
        End If

        Dim ds = New DataSet()

        'clear the chart series
        Chart1.Series.Clear()
        Chart1.Series.Add("add")

        'get the collection of domain criteres

        CritCombList = GenereCritCombin()

        'initialize the chart properties
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add("chart1")
        Chart1.ChartAreas(0).AxisX.Title = RepartCrit
        Select Case EtudCrit.getChamps
            Case "Nombre", BDD.champsMOYEIN
                Chart1.ChartAreas(0).AxisY.Title = "Nombre des étudiants"
            Case BDD.champsNOJUNO, BDD.champsDECIIN
                Chart1.ChartAreas(0).AxisY.Title = "Taux"
        End Select

        Chart1.Titles(0).Text = CB_CRITERE.Text + IIf(ds.Tables.Count > 1, " entre", " ")
        Chart1.Series.RemoveAt(0)
        For i As Integer = 0 To CritCombList.Count - 1 Step 1  'comb As IList(Of Critere) In CritCombList
            stat = New Statistiques(CritCombList(i), EtudCrit, RepartCrit)
            If stat.GetDataTable().Rows.Count > 0 Then
                ds.Tables.Add(stat.GetDataTable())
                'add and rename the series
                Dim sername As String = SerieName(CritCombList(i))
                'If i = 0 Then
                'Chart1.Series.Item(0).Name = sername
                'Else
                Chart1.Series.Add(sername)
                'End If
            End If
            'IIf(DomainCrit.Count > 0, DomainCrit.Item(0).getChamps + " " + DomainCrit.Item(0).getValeur, "graphe1"))

        Next

        Dim dt As DataTable = Statistiques.SingleKeyMergeDataSet(ds)
        'DataSource indique la source de données
        Chart1.DataSource = dt
        Chart1.Titles(0).Text += IIf(CritCombList.Count = 1 And CritCombList.Item(0).Count = 0, "", "pour")
        For i As Integer = 0 To ds.Tables.Count - 1 Step 1  'for each table in the dataset
            With Chart1.Series.Item(i)
                .XValueMember = "Key"
                .YValueMembers = dt.Columns.Item("Total" + (i + 1).ToString).ColumnName
                .ChartArea = Chart1.ChartAreas.Item(0).Name
                Chart1.Titles(0).Text += IIf(i = 0, " ", IIf(i = ds.Tables.Count - 1, " et ", ",")) + .Name
                'affichons les valeurs au-dessus de chaque colonne
                If ds.Tables.Count <= 4 Then
                    .IsValueShownAsLabel = True
                End If
                .BorderWidth = 8
                .EmptyPointStyle.BorderWidth = 1
                .EmptyPointStyle.BorderColor = Color.Black
                .EmptyPointStyle.MarkerColor = Color.Red
                .EmptyPointStyle.MarkerSize = 15
                .EmptyPointStyle.MarkerStyle = DataVisualization.Charting.MarkerStyle.Cross
            End With
        Next


        If ds.Tables.Count <= 1 Then
            If Not chart_kind.Contains("Pie") Then
                chart_kind.AddRange({"Pie", "Doughnut", "Funnel", "Pyramid"})
            End If
        Else
            If chart_kind.Contains("Pie") Then
                chart_kind.Remove("Pie")
                chart_kind.Remove("Doughnut")
                chart_kind.Remove("Funnel")
                chart_kind.Remove("Pyramid")
            End If

        End If

        'exchange betwen boutton and combobox
        CB_CHARTKIND.Visible = True
        CB_CHARTKIND.ValueMember = "Column"
        'CB_CHARTKIND_SelectedIndexChanged
        CB_CHARTKIND.DataSource = chart_kind
        CB_CHARTKIND.SelectedIndex = chart_kind.IndexOf("Column")

        'Bind() déclenche le Binding
        'Chart1.DataBindTable(dt.DefaultView, dt.Columns.Item(1).ColumnName)
        Chart1.DataBind()
        'Form1.DataGridView1.DataSource = dt
        'Form1.Show()
        BT_NEXT.Enabled = True
        BT_PREV.Enabled = True
    End Sub

    Private Sub BT_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_NEXT.Click
        i = (i + 1) Mod chart_kind.Count
        CB_CHARTKIND.SelectedIndex = i
        For Each ser In Chart1.Series
            ser.ChartType = DirectCast([Enum].Parse(GetType(DataVisualization.Charting.SeriesChartType), chart_kind(i)), DataVisualization.Charting.SeriesChartType)
        Next
    End Sub

    Private Sub BT_PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PREV.Click
        i = IIf(i = 0, chart_kind.Count - 1, (i - 1) Mod chart_kind.Count)
        CB_CHARTKIND.SelectedIndex = i
        For Each ser In Chart1.Series
            ser.ChartType = DirectCast([Enum].Parse(GetType(DataVisualization.Charting.SeriesChartType), chart_kind(i)), DataVisualization.Charting.SeriesChartType)
        Next
    End Sub

    Private Sub CB_CHARTKIND_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CHARTKIND.SelectedIndexChanged
        'change the type of chart
        i = CB_CHARTKIND.SelectedIndex
        For Each ser In Chart1.Series
            ser.ChartType = DirectCast([Enum].Parse(GetType(DataVisualization.Charting.SeriesChartType), chart_kind(i)), DataVisualization.Charting.SeriesChartType)
        Next
    End Sub

    Private Sub TXT_MOYSEUIL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MOYSEUIL.TextChanged
        PictureBox3.Visible = (TXT_MOYSEUIL.Text.Equals(""))
    End Sub

    Private Sub Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SexeLabel.Click, MatiereLabel.Click, NiveauLabel.Click, Label1.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click

        'For Each lbl As Control In StatistiquesPanel.Controls
        '    If lbl.GetType.ToString.Equals("System.Windows.Forms.Label") Then
        '        If CType(lbl, Label).ImageIndex <> 0 And Not CType(lbl, Label).Name.Equals(CType(sender, Label).Name) Then

        '        End If
        '    End If
        'Next

        With CType(sender.Parent.Parent, SplitContainer)
            Console.WriteLine(.Name)
            .Panel2Collapsed = Not .Panel2Collapsed
            Console.WriteLine(.Height.ToString + "   " + .Panel2.Controls.Item(0).Height.ToString + "    " + CType(.Panel2.Controls.Item(0), CheckedListBox).Items.Count.ToString)
            Dim h As Integer = IIf(CType(.Panel2.Controls.Item(0), CheckedListBox).Items.Count <= 17, (CType(.Panel2.Controls.Item(0), CheckedListBox).Items.Count) * 21, 17 * 21)
            .Height += IIf(CType(sender, Label).ImageIndex = 0, h, -h)
            CType(.Panel2.Controls.Item(0), CheckedListBox).BackColor = Color.White
            CType(.Panel2.Controls.Item(0), CheckedListBox).Height = h + 21
            Console.WriteLine(.Height.ToString)
        End With
        CType(sender, Label).ImageIndex = (CType(sender, Label).ImageIndex + 1) Mod 2
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles ToolStripMenuItem1.Click
        Dim tool As ToolStripMenuItem = sender
        CB_CRITERE.Text = tool.OwnerItem.Text + " " + tool.Text.ToLower()
        BT_CHARTLOAD.Enabled = True

        requireFields({}, False)

        DomainCrit.Clear()
        For Each pct As PictureBox In AlertPicture.Keys
            pct.Visible = False
        Next
        TXT_MOYSEUIL.Text = ""

        Select Case CB_CRITERE.DropDownItems.IndexOf(tool.OwnerItem)
            Case 0
                EtudCrit = New Critere("Nombre", "")
                TXT_MOYSEUIL.Enabled = False
                enableRepartSplit(False)
                enableDomainSplit(True)
                Select Case CType(tool.OwnerItem, ToolStripMenuItem).DropDownItems.IndexOf(tool)
                    Case 0
                        RepartCrit = BDD.champsDECIIN
                    Case 1
                        RepartCrit = BDD.champsSEXE
                    Case 2
                        RepartCrit = BDD.champsOption
                        SpecialiteSpliter.Enabled = False
                End Select
            Case 2, 3, 4, 5
                TXT_MOYSEUIL.Enabled = False
                enableRepartSplit(False)
                enableDomainSplit(True)
                Select Case CType(tool.OwnerItem, ToolStripMenuItem).DropDownItems.IndexOf(tool)
                    Case 0
                        EtudCrit = New Critere(BDD.champsNOJUNO, 10)
                        RepartCrit = BDD.champsCOMAMA
                        inclusive = False
                        requireFields({CHB_SPECIALITE, CHB_NIVEAU, CHB_ANNEE}, True)
                    Case 2
                        EtudCrit = New Critere(BDD.champsDECIIN, "REUSSITE")
                        RepartCrit = BDD.champsCodeGroupe
                        inclusive = True
                        requireFields({CHB_SPECIALITE, CHB_NIVEAU, CHB_ANNEE})
                    Case 1
                        EtudCrit = New Critere(BDD.champsDECIIN, "REUSSITE")
                        RepartCrit = BDD.champsNiveau
                        NiveauSpliter.Enabled = False
                End Select
            Case 7
                TXT_MOYSEUIL.Enabled = True
                PictureBox3.Visible = True
                enableRepartSplit(False)
                enableDomainSplit(True)
                Select Case CType(tool.OwnerItem, ToolStripMenuItem).DropDownItems.IndexOf(tool)
                    Case 0
                        RepartCrit = BDD.champsNiveau
                        NiveauSpliter.Enabled = False
                    Case 1
                        RepartCrit = BDD.champsCodeGroupe
                        inclusive = True
                        requireFields({CHB_SPECIALITE, CHB_NIVEAU, CHB_ANNEE})
                    Case 2
                        RepartCrit = BDD.champsCodeSection
                        inclusive = True
                        requireFields({CHB_SPECIALITE, CHB_NIVEAU, CHB_ANNEE})
                End Select

                EtudCrit = New Critere(BDD.champsMOYEIN, "")
        End Select

        For Each tl As ToolStripItem In CB_CRITERE.DropDownItems
            If tl.GetType.ToString.Equals("System.Windows.Forms.ToolStripMenuItem") Then
                CType(tl, ToolStripMenuItem).CheckState = CheckState.Unchecked
                For Each itm As ToolStripMenuItem In CType(tl, ToolStripMenuItem).DropDownItems
                    itm.CheckState = CheckState.Unchecked
                Next
            End If
        Next
    End Sub

    Private Sub enableDomainSplit(ByVal enbl As Boolean)
        For Each Split As SplitContainer In DomainSpliter.Keys
            Split.Enabled = enbl
        Next
    End Sub

    Private Sub enableDomain2Split(Optional ByVal enbl As Boolean = False)
        enbl = CHB_NIVEAU.CheckedItems.Count > 0 And CHB_SPECIALITE.CheckedItems.Count > 0 And CHB_ANNEE.CheckedItems.Count > 0
        Dim rqrd As Boolean
        If inclusive Then
            rqrd = CHB_NIVEAU.CheckedItems.Count > 0 And CHB_SPECIALITE.CheckedItems.Count > 0 And CHB_ANNEE.CheckedItems.Count > 0
        Else
            rqrd = CHB_NIVEAU.CheckedItems.Count > 0 Or CHB_SPECIALITE.CheckedItems.Count > 0 Or CHB_ANNEE.CheckedItems.Count > 0
        End If

        requireFields({}, Not rqrd)

        'For Each Split As SplitContainer In Domain2Spliter.Keys
        '    Split.Enabled = enbl
        'Next
        If Not RepartCrit.Equals(BDD.champsCodeSection) Then
            SectionSpliter.Enabled = enbl
            If enbl Then
                CritCombList = GenereCritCombin()
                Dim grp As New List(Of String)
                Dim sct As New List(Of String)
                For Each combin As List(Of Critere) In CritCombList
                    Dim ls As List(Of Critere) = generPromo(combin)
                    'initialiser de groupe
                    ls.Item(0).setTable(BDD.nomTablePROMO)
                    grp.AddRange(Recherche.GetALLConditioned(BDD.champsCodeGroupe, BDD.nomTableGROUP, ls).AsEnumerable().Select(Function(dr) dr(0).ToString).ToArray)
                    'initialiser de section
                    ls.Item(0).setTable(BDD.nomTablePROMO)
                    sct.AddRange(Recherche.GetALLConditioned(BDD.champsCodeSection, BDD.nomTableSection, ls).AsEnumerable().Select(Function(dr) dr(0).ToString).ToArray)
                Next
                CHB_GROUPE.Items.Clear()
                CHB_GROUPE.Items.AddRange(grp.Distinct().ToArray)
                'initialiser de section
                CHB_SECTION.Items.Clear()
                CHB_SECTION.Items.AddRange(sct.Distinct().ToArray)
                CHB_GROUPE.Height = 21 * CHB_GROUPE.Items.Count
                CHB_SECTION.Height = 21 * CHB_SECTION.Items.Count
            End If
        End If
        If RepartCrit.Equals(BDD.champsCodeGroupe) Then
            CHB_GROUPE.Items.Clear()
            GroupeSpliter.Enabled = False
        Else
            GroupeSpliter.Enabled = enbl
        End If

    End Sub

    Private Sub enableRepartSplit(ByVal enbl As Boolean)
        For Each Split As SplitContainer In RepartSpliter
            Split.Enabled = enbl
        Next
    End Sub

    Private Sub PictureBox1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupeAlert.VisibleChanged, SectionAlert.VisibleChanged, AnneeAlert.VisibleChanged, SpecialiteAlert.VisibleChanged, NiveauAlert.VisibleChanged, PictureBox3.VisibleChanged, MatiereAlert.VisibleChanged, SexeAlert.VisibleChanged
        'Dim AvertTip As ToolTip = New ToolTip()
        AvertTip.IsBalloon = True
        If CType(sender, PictureBox).Visible Then
            If Not AvertTip.Active Then
                AvertTip.SetToolTip(sender, AlertPicture(CType(sender, PictureBox)))
                AvertTip.Active = True
                AvertTip.ShowAlways = True
            End If
        Else
            AvertTip.Active = False
            AvertTip.ShowAlways = True
        End If
        For Each pct As PictureBox In AlertPicture.Keys
            If pct.Visible Then
                BT_CHARTLOAD.Enabled = False
                Exit For
            Else
                BT_CHARTLOAD.Enabled = True
            End If
        Next
    End Sub

    Private Sub CHB_SEXE_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles CHB_SEXE.ItemCheck, CHB_MAT.ItemCheck, CHB_SPECIALITE.ItemCheck, CHB_SECTION.ItemCheck, CHB_NIVEAU.ItemCheck, CHB_GROUPE.ItemCheck, CHB_ANNEE.ItemCheck
        Dim lst As CheckedListBox = CType(sender, CheckedListBox)
        If Obligatoryinput.Contains(lst) Then
            If lst.CheckedItems.Count = 0 And e.NewValue = CheckState.Checked Then
                StatistiquesPanel.Controls.Item(lst.Name.Substring(4) + "Alert").Visible = False
            ElseIf lst.CheckedItems.Count = 1 And e.NewValue = CheckState.Unchecked Then
                StatistiquesPanel.Controls.Item(lst.Name.Substring(4) + "Alert").Visible = True
            End If
        End If

        If lst.Equals(CHB_NIVEAU) Or lst.Equals(CHB_SPECIALITE) Or lst.Equals(CHB_ANNEE) Then
            'Dim methodInvoker As MethodInvoker = AddressOf enableDomain2Split
            Me.BeginInvoke(Sub() enableDomain2Split())
        End If

        'CType(sender, Control).BeginInvoke(CType(enableDomain2Split(CHB_NIVEAU.CheckedItems.Count > 0 And CHB_SPECIALITE.CheckedItems.Count > 0 And CHB_ANNEE.CheckedItems.Count > 0), [Delegate]))

    End Sub

    Private Sub TXT_MOYSEUIL_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_MOYSEUIL.KeyPress
        Dim c As Char = e.KeyChar
        PictureBox3.Visible = TXT_MOYSEUIL.Text.Equals("")
        If TXT_MOYSEUIL.Text.Count = 5 And Not AscW(c) = 8 Then
            e.Handled = True
            Return
        End If
        If AscW(c) = 46 And TXT_MOYSEUIL.Text.IndexOf(".") <> -1 Then
            e.Handled = True
            Return
        End If
        If Not Char.IsDigit(c) And Not AscW(c) = 8 And Not AscW(c) = 46 Then
            e.Handled = True
        End If

    End Sub

    Private Sub requireFields(ByVal lst As Array, Optional ByVal rqrd As Boolean = True)
        If inclusive Then
            rqrd = CHB_NIVEAU.CheckedItems.Count > 0 And CHB_SPECIALITE.CheckedItems.Count > 0 And CHB_ANNEE.CheckedItems.Count > 0
        Else
            rqrd = CHB_NIVEAU.CheckedItems.Count > 0 Or CHB_SPECIALITE.CheckedItems.Count > 0 Or CHB_ANNEE.CheckedItems.Count > 0
        End If
        If rqrd And lst.Length <> 0 Then
            Obligatoryinput.AddRange(lst)

            For Each elm As Control In Obligatoryinput
                StatistiquesPanel.Controls.Item(elm.Name.Substring(4) + "Alert").Visible = rqrd
            Next
        Else
            For Each elm As Control In StatistiquesPanel.Controls.OfType(Of PictureBox)()
                elm.Visible = rqrd
            Next
        End If
    End Sub

    Private Function SerieName(ByVal lst As List(Of Critere)) As String
        Dim n As String = ""
        For Each elm As Critere In lst
            Select Case elm.getChamps
                Case BDD.champsNiveau
                Case BDD.champsOption

                Case BDD.champsAnnee
                Case BDD.champsCodeSection
                    n += "Sec:"
                Case BDD.champsCodeGroupe
                    n += "G "
                Case BDD.champsSEXE
            End Select
            n += elm.getValeur + IIf(lst.IndexOf(elm) = lst.Count - 1, "", "/")
        Next
        Return n
    End Function

    Private Function GenereCritCombin() As List(Of List(Of Critere))
        Dim dmncomb As New Dictionary(Of CheckedListBox, String)

        For Each Domain As KeyValuePair(Of SplitContainer, String) In DomainSpliter.Union(Domain2Spliter)
            If CType(Domain.Key.Panel2.Controls.Item(0), CheckedListBox).CheckedItems.Count > 0 Then
                dmncomb.Add(CType(Domain.Key.Panel2.Controls.Item(0), CheckedListBox), Domain.Value)
            End If
        Next

        CritCombList = New List(Of List(Of Critere))
        Dim cpt As Integer = 0

        If dmncomb.Count > 0 And DomainCrit.Count < 1 Then
            For Each niv In dmncomb.Keys(0).CheckedItems
                DomainCrit.Add(New Critere(dmncomb.Item(dmncomb.Keys(0)), niv.ToString))
                If dmncomb.Count > 1 And DomainCrit.Count < 2 Then
                    For Each opt In dmncomb.Keys(1).CheckedItems
                        DomainCrit.Add(New Critere(dmncomb.Item(dmncomb.Keys(1)), opt.ToString))
                        If dmncomb.Count > 2 And DomainCrit.Count < 3 Then
                            For Each an In dmncomb.Keys(2).CheckedItems
                                DomainCrit.Add(New Critere(dmncomb.Item(dmncomb.Keys(2)), an.ToString))
                                If dmncomb.Count > 3 And DomainCrit.Count < 4 Then
                                    For Each sec In dmncomb.Keys(3).CheckedItems
                                        DomainCrit.Add(New Critere(dmncomb.Item(dmncomb.Keys(3)), sec.ToString))
                                        If dmncomb.Count > 4 And DomainCrit.Count < 5 Then
                                            For Each grp In dmncomb.Keys(4).CheckedItems
                                                DomainCrit.Add(New Critere(dmncomb.Item(dmncomb.Keys(4)), grp.ToString))
                                                CritCombList.Add(DomainCrit.ToList())
                                                'stat = New Statistiques(DomainCrit, EtudCrit, RepartCrit)
                                                'ds.Tables.Add(stat.GetDataTable())
                                                DomainCrit.RemoveAt(4)
                                            Next
                                        Else
                                            CritCombList.Add(DomainCrit.ToList())
                                            'stat = New Statistiques(DomainCrit, EtudCrit, RepartCrit)
                                            'ds.Tables.Add(stat.GetDataTable())
                                        End If
                                        DomainCrit.RemoveAt(3)
                                    Next

                                Else
                                    CritCombList.Add(DomainCrit.ToList())
                                    'stat = New Statistiques(DomainCrit, EtudCrit, RepartCrit)
                                    'ds.Tables.Add(stat.GetDataTable())
                                End If
                                DomainCrit.RemoveAt(2)
                            Next

                        Else
                            CritCombList.Add(DomainCrit.ToList())
                            'stat = New Statistiques(DomainCrit, EtudCrit, RepartCrit)
                            'ds.Tables.Add(stat.GetDataTable())
                        End If
                        DomainCrit.RemoveAt(1)
                    Next
                Else
                    CritCombList.Add(DomainCrit.ToList())
                    'stat = New Statistiques(DomainCrit, EtudCrit, RepartCrit)

                End If
                DomainCrit.RemoveAt(0)
            Next
        Else
            CritCombList.Add(DomainCrit.ToList())
        End If

        Return CritCombList

    End Function

    Public Function generPromo(ByVal lst As List(Of Critere)) As List(Of Critere)
        lst.Insert(3, New Critere(BDD.champsCodePromo, lst.Item(0).getValeur + "/" + lst.Item(1).getValeur + "/" + lst.Item(2).getValeur.ToString.Substring(2, 2)))

        lst.RemoveRange(0, 3)
        Return lst
    End Function

End Class




'Public Shared Sub stat()

'    Dim domaine As New List(Of Critere)({New Critere(BDD.champsOption, "TRC", "")}) ', New Critere(BDD.champsNiveau, "4", BDD.nomTablePROMO)})
'    '({New Critere(BDD.champsCodePromo, "4/SI/00", BDD.nomTableINSCRIPTION)})
'    '({New Critere(BDD.champsCodePromo, "4/SI/00")})
'    '({New Critere(BDD.champsNiveau, "4", BDD.nomTablePROMO)
'    ' New Critere(BDD.champsCodeGroupe, 6)

'    'Dim dt As New DataTable

'    Dim stat1_1 As New Statistiques(domaine, New Critere("Nombre", ""), BDD.champsDECIIN)

'    Dim stat1_2 As New Statistiques(domaine, New Critere("Nombre", ""), BDD.champsSEXE)

'    Dim stat1_3 As New Statistiques(domaine, New Critere("Nombre", ""), BDD.champsOption)


'    Dim stat2_1 As New Statistiques(domaine, New Critere(BDD.champsNOJUNO, 10), BDD.champsCOMAMA)
'    Console.WriteLine(stat2_1.GetTotal("ALGO"))

'    Dim stat2_2 As New Statistiques(domaine, New Critere(BDD.champsDECIIN, "REUSSITE"), BDD.champsCodeGroupe)

'    Dim stat2_3 As New Statistiques(domaine, New Critere(BDD.champsDECIIN, "REUSSITE"), BDD.champsNiveau)


'    Dim stat5_1 As New Statistiques(domaine, New Critere(BDD.champsMOYEIN, 10), BDD.champsNiveau)

'    Dim stat5_2 As New Statistiques(domaine, New Critere(BDD.champsMOYEIN, 10), BDD.champsCodeGroupe)

'    Dim stat5_3 As New Statistiques(domaine, New Critere(BDD.champsMOYEIN, 10), BDD.champsCodeSection)


'End Sub




'For Each niv In CHB_NIVEAU.CheckedItems
'    DomainCrit.Add(New Critere(BDD.champsNiveau, niv.ToString))
'    If CHB_SPECIALITE.CheckedItems.Count > 0 Then
'        For Each opt In CHB_SPECIALITE.CheckedItems
'            DomainCrit.Add(New Critere(BDD.champsOption, opt.ToString))
'            If CHB_ANNEE.CheckedItems.Count > 0 Then
'                For Each an In CHB_ANNEE.CheckedItems
'                    DomainCrit.Add(New Critere(BDD.champsAnnee, an.ToString))
'                    If CHB_SECTION.CheckedItems.Count > 0 Then
'                        For Each sec In CHB_SECTION.CheckedItems
'                            DomainCrit.Add(New Critere(BDD.champsCodeSection, sec.ToString))
'                            If CHB_SECTION.CheckedItems.Count > 0 Then
'                                For Each grp In CHB_GROUPE.CheckedItems
'                                    DomainCrit.Add(New Critere(BDD.champsCodeGroupe, grp.ToString))
'                                    stat = New Statistiques(DomainCrit, EtudCrit, RepartCrit)
'                                    ds.Tables.Add(stat.GetDataTable())
'                                    DomainCrit.RemoveAt(4)
'                                Next
'                                DomainCrit.RemoveAt(3)
'                            Else
'                                stat = New Statistiques(DomainCrit, EtudCrit, RepartCrit)
'                                ds.Tables.Add(stat.GetDataTable())
'                            End If
'                        Next
'                        DomainCrit.RemoveAt(2)
'                    Else
'                        stat = New Statistiques(DomainCrit, EtudCrit, RepartCrit)
'                        ds.Tables.Add(stat.GetDataTable())
'                    End If
'                Next
'                DomainCrit.RemoveAt(1)
'            Else
'                stat = New Statistiques(DomainCrit, EtudCrit, RepartCrit)
'                ds.Tables.Add(stat.GetDataTable())
'            End If
'        Next
'    Else
'        stat = New Statistiques(DomainCrit, EtudCrit, RepartCrit)
'        '    .XValueMember = ds.Tables(0).Columns.Item(1).ColumnName
'        '    .YValueMembers = "Total0" 'ds.Tables(0).Columns.Item("Total" + (ds.Tables.Count - 1).ToString).ColumnName
'        '    .ChartArea = Chart1.ChartAreas.Item(0).Name
'        'End With
'    End If
'    DomainCrit.RemoveAt(0)
'Next
'stat.GetDataTable().Columns.Item(0).ColumnName += (ds.Tables.Count).ToString
'ds.Tables.Add(stat.GetDataTable())
'ds.Tables.Item(ds.Tables.Count - 1).Columns.Item(0).ColumnName += (ds.Tables.Count - 1).ToString
'If ds.Tables.Count > 1 Then
'    'ds.Tables(0).Columns.Add(ds.Tables.Item(ds.Tables.Count - 1).Columns.Item(0).ColumnName)
'    'ds.Tables(0).Merge(ds.Tables.Item(ds.Tables.Count - 1), False, MissingSchemaAction.Ignore)
'End If






'Private Sub CHB_SEXE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_SEXE.SelectedIndexChanged

'End Sub

'Private Sub CHB_MAT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    'BT_CHARTLOAD.Visible = True
'    'CB_CHARTKIND.Visible = False
'End Sub

'Private Sub CHB_NIVEAU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_NIVEAU.SelectedIndexChanged

'    'DomainCrit.Add(New Critere(BDD.champsNiveau, CHB_NIVEAU.t))
'End Sub

'Private Sub CHB_ANNEE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    'BT_CHARTLOAD.Visible = True
'    'CB_CHARTKIND.Visible = False
'End Sub

'Private Sub CHB_SPECIALITE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    'BT_CHARTLOAD.Visible = True
'    'CB_CHARTKIND.Visible = False
'End Sub

'Private Sub CHB_SECTION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    'BT_CHARTLOAD.Visible = True
'    'CB_CHARTKIND.Visible = False
'End Sub

'Private Sub CHB_GROUPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    'BT_CHARTLOAD.Visible = True
'    'CB_CHARTKIND.Visible = False
'End Sub



'If CType(Domain.Key.Panel2.Controls.Item(0), CheckedListBox).CheckedItems.Count > 0 Then
'If CHB_S.CheckedItems.Count > 0 Then
'For Each Domain As KeyValuePair(Of SplitContainer, String) In dmncomb
'    For Each crit In CType(Domain.Key.Panel2.Controls.Item(0), CheckedListBox).CheckedItems
'        DomainCrit.Add(New Critere(Domain.Value, crit.ToString))
'    Next
'Next

'While dmncomb.Count <> 0
'For i As Integer = 0 To dmncomb.Count - 1 Step 1
'    For Each itm In dmncomb.Item(i).CheckedItems
'        For Each dm As CheckedListBox In dmncomb.Keys.ToList.Take(i + 1)
'            DomainCrit.Add(New Critere(dmncomb.Item(dmn).ToString, itm.ToString))
'            If (dmncomb.Keys.ToList.IndexOf(dmn) = dmncomb.Count - 1) Then
'                DomainCrit.RemoveAt(DomainCrit.Count - 1)
'                dmn.SetItemCheckState(dmn.FindStringExact(dmn.CheckedItems.Item(0).ToString), CheckState.Unchecked)
'            Else

'            End If
'        Next
'    Next
'Next
'End While

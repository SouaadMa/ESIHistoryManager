Public Class StatistiquePage


    Private chart_kind As String() = System.Enum.GetNames(GetType(DataVisualization.Charting.SeriesChartType)) '{"Spline", "bar", "column", "pie doughnut"}
    Private DomainCrit As New List(Of Critere)
    Private RepartCrit As String
    Private EtudCrit As Critere
    Private i As Integer '= chart_kind(chart_kind.IndexOf("Column"))
    Private RepartSpliter As New List(Of SplitContainer)
    Private DomainSpliter As New Dictionary(Of SplitContainer, String)
    Private stat As Statistiques

    Private Sub StatistiquePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        i = Array.IndexOf(chart_kind, "Column")

        DomainSpliter.Add(NiveauSpliter, BDD.champsNiveau) ', SpecialiteSpliter, AnneeSpliter, SectionSpliter, GroupeSpliter})
        DomainSpliter.Add(SpecialiteSpliter, BDD.champsOption)
        DomainSpliter.Add(AnneeSpliter, BDD.champsAnnee)
        'DomainSpliter.Add(SectionSpliter, BDD.champsCodeSection)
        'DomainSpliter.Add(GroupeSpliter, BDD.champsCodeGroupe)

        RepartSpliter.AddRange({SexeSpliter, MatiereSpliter})
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
        CHB_ANNEE.Items.AddRange(InfosGenerales.Annee)
        CHB_ANNEE.Height = 21 * CHB_ANNEE.Items.Count
        'initialiser de groupe
        CHB_GROUPE.Items.AddRange(Login.Infosgenerale.groupe.AsEnumerable().Select(Function(dr) dr(0).ToString).ToArray)
        CHB_GROUPE.Height = 21 * CHB_GROUPE.Items.Count
        'initialiser de section
        CHB_SECTION.Items.AddRange(Login.Infosgenerale.section.AsEnumerable().Select(Function(dr) dr(0).ToString).ToArray)
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
        'exchange betwen boutton and combobox
        CB_CHARTKIND.Visible = True
        CB_CHARTKIND.ValueMember = "Column"
        'CB_CHARTKIND_SelectedIndexChanged
        CB_CHARTKIND.DataSource = chart_kind
        CB_CHARTKIND.SelectedIndex = i
        'get the collection of domain criteres

        Dim dmncomb As New Dictionary(Of CheckedListBox, String)

        For Each Domain As KeyValuePair(Of SplitContainer, String) In DomainSpliter
            If CType(Domain.Key.Panel2.Controls.Item(0), CheckedListBox).CheckedItems.Count > 0 Then
                dmncomb.Add(CType(Domain.Key.Panel2.Controls.Item(0), CheckedListBox), Domain.Value)
            End If
        Next

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
        Dim CritCombList As New List(Of List(Of Critere))
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
                    '    .XValueMember = ds.Tables(0).Columns.Item(1).ColumnName
                    '    .YValueMembers = "Total0" 'ds.Tables(0).Columns.Item("Total" + (ds.Tables.Count - 1).ToString).ColumnName
                    '    .ChartArea = Chart1.ChartAreas.Item(0).Name
                    'End With
                End If
                DomainCrit.RemoveAt(0)
            Next
        Else
            CritCombList.Add(DomainCrit.ToList())
        End If

        For Each comb As IList(Of Critere) In CritCombList
            stat = New Statistiques(comb, EtudCrit, RepartCrit)
            ds.Tables.Add(stat.GetDataTable())
        Next
        ''add and rename the series
        'Chart1.Series.Add(DomainCrit.Item(0).getChamps + " " + DomainCrit.Item(0).getValeur)
        'With Chart1.Series.Item(ds.Tables.Count - 1)
        '    'ds.Tables(ds.Tables.Count - 1).TableName + "."
        'DataSource indique la source de données
        'Chart1.DataSource = ds

        'For i As Integer = 0 To ds.Tables.Count - 1 Step 1  'for each table in the dataset
        '    'rename the series
        '    Chart1.Series.Item(i).Name = DomainCrit.Item(0).getChamps + " " + DomainCrit.Item(0).getValeur
        '    End If

        'Next
        'Dans une series YValueMembers indique quelle colonne utiliser pour les valeurs Y
        'Chart1.Series(0)
        'Bind() déclenche le Binding
        Chart1.DataBind()
        Form1.ds = ds
        Form1.Show()
    End Sub

    Private Sub BT_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_NEXT.Click
        i = (i + 1) Mod chart_kind.Count
        CB_CHARTKIND.SelectedIndex = i
        Chart1.Series(0).ChartType = DirectCast([Enum].Parse(GetType(DataVisualization.Charting.SeriesChartType), chart_kind(i)), DataVisualization.Charting.SeriesChartType)
    End Sub

    Private Sub BT_PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PREV.Click
        i = IIf(i = 0, 34, (i - 1) Mod chart_kind.Count)
        CB_CHARTKIND.SelectedIndex = i
        Chart1.Series(0).ChartType = DirectCast([Enum].Parse(GetType(DataVisualization.Charting.SeriesChartType), chart_kind(i)), DataVisualization.Charting.SeriesChartType)
    End Sub

    Private Sub CB_CHARTKIND_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CHARTKIND.SelectedIndexChanged
        'change the type of chart
        i = CB_CHARTKIND.SelectedIndex
        Chart1.Series(0).ChartType = DirectCast([Enum].Parse(GetType(DataVisualization.Charting.SeriesChartType), chart_kind(i)), DataVisualization.Charting.SeriesChartType)
    End Sub

    Private Sub CHB_SEXE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_SEXE.SelectedIndexChanged
        
    End Sub

    Private Sub CHB_MAT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'BT_CHARTLOAD.Visible = True
        'CB_CHARTKIND.Visible = False
    End Sub

    Private Sub CHB_NIVEAU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHB_NIVEAU.SelectedIndexChanged

        'DomainCrit.Add(New Critere(BDD.champsNiveau, CHB_NIVEAU.t))
    End Sub

    Private Sub CHB_ANNEE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'BT_CHARTLOAD.Visible = True
        'CB_CHARTKIND.Visible = False
    End Sub

    Private Sub CHB_SPECIALITE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'BT_CHARTLOAD.Visible = True
        'CB_CHARTKIND.Visible = False
    End Sub

    Private Sub CHB_SECTION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'BT_CHARTLOAD.Visible = True
        'CB_CHARTKIND.Visible = False
    End Sub

    Private Sub CHB_GROUPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'BT_CHARTLOAD.Visible = True
        'CB_CHARTKIND.Visible = False
    End Sub

    Private Sub TXT_MOYSEUIL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'BT_CHARTLOAD.Visible = True
        'CB_CHARTKIND.Visible = False
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

        DomainCrit.Clear()

        Select Case CB_CRITERE.DropDownItems.IndexOf(tool.OwnerItem)
            Case 0
                EtudCrit = New Critere("Nombre", "")
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
            Case 3, 4, 5, 6
                enableRepartSplit(False)
                enableDomainSplit(True)
                Select Case CType(tool.OwnerItem, ToolStripMenuItem).DropDownItems.IndexOf(tool.OwnerItem)
                    Case 0
                        EtudCrit = New Critere(BDD.champsNOJUNO, 10)
                        RepartCrit = BDD.champsCOMAMA
                    Case 1
                        EtudCrit = New Critere(BDD.champsDECIIN, "REUSSITE")
                        RepartCrit = BDD.champsCodeGroupe
                    Case 2
                        EtudCrit = New Critere(BDD.champsDECIIN, "REUSSITE")
                        RepartCrit = BDD.champsNiveau
                        NiveauSpliter.Enabled = False
                End Select
            Case 7
                TXT_MOYSEUIL.Enabled = True
                Select Case CType(tool.OwnerItem, ToolStripMenuItem).DropDownItems.IndexOf(tool.OwnerItem)
                    Case 0
                        RepartCrit = BDD.champsNiveau
                        NiveauSpliter.Enabled = False
                    Case 1
                        RepartCrit = BDD.champsCodeGroupe
                    Case 2
                        RepartCrit = BDD.champsCodeSection
                End Select
                'EtudCrit.Add(New Critere(BDD.champsMOYEIN, SEUIL))
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

    Private Sub enableRepartSplit(ByVal enbl As Boolean)
        For Each Split As SplitContainer In RepartSpliter
            Split.Enabled = enbl
        Next
    End Sub

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

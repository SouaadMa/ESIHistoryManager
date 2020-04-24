Public Class Classement
    'Classe pour la fonctionnalité du classement et du tri des étudiants

    ' Ancienne Méthode qui retourne une collection limitée d'étudiants, triée selon leurs moyennes
    Public Shared Function TraitClassement(ByVal criteres As List(Of Critere), ByVal limite As Integer) As DataTable

        Dim req = ""

        Dim year As New String("")
        Dim optio As New String("")
        Dim niv As New String("")
        Dim conditions As New List(Of Critere)

        ' This for each loop serves to create CodePromo and add it with the rest of the conditions..

        For Each criterea As Critere In criteres

            If criterea.getChamps.Equals(BDD.champsAnnee) Then
                year = criterea.getValeur
            Else
                If criterea.getChamps.Equals(BDD.champsOption) Then
                    optio = criterea.getValeur
                Else
                    If criterea.getChamps.Equals(BDD.champsNiveau) Then
                        niv = criterea.getValeur
                    Else
                        ' Other fields can be CodeSection and CodeGroupe
                        conditions.Add(criterea)

                    End If
                End If
            End If

        Next

        Try
            Dim codePromo As New Critere(BDD.champsCodePromo, New String(niv + "/" + optio + "/" + year))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim champsDemandes As New List(Of String)({BDD.champsNomEtud, BDD.champsPrenoms, BDD.champsRANGIN, BDD.champsMATRIN, BDD.champsMOYEIN})

        'req = Rech_BDD.genereRechMultipleRequetes(champsDemandes, BDD.nomTableINSCRIPTION, BDD.nomTableEtudiant, conditions)
        'BDD.AjouteLimite(req, limite)
        'BDD.AjouteOrdre(req, BDD.champsMOYEIN)

        Return BDD.executeRequete(req)


    End Function


    ' Méthode pour le tri ascendant d'une datatable 
    Public Shared Function SortASCCollection(ByVal table As DataTable, ByVal champs As String) As DataTable

        table.DefaultView.Sort = champs + " ASC"
        Return table.DefaultView.ToTable

    End Function

    ' Méthode pour le tri ascendant d'une datatable 
    Public Shared Function SortDESCollection(ByVal table As DataTable, ByVal champs As String) As DataTable

        table.DefaultView.Sort = champs + " DESC"
        Return table.DefaultView.ToTable

    End Function

    ' Méthode pour le classement ascendant d'une collection d'étudiants
    Public Shared Function SortASCCollection(ByVal collection As List(Of Etudiant), ByVal champs As String) As List(Of Etudiant)

        ' Création du comparateur selon le champs donné
        Dim cust_comparer As New  _
            ComparateurASCEtudiant(champs)

        ' Le tri
        collection.Sort(cust_comparer)

        Return collection
    End Function

    ' Méthode pour le classement descendant d'une collection d'étudiants
    Public Shared Function SortDESCollection(ByVal collection As List(Of Etudiant), ByVal champs As String) As List(Of Etudiant)

        ' Création du comparateur selon le champs donné
        Dim cust_comparer As New  _
            ComparateurDESEtudiant(champs)

        ' Le tri
        collection.Sort(cust_comparer)

        Return collection
    End Function


    'Classe interne qui aide avec la comparaison avec plusieurs champs 
    'Pour le tri ascendant

    Private Class ComparateurASCEtudiant
        Implements IComparer(Of Etudiant)

        ' L'attribut décide le champs avec lequel les étudiants seront comparés.
        Public ChampsComparaison As String = BDD.champsMATRIN


        Public Sub New(ByVal compare_type As String)
            ChampsComparaison = compare_type
        End Sub

        ' Méthode qui compare deux étudiants selon l'attribut ChampsComparaison de la classe.
        Public Function Compare(ByVal x As Etudiant, ByVal y As  _
            Etudiant) As Integer Implements _
            System.Collections.Generic.IComparer(Of Etudiant).Compare

            'On fait le cast des deux objets en entrée
            Dim x_cust As Etudiant = DirectCast(x,  _
                Etudiant)
            Dim y_cust As Etudiant = DirectCast(y,  _
                Etudiant)

            Return x_cust.GetInfoChamps(ChampsComparaison).CompareTo(y_cust.GetInfoChamps(ChampsComparaison))

        End Function
    End Class

    'Classe interne qui aide avec la comparaison avec plusieurs champs
    'Pour le tri descendant

    Private Class ComparateurDESEtudiant
        Implements IComparer(Of Etudiant)

        ' L'attribut décide le champs avec lequel les étudiants seront comparés.
        Public ChampsComparaison As String = BDD.champsMATRIN


        Public Sub New(ByVal compare_type As String)
            ChampsComparaison = compare_type
        End Sub

        ' Méthode qui compare deux étudiants selon l'attribut ChampsComparaison de la classe.
        Public Function Compare(ByVal x As Etudiant, ByVal y As  _
            Etudiant) As Integer Implements _
            System.Collections.Generic.IComparer(Of Etudiant).Compare

            'On fait le cast des deux objets en entrée
            Dim x_cust As Etudiant = DirectCast(x,  _
                Etudiant)
            Dim y_cust As Etudiant = DirectCast(y,  _
                Etudiant)

            Return -(x_cust.GetInfoChamps(ChampsComparaison).CompareTo(y_cust.GetInfoChamps(ChampsComparaison)))

        End Function
    End Class


End Class


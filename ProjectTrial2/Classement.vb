Public Class Classement
    'Classe pour la fonctionnalité du classement et du tri des étudiants

    Public Shared Function SortCollection(ByVal collection As List(Of Etudiant), ByVal champs As String) As List(Of Etudiant)

        ' Création du comparateur selon le champs donné
        Dim cust_comparer As New  _
            ComparateurEtudiant(champs)

        ' Le tri
        collection.Sort(cust_comparer)

        Return collection
    End Function


    'Classe interne qui aide avec la comparaison avec plusieurs champs
    Private Class ComparateurEtudiant
        Implements IComparer(Of Etudiant)

        ' L'attribut décide le champs avec lequel les étudiants seront comparés.
        Public ChampsComparaison As String = "Matricule"

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

            Return x_cust.getInfo(ChampsComparaison).CompareTo(y_cust.getInfo(ChampsComparaison))

        End Function
    End Class


End Class


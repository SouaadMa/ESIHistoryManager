Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable()>
Public Class InfosGenerales

    Public wilaya As DataTable

    Public wilayaarabe As DataTable
    Public codewilaya As DataTable
    Public section As DataTable
    Public groupe As DataTable
    Public matiere As DataTable
    Public seribac As DataTable

    Public Shared sexe() As String = {"Autre", "Homme", "Femme"}
    Public Shared specialite() As String = {"TRC", "SI", "SIQ"}
    Public Shared promo() As String = {"1", "2", "3", "4", "5"}
    Public Shared Annee() As String = {"00", "01", "02", "03", "04", "05", "06", "08", "09", "10", "11", "88", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "TR"}
    Public Shared firstYear As Integer = 1989
    Public Shared lastYear As Integer = 2011

    Public Sub New()
        wilaya = Recherche.GetALL(BDD.champsWILAYA, BDD.nomTableEtudiant)
        wilaya.PrimaryKey = {wilaya.Columns.Item(BDD.champsWILAYA)}
        wilayaarabe = Recherche.GetALL(BDD.champsWilayaNaisA, BDD.nomTableEtudiant)
        wilayaarabe.PrimaryKey = {wilayaarabe.Columns.Item(BDD.champsWilayaNaisA)}
        seribac = Recherche.GetALL(BDD.champsSERIEBAC, BDD.nomTableEtudiant)
        codewilaya = Recherche.GetALL(BDD.champsWILNAIS, BDD.nomTableEtudiant)
        codewilaya.PrimaryKey = {codewilaya.Columns.Item(BDD.champsWILNAIS)}
        groupe = Recherche.GetALL(BDD.champsCodeGroupe, BDD.nomTableGROUP)
        section = Recherche.GetALL(BDD.champsCodeSection, BDD.nomTableSection)
        matiere = Recherche.GetALL(BDD.champsCOMAMA, BDD.nomTableMATIERE)
        
        Console.WriteLine("Loading info generale DONE")
    End Sub

End Class



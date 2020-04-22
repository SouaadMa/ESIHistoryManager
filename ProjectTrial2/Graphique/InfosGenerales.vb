Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable()>
Public Class InfosGenerales

    Public wilaya As New List(Of String)
    Public wilayaarabe As New List(Of String)
    Public codewilaya As New List(Of String)
    Public section As New List(Of String)
    Public groupe As New List(Of String)
    Public matiere As New List(Of String)
    Public Shared sexe() As String = {"Homme", "Femme", "Autre"}
    Public Shared specialite() As String = {"TRC", "SI", "SIQ"}
    Public Shared promo() As String = {"01", "02", "03", "04", "05"}
    Public seribac As New List(Of String)
    Public Shared Annee() As String = {"00", "01", "02", "03", "04", "05", "06", "08", "09", "10", "11", "88", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "TR"}
    Public Shared firstYear As Integer = 1989
    Public Shared lastYear As Integer = 2011

    Public Sub New()
        wilaya = Recherche.GetALL(BDD.champsWILAYA, BDD.nomTableEtudiant)
        'groupe = Recherche.GetALL(BDD.champsNG)
        'section = Recherche.GetALL(BDD.champsNS)
        'matiere = Recherche.GetALL(BDD.champsCOMAMA)
        'wilayaarabe = Recherche.GetALL(BDD.champsWilayaNaisA, BDD.nomTableEtudiant)
        'seribac = Recherche.GetALL(BDD.champsSERIEBAC, BDD.nomTableEtudiant)
        codewilaya = Recherche.GetALL(BDD.champsWILNAIS, BDD.nomTableEtudiant)

        For Each item As String In seribac
            Console.WriteLine(item)
        Next

    End Sub

End Class



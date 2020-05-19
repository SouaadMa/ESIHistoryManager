Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable()>
Public Class InfosGenerales

    Public wilayaactuelle As DataTable = Nothing
    Public wilayaNaissanceArabe As DataTable = Nothing
    Public codewilayaN As DataTable = Nothing
    Public codesPostales As DataTable = Nothing
    Public wilayaBAC As DataTable = Nothing

    Public section As DataTable = Nothing
    Public groupe As DataTable = Nothing
    Public matiere As DataTable = Nothing
    Public seribac As DataTable = Nothing

    Public Shared sexe() As String = {"Autre", "Homme", "Femme"}
    Public Shared specialite() As String = {"TRC", "SI", "SIQ"}
    Public Shared promo() As String = {"1", "2", "3", "4", "5"}
    Public Shared Annee() As String = {"00", "01", "02", "03", "04", "05", "06", "08", "09", "10", "11", "88", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "TR"}
    Public Shared firstYear As Integer = 1989
    Public Shared lastYear As Integer = 2011

    Public Sub New()
        'Wilayas Actuelles
        wilayaactuelle = Recherche.GetALL(BDD.champsWILAYA, BDD.nomTableEtudiant)
        wilayaactuelle.PrimaryKey = {wilayaactuelle.Columns.Item(BDD.champsWILAYA)}

        wilayaNaissanceArabe = Recherche.GetALL(BDD.champsWilayaNaisA, BDD.nomTableEtudiant)
        wilayaNaissanceArabe.PrimaryKey = {wilayaNaissanceArabe.Columns.Item(BDD.champsWilayaNaisA)}

        codewilayaN = Recherche.GetALL(BDD.champsWILNAIS, BDD.nomTableEtudiant)
        codewilayaN.PrimaryKey = {codewilayaN.Columns.Item(BDD.champsWILNAIS)}

        wilayaBAC = Recherche.GetALL(BDD.champsWILBAC, BDD.nomTableEtudiant)
        wilayaBAC.PrimaryKey = {wilayaBAC.Columns.Item(BDD.champsWILBAC)}

        seribac = Recherche.GetALL(BDD.champsSERIEBAC, BDD.nomTableEtudiant)

        groupe = Recherche.GetALL(BDD.champsCodeGroupe, BDD.nomTableGROUP)
        section = Recherche.GetALL(BDD.champsCodeSection, BDD.nomTableSection)
        matiere = Recherche.GetALL(BDD.champsCOMAMA, BDD.nomTableMATIERE)

    End Sub

    Public Shared Function Recover() As InfosGenerales
        Dim stream As FileStream
        stream = File.OpenRead("InfosGenerale.bin")

        'create the binary formatter
        Dim formatter As New BinaryFormatter
        Dim obj As InfosGenerales = formatter.Deserialize(stream)

        stream.Close()

        Return obj
    End Function

    Public Sub Save()
        'open our filestream
        Dim stream As FileStream
        stream = File.OpenWrite("InfosGenerale.bin")

        'create the binary formatter
        Dim formatter As New BinaryFormatter
        formatter.Serialize(stream, Me)
        stream.Close()
    End Sub

    Public Function isEmpty() As Boolean


        Return (wilayaactuelle Is Nothing Or wilayaBAC Is Nothing Or wilayaNaissanceArabe Is Nothing Or codesPostales Is Nothing Or codewilayaN Is Nothing Or section Is Nothing Or groupe Is Nothing Or seribac Is Nothing Or promo Is Nothing)


    End Function

    Public Sub reFill()

        If wilayaactuelle Is Nothing Then

            wilayaactuelle = Recherche.GetALL(BDD.champsWILAYA, BDD.nomTableEtudiant)
            wilayaactuelle.PrimaryKey = {wilayaactuelle.Columns.Item(BDD.champsWILAYA)}
        End If

        If wilayaNaissanceArabe Is Nothing Then

            wilayaNaissanceArabe = Recherche.GetALL(BDD.champsWilayaNaisA, BDD.nomTableEtudiant)
            wilayaNaissanceArabe.PrimaryKey = {wilayaNaissanceArabe.Columns.Item(BDD.champsWilayaNaisA)}
        End If

        If codewilayaN Is Nothing Then
            codewilayaN = Recherche.GetALL(BDD.champsWILNAIS, BDD.nomTableEtudiant)
            codewilayaN.PrimaryKey = {codewilayaN.Columns.Item(BDD.champsWILNAIS)}
        End If

        If wilayaBAC Is Nothing Then
            wilayaBAC = Recherche.GetALL(BDD.champsWILBAC, BDD.nomTableEtudiant)
            wilayaBAC.PrimaryKey = {wilayaBAC.Columns.Item(BDD.champsWILBAC)}
        End If

        If seribac Is Nothing Then
            seribac = Recherche.GetALL(BDD.champsSERIEBAC, BDD.nomTableEtudiant)
        End If

        If groupe Is Nothing Then
            groupe = Recherche.GetALL(BDD.champsCodeGroupe, BDD.nomTableGROUP)
        End If
        If section Is Nothing Then
            section = Recherche.GetALL(BDD.champsCodeSection, BDD.nomTableSection)

        End If
        If matiere Is Nothing Then
            matiere = Recherche.GetALL(BDD.champsCOMAMA, BDD.nomTableMATIERE)
        End If



    End Sub


End Class



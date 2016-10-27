
Imports System.IO

Public Class Database

    Public Const FILEPATH = "C:/Users/bpctsite/Desktop\quotasBasesMails"

    Private Const FILE_HEADER = "quotas"

    Private Const FILE_END = "0825"

    Private users As Dictionary(Of String, User)

    Public Sub New()
        MyBase.New
        Me.users = New Dictionary(Of String, User)
    End Sub


    Public Function getUser(ByVal name As String) As User
        Return Me.users.Values(name.ToLower)

    End Function


    Public Sub addUser(ByVal user As User)
        Me.users.Add(user.getName.ToLower, user)
    End Sub


    Public Function isUserRegistered(ByVal name As String) As Boolean
        Return Me.getUser(name) IsNot Nothing
    End Function



    Public Sub loadCSV(ByRef aDate As Integer)


        Dim lstString As New List(Of String)
        Dim ligne As String
        Dim filepath2 = (FILEPATH + FILE_HEADER + aDate + FILE_END + ".csv")
        Dim reader As New StreamReader(filepath2)



        While reader.Peek <> -1
            ligne = reader.ReadLine()
            lstString.Add(ligne)

            Dim entry() As String = ligne.Split(";")
            Dim user As User = Me.getUser(entry(2))

            If (user Is Nothing) Then
                user = New User(entry(2), entry(3))
                Me.addUser(user)
            End If

            Dim data As Data = New Data(Integer.Parse(entry(0)), Single.Parse(entry(1)))
            user.addData(aDate, data)

        End While

        MsgBox("Nombre de ligne=" & lstString.Count)
        reader.Close()


    End Sub






    Public Sub clear()
        Me.users.Clear()
    End Sub
End Class

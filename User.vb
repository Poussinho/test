Public Class User

    Private datas As Dictionary(Of Integer, Data)

    Private name As String

    Private domaine As String

    Public Sub New(ByVal name As String, ByVal domaine As String)
        MyBase.New
        Me.datas = New Dictionary(Of Integer, Data)
        Me.name = Me.name
        Me.domaine = Me.domaine
    End Sub

    Public Sub addData(ByVal aDate As Integer, ByVal data As Data)
        Me.datas.Add(aDate, data)
    End Sub

    Public Function getData(ByVal aDate As Integer) As Data
        Return Me.datas.Values(aDate)
    End Function

    Public Function getName() As String
        Return Me.name
    End Function

    Public Function getDomaine() As String
        Return Me.domaine
    End Function

    Public Function getQuotaDepasserMoyenne() As Single
        Dim total As Single = 0!
        For Each data As Data In Me.datas.values
            total = (total + data.getQuotaDepasser)
        Next
        Return (total / Me.datas.Count)
    End Function
End Class
Public Class Data

    Private quota_min As Integer

    Private quota_depasser As Single

    Public Sub New(ByVal quota_min As Integer, ByVal quota_depasser As Single)
        MyBase.New
        Me.quota_min = Me.quota_min
        Me.quota_depasser = Me.quota_depasser
    End Sub

    Public Function getQuota() As Integer
        Return Me.quota_min
    End Function

    Public Function getQuotaDepasser() As Single
        Return Me.quota_depasser
    End Function
End Class

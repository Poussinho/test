Imports System.Globalization
Imports System.Windows
Imports VisionCotat.My.MyProject

Public Class VisionCotat


    Private Sub DateFirst_ValueChanged(sender As Object, e As EventArgs) Handles DateFirst.ValueChanged

        Dim laDate As Date = DateFirst.Value.Date
        Dim newDate As Integer = laDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture)

    End Sub

    Private Sub DateSecond_ValueChanged(sender As Object, e As EventArgs) Handles DateSecond.ValueChanged
        Dim laDate2 As Date = DateSecond.Value.Date
        Dim newDate2 As String = laDate2.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
    End Sub


    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        Dim data As Database = New Database

        data.loadCSV(20160404)

    End Sub


    Private Sub DateFirst_ValueChanged()
        Throw New NotImplementedException()
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        If MessageBox.Show("Voulez-vous vraiment quitter?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub QuotaMin_TextClick(sender As Object, e As EventArgs) Handles QuotaMin.Click
        Me.QuotaMin.Text = ""
    End Sub

    Private Sub QuotaMin_TextChanged(sender As Object, e As EventArgs) Handles QuotaMin.TextChanged


    End Sub


    Private Sub QuotaMax_TextClick(sender As Object, e As EventArgs) Handles QuotaMax.Click
        Me.QuotaMax.Text = ""
    End Sub

    Private Sub QuotaMax_TextChanged(sender As Object, e As EventArgs) Handles QuotaMax.TextChanged

    End Sub

End Class

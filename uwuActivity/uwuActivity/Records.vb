Public Class frmRecords

    Public Sub AddRecords(ByVal sNum As String, ByVal sName As String, ByVal cc103 As Double, ByVal is101 As Double, ByVal webdev As Double)
        Dim ave As Double = (cc103 + is101 + webdev) / 3

        Dim newItem As New ListViewItem(sNum)
        newItem.SubItems.Add(sName)
        newItem.SubItems.Add(cc103.ToString())
        newItem.SubItems.Add(is101.ToString())
        newItem.SubItems.Add(webdev.ToString())
        newItem.SubItems.Add(ave.ToString())

        lvRecords.Items.Add(newItem)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lvRecords.Items.Clear()
    End Sub

End Class

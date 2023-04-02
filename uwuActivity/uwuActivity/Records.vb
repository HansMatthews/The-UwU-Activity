Public Class frmRecords

    Private cc103Total As Double = 0
    Private is101Total As Double = 0
    Private webdevTotal As Double = 0
    Private peTotal As Double = 0
    Private i As Integer = 0

    Public Sub AddRecords(ByVal sNum As String, ByVal sName As String, ByVal cc103 As Double, ByVal is101 As Double, ByVal webdev As Double, ByVal pe As Double)
        Dim ave As Double = (cc103 + is101 + webdev + pe) / 4
        ave = Format(Val(ave), "0.00")

        Dim newItem As New ListViewItem()

        newItem.Text = sNum
        newItem.SubItems.Add(sName)
        newItem.SubItems.Add(cc103.ToString())
        newItem.SubItems.Add(is101.ToString())
        newItem.SubItems.Add(webdev.ToString())
        newItem.SubItems.Add(pe.ToString())
        newItem.SubItems.Add(ave.ToString())

        lvRecords.Items.Add(newItem)

        cc103Total += cc103
        is101Total += is101
        webdevTotal += webdev
        peTotal += pe
        i += 1

        ComSubAve()

    End Sub

    Private Sub ComSubAve()
        If i > 0 Then
            Dim cc103Ave As Double = cc103Total / i
            lblCc103.Text = cc103Ave.ToString("0.00")

            Dim is101Ave As Double = is101Total / i
            lblIs101.Text = is101Ave.ToString("0.00")

            Dim webdevAve As Double = webdevTotal / i
            lblWebdev.Text = webdevAve.ToString("0.00")

            Dim peAve As Double = peTotal / i
            lblPe.Text = peAve.ToString("0.00")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lvRecords.Items.Clear()
        lblCc103.Text = ""
        lblIs101.Text = ""
        lblWebdev.Text = ""
        lblPe.Text = ""

    End Sub
End Class
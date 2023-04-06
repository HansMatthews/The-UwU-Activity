Public Class frmRecords

    Public cc103Total As Double = 0
    Public is101Total As Double = 0
    Public webdevTotal As Double = 0
    Public peTotal As Double = 0
    Public i As Integer = 0

    Private selectedItem As ListViewItem

    Public Sub SubAveComp()

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

    Public Sub Records(ByVal sNum As String, ByVal sName As String, ByVal cc103 As Double, ByVal is101 As Double, ByVal webdev As Double, ByVal pe As Double)

        Dim newItem As New ListViewItem()

        newItem.Text = sNum
        newItem.SubItems.Add(sName)
        newItem.SubItems.Add(cc103.ToString())
        newItem.SubItems.Add(is101.ToString())
        newItem.SubItems.Add(webdev.ToString())
        newItem.SubItems.Add(pe.ToString())

        lvRecords.Items.Add(newItem)

        cc103Total += cc103
        is101Total += is101
        webdevTotal += webdev
        peTotal += pe
        i += 1

        Dim ave As Double = (cc103Total + is101Total + webdevTotal + peTotal) / (i * 4)
        ave = Format(Val(ave), "0.00")
        newItem.SubItems.Add(ave.ToString())

        SubAveComp()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lvRecords.Items.Clear()
        lblCc103.Text = ""
        lblIs101.Text = ""
        lblWebdev.Text = ""
        lblPe.Text = ""

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If btnDelete.Tag IsNot Nothing Then
            If MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Dim item As ListViewItem = CType(btnDelete.Tag, ListViewItem)

                cc103Total -= Val(item.SubItems(2).Text)
                is101Total -= Val(item.SubItems(3).Text)
                webdevTotal -= Val(item.SubItems(4).Text)
                peTotal -= Val(item.SubItems(5).Text)
                i -= 1

                lvRecords.Items.Remove(item)
                btnDelete.Tag = Nothing

                SubAveComp()
            End If
        End If
    End Sub

    Public Sub lvRecords_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRecords.SelectedIndexChanged

        selectedItem = lvRecords.SelectedItems.Cast(Of ListViewItem)().FirstOrDefault()
        btnDelete.Tag = selectedItem
        btnEdit.Tag = selectedItem

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If btnEdit.Tag IsNot Nothing Then
            Dim selectedItem As ListViewItem = Me.lvRecords.SelectedItems(0)

            Dim editForm As New Edit(selectedItem)
            editForm.btnUpdate.Tag = selectedItem

            editForm.Show()

            editForm.txtStNum.Text = selectedItem.Text
            editForm.txtStName.Text = selectedItem.SubItems(1).Text
            editForm.txtCc103.Text = selectedItem.SubItems(2).Text
            editForm.txtIs101.Text = selectedItem.SubItems(3).Text
            editForm.txtWebdev.Text = selectedItem.SubItems(4).Text
            editForm.txtPe.Text = selectedItem.SubItems(5).Text

        Else
            MessageBox.Show("Please select a record to edit")
        End If
    End Sub
End Class
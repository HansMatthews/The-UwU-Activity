Public Class Edit
    Private selectedItem As ListViewItem

    Public Sub New(ByVal item As ListViewItem)
        InitializeComponent()
        selectedItem = item

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim sNum As String = txtStNum.Text
        Dim sName As String = txtStName.Text
        Dim cc103 As Double = Double.Parse(txtCc103.Text, cc103)
        Dim is101 As Double = Double.Parse(txtIs101.Text, is101)
        Dim webdev As Double = Double.Parse(txtWebdev.Text, webdev)
        Dim pe As Double = Double.Parse(txtPe.Text, pe)

        selectedItem.Text = sNum
        selectedItem.SubItems(1).Text = sName
        selectedItem.SubItems(2).Text = cc103
        selectedItem.SubItems(3).Text = is101
        selectedItem.SubItems(4).Text = webdev
        selectedItem.SubItems(5).Text = pe

        Dim RecordForm As New frmRecords()
        RecordForm.Records(sNum, sName, cc103, is101, webdev, pe)

        ClearData()

    End Sub

    Private Sub ClearData()

        txtStNum.Text = ""
        txtStName.Text = ""
        txtCc103.Text = ""
        txtIs101.Text = ""
        txtWebdev.Text = ""
        txtPe.Text = ""

        Me.Hide()

    End Sub
End Class
Public Class frmAddRecords
    Private recordsForm As frmRecords

    Private Sub btnGetRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetRec.Click
        Dim sNum As String = txtStNum.Text
        Dim sName As String = txtStName.Text
        Dim cc103 As Double = Val(txtCc103.Text)
        Dim is101 As Double = Val(txtIs101.Text)
        Dim webdev As Double = Val(txtWebdev.Text)
        Dim pe As Double = Val(txtPe.Text)

        If recordsForm Is Nothing OrElse recordsForm.IsDisposed Then
            recordsForm = New frmRecords
        End If

        recordsForm.Records(sNum, sName, cc103, is101, webdev, pe)

        recordsForm.Show()
        ClearData()

    End Sub

    Private Sub ClearData()

        txtStNum.Text = ""
        txtStName.Text = ""
        txtCc103.Text = ""
        txtIs101.Text = ""
        txtWebdev.Text = ""
        txtPe.Text = ""

        txtStNum.Focus()
        frmRecords.Focus()

    End Sub
End Class

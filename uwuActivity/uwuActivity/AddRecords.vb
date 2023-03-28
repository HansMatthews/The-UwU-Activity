﻿Public Class frmAddRecords
    Private recordsForm As frmRecords

    Private Sub btnGetRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetRec.Click
        Dim sNum As String = txtStNum.Text
        Dim sName As String = txtStNum.Text
        Dim cc103 As Double = Double.Parse(txtCc103.Text)
        Dim is101 As Double = Double.Parse(txtIs101.Text)
        Dim webdev As Double = Double.Parse(txtWebDev.Text)

        Dim newItem As New ListViewItem(sNum)
        newItem.SubItems.Add(sName)
        newItem.SubItems.Add(cc103.ToString())
        newItem.SubItems.Add(is101.ToString())
        newItem.SubItems.Add(webdev.ToString())

        Dim ave As Double = (cc103 + is101 + webdev) / 3
        newItem.SubItems.Add(ave.ToString())

        If recordsForm Is Nothing Then
            recordsForm = New frmRecords
        End If

        recordsForm.AddRecords(sNum, sName, cc103, is101, webdev)
        recordsForm.Show()

        txtStNum.Text = ""
        txtStNum.Text = ""
        txtCc103.Text = ""
        txtIs101.Text = ""
        txtWebDev.Text = ""

    End Sub

End Class
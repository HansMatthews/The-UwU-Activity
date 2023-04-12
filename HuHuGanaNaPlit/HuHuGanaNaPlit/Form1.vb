Public Class frmRecord

    Dim studentNumber As String
    Dim studentName As String
    Dim subject1 As Double
    Dim subject2 As Double
    Dim subject3 As Double
    Dim subject4 As Double

    Dim studentAverage As Double
    Dim subject1Average As Double
    Dim subject2Average As Double
    Dim subject3Average As Double
    Dim subject4Average As Double

    Dim selectedItem As ListViewItem

    Private Sub lvRecords_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvRecords.SelectedIndexChanged

        selectedItem = lvRecords.SelectedItems.Cast(Of ListViewItem)().FirstOrDefault()
        btnEdit.Tag = selectedItem
        btnDelete.Tag = selectedItem

    End Sub

    Private Sub btnGetRec_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetRec.Click

        studentNumber = txtStudentNumber.Text
        studentName = txtStudentName.Text
        subject1 = CDbl(txtSubject1.Text)
        subject2 = CDbl(txtSubject2.Text)
        subject3 = CDbl(txtSubject3.Text)
        subject4 = CDbl(txtSubject4.Text)

        studentAverage = (subject1 + subject2 + subject3 + subject4) / 4

        Dim newItem As New ListViewItem()

        newItem.Text = studentNumber
        newItem.SubItems.Add(studentName)
        newItem.SubItems.Add(subject1)
        newItem.SubItems.Add(subject2)
        newItem.SubItems.Add(subject3)
        newItem.SubItems.Add(subject4)
        newItem.SubItems.Add(studentAverage)

        lvRecords.Items.Add(newItem)

        SubAve()
        ClearTxt()
        txtStudentNumber.Focus()

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click

        studentNumber = txtStudentNumber.Text
        studentName = txtStudentName.Text
        subject1 = Integer.Parse(txtSubject1.Text)
        subject2 = Integer.Parse(txtSubject2.Text)
        subject3 = Integer.Parse(txtSubject3.Text)
        subject4 = Integer.Parse(txtSubject4.Text)

        studentAverage = (subject1 + subject2 + subject3 + subject4) / 4

        selectedItem.SubItems(0).Text = studentNumber
        selectedItem.SubItems(1).Text = studentName
        selectedItem.SubItems(2).Text = subject1.ToString()
        selectedItem.SubItems(3).Text = subject2.ToString()
        selectedItem.SubItems(4).Text = subject3.ToString()
        selectedItem.SubItems(5).Text = subject4.ToString()
        selectedItem.SubItems(6).Text = studentAverage.ToString()

        SubAve()
        Clean()
        txtStudentNumber.Focus()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        txtStudentNumber.Focus()

        If lvRecords.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvRecords.SelectedItems(0)

            txtStudentNumber.Text = selectedItem.SubItems(0).Text
            txtStudentName.Text = selectedItem.SubItems(1).Text
            txtSubject1.Text = selectedItem.SubItems(2).Text
            txtSubject2.Text = selectedItem.SubItems(3).Text
            txtSubject3.Text = selectedItem.SubItems(4).Text
            txtSubject4.Text = selectedItem.SubItems(5).Text
        Else
            MessageBox.Show("Please select an item from the list view to edit.")
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If btnDelete.Tag IsNot Nothing Then
            If MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim item As ListViewItem = CType(btnDelete.Tag, ListViewItem)

                Dim subject1Total As Double = 0
                Dim subject2Total As Double = 0
                Dim subject3Total As Double = 0
                Dim subject4Total As Double = 0

                For i As Integer = 0 To lvRecords.Items.Count - 1
                    If lvRecords.Items(i) Is item Then
                        subject1Total -= CDbl(item.SubItems(2).Text)
                        subject2Total -= CDbl(item.SubItems(3).Text)
                        subject3Total -= CDbl(item.SubItems(4).Text)
                        subject4Total -= CDbl(item.SubItems(5).Text)
                    Else
                        subject1Total += CDbl(lvRecords.Items(i).SubItems(2).Text)
                        subject2Total += CDbl(lvRecords.Items(i).SubItems(3).Text)
                        subject3Total += CDbl(lvRecords.Items(i).SubItems(4).Text)
                        subject4Total += CDbl(lvRecords.Items(i).SubItems(5).Text)
                    End If
                Next

                lblSubject1Average.Text = subject1Total.ToString("0.00")
                lblSubject2Average.Text = subject2Total.ToString("0.00")
                lblSubject3Average.Text = subject3Total.ToString("0.00")
                lblSubject4Average.Text = subject4Total.ToString("0.00")

                lvRecords.Items.Remove(item)
                btnDelete.Tag = Nothing
            End If
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lvRecords.Items.Clear()
        txtSubject1.Text = ""
        txtSubject2.Text = ""
        txtSubject3.Text = ""
        txtSubject4.Text = ""

    End Sub

    Private Sub SubAve()

        Dim numStudents As Integer = lvRecords.Items.Count
        Dim subject1Total As Double = 0
        Dim subject2Total As Double = 0
        Dim subject3Total As Double = 0
        Dim subject4Total As Double = 0

        For Each item As ListViewItem In lvRecords.Items
            subject1Total += CDbl(item.SubItems(2).Text)
            subject2Total += CDbl(item.SubItems(3).Text)
            subject3Total += CDbl(item.SubItems(4).Text)
            subject4Total += CDbl(item.SubItems(5).Text)
        Next

        If numStudents > 1 Then
            subject1Average = subject1Total / numStudents
            subject2Average = subject2Total / numStudents
            subject3Average = subject3Total / numStudents
            subject4Average = subject4Total / numStudents

            lblSubject1Average.Text = subject1Average.ToString("0.00")
            lblSubject2Average.Text = subject2Average.ToString("0.00")
            lblSubject3Average.Text = subject3Average.ToString("0.00")
            lblSubject4Average.Text = subject4Average.ToString("0.00")
        Else
            lblSubject1Average.Text = "-"
            lblSubject2Average.Text = "-"
            lblSubject3Average.Text = "-"
            lblSubject4Average.Text = "-"
        End If

    End Sub

    Private Sub ClearTxt()

        txtStudentNumber.Clear()
        txtStudentName.Clear()
        txtSubject1.Clear()
        txtSubject2.Clear()
        txtSubject3.Clear()
        txtSubject4.Clear()
        txtStudentNumber.Focus()

    End Sub

    Private Sub Clean()

        txtStudentNumber.Clear()
        txtStudentName.Clear()
        txtSubject1.Clear()
        txtSubject2.Clear()
        txtSubject3.Clear()
        txtSubject4.Clear()
        txtStudentNumber.Focus()

    End Sub

    Private Sub frmRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddHandler lvRecords.SelectedIndexChanged, AddressOf lvRecords_SelectedIndexChanged

    End Sub

End Class

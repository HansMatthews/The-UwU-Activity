<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecord))
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblSubject3Average = New System.Windows.Forms.Label
        Me.lblSubject2Average = New System.Windows.Forms.Label
        Me.lblSubject1Average = New System.Windows.Forms.Label
        Me.lvRecords = New System.Windows.Forms.ListView
        Me.chSNumber = New System.Windows.Forms.ColumnHeader
        Me.chSName = New System.Windows.Forms.ColumnHeader
        Me.chCc103 = New System.Windows.Forms.ColumnHeader
        Me.chIs101 = New System.Windows.Forms.ColumnHeader
        Me.chWebdev = New System.Windows.Forms.ColumnHeader
        Me.chPe = New System.Windows.Forms.ColumnHeader
        Me.chAve = New System.Windows.Forms.ColumnHeader
        Me.btnGetRec = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtSubject4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSubject3 = New System.Windows.Forms.TextBox
        Me.txtSubject2 = New System.Windows.Forms.TextBox
        Me.txtSubject1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtStudentName = New System.Windows.Forms.TextBox
        Me.txtStudentNumber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSubject4Average = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Tomato
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(495, 409)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(191, 73)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Orange
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(296, 409)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(193, 73)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(692, 409)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(193, 73)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Delete All Records"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblSubject3Average
        '
        Me.lblSubject3Average.AutoSize = True
        Me.lblSubject3Average.Location = New System.Drawing.Point(718, 392)
        Me.lblSubject3Average.Name = "lblSubject3Average"
        Me.lblSubject3Average.Size = New System.Drawing.Size(10, 13)
        Me.lblSubject3Average.TabIndex = 11
        Me.lblSubject3Average.Text = "-"
        '
        'lblSubject2Average
        '
        Me.lblSubject2Average.AutoSize = True
        Me.lblSubject2Average.Location = New System.Drawing.Point(658, 393)
        Me.lblSubject2Average.Name = "lblSubject2Average"
        Me.lblSubject2Average.Size = New System.Drawing.Size(10, 13)
        Me.lblSubject2Average.TabIndex = 9
        Me.lblSubject2Average.Text = "-"
        '
        'lblSubject1Average
        '
        Me.lblSubject1Average.AutoSize = True
        Me.lblSubject1Average.Location = New System.Drawing.Point(596, 392)
        Me.lblSubject1Average.Name = "lblSubject1Average"
        Me.lblSubject1Average.Size = New System.Drawing.Size(10, 13)
        Me.lblSubject1Average.TabIndex = 99
        Me.lblSubject1Average.Text = "-"
        '
        'lvRecords
        '
        Me.lvRecords.BackColor = System.Drawing.Color.PeachPuff
        Me.lvRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvRecords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chSNumber, Me.chSName, Me.chCc103, Me.chIs101, Me.chWebdev, Me.chPe, Me.chAve})
        Me.lvRecords.Font = New System.Drawing.Font("Malgun Gothic Semilight", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRecords.FullRowSelect = True
        Me.lvRecords.GridLines = True
        Me.lvRecords.HoverSelection = True
        Me.lvRecords.Location = New System.Drawing.Point(296, 12)
        Me.lvRecords.Name = "lvRecords"
        Me.lvRecords.Size = New System.Drawing.Size(589, 378)
        Me.lvRecords.TabIndex = 11
        Me.lvRecords.UseCompatibleStateImageBehavior = False
        Me.lvRecords.View = System.Windows.Forms.View.Details
        '
        'chSNumber
        '
        Me.chSNumber.Text = "ID NO."
        Me.chSNumber.Width = 90
        '
        'chSName
        '
        Me.chSName.Text = "STUDENT NAME"
        Me.chSName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chSName.Width = 200
        '
        'chCc103
        '
        Me.chCc103.Text = "CC 103"
        Me.chCc103.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chIs101
        '
        Me.chIs101.Text = "IS 101"
        Me.chIs101.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chWebdev
        '
        Me.chWebdev.Text = "WEBDEV"
        Me.chWebdev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chPe
        '
        Me.chPe.Text = "PE"
        Me.chPe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chAve
        '
        Me.chAve.Text = "GWA"
        Me.chAve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGetRec
        '
        Me.btnGetRec.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnGetRec.FlatAppearance.BorderSize = 0
        Me.btnGetRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.btnGetRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.btnGetRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetRec.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetRec.Location = New System.Drawing.Point(12, 299)
        Me.btnGetRec.Name = "btnGetRec"
        Me.btnGetRec.Size = New System.Drawing.Size(249, 61)
        Me.btnGetRec.TabIndex = 6
        Me.btnGetRec.Text = "ADD RECORD"
        Me.btnGetRec.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSubject4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtSubject3)
        Me.GroupBox2.Controls.Add(Me.txtSubject2)
        Me.GroupBox2.Controls.Add(Me.txtSubject1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 175)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grades"
        '
        'txtSubject4
        '
        Me.txtSubject4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubject4.Location = New System.Drawing.Point(94, 122)
        Me.txtSubject4.MaxLength = 5
        Me.txtSubject4.Name = "txtSubject4"
        Me.txtSubject4.Size = New System.Drawing.Size(39, 21)
        Me.txtSubject4.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 14)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "PE"
        '
        'txtSubject3
        '
        Me.txtSubject3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubject3.Location = New System.Drawing.Point(94, 96)
        Me.txtSubject3.MaxLength = 5
        Me.txtSubject3.Name = "txtSubject3"
        Me.txtSubject3.Size = New System.Drawing.Size(39, 21)
        Me.txtSubject3.TabIndex = 4
        '
        'txtSubject2
        '
        Me.txtSubject2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubject2.Location = New System.Drawing.Point(94, 67)
        Me.txtSubject2.MaxLength = 5
        Me.txtSubject2.Name = "txtSubject2"
        Me.txtSubject2.Size = New System.Drawing.Size(39, 21)
        Me.txtSubject2.TabIndex = 3
        '
        'txtSubject1
        '
        Me.txtSubject1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubject1.Location = New System.Drawing.Point(94, 37)
        Me.txtSubject1.MaxLength = 5
        Me.txtSubject1.Name = "txtSubject1"
        Me.txtSubject1.Size = New System.Drawing.Size(39, 21)
        Me.txtSubject1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 14)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "WEBDEV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 14)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "IS101"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 14)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "CC103"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStudentName)
        Me.GroupBox1.Controls.Add(Me.txtStudentNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student"
        '
        'txtStudentName
        '
        Me.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentName.Location = New System.Drawing.Point(98, 58)
        Me.txtStudentName.MaxLength = 70
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(145, 21)
        Me.txtStudentName.TabIndex = 1
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentNumber.Location = New System.Drawing.Point(98, 28)
        Me.txtStudentNumber.MaxLength = 8
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(89, 21)
        Me.txtStudentNumber.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student No."
        '
        'lblSubject4Average
        '
        Me.lblSubject4Average.AutoSize = True
        Me.lblSubject4Average.Location = New System.Drawing.Point(780, 392)
        Me.lblSubject4Average.Name = "lblSubject4Average"
        Me.lblSubject4Average.Size = New System.Drawing.Size(10, 13)
        Me.lblSubject4Average.TabIndex = 15
        Me.lblSubject4Average.Text = "-"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(12, 409)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(249, 73)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "UPDATE RECORD"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'frmRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(897, 502)
        Me.Controls.Add(Me.btnGetRec)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblSubject4Average)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblSubject3Average)
        Me.Controls.Add(Me.lblSubject2Average)
        Me.Controls.Add(Me.lblSubject1Average)
        Me.Controls.Add(Me.lvRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(903, 531)
        Me.MinimumSize = New System.Drawing.Size(903, 531)
        Me.Name = "frmRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Records"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblSubject3Average As System.Windows.Forms.Label
    Friend WithEvents lblSubject2Average As System.Windows.Forms.Label
    Friend WithEvents lblSubject1Average As System.Windows.Forms.Label
    Friend WithEvents lvRecords As System.Windows.Forms.ListView
    Friend WithEvents chSNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCc103 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chIs101 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chWebdev As System.Windows.Forms.ColumnHeader
    Friend WithEvents chPe As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAve As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnGetRec As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSubject4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSubject3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSubject4Average As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecords))
        Me.lvRecords = New System.Windows.Forms.ListView
        Me.chSNumber = New System.Windows.Forms.ColumnHeader
        Me.chSName = New System.Windows.Forms.ColumnHeader
        Me.chCc103 = New System.Windows.Forms.ColumnHeader
        Me.chIs101 = New System.Windows.Forms.ColumnHeader
        Me.chWebdev = New System.Windows.Forms.ColumnHeader
        Me.chPe = New System.Windows.Forms.ColumnHeader
        Me.chAve = New System.Windows.Forms.ColumnHeader
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblCc103 = New System.Windows.Forms.Label
        Me.lblIs101 = New System.Windows.Forms.Label
        Me.lblWebdev = New System.Windows.Forms.Label
        Me.lblPe = New System.Windows.Forms.Label
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lvRecords
        '
        Me.lvRecords.BackColor = System.Drawing.Color.Silver
        Me.lvRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvRecords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chSNumber, Me.chSName, Me.chCc103, Me.chIs101, Me.chWebdev, Me.chPe, Me.chAve})
        Me.lvRecords.Font = New System.Drawing.Font("Malgun Gothic Semilight", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRecords.FullRowSelect = True
        Me.lvRecords.GridLines = True
        Me.lvRecords.HoverSelection = True
        Me.lvRecords.Location = New System.Drawing.Point(-1, -1)
        Me.lvRecords.Name = "lvRecords"
        Me.lvRecords.Size = New System.Drawing.Size(589, 378)
        Me.lvRecords.TabIndex = 0
        Me.lvRecords.UseCompatibleStateImageBehavior = False
        Me.lvRecords.View = System.Windows.Forms.View.Details
        '
        'chSNumber
        '
        Me.chSNumber.Text = "Student Number"
        Me.chSNumber.Width = 90
        '
        'chSName
        '
        Me.chSName.Text = "Student Name"
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
        Me.chWebdev.Text = "WebDev"
        Me.chWebdev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chPe
        '
        Me.chPe.Text = "PE"
        Me.chPe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chAve
        '
        Me.chAve.Text = "AVE"
        Me.chAve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(594, -1)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(260, 103)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Delete All Records"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblCc103
        '
        Me.lblCc103.AutoSize = True
        Me.lblCc103.Location = New System.Drawing.Point(300, 380)
        Me.lblCc103.Name = "lblCc103"
        Me.lblCc103.Size = New System.Drawing.Size(39, 13)
        Me.lblCc103.TabIndex = 2
        Me.lblCc103.Text = "Label1"
        '
        'lblIs101
        '
        Me.lblIs101.AutoSize = True
        Me.lblIs101.Location = New System.Drawing.Point(362, 380)
        Me.lblIs101.Name = "lblIs101"
        Me.lblIs101.Size = New System.Drawing.Size(39, 13)
        Me.lblIs101.TabIndex = 3
        Me.lblIs101.Text = "Label2"
        '
        'lblWebdev
        '
        Me.lblWebdev.AutoSize = True
        Me.lblWebdev.Location = New System.Drawing.Point(421, 380)
        Me.lblWebdev.Name = "lblWebdev"
        Me.lblWebdev.Size = New System.Drawing.Size(39, 13)
        Me.lblWebdev.TabIndex = 4
        Me.lblWebdev.Text = "Label3"
        '
        'lblPe
        '
        Me.lblPe.AutoSize = True
        Me.lblPe.Location = New System.Drawing.Point(480, 381)
        Me.lblPe.Name = "lblPe"
        Me.lblPe.Size = New System.Drawing.Size(39, 13)
        Me.lblPe.TabIndex = 5
        Me.lblPe.Text = "Label3"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Orange
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(594, 190)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(260, 102)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Brown
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(594, 99)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(260, 95)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'frmRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 403)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPe)
        Me.Controls.Add(Me.lblWebdev)
        Me.Controls.Add(Me.lblIs101)
        Me.Controls.Add(Me.lblCc103)
        Me.Controls.Add(Me.lvRecords)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Records"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvRecords As System.Windows.Forms.ListView
    Friend WithEvents chSNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCc103 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chIs101 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chWebdev As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblCc103 As System.Windows.Forms.Label
    Friend WithEvents lblIs101 As System.Windows.Forms.Label
    Friend WithEvents lblWebdev As System.Windows.Forms.Label
    Friend WithEvents chPe As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblPe As System.Windows.Forms.Label
    Friend WithEvents chAve As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button

End Class

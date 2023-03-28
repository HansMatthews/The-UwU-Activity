<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddRecords))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtStNum = New System.Windows.Forms.TextBox
        Me.txtStName = New System.Windows.Forms.TextBox
        Me.txtCc103 = New System.Windows.Forms.TextBox
        Me.txtIs101 = New System.Windows.Forms.TextBox
        Me.txtWebdev = New System.Windows.Forms.TextBox
        Me.btnGetRec = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStName)
        Me.GroupBox1.Controls.Add(Me.txtStNum)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtWebdev)
        Me.GroupBox2.Controls.Add(Me.txtIs101)
        Me.GroupBox2.Controls.Add(Me.txtCc103)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(68, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 154)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grades"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IS101"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CC103"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "WEBDEV"
        '
        'txtStNum
        '
        Me.txtStNum.Location = New System.Drawing.Point(87, 28)
        Me.txtStNum.Name = "txtStNum"
        Me.txtStNum.Size = New System.Drawing.Size(100, 20)
        Me.txtStNum.TabIndex = 2
        '
        'txtStName
        '
        Me.txtStName.Location = New System.Drawing.Point(87, 58)
        Me.txtStName.Name = "txtStName"
        Me.txtStName.Size = New System.Drawing.Size(100, 20)
        Me.txtStName.TabIndex = 3
        '
        'txtCc103
        '
        Me.txtCc103.Location = New System.Drawing.Point(87, 28)
        Me.txtCc103.Name = "txtCc103"
        Me.txtCc103.Size = New System.Drawing.Size(100, 20)
        Me.txtCc103.TabIndex = 4
        '
        'txtIs101
        '
        Me.txtIs101.Location = New System.Drawing.Point(87, 58)
        Me.txtIs101.Name = "txtIs101"
        Me.txtIs101.Size = New System.Drawing.Size(100, 20)
        Me.txtIs101.TabIndex = 5
        '
        'txtWebdev
        '
        Me.txtWebdev.Location = New System.Drawing.Point(87, 87)
        Me.txtWebdev.Name = "txtWebdev"
        Me.txtWebdev.Size = New System.Drawing.Size(100, 20)
        Me.txtWebdev.TabIndex = 6
        '
        'btnGetRec
        '
        Me.btnGetRec.Location = New System.Drawing.Point(104, 319)
        Me.btnGetRec.Name = "btnGetRec"
        Me.btnGetRec.Size = New System.Drawing.Size(138, 66)
        Me.btnGetRec.TabIndex = 2
        Me.btnGetRec.Text = "Add Record"
        Me.btnGetRec.UseVisualStyleBackColor = True
        '
        'frmAddRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 410)
        Me.Controls.Add(Me.btnGetRec)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddRecords"
        Me.Text = "AddRecords"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStName As System.Windows.Forms.TextBox
    Friend WithEvents txtStNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtWebdev As System.Windows.Forms.TextBox
    Friend WithEvents txtIs101 As System.Windows.Forms.TextBox
    Friend WithEvents txtCc103 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGetRec As System.Windows.Forms.Button
End Class

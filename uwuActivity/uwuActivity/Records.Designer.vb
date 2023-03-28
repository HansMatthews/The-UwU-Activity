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
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.btnClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lvRecords
        '
        Me.lvRecords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chSNumber, Me.chSName, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lvRecords.FullRowSelect = True
        Me.lvRecords.GridLines = True
        Me.lvRecords.HoverSelection = True
        Me.lvRecords.Location = New System.Drawing.Point(12, 12)
        Me.lvRecords.Name = "lvRecords"
        Me.lvRecords.Size = New System.Drawing.Size(431, 365)
        Me.lvRecords.TabIndex = 0
        Me.lvRecords.UseCompatibleStateImageBehavior = False
        Me.lvRecords.View = System.Windows.Forms.View.Details
        '
        'chSNumber
        '
        Me.chSNumber.Text = "Student Number"
        Me.chSNumber.Width = 70
        '
        'chSName
        '
        Me.chSName.Text = "Student Name"
        Me.chSName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chSName.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "IS 101"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 40
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CC 103"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 40
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "WebDev"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 40
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "AVE"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 40
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(449, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(166, 54)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Dispose Records"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 389)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lvRecords)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Records"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvRecords As System.Windows.Forms.ListView
    Friend WithEvents chSNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class

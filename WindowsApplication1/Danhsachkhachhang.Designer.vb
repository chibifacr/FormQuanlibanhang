<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Danhsachkhachhang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Danhsachkhachhang))
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.btnload3 = New System.Windows.Forms.Button()
        Me.btnload4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView5
        '
        Me.DataGridView5.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(13, 47)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(500, 250)
        Me.DataGridView5.TabIndex = 0
        '
        'btnload3
        '
        Me.btnload3.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnload3.Location = New System.Drawing.Point(31, 13)
        Me.btnload3.Name = "btnload3"
        Me.btnload3.Size = New System.Drawing.Size(75, 23)
        Me.btnload3.TabIndex = 1
        Me.btnload3.Text = "Tải bảng"
        Me.btnload3.UseVisualStyleBackColor = True
        '
        'btnload4
        '
        Me.btnload4.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnload4.Location = New System.Drawing.Point(132, 13)
        Me.btnload4.Name = "btnload4"
        Me.btnload4.Size = New System.Drawing.Size(75, 23)
        Me.btnload4.TabIndex = 1
        Me.btnload4.Text = "Thoát"
        Me.btnload4.UseVisualStyleBackColor = True
        '
        'Danhsachkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(525, 309)
        Me.Controls.Add(Me.btnload4)
        Me.Controls.Add(Me.btnload3)
        Me.Controls.Add(Me.DataGridView5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Danhsachkhachhang"
        Me.Text = "Danh sách khách hàng"
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents btnload3 As System.Windows.Forms.Button
    Friend WithEvents btnload4 As System.Windows.Forms.Button
End Class

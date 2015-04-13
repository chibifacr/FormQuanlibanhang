<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Danhsachsanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Danhsachsanpham))
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.btnload1 = New System.Windows.Forms.Button()
        Me.btnload2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView4
        '
        Me.DataGridView4.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(13, 47)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(500, 250)
        Me.DataGridView4.TabIndex = 0
        '
        'btnload1
        '
        Me.btnload1.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnload1.Location = New System.Drawing.Point(31, 13)
        Me.btnload1.Name = "btnload1"
        Me.btnload1.Size = New System.Drawing.Size(75, 23)
        Me.btnload1.TabIndex = 1
        Me.btnload1.Text = "Tải bảng"
        Me.btnload1.UseVisualStyleBackColor = True
        '
        'btnload2
        '
        Me.btnload2.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnload2.Location = New System.Drawing.Point(132, 13)
        Me.btnload2.Name = "btnload2"
        Me.btnload2.Size = New System.Drawing.Size(75, 23)
        Me.btnload2.TabIndex = 1
        Me.btnload2.Text = "Thoát"
        Me.btnload2.UseVisualStyleBackColor = True
        '
        'Danhsachsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(525, 309)
        Me.Controls.Add(Me.btnload2)
        Me.Controls.Add(Me.btnload1)
        Me.Controls.Add(Me.DataGridView4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Danhsachsanpham"
        Me.Text = "Danh sách sản phẩm"
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents btnload1 As System.Windows.Forms.Button
    Friend WithEvents btnload2 As System.Windows.Forms.Button
End Class

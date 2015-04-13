<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLNhanvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QLNhanvien))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnadd2 = New System.Windows.Forms.Button()
        Me.txtmaNV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.TxtMatkhau = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnedit2 = New System.Windows.Forms.Button()
        Me.btndelete2 = New System.Windows.Forms.Button()
        Me.btnexit2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(300, 12)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(342, 208)
        Me.DataGridView2.TabIndex = 0
        '
        'btnadd2
        '
        Me.btnadd2.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnadd2.Location = New System.Drawing.Point(300, 235)
        Me.btnadd2.Name = "btnadd2"
        Me.btnadd2.Size = New System.Drawing.Size(75, 23)
        Me.btnadd2.TabIndex = 1
        Me.btnadd2.Text = "Thêm"
        Me.btnadd2.UseVisualStyleBackColor = True
        '
        'txtmaNV
        '
        Me.txtmaNV.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtmaNV.Location = New System.Drawing.Point(116, 19)
        Me.txtmaNV.Name = "txtmaNV"
        Me.txtmaNV.Size = New System.Drawing.Size(166, 20)
        Me.txtmaNV.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã nhân viên"
        '
        'txtTenNV
        '
        Me.txtTenNV.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTenNV.Location = New System.Drawing.Point(116, 45)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(166, 20)
        Me.txtTenNV.TabIndex = 2
        '
        'TxtMatkhau
        '
        Me.TxtMatkhau.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtMatkhau.Location = New System.Drawing.Point(116, 71)
        Me.TxtMatkhau.Name = "TxtMatkhau"
        Me.TxtMatkhau.Size = New System.Drawing.Size(166, 20)
        Me.TxtMatkhau.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(38, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên nhân viên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(38, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mật khẩu"
        '
        'btnedit2
        '
        Me.btnedit2.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnedit2.Location = New System.Drawing.Point(381, 235)
        Me.btnedit2.Name = "btnedit2"
        Me.btnedit2.Size = New System.Drawing.Size(75, 23)
        Me.btnedit2.TabIndex = 1
        Me.btnedit2.Text = "Sửa"
        Me.btnedit2.UseVisualStyleBackColor = True
        '
        'btndelete2
        '
        Me.btndelete2.ForeColor = System.Drawing.Color.OrangeRed
        Me.btndelete2.Location = New System.Drawing.Point(462, 235)
        Me.btndelete2.Name = "btndelete2"
        Me.btndelete2.Size = New System.Drawing.Size(75, 23)
        Me.btndelete2.TabIndex = 1
        Me.btndelete2.Text = "Xóa"
        Me.btndelete2.UseVisualStyleBackColor = True
        '
        'btnexit2
        '
        Me.btnexit2.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnexit2.Location = New System.Drawing.Point(543, 235)
        Me.btnexit2.Name = "btnexit2"
        Me.btnexit2.Size = New System.Drawing.Size(75, 23)
        Me.btnexit2.TabIndex = 1
        Me.btnexit2.Text = "Thoát"
        Me.btnexit2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 138)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Button1.Location = New System.Drawing.Point(12, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 42)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Tải dữ liệu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'QLNhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(654, 289)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMatkhau)
        Me.Controls.Add(Me.txtTenNV)
        Me.Controls.Add(Me.txtmaNV)
        Me.Controls.Add(Me.btnexit2)
        Me.Controls.Add(Me.btndelete2)
        Me.Controls.Add(Me.btnedit2)
        Me.Controls.Add(Me.btnadd2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(113, 19)
        Me.Name = "QLNhanvien"
        Me.Text = "Quản lí nhân viên"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnadd2 As System.Windows.Forms.Button
    Friend WithEvents txtmaNV As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTenNV As System.Windows.Forms.TextBox
    Friend WithEvents TxtMatkhau As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnedit2 As System.Windows.Forms.Button
    Friend WithEvents btndelete2 As System.Windows.Forms.Button
    Friend WithEvents btnexit2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLSanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QLSanpham))
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtloaisp = New System.Windows.Forms.TextBox()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Datagridview = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.btnloaddata = New System.Windows.Forms.Button()
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmasp
        '
        Me.txtmasp.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtmasp.Location = New System.Drawing.Point(104, 19)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(166, 20)
        Me.txtmasp.TabIndex = 0
        '
        'txttensp
        '
        Me.txttensp.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txttensp.Location = New System.Drawing.Point(104, 44)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(166, 20)
        Me.txttensp.TabIndex = 0
        '
        'txtloaisp
        '
        Me.txtloaisp.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtloaisp.Location = New System.Drawing.Point(104, 70)
        Me.txtloaisp.Name = "txtloaisp"
        Me.txtloaisp.Size = New System.Drawing.Size(166, 20)
        Me.txtloaisp.TabIndex = 0
        '
        'txtgia
        '
        Me.txtgia.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtgia.Location = New System.Drawing.Point(104, 96)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(166, 20)
        Me.txtgia.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã sản phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên sản phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(11, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Loại sản phẩm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Giá"
        '
        'txtsoluong
        '
        Me.txtsoluong.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtsoluong.Location = New System.Drawing.Point(104, 122)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(166, 20)
        Me.txtsoluong.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(12, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Số lượng"
        '
        'Datagridview
        '
        Me.Datagridview.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Datagridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagridview.Location = New System.Drawing.Point(297, 15)
        Me.Datagridview.Name = "Datagridview"
        Me.Datagridview.Size = New System.Drawing.Size(342, 208)
        Me.Datagridview.TabIndex = 2
        '
        'btnadd
        '
        Me.btnadd.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnadd.Location = New System.Drawing.Point(297, 241)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 3
        Me.btnadd.Text = "Thêm"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnedit.Location = New System.Drawing.Point(387, 241)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 3
        Me.btnedit.Text = "Sửa"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.ForeColor = System.Drawing.Color.OrangeRed
        Me.btndelete.Location = New System.Drawing.Point(477, 241)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "Xóa"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnexit.Location = New System.Drawing.Point(564, 241)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Thoát"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(104, 177)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 115)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(12, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Mã loại"
        '
        'txtmaloai
        '
        Me.txtmaloai.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtmaloai.Location = New System.Drawing.Point(104, 151)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(166, 20)
        Me.txtmaloai.TabIndex = 0
        '
        'btnloaddata
        '
        Me.btnloaddata.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnloaddata.Location = New System.Drawing.Point(8, 229)
        Me.btnloaddata.Name = "btnloaddata"
        Me.btnloaddata.Size = New System.Drawing.Size(75, 35)
        Me.btnloaddata.TabIndex = 5
        Me.btnloaddata.Text = "Tải dữ liệu"
        Me.btnloaddata.UseVisualStyleBackColor = True
        '
        'QLSanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(654, 289)
        Me.Controls.Add(Me.btnloaddata)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Datagridview)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmaloai)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.txtgia)
        Me.Controls.Add(Me.txtloaisp)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtmasp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QLSanpham"
        Me.Text = "Quản lí sản phẩm"
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtloaisp As System.Windows.Forms.TextBox
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Datagridview As System.Windows.Forms.DataGridView
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents btnloaddata As System.Windows.Forms.Button
End Class

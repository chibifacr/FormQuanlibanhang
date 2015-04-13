Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class QLKhachhang
    Dim tb As New DataTable
    Dim connectstring As String = "workstation id=Quanlibanhang.mssql.somee.com;packet size=4096;user id=chibifacr_SQLLogin_1;pwd=p6fkdkl97e;data source=Quanlibanhang.mssql.somee.com;persist security info=False;initial catalog=Quanlibanhang"

    Public Sub LoadData()
        Dim Connect As New SqlConnection(connectstring)
        Dim sqlAdapter As New SqlDataAdapter("select * from Khachhang", Connect)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        Connect.Close()
    End Sub

    Private Sub Datagridview1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtmaKH.Text = DataGridView1.Item(0, index).Value
        txtTenKH.Text = DataGridView1.Item(1, index).Value
        Txtemail.Text = DataGridView1.Item(2, index).Value
        txtaddress.Text = DataGridView1.Item(3, index).Value
        txtSDT.Text = DataGridView1.Item(4, index).Value
    End Sub

    Private Sub btnadd1_Click(sender As Object, e As EventArgs) Handles btnadd1.Click
        'Ket noi toi Database online thong qua ket noi connecstring
        Dim Connect As New SqlConnection(connectstring)
        'Mo ket noi'
        Connect.Open()
        'Cau lenh truy van de sua du lieu theo ma
        Dim stringadd As String = "Insert into Khachhang values (@MaKH,@TenKH,@Email,@Diachi,@SDT)"
        Dim command As New SqlCommand(stringadd, Connect)
        Try
            command.Parameters.AddWithValue("@MaKH", txtmaKH.Text)
            command.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            command.Parameters.AddWithValue("@Email", Txtemail.Text)
            command.Parameters.AddWithValue("@Diachi", txtaddress.Text)
            command.Parameters.AddWithValue("@SDT", txtSDT.Text)
            'thuc thi cau truy van va sua du lieu trong Database
            command.ExecuteNonQuery()
            'dong ket noi
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        'Tai lai san pham
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnedit1_Click(sender As Object, e As EventArgs) Handles btnedit1.Click
        'Ket noi toi Database online thong qua ket noi connecstring
        Dim Connect As New SqlConnection(connectstring)
        'Mo ket noi'
        Connect.Open()
        'Cau lenh truy van de sua du lieu theo ma
        Dim stringadd As String = "Update Khachhang set TenKH = @TenKH, Email = @Email, Diachi = @Diachi, SDT = @SDT where MaKH = @MaKH"
        Dim command As New SqlCommand(stringadd, Connect)
        Try
            command.Parameters.AddWithValue("@MaKH", txtmaKH.Text)
            command.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            command.Parameters.AddWithValue("@Email", Txtemail.Text)
            command.Parameters.AddWithValue("@Diachi", txtaddress.Text)
            command.Parameters.AddWithValue("@SDT", txtSDT.Text)
            'thuc thi cau truy van va sua du lieu trong Database
            command.ExecuteNonQuery()
            'dong ket noi
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại")
        End Try
        'Tai lai san pham
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btndelete1_Click(sender As Object, e As EventArgs) Handles btndelete1.Click
        Dim Connect As New SqlConnection(connectstring)
        Connect.Open()
        Dim stringadd As String = "Delete from Khachhang where MaKH = @MaKH"
        Dim command As New SqlCommand(stringadd, Connect)
        Try
            command.Parameters.AddWithValue("@MaKH", txtmaKH.Text)
            command.ExecuteNonQuery()
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("xóa không thành công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnexit1_Click(sender As Object, e As EventArgs) Handles btnexit1.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Connect As New SqlConnection(connectstring)
        Dim sqlAdapter As New SqlDataAdapter("select * from Khachhang", Connect)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        Connect.Close()
    End Sub
End Class
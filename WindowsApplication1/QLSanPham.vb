
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class QLSanpham
    Dim tb As New DataTable
    Dim connectstring As String = "workstation id=Quanlibanhang.mssql.somee.com;packet size=4096;user id=chibifacr_SQLLogin_1;pwd=p6fkdkl97e;data source=Quanlibanhang.mssql.somee.com;persist security info=False;initial catalog=Quanlibanhang"

    Public Sub LoadData()
        Dim Connect As New SqlConnection(connectstring)
        Dim sqlAdapter As New SqlDataAdapter("select * from SanPham", Connect)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        Datagridview.DataSource = tb
        Connect.Close()
    End Sub

    Private Sub Datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview.CellContentClick
        Dim index As Integer = Datagridview.CurrentCell.RowIndex
        txtmasp.Text = Datagridview.Item(0, index).Value
        txttensp.Text = Datagridview.Item(1, index).Value
        txtloaisp.Text = Datagridview.Item(2, index).Value
        txtgia.Text = Datagridview.Item(3, index).Value
        txtsoluong.Text = Datagridview.Item(4, index).Value
        txtmaloai.Text = Datagridview.Item(5, index).Value
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        'Ket noi toi Database online thong qua ket noi connecstring
        Dim Connect As New SqlConnection(connectstring)
        'Mo ket noi'
        Connect.Open()
        'Cau lenh truy van de sua du lieu theo ma
        Dim stringadd As String = "Insert into Sanpham values (@MaSP,@TenSP,@LoaiSP,@Gia,@SoluongSP,@LoaiSanPham_Maloai)"
        Dim command As New SqlCommand(stringadd, Connect)
        Try
            command.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            command.Parameters.AddWithValue("@TenSP", txttensp.Text)
            command.Parameters.AddWithValue("@LoaiSP", txtloaisp.Text)
            command.Parameters.AddWithValue("@Gia", txtgia.Text)
            command.Parameters.AddWithValue("@SoluongSP", txtsoluong.Text)
            command.Parameters.AddWithValue("@LoaiSanPham_Maloai", txtmaloai.Text)
            'thuc thi cau truy van va sua du lieu trong Database
            command.ExecuteNonQuery()
            'dong ket noi
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        'Tai lai san pham
        tb.Clear()
        Datagridview.DataSource = tb
        Datagridview.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        'Ket noi toi Database online thong qua ket noi connecstring
        Dim Connect As New SqlConnection(connectstring)
        'Mo ket noi'
        Connect.Open()
        'Cau lenh truy van de sua du lieu theo ma
        Dim stringadd As String = "Update Sanpham set TenSP = @TenSP, LoaiSP = @LoaiSP, Gia = @Gia, SoluongSP = @SoluongSP, LoaiSanPham_Maloai = @LoaiSanPham_Maloai where MaSP = @MaSP"
        Dim command As New SqlCommand(stringadd, Connect)
        Try
            command.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            command.Parameters.AddWithValue("@TenSP", txttensp.Text)
            command.Parameters.AddWithValue("@LoaiSP", txtloaisp.Text)
            command.Parameters.AddWithValue("@Gia", txtgia.Text)
            command.Parameters.AddWithValue("@SoluongSP", txtsoluong.Text)
            command.Parameters.AddWithValue("@LoaiSanPham_Maloai", txtmaloai.Text)
            'thuc thi cau truy van va sua du lieu trong Database
            command.ExecuteNonQuery()
            'dong ket noi
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại")
        End Try
        'Tai lai san pham
        tb.Clear()
        Datagridview.DataSource = tb
        Datagridview.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim Connect As New SqlConnection(connectstring)
        Connect.Open()
        Dim stringadd As String = "Delete from SanPham where MaSP = @MaSP"
        Dim command As New SqlCommand(stringadd, Connect)
        Try
            command.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            command.ExecuteNonQuery()
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("xóa không thành công")
        End Try
        tb.Clear()
        Datagridview.DataSource = tb
        Datagridview.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
    End Sub
    Private Sub btnloaddata_Click(sender As Object, e As EventArgs) Handles btnloaddata.Click
        Dim Connect As New SqlConnection(connectstring)
        Dim sqlAdapter As New SqlDataAdapter("select * from SanPham", Connect)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        Datagridview.DataSource = tb
        Connect.Close()
    End Sub
End Class


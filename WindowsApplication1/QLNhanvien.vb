Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class QLNhanvien
    Dim tb As New DataTable
    Dim connectstring As String = "workstation id=Quanlibanhang.mssql.somee.com;packet size=4096;user id=chibifacr_SQLLogin_1;pwd=p6fkdkl97e;data source=Quanlibanhang.mssql.somee.com;persist security info=False;initial catalog=Quanlibanhang"

    Public Sub LoadData()
        Dim Connect As New SqlConnection(connectstring)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhanvien", Connect)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        DataGridView2.DataSource = tb
        Connect.Close()
    End Sub

    Private Sub Datagridview2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim index As Integer = DataGridView2.CurrentCell.RowIndex
        txtmaNV.Text = DataGridView2.Item(0, index).Value
        txtTenNV.Text = DataGridView2.Item(1, index).Value
        TxtMatkhau.Text = DataGridView2.Item(2, index).Value
    End Sub

    Private Sub btnadd2_Click(sender As Object, e As EventArgs) Handles btnadd2.Click
        'Ket noi toi Database online thong qua ket noi connecstring
        Dim Connect As New SqlConnection(connectstring)
        'Mo ket noi'
        Connect.Open()
        'Cau lenh truy van de sua du lieu theo ma
        Dim stringadd As String = "Insert into Nhanvien values (@MaNV,@TenNV,@Matkhau)"
        Dim command As New SqlCommand(stringadd, Connect)
        Try
            command.Parameters.AddWithValue("@MaNV", txtmaNV.Text)
            command.Parameters.AddWithValue("@TenNV", txtTenNV.Text)
            command.Parameters.AddWithValue("@Matkhau", TxtMatkhau.Text)
            command.ExecuteNonQuery()
            'dong ket noi
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        'Tai lai san pham
        tb.Clear()
        DataGridView2.DataSource = tb
        DataGridView2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnedit2_Click(sender As Object, e As EventArgs) Handles btnedit2.Click
        'Ket noi toi Database online thong qua ket noi connecstring
        Dim Connect As New SqlConnection(connectstring)
        'Mo ket noi'
        Connect.Open()
        'Cau lenh truy van de sua du lieu theo ma
        Dim stringadd As String = "Update Nhanvien set TenNV = @TenNV, Matkhau = @Matkhau where MaNV = @MaNV"
        Dim command As New SqlCommand(stringadd, Connect)
        Try
            command.Parameters.AddWithValue("@MaNV", txtmaNV.Text)
            command.Parameters.AddWithValue("@TenNV", txtTenNV.Text)
            command.Parameters.AddWithValue("@Matkhau", TxtMatkhau.Text)
            'thuc thi cau truy van va sua du lieu trong Database
            command.ExecuteNonQuery()
            'dong ket noi
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại")
        End Try
        'Tai lai san pham
        tb.Clear()
        DataGridView2.DataSource = tb
        DataGridView2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btndelete2_Click(sender As Object, e As EventArgs) Handles btndelete2.Click
        Dim Connect As New SqlConnection(connectstring)
        Connect.Open()
        Dim stringadd As String = "Delete from Nhanvien where MaNV = @MaNV"
        Dim command As New SqlCommand(stringadd, Connect)
        Try
            command.Parameters.AddWithValue("@MaNV", txtmaNV.Text)
            command.ExecuteNonQuery()
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("xóa không thành công")
        End Try
        tb.Clear()
        DataGridView2.DataSource = tb
        DataGridView2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnexit2_Click(sender As Object, e As EventArgs) Handles btnexit2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Connect As New SqlConnection(connectstring)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhanvien", Connect)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        DataGridView2.DataSource = tb
        Connect.Close()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class Login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim connectstring As String = "workstation id=Quanlibanhang.mssql.somee.com;packet size=4096;user id=chibifacr_SQLLogin_1;pwd=p6fkdkl97e;data source=Quanlibanhang.mssql.somee.com;persist security info=False;initial catalog=Quanlibanhang"
        Dim connect As SqlConnection = New SqlConnection(connectstring)
        Dim sqladapter As New SqlDataAdapter("select*from Nhanvien where TenNV='" & txtlogin.Text & "' and Matkhau='" & txtpass.Text & "'", connect)
        Dim tb As New DataTable
        Try
            connect.Open()
            sqladapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                Quanli.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tên đăng nhập và mật khẩu không đúng")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class

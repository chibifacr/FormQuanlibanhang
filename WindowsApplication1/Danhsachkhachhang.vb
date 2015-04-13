Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Danhsachkhachhang
    Dim tb As New DataTable
    Dim connectstring As String = "workstation id=Quanlibanhang.mssql.somee.com;packet size=4096;user id=chibifacr_SQLLogin_1;pwd=p6fkdkl97e;data source=Quanlibanhang.mssql.somee.com;persist security info=False;initial catalog=Quanlibanhang"
    Private Sub btnload3_Click(sender As Object, e As EventArgs) Handles btnload3.Click
        Dim Connect As New SqlConnection(connectstring)
        Dim sqlAdapter2 As New SqlDataAdapter("select * from Khachhang", Connect)
        Try
            sqlAdapter2.Fill(tb)
        Catch ex As Exception

        End Try
        DataGridView5.DataSource = tb
        Connect.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnload4.Click
        Me.Hide()
    End Sub

End Class
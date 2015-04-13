
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Danhsachsanpham
    Dim tb As New DataTable
    Dim connectstring As String = "workstation id=Quanlibanhang.mssql.somee.com;packet size=4096;user id=chibifacr_SQLLogin_1;pwd=p6fkdkl97e;data source=Quanlibanhang.mssql.somee.com;persist security info=False;initial catalog=Quanlibanhang"
    Private Sub btnload1_Click(sender As Object, e As EventArgs) Handles btnload1.Click
        Dim Connect As New SqlConnection(connectstring)
        Dim sqlAdapter2 As New SqlDataAdapter("select * from Sanpham", Connect)
        Try
            sqlAdapter2.Fill(tb)
        Catch ex As Exception

        End Try
        DataGridView4.DataSource = tb
        Connect.Close()
    End Sub

    Private Sub btnload2_Click(sender As Object, e As EventArgs) Handles btnload2.Click
        Me.Hide()
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub
End Class
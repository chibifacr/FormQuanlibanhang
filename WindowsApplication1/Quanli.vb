
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Quanli
    Dim tb As New DataTable
    Dim connectstring As String = "workstation id=Quanlibanhang.mssql.somee.com;packet size=4096;user id=chibifacr_SQLLogin_1;pwd=p6fkdkl97e;data source=Quanlibanhang.mssql.somee.com;persist security info=False;initial catalog=Quanlibanhang"
    Private Sub DanhSáchNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchNhânViênToolStripMenuItem.Click
        Dim Connect As New SqlConnection(connectstring)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhanvien", Connect)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb

        Connect.Close()
    End Sub
    Private Sub QuảnLíSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíSảnPhẩmToolStripMenuItem.Click
        QLSanpham.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        End
    End Sub

    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhậpToolStripMenuItem.Click
        Login.Show()
    End Sub

    Private Sub DanhSáchSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchSảnPhẩmToolStripMenuItem.Click
        Danhsachsanpham.Show()
    End Sub

    Private Sub DanhSáchKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchKháchHàngToolStripMenuItem.Click
        Danhsachkhachhang.Show()
    End Sub

    Private Sub QuảnLíKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíKháchHàngToolStripMenuItem.Click
        QLKhachhang.Show()
    End Sub

    Private Sub QuảnLíĐơnHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíĐơnHàngToolStripMenuItem.Click
        QLNhanvien.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
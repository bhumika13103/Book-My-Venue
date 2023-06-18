Imports System.Data.OleDb
Public Class childVIEWVENUESADMIN
    Private Sub viewvenues()
        Dim cmd As OleDbCommand
        Dim adp As OleDbDataAdapter
        Dim t1 As DataTable
        adp = New OleDbDataAdapter("SELECT * FROM VENUEDISPLAY", dbcon)
        t1 = New DataTable()
        t1.Clear()
        adp.Fill(t1)
        DgvVIEWVENUES.DataSource = t1
    End Sub

    Private Sub BtnSHOW_Click(sender As Object, e As EventArgs) Handles BtnSHOW.Click
        viewvenues()
    End Sub

    Private Sub childVIEWVENUESADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
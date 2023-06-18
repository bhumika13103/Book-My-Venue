Imports System.Data.OleDb
Public Class ChildVIEWBOOKINGSADMINvb
    Private Sub showbookings()
        Dim adp As OleDbDataAdapter
        Dim t1 As DataTable
        adp = New OleDbDataAdapter("SELECT * FROM BOOKINGSDISPLAY", dbcon)
        t1 = New DataTable()
        t1.Clear()
        adp.Fill(t1)
        DgvVIEWBOOKINGS.DataSource = t1

    End Sub

    Private Sub BtnSHOW_Click(sender As Object, e As EventArgs) Handles BtnSHOW.Click
        showbookings()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChildVIEWBOOKINGSADMINvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
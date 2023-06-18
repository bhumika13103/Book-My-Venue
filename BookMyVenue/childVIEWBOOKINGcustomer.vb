Imports System.Data.OleDb
Public Class childVIEWBOOKINGcustomer
    Dim adp As OleDbDataAdapter
    Dim dt As DataTable
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim customerid As Integer
    Dim custname As String
    Public WriteOnly Property Setid As Integer
        Set(value As Integer)
            customerid = value
        End Set
    End Property

    Public WriteOnly Property setcustname As String
        Set(value As String)
            custname = value
        End Set
    End Property
    Private Sub dgvload()
        Dim str As String = "SELECT * FROM BOOKINGSDISPLAY"
        adp = New OleDbDataAdapter(str, dbcon)
        dt = New DataTable()
        dt.Clear()
        adp.Fill(dt)
        DgvCUSTBOOKING.AllowUserToAddRows = True
        DgvCUSTBOOKING.DataSource = dt

    End Sub
    Private Sub childVIEWBOOKINGcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvload()

    End Sub

    Private Sub BtnEXIT_Click(sender As Object, e As EventArgs) Handles BtnEXIT.Click
        pDisconnectDB()
        Me.Close()
    End Sub
End Class
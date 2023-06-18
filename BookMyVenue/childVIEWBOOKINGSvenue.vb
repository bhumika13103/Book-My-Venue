Imports System.Data.OleDb
Public Class childVIEWBOOKINGSvenue
    Dim adp As OleDbDataAdapter
    Dim dt As DataTable
    Dim vid As Integer
    Dim vname As String

    Public WriteOnly Property Setid As Integer
        Set(value As Integer)
            vid = value
        End Set
    End Property

    Public WriteOnly Property setvname As String
        Set(value As String)
            vname = value
        End Set
    End Property
    Private Sub childVIEWBOOKINGSvenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pConnectDB()
        dgvload()
    End Sub

    Private Sub dgvload()
        Dim str As String = "SELECT * FROM bookingLIST"
        adp = New OleDbDataAdapter(str, dbcon)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DgvVIEWVENUEBOOKINGS.DataSource = ds.Tables(0)
    End Sub
End Class
Imports System.Data.OleDb
Public Class ChildEDITBOOKINGSADMIN
    Dim ra As Integer
    Private Sub ChildEDITBOOKINGSADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pConnectDB()
        dgvload()
    End Sub

    Private Sub dgvload()
        Dim str As String = "SELECT * FROM bookingLIST"
        Dim adp As New OleDbDataAdapter(str, dbcon)
        Dim dt As New DataTable()
        adp.Fill(dt)
        DgvEDITBOOKINGS.DataSource = dt
    End Sub

    Private Sub BtnSAVECHANGES_Click(sender As Object, e As EventArgs) Handles BtnSAVECHANGES.Click
        For i As Integer = 0 To DgvEDITBOOKINGS.Rows.Count - 1
            Dim str As String = "UPDATE bookingLIST SET CUSTOMER_ID = @custid , VENUE_ID = @venueid , CHECKIN_DATE = @checkin , CHECKOUT_DATE = @checkout , TOTAL_AMOUNT = @total WHERE BOOKING_ID = @bookid"
            Dim cmd As New OleDbCommand(str, dbcon)
            cmd.Parameters.AddWithValue("custid", DgvEDITBOOKINGS.Rows(i).Cells(1).Value)
            cmd.Parameters.AddWithValue("venueid", DgvEDITBOOKINGS.Rows(i).Cells(2).Value)
            cmd.Parameters.AddWithValue("checkin", DgvEDITBOOKINGS.Rows(i).Cells(3).Value)
            cmd.Parameters.AddWithValue("checkout", DgvEDITBOOKINGS.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("total", DgvEDITBOOKINGS.Rows(i).Cells(5).Value)
            cmd.Parameters.AddWithValue("bookid", DgvEDITBOOKINGS.Rows(i).Cells(0).Value)
            cmd.ExecuteNonQuery()
        Next
        MessageBox.Show("Updated successfully")
        dgvload()
    End Sub

    Private Sub BtnEXIT_Click(sender As Object, e As EventArgs) Handles BtnEXIT.Click
        Me.Close()
    End Sub
End Class
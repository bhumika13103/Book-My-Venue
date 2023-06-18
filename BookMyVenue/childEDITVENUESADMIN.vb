Imports System.Data.OleDb
Public Class childEDITVENUESADMIN
    Private Sub childEDITVENUESADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pConnectDB()
        dgvload()
    End Sub

    Private Sub dgvload()
        Dim str As String = "SELECT * FROM venueDETAILS"
        Dim adp As New OleDbDataAdapter(str, dbcon)
        Dim dt As New DataTable()
        adp.Fill(dt)
        DgvEDITVENUE.DataSource = dt
    End Sub

    Private Sub BtnSAVECHANGES_Click(sender As Object, e As EventArgs) Handles BtnSAVECHANGES.Click
        For i As Integer = 0 To DgvEDITVENUE.Rows.Count - 1
            Dim str As String = "UPDATE venueDETAILS set [VENUE_NAME] = @vname , [PASSWORD] = @pwd , [PHONE_NUMBER] = @phone , [TYPE] = @type , [ADDRESS] = @address , [CITY] = @city , [STATE] = @state , [PINCODE] = @pincode , [EMAIL_ID] = @mail , [PRICE] = @price , [GUESTS] = @guests , [AVAILABILITY] = @avail WHERE [VENUE_ID] = @venueid"
            Dim cmd As New OleDbCommand(str, dbcon)
            cmd.Parameters.AddWithValue("vname", DgvEDITVENUE.Rows(i).Cells(1).Value)
            cmd.Parameters.AddWithValue("pwd", DgvEDITVENUE.Rows(i).Cells(2).Value)
            cmd.Parameters.AddWithValue("phone", DgvEDITVENUE.Rows(i).Cells(3).Value)
            cmd.Parameters.AddWithValue("type", DgvEDITVENUE.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("address", DgvEDITVENUE.Rows(i).Cells(5).Value)
            cmd.Parameters.AddWithValue("city", DgvEDITVENUE.Rows(i).Cells(6).Value)
            cmd.Parameters.AddWithValue("state", DgvEDITVENUE.Rows(i).Cells(7).Value)
            cmd.Parameters.AddWithValue("pincode", DgvEDITVENUE.Rows(i).Cells(8).Value)
            cmd.Parameters.AddWithValue("mail", DgvEDITVENUE.Rows(i).Cells(9).Value)
            cmd.Parameters.AddWithValue("price", DgvEDITVENUE.Rows(i).Cells(10).Value)
            cmd.Parameters.AddWithValue("guests", DgvEDITVENUE.Rows(i).Cells(11).Value)
            cmd.Parameters.AddWithValue("avail", DgvEDITVENUE.Rows(i).Cells(12).Value)
            cmd.Parameters.AddWithValue("venueid", DgvEDITVENUE.Rows(i).Cells(0).Value)

            cmd.ExecuteNonQuery()
        Next
        MessageBox.Show("Updated successfully")
        dgvload()
    End Sub

    Private Sub BtnEXIT_Click(sender As Object, e As EventArgs) Handles BtnEXIT.Click
        pDisconnectDB()
        Me.Close()
    End Sub
End Class
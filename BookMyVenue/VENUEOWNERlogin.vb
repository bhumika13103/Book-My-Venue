Imports System.Data.OleDb
Public Class VENUEOWNERlogin
    Dim sql As String
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Private Sub BtnVENUELOGIN_Click(sender As Object, e As EventArgs) Handles BtnVENUELOGIN.Click
        sql = "SELECT * FROM venueDETAILS WHERE VENUE_ID = " & TxtUSERID.Text & " AND PASSWORD = '" & TxtPWD.Text & "'"
        adp = New OleDbDataAdapter(sql, dbcon)
        ds = New DataSet()
        adp.Fill(ds)
        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            pDisconnectDB()
            VENUEOWNERdashboard.setvenue = Integer.Parse(TxtUSERID.Text)
            VENUEOWNERdashboard.Show()
            Me.Close()
        Else
            MessageBox.Show("Wrong username or password entered", "Invalid Credentials", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
            TxtUSERID.Text = ""
            TxtPWD.Text = ""
        End If
    End Sub

    Private Sub VENUEOWNERlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pConnectDB()
    End Sub

    Private Sub CboxSHOWPWD_CheckedChanged(sender As Object, e As EventArgs) Handles CboxSHOWPWD.CheckedChanged
        If CboxSHOWPWD.Checked = True Then
            TxtPWD.UseSystemPasswordChar = True
        Else
            TxtPWD.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub LlabelFORGOTPWD_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlabelFORGOTPWD.LinkClicked
        Dim id As Integer
        Dim phone As Long
        Dim userfound As Boolean = False
        id = InputBox("Enter your User ID:", "Verification")
        phone = InputBox("Enter your registered phone number:", "Verification")
        Dim sql2 As String = "SELECT VENUE_ID, VENUE_NAME, PASSWORD FROM venueDETAILS WHERE VENUE_ID = " & id & " AND PHONE_NUMBER = '" & phone & "'"
        adp = New OleDbDataAdapter(sql2, dbcon)
        ds = New DataSet()
        adp.Fill(ds)
        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            userfound = True
        Else
            userfound = False
        End If

        If userfound = True Then
            MessageBox.Show("Account details: " & vbNewLine & "VENUE ID = " & id & vbNewLine & "VENUE NAME = " & ds.Tables(0).Rows(0).Item(1) & vbNewLine & "PASSWORD = " & ds.Tables(0).Rows(0).Item(2), "User Found")
        Else
            MessageBox.Show("Invalid credentials entered", "Authentication failed")
        End If
    End Sub
End Class
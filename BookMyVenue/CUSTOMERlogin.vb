Imports System.Data.OleDb
Public Class CUSTOMERlogin
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Public cusid As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()
    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim id As Integer
        Dim pass As String
        Dim userfound As Boolean = False
        adp = New OleDbDataAdapter("SELECT * FROM CustomerDETAILS WHERE CUSTOMER_ID = " & TxtuserID.Text & " and PASSWORD ='" & (Txtpass.Text).ToString & "'", dbcon)
        ds = New DataSet()
        adp.Fill(ds)

        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            id = ds.Tables(0).Rows(0).Item(0)
            pass = ds.Tables(0).Rows(0).Item(2)
            userfound = True
        Else
            MessageBox.Show("Invalid Username or Password", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
        If userfound = True Then
            pDisconnectDB()
            cusid = Integer.Parse(TxtuserID.Text)
            CUSTOMERdashboard.Setb = cusid
            CUSTOMERdashboard.Show()

            Me.Close()
        End If

    End Sub

    Private Sub CboxShowpwd_CheckedChanged(sender As Object, e As EventArgs) Handles CboxShowpwd.CheckedChanged
        If CboxShowpwd.Checked = True Then
            Txtpass.UseSystemPasswordChar = False
        Else
            Txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Llabforgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Llabforgot.LinkClicked
        Dim id As Integer
        Dim phone As Long
        Dim userfound As Boolean = False
        id = InputBox("Enter your User ID:", "Verification")
        phone = InputBox("Enter your registered phone number:", "Verification")
        Dim sql2 As String = "SELECT CUSTOMER_ID, PHONE_NUMBER, PASSWORD FROM CustomerDETAILS WHERE CUSTOMER_ID = " & id & " AND PHONE_NUMBER = '" & phone & "'"
        adp = New OleDbDataAdapter(sql2, dbcon)
        ds = New DataSet()
        adp.Fill(ds)

        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            userfound = True
        Else
            userfound = False
        End If

        If userfound = True Then
            MessageBox.Show("Account details: " & vbNewLine & "ID = " & id & vbNewLine & "PHONE NUMBER = " & phone & vbNewLine & "PASSWORD = " & ds.Tables(0).Rows(0).Item(2))
        End If
    End Sub


End Class

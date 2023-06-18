Imports System.Data.OleDb
Public Class ADMINlogin
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Private Sub CboxSHOWPWD_CheckedChanged(sender As Object, e As EventArgs) Handles CboxSHOWPWD.CheckedChanged
        If TxtPWD.UseSystemPasswordChar = True Then
            TxtPWD.UseSystemPasswordChar = False
        Else
            TxtPWD.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnLOGIN_Click(sender As Object, e As EventArgs) Handles BtnLOGIN.Click
        Dim username As String
        Dim pass As String
        Dim userfound As Boolean = False
        adp = New OleDbDataAdapter("SELECT * FROM adminDETAILS WHERE USERNAME = '" & TxtUSERNAME.Text & "' and PASSWORD ='" & TxtPWD.Text & "'", dbcon)
        ds = New DataSet()
        adp.Fill(ds)

        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            username = ds.Tables(0).Rows(0).Item(0)
            pass = ds.Tables(0).Rows(0).Item(1)
            userfound = True
        Else
            MessageBox.Show("Invalid Username or Password", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
        If userfound = True Then
            Call pDisconnectDB()
            ADMINdashboard.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ADMINlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()
    End Sub
End Class
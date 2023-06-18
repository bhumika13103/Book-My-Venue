Imports System.Data.OleDb
Public Class CUSTOMER_REGISRATION
    Dim cmd As OleDbCommand
    Private Sub BtnREGISTER_Click(sender As Object, e As EventArgs) Handles BtnREGISTER.Click
        Dim sql As String = "INSERT INTO [CustomerDETAILS] ([FULLNAME],[PASSWORD],[PHONE_NUMBER],[DOB],[ADDRESS],[STATE],[OCCUPATION],[EMAIL_ID]) VALUES ('" & TxtFULLNAME.Text & "','" & TxtPWD.Text & "','" & TxtPHONENO.Text & "',#" & Date.Parse(DtpDOB.Text) & "#,'" & RTxtADDRESS.Text & "','" & TxtSTATE.Text & "','" & TxtOCCUPATION.Text & "','" & TxtMAILID.Text & "')"
        'Dim sql As String = "INSERT INTO [CustomerDETAILS] ([FULLNAME],[PASSWORD],[PHONE_NUMBER],[DOB],[ADDRESS],[STATE],[OCCUPATION],[EMAIL_ID]) VALUES(@name,@pwd,@pn,@dob,@address,@state,@@occup,
        cmd = New OleDbCommand(sql, dbcon)
        Dim ra As Integer = cmd.ExecuteNonQuery()
        If ra > 0 Then
            MsgBox("Registration Successfull")
            Dim sql2 As String = "SELECT CUSTOMER_ID FROM [CustomerDETAILS] WHERE FULLNAME = '" & TxtFULLNAME.Text & "'"
            Dim adp As OleDbDataAdapter = New OleDbDataAdapter(sql2, dbcon)
            Dim ds As DataSet = New DataSet()
            adp.Fill(ds)
            MessageBox.Show("User ID: " & ds.Tables(0).Rows(0).Item(0).ToString & vbNewLine & "Password: " & TxtPWD.Text, "LOGIN CREDENTIALS")
            homepage.Show()
            pDisconnectDB()
            Me.Close()
        End If
    End Sub

    Private Sub CUSTOMER_REGISRATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pConnectDB()
    End Sub
End Class
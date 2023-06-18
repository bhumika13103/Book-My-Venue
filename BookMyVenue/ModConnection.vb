Imports System.Data.OleDb
Module ModConnection
    Public dbcon As New OleDbConnection
    Public Sub pConnectDB()
        dbcon.ConnectionString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\OneDrive\Documents\Visual Studio 2015\Projects\BookMyVenue\Book_my_venue.accdb"
        If dbcon.State = ConnectionState.Open Then
        Else
            dbcon.Open()
        End If
        'If dbcon.State = ConnectionState.Open Then
        '    MsgBox("success")
        'End If
    End Sub
    Public Sub pDisconnectDB()
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()

        End If
    End Sub
End Module

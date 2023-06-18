Imports System.Data.OleDb
Public Class VENUEOWNERdashboard
    Dim adp As OleDbDataAdapter
    Dim dt As DataTable
    Public venueid As Integer
    Private currentpnl As Panel
    Private currentbtn As Button
    Public af As Form
    Public cmd As OleDbCommand
    Private Sub BtnLOGOUT_Click(sender As Object, e As EventArgs) Handles BtnLOGOUT.Click
        pDisconnectDB()
        homepage.Show()
        Me.Close()
    End Sub

    Public WriteOnly Property setvenue As Integer
        Set(value As Integer)
            venueid = value
        End Set
    End Property

    Private Function getvenuename(id As Integer) As String
        Dim str As String = "SELECT VENUE_NAME FROM venueDETAILS WHERE VENUE_ID = " & venueid
        adp = New OleDbDataAdapter(str, dbcon)
        dt = New DataTable()
        dt.Clear()
        adp.Fill(dt)
        Return dt.Rows(0).Item(0).ToString
    End Function
    Private Sub VENUEOWNERdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()
        PanelVIEWBOOKINGS.Visible = False
        PanelCHANGEPASSWORD.Visible = False
        LabelWELCOME.Text = "Welcome, " & getvenuename(venueid)
    End Sub

    Private Function activatebutton(senderbtn As Object, pnl As Panel)
        If currentpnl IsNot Nothing Then
            deactivatebutton(currentpnl)
            currentpnl = pnl
            currentbtn = CType(senderbtn, Button)
            pnl.Visible = True
            pnl.BackColor = Color.OldLace
        Else
            currentpnl = pnl
            pnl.Visible = True
            pnl.BackColor = Color.OldLace
        End If

    End Function
    Private Function deactivatebutton(pnl As Panel)
        pnl.Visible = False
    End Function

    Public Sub OpenChildForm(Childform As Form, sender As Object)
        If (af IsNot Nothing) Then
            af.Close()
        End If
        af = Childform
        Childform.TopLevel = False
        Childform.FormBorderStyle = FormBorderStyle.None
        Me.PanelCHILD.Controls.Add(Childform)
        Me.PanelCHILD.Tag = Childform
        Childform.BringToFront()
        Childform.Dock = Dock.Fill
        Childform.Show()
    End Sub

    Private Sub BtnVIEWBOOKINGS_Click(sender As Object, e As EventArgs) Handles BtnVIEWBOOKINGS.Click
        activatebutton(sender, PanelVIEWBOOKINGS)
        childVIEWBOOKINGSvenue.setvname = getvenuename(venueid)
        childVIEWBOOKINGSvenue.Setid = venueid
        pDisconnectDB()
        OpenChildForm(New childVIEWBOOKINGSvenue, sender)
    End Sub

    Private Sub BtnCHANGEPASSWORD_Click(sender As Object, e As EventArgs) Handles BtnCHANGEPASSWORD.Click
        activatebutton(sender, PanelCHANGEPASSWORD)
        pDisconnectDB()
        OpenChildForm(New childCHANGEPASSWORDvenue, sender)
    End Sub
End Class
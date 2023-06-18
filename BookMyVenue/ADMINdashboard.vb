Imports System.Data.OleDb
Public Class ADMINdashboard
    Private currentpnl As Panel
    Private currentbtn As Button
    Public af As Form
    Public cmd As OleDbCommand
    Public adp As OleDbDataAdapter
    Public dr As OleDbDataReader
    Private Function activatebutton(senderbtn As Object, pnl As Panel)
        If currentpnl IsNot Nothing Then
            deactivatebutton(currentpnl)
            currentpnl = pnl
            currentbtn = CType(senderbtn, Button)
            pnl.Visible = True
            pnl.BackColor = Color.Bisque
        Else
            currentpnl = pnl
            pnl.Visible = True
            pnl.BackColor = Color.Bisque
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
        Me.PnlMAIN.Controls.Add(Childform)
        Me.PnlMAIN.Tag = Childform
        Childform.BringToFront()
        Childform.Dock = Dock.Fill
        Childform.Show()
    End Sub
    Private Sub BtnVIEWBOOKINGS_Click(sender As Object, e As EventArgs) Handles BtnVIEWBOOKINGS.Click
        activatebutton(sender, PbtnVIEWBOOKINGS)
        OpenChildForm(New ChildVIEWBOOKINGSADMINvb, sender)
    End Sub

    Private Sub ButtonVIEWVENUES_Click(sender As Object, e As EventArgs) Handles ButtonVIEWVENUES.Click
        activatebutton(sender, PbtnVIEWVENUES)
        OpenChildForm(New childVIEWVENUESADMIN, sender)
    End Sub

    Private Sub ButtonEDITBOOKINGS_Click(sender As Object, e As EventArgs) Handles ButtonEDITBOOKINGS.Click
        activatebutton(sender, PbtnEDITBOOKINGS)
        pDisconnectDB()
        OpenChildForm(New ChildEDITBOOKINGSADMIN, sender)
    End Sub

    Private Sub ButtonEDITVENUES_Click(sender As Object, e As EventArgs) Handles ButtonEDITVENUES.Click
        activatebutton(sender, PbtnEDITVENUES)
        pDisconnectDB()
        OpenChildForm(New childEDITVENUESADMIN, sender)
    End Sub

    Private Sub ButtonGENERATESLIPS_Click(sender As Object, e As EventArgs) Handles ButtonMAKEBOOKING.Click
        activatebutton(sender, PbtnMAKEBOOKING)
        OpenChildForm(New NEWBOOKING, sender)
    End Sub

    Private Sub ButtonADDCUSTOMER_Click(sender As Object, e As EventArgs) Handles ButtonADDCUSTOMER.Click
        activatebutton(sender, PbtnADDCUSTOMER)
        pDisconnectDB()
        OpenChildForm(New CUSTOMER_REGISRATION, sender)
    End Sub

    Private Sub ButtonADDVENUE_Click(sender As Object, e As EventArgs) Handles ButtonADDVENUE.Click
        activatebutton(sender, PbtnADDVENUE)
        pDisconnectDB()
        OpenChildForm(New VENUEOWNER_REGISTRATION, sender)
    End Sub
    Private Sub ADMINdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()
    End Sub

    Private Sub BtnLOGOUT_Click_1(sender As Object, e As EventArgs) Handles BtnLOGOUT.Click
        pDisconnectDB()
        homepage.Show()
        Me.Close()
    End Sub

    Private Sub BtnCHANGEPASSWORD_Click_1(sender As Object, e As EventArgs) Handles BtnCHANGEPASSWORD.Click
        OpenChildForm(New childCHANGEPASSWORDadmin, sender)
    End Sub
End Class
Imports System.Data.OleDb
Public Class CUSTOMERdashboard
    Private currentpnl As Panel
    Private currentbtn As Button
    Public af As Form
    Public dt As DataTable
    Public cmd As OleDbCommand
    Public adp As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public custid As Integer
    Public WriteOnly Property Setb As Integer
        Set(value As Integer)
            custid = value
        End Set
    End Property

    Private Function getcustomername(id As Integer) As String
        Dim str As String = "SELECT FULLNAME FROM customerDETAILS WHERE CUSTOMER_ID = " & custid
        adp = New OleDbDataAdapter(str, dbcon)
        dt = New DataTable()
        dt.Clear()
        adp.Fill(dt)
        Return dt.Rows(0).Item(0).ToString
    End Function
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
        Me.pnlCONTENT.Controls.Add(Childform)
        Me.pnlCONTENT.Tag = Childform
        Childform.BringToFront()
        Childform.Dock = Dock.Fill
        Childform.Show()
    End Sub
    Private Sub CUSTOMERdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()
        PanelVIEWBOOKING.Visible = False
        PanelNEWBOOKING.Visible = False
        PanelCHANGEPASSWORD.Visible = False
        LabelWELCOME.Text = "Welcome, " & getcustomername(custid)
    End Sub

    Private Sub BtnVIEWBOOKING_Click(sender As Object, e As EventArgs) Handles BtnVIEWBOOKING.Click
        activatebutton(sender, PanelVIEWBOOKING)
        childVIEWBOOKINGcustomer.Setid = custid
        OpenChildForm(New childVIEWBOOKINGcustomer, sender)
    End Sub

    Private Sub BtnNEWBOOKING_Click(sender As Object, e As EventArgs) Handles BtnNEWBOOKING.Click
        activatebutton(sender, PanelNEWBOOKING)
        OpenChildForm(New NEWBOOKING, sender)
    End Sub

    Private Sub BtnCHANGEPASSWORD_Click(sender As Object, e As EventArgs) Handles BtnCHANGEPASSWORD.Click
        activatebutton(sender, PanelCHANGEPASSWORD)
        pDisconnectDB()
        OpenChildForm(New childCHANGEPASSWORDcustomer, sender)
    End Sub

    Private Sub BtnLOGOUT_Click(sender As Object, e As EventArgs) Handles BtnLOGOUT.Click
        Call pDisconnectDB()
        homepage.Show()
        Me.Close()
    End Sub
End Class
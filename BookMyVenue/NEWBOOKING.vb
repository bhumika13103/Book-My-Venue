Imports System.Data.OleDb

Public Class NEWBOOKING
    Public selectedvenuetype As String
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter
    Dim dt As DataTable
    Dim dr As OleDbDataReader
    Dim ds As DataSet
    Public venuebook As Integer
    Public price As Integer
    Public cid As Integer
    Private Function startbooking()


    End Function

    Private Sub dgvload()
        PanelVENUELIST.Visible = True
        Dim str As String = "SELECT VENUE_NAME , PHONE_NUMBER , ADDRESS , CITY , STATE , PINCODE , EMAIL_ID , PRICE , GUESTS , AVAILABILITY , VENUE_ID FROM [venueDETAILS] WHERE TYPE = '" & selectedvenuetype & "'"
        adp = New OleDbDataAdapter(str, dbcon)
        dt = New DataTable()
        adp.Fill(dt)
        DgvCAFE.DataSource = dt
        DgvCAFE.ReadOnly = True
        DgvCAFE.Columns(1).Name = "PROPERTY NAME"
        DgvCAFE.Columns(2).Name = "PHONE NUMBER"
        DgvCAFE.Columns(3).Name = "ADDRESS"
        DgvCAFE.Columns(4).Name = "CITY"
        DgvCAFE.Columns(5).Name = "STATE"
        DgvCAFE.Columns(6).Name = "PINCODE"
        DgvCAFE.Columns(7).Name = "EMAIL ID"
        DgvCAFE.Columns(8).Name = "PRICE"
        DgvCAFE.Columns(9).Name = "GUESTS"
        DgvCAFE.Columns(10).Name = "AVAILABILITY"
        DgvCAFE.Columns(11).Name = "VENUE_ID"

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCAFE.CellContentClick
        PanelBOOK.Visible = True
        DgvCAFE.Rows(e.RowIndex).Selected = True
        venuebook = DgvCAFE.SelectedRows(0).Cells(11).Value
        price = DgvCAFE.SelectedRows(0).Cells(8).Value
        Cboxload()
        cid = Integer.Parse(ComboBox1.SelectedValue.ToString)
        If ParentForm.Name = "CUSTOMERdashboard" Then
            cid = Integer.Parse(CUSTOMERdashboard.custid.ToString)
            ComboBox1.SelectedText = cid.ToString
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub BtnBOOK_Click(sender As Object, e As EventArgs) Handles BtnBOOK.Click
        If DtpCHECKIN.Value < Now().AddDays(-1) Then
            MessageBox.Show("Invalid Check-in Date")
        End If
        If DtpCHECKOUT.Value < Now AndAlso DtpCHECKOUT.Value < DtpCHECKIN.Value Then
            MessageBox.Show("Invalid Check-out date")
        End If
        Dim totaldays As Integer = DateDiff("d", DtpCHECKIN.Value, DtpCHECKOUT.Value)
        Dim totalprice As Integer = totaldays * price

        Dim str As String = "INSERT INTO bookingLIST([CUSTOMER_ID],[VENUE_ID],[CHECKIN_DATE],[CHECKOUT_DATE],[TOTAL_AMOUNT]) VALUES(" & cid & "," & venuebook & ",@checkin,@checkout," & totalprice & ")"

        cmd = New OleDbCommand(str, dbcon)
        cmd.Parameters.AddWithValue("@checkin", Date.Parse(DtpCHECKIN.Value))
        cmd.Parameters.AddWithValue("@checkout", Date.Parse(DtpCHECKOUT.Value))
        Dim ra As Integer = cmd.ExecuteNonQuery()
        If ra > 0 Then
            MsgBox("Booking succesfull")
            PanelBOOK.Visible = False
            PanelVENUELIST.Visible = False
        Else
            MsgBox("error")
        End If
    End Sub

    Private Sub Cboxload()
        adp = New OleDbDataAdapter("SELECT CUSTOMER_ID FROM customerDETAILS", dbcon)
        dt = New DataTable()
        adp.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "CUSTOMER_ID"
        ComboBox1.ValueMember = "CUSTOMER_ID"
        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox1.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCAFE.Click
        selectedvenuetype = "Cafe or Restaurant"
        dgvload()
    End Sub

    Private Sub BtnVILLA_Click(sender As Object, e As EventArgs) Handles BtnVILLA.Click
        selectedvenuetype = "Villa"
        dgvload()
    End Sub

    Private Sub BtnRESORT_Click(sender As Object, e As EventArgs) Handles BtnRESORT.Click
        selectedvenuetype = "Resort"
        dgvload()
    End Sub

    Private Sub BtnBANQUETHALL_Click(sender As Object, e As EventArgs) Handles BtnBANQUETHALL.Click
        selectedvenuetype = "Banquet Hall"
        dgvload()
    End Sub

    Private Sub BtnGARDEN_Click(sender As Object, e As EventArgs) Handles BtnGARDEN.Click
        selectedvenuetype = "Garden or Beach"
        dgvload()
    End Sub

    Private Sub BtnCLUBHOUSE_Click(sender As Object, e As EventArgs) Handles BtnCLUBHOUSE.Click
        selectedvenuetype = "Club House"
        dgvload()
    End Sub

    Private Sub BtnAPARTMENT_Click(sender As Object, e As EventArgs) Handles BtnAPARTMENT.Click
        selectedvenuetype = "Apartment or Flat"
        dgvload()
    End Sub

    Private Sub NEWBOOKING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelVENUELIST.Visible = False

    End Sub
End Class
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class VENUEOWNER_REGISTRATION
    Dim adp As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Public bytImage() As Byte
    Public states() As String

    Private Sub cboxvenuetype_load()
        CBoxVENUETYPE.Items.Add("Cafe or Restaurant")
        CBoxVENUETYPE.Items.Add("Villa")
        CBoxVENUETYPE.Items.Add("Resort")
        CBoxVENUETYPE.Items.Add("Banquet Hall")
        CBoxVENUETYPE.Items.Add("Garden or Beach")
        CBoxVENUETYPE.Items.Add("Club House")
        CBoxVENUETYPE.Items.Add("Apartment or Flat")

    End Sub

    Private Sub cboxSTATE_load()
        STATE.Items.Add("Andhra Pradesh")
        STATE.Items.Add("Arunachal Pradesh")
        STATE.Items.Add("Assam")
        STATE.Items.Add("Bihar")
        STATE.Items.Add("Chhattisgarh")
        STATE.Items.Add("Goa")
        STATE.Items.Add("Gujarat")
        STATE.Items.Add("Haryana")
        STATE.Items.Add("Himachal Pradesh")
        STATE.Items.Add("Jammu And Kashmir")
        STATE.Items.Add("Jharkhand")
        STATE.Items.Add("Karnataka")
        STATE.Items.Add("Kerala")
        STATE.Items.Add("Madhya Pradesh")
        STATE.Items.Add("Maharashtra")
        STATE.Items.Add("Manipur")
        STATE.Items.Add("Meghalaya")
        STATE.Items.Add("Mizoram")
        STATE.Items.Add("Nagaland")
        STATE.Items.Add("Odisha")
        STATE.Items.Add("Punjab")
        STATE.Items.Add("Rajasthan")
        STATE.Items.Add("Sikkim")
        STATE.Items.Add("Tamil Nadu")
        STATE.Items.Add("Telangana")
        STATE.Items.Add("Tripura")
        STATE.Items.Add("Uttar Pradesh")
        STATE.Items.Add("West Bengal")
    End Sub
    Private Sub VENUEOWNER_REGISTRATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pConnectDB()
        Me.ActiveControl = LabelVENUEOWNERREGIS
        cboxSTATE_load()
        cboxvenuetype_load()
        PWD.UseSystemPasswordChar = True

    End Sub



    Private Sub cboxVENUETYPE_focus(sender As Object, e As EventArgs) Handles CBoxVENUETYPE.GotFocus
        CBoxVENUETYPE.DroppedDown = True
    End Sub



    Private Sub BtnREGISTER_Click(sender As Object, e As EventArgs) Handles BtnREGISTER.Click
        Dim success As Boolean = True
        Dim success2 As Boolean = True
        Dim errorCount As Integer = 0
        For Each ctrl As Control In Me.Controls
            If ErrorProvider1.GetError(ctrl) <> "" Then
                errorCount += 1
            End If
        Next
        If errorCount > 0 Then
            success = False
        End If
        If PictureBox1.Image Is Nothing Then
            success2 = False
        End If

        If success Then
            If success2 Then
                Dim rowsaffected As Integer
                Dim cmd As OleDbCommand

                Dim savedirectory As String = "C:\Users\HP\OneDrive\Documents\Visual Studio 2015\Projects\BookMyVenue\venueimg\"
                Dim fname As String = Path.GetFileName(opf.FileName)
                Dim dest As String = Path.Combine(savedirectory, fname)
                File.Copy(opf.FileName, dest, True)
                Dim sql2 As String = "INSERT INTO venueDETAILS([VENUE_NAME],[PASSWORD],[PHONE_NUMBER],[TYPE],[ADDRESS],[CITY],[STATE],[PINCODE],[EMAIL_ID],[PRICE],[GUESTS],[PIC1],[PICPATH]) VALUES('" & VENUE_NAME.Text & "','" & PWD.Text & "'," & Integer.Parse(PHONE_NO.Text) & ",'" & CBoxVENUETYPE.SelectedItem.ToString & "','" & ADDRESS.Text & "','" & CITY.Text & "','" & STATE.SelectedItem.ToString & "'," & Integer.Parse(PINCODE.Text) & ",'" & EMAIL_ID.Text & "'," & Integer.Parse(PRICE.Text) & "," & Integer.Parse(GUESTS.Text) & ",@fname,@path)"
                cmd = New OleDbCommand(sql2, dbcon)
                cmd.Parameters.AddWithValue("@fname", Path.GetFileName(fname))
                cmd.Parameters.AddWithValue("@Path", dest)
                rowsaffected = cmd.ExecuteNonQuery()

                If rowsaffected > 0 Then
                    Dim dr As DialogResult
                    Dim sql As String = "SELECT * FROM venueDETAILS WHERE VENUE_NAME = '" & VENUE_NAME.Text & "'"
                    adp = New OleDbDataAdapter(sql, dbcon)
                    dt = New DataTable()
                    adp.Fill(dt)
                    dr = MessageBox.Show("Use these credentials to login" & vbNewLine & "USER_ID:  " & dt.Rows(0).Item(0) & vbNewLine & "PASSWORD: '" & dt.Rows(0).Item(2) & "'", "Regsitration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If dr = DialogResult.OK Then
                        homepage.Show()
                        pDisconnectDB()
                        Me.Close()
                    End If
                End If
            Else
                MessageBox.Show("Please upload an image first")
            End If


        Else
            MessageBox.Show("Validate all the fields to complete the registration")
        End If

    End Sub


    'Private Sub checkchar(txt As TextBox)
    '    Dim flag As Boolean = txt.Text.AsEnumerable().All(Function(c As Char) Char.IsLetter(c))
    '    If flag = False Then
    '        MsgBox("Enter a valid text with only letters")
    '        txt.Focus()
    '        txt.Clear()
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSHOWHIDE.Click
        If PWD.UseSystemPasswordChar = True Then
            PWD.UseSystemPasswordChar = False
            BtnSHOWHIDE.Image = Image.FromFile("C:\Users\HP\OneDrive\Documents\Visual Studio 2015\Projects\BookMyVenue\png\show.png")
        Else
            PWD.UseSystemPasswordChar = True
            BtnSHOWHIDE.Image = Image.FromFile("C:\Users\HP\OneDrive\Documents\Visual Studio 2015\Projects\BookMyVenue\png\hide.png")
        End If
    End Sub

    Private Sub checknull(txt As TextBox)
        If String.IsNullOrWhiteSpace(txt.Text.Trim) Then
            ErrorProvider1.SetError(txt, txt.Name & " is required")
        Else
            ErrorProvider1.SetError(txt, Nothing)
        End If
    End Sub
    Private Sub VENUE_NAME_Validating(sender As Object, e As CancelEventArgs) Handles VENUE_NAME.Validating
        checknull(VENUE_NAME)
        VENUE_NAME.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub PWD_Validating(sender As Object, e As CancelEventArgs) Handles PWD.Validating
        checknull(PWD)

        If PWD.Text.Length < 8 Then
            ErrorProvider1.SetError(PWD, "should not be less than 8 characters")
        Else
            ErrorProvider1.SetError(PWD, "")
        End If
    End Sub

    Private Sub CITY_Validating(sender As Object, e As CancelEventArgs) Handles CITY.Validating
        checknull(CITY)
        CITY.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub STATE_Validating(sender As Object, e As CancelEventArgs) Handles STATE.Validating

    End Sub

    Private Sub PINCODE_Validating(sender As Object, e As CancelEventArgs) Handles PINCODE.Validating
        checknull(PINCODE)
        If Not IsNumeric(PINCODE.Text) Then
            ErrorProvider1.SetError(PINCODE, "Pincode has to be in numbers")
        Else
            ErrorProvider1.SetError(PINCODE, "")
            If PINCODE.Text.Length = 6 Then
                ErrorProvider1.SetError(PINCODE, "")
                If Integer.Parse(PINCODE.Text(0)) = 0 Then
                    ErrorProvider1.SetError(PINCODE, "Pincode should not start with 0")
                Else
                    ErrorProvider1.SetError(PINCODE, "")
                End If
            Else
                ErrorProvider1.SetError(PINCODE, "Pincode should consist of 6 digits")
            End If
        End If


    End Sub

    Private Sub EMAIL_ID_Validating(sender As Object, e As CancelEventArgs) Handles EMAIL_ID.Validating
        checknull(EMAIL_ID)
        Dim check As Boolean = ValidateEmail(EMAIL_ID.Text.Trim)
        If check = False Then
            ErrorProvider1.SetError(EMAIL_ID, "not a valid email address")
        End If
    End Sub

    Public Function ValidateEmail(ByVal strCheck As String) As Boolean
        Try
            Dim vEmailAddress As New System.Net.Mail.MailAddress(strCheck)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Private Sub PRICE_Validating(sender As Object, e As CancelEventArgs) Handles PRICE.Validating
        checknull(PRICE)
    End Sub

    Private Sub GUESTS_Validating(sender As Object, e As CancelEventArgs) Handles GUESTS.Validating
        checknull(GUESTS)
    End Sub

    Private Sub PHONE_NO_Validating(sender As Object, e As CancelEventArgs) Handles PHONE_NO.Validating
        checknull(PHONE_NO)
    End Sub

    Private Sub ADDRESS_Validating(sender As Object, e As CancelEventArgs) Handles ADDRESS.Validating
        If String.IsNullOrWhiteSpace(ADDRESS.Text.Trim) Then
            ErrorProvider1.SetError(ADDRESS, ADDRESS.Name & " is required")
        Else
            ErrorProvider1.SetError(ADDRESS, "")
        End If
    End Sub

    Private Sub CBoxVENUETYPE_Validated(sender As Object, e As EventArgs) Handles CBoxVENUETYPE.Validated
        If (CBoxVENUETYPE.SelectedIndex = 1 Or 6) Then
            LabelPRICE.Text = "Price (per night)"
        End If
        If CBoxVENUETYPE.SelectedIndex = 0 Or 2 Or 3 Or 4 Or 5 Then
            LabelPRICE.Text = "Price (per time of the day)" & vbNewLine & "(Morning,Afternoon,Evening,Dinner)"
        End If

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnUPLOAD_Click(sender As Object, e As EventArgs) Handles BtnUPLOAD.Click

        opf.Filter = "Image files (*.jpg, *.jpeg, *.png) |*.jpg; *.jpeg; *.png"
        opf.Multiselect = False
        'AddHandler opf.FileOk, Sub(s, ce)
        '                           If opf.FileNames.Length > 3 Then
        '                               MessageBox.Show("Please select no more than 3 files")
        '                               ce.Cancel = True
        '                           End If
        '                       End Sub
        If opf.ShowDialog() = DialogResult.OK Then
            'For i As Integer = 0 To opf.FileNames.Count - 1
            '    If i = 0 Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            'End If
            BtnDONE.Enabled = True
            'Next
        End If

    End Sub

    Private Sub BtnDONE_Click(sender As Object, e As EventArgs) Handles BtnDONE.Click
        Panel1.Visible = False
    End Sub

    Private Sub BtnUPLOADPICTURES_Click(sender As Object, e As EventArgs) Handles BtnUPLOADPICTURES.Click
        Panel1.Visible = True
    End Sub


End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VENUEOWNER_REGISTRATION
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelVENUEOWNERREGIS = New System.Windows.Forms.Label()
        Me.PanelHEAD = New System.Windows.Forms.Panel()
        Me.LabelSELECTTYPE = New System.Windows.Forms.Label()
        Me.LabelPINCODE = New System.Windows.Forms.Label()
        Me.LabelGUESTS = New System.Windows.Forms.Label()
        Me.LabelPRICE = New System.Windows.Forms.Label()
        Me.LabelEMAILID = New System.Windows.Forms.Label()
        Me.LabelSTATE = New System.Windows.Forms.Label()
        Me.LabelCITY = New System.Windows.Forms.Label()
        Me.LabelPHONENO = New System.Windows.Forms.Label()
        Me.LabelNAME = New System.Windows.Forms.Label()
        Me.LabelADDRESS = New System.Windows.Forms.Label()
        Me.CBoxVENUETYPE = New System.Windows.Forms.ComboBox()
        Me.VENUE_NAME = New System.Windows.Forms.TextBox()
        Me.PHONE_NO = New System.Windows.Forms.TextBox()
        Me.ADDRESS = New System.Windows.Forms.RichTextBox()
        Me.CITY = New System.Windows.Forms.TextBox()
        Me.PINCODE = New System.Windows.Forms.TextBox()
        Me.BtnUPLOADPICTURES = New System.Windows.Forms.Button()
        Me.BtnREGISTER = New System.Windows.Forms.Button()
        Me.GUESTS = New System.Windows.Forms.TextBox()
        Me.PRICE = New System.Windows.Forms.TextBox()
        Me.EMAIL_ID = New System.Windows.Forms.TextBox()
        Me.STATE = New System.Windows.Forms.ComboBox()
        Me.LabelLOGINPWD = New System.Windows.Forms.Label()
        Me.PWD = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnSHOWHIDE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnDONE = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnUPLOAD = New System.Windows.Forms.Button()
        Me.opf = New System.Windows.Forms.OpenFileDialog()
        Me.PanelHEAD.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelVENUEOWNERREGIS
        '
        Me.LabelVENUEOWNERREGIS.AutoSize = True
        Me.LabelVENUEOWNERREGIS.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVENUEOWNERREGIS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelVENUEOWNERREGIS.Location = New System.Drawing.Point(302, 26)
        Me.LabelVENUEOWNERREGIS.Name = "LabelVENUEOWNERREGIS"
        Me.LabelVENUEOWNERREGIS.Size = New System.Drawing.Size(466, 37)
        Me.LabelVENUEOWNERREGIS.TabIndex = 0
        Me.LabelVENUEOWNERREGIS.Text = "VENUE OWNER REGISTRATION"
        '
        'PanelHEAD
        '
        Me.PanelHEAD.BackColor = System.Drawing.Color.SandyBrown
        Me.PanelHEAD.Controls.Add(Me.LabelVENUEOWNERREGIS)
        Me.PanelHEAD.Location = New System.Drawing.Point(1, 28)
        Me.PanelHEAD.Name = "PanelHEAD"
        Me.PanelHEAD.Size = New System.Drawing.Size(1043, 83)
        Me.PanelHEAD.TabIndex = 1
        '
        'LabelSELECTTYPE
        '
        Me.LabelSELECTTYPE.AutoSize = True
        Me.LabelSELECTTYPE.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSELECTTYPE.Location = New System.Drawing.Point(44, 158)
        Me.LabelSELECTTYPE.Name = "LabelSELECTTYPE"
        Me.LabelSELECTTYPE.Size = New System.Drawing.Size(126, 26)
        Me.LabelSELECTTYPE.TabIndex = 2
        Me.LabelSELECTTYPE.Text = "Select type:"
        '
        'LabelPINCODE
        '
        Me.LabelPINCODE.AutoSize = True
        Me.LabelPINCODE.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPINCODE.Location = New System.Drawing.Point(44, 581)
        Me.LabelPINCODE.Name = "LabelPINCODE"
        Me.LabelPINCODE.Size = New System.Drawing.Size(97, 26)
        Me.LabelPINCODE.TabIndex = 3
        Me.LabelPINCODE.Text = "Pincode:"
        '
        'LabelGUESTS
        '
        Me.LabelGUESTS.AutoSize = True
        Me.LabelGUESTS.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGUESTS.Location = New System.Drawing.Point(528, 316)
        Me.LabelGUESTS.Name = "LabelGUESTS"
        Me.LabelGUESTS.Size = New System.Drawing.Size(182, 52)
        Me.LabelGUESTS.TabIndex = 8
        Me.LabelGUESTS.Text = "Guests Capacity: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(maximum)"
        '
        'LabelPRICE
        '
        Me.LabelPRICE.AutoSize = True
        Me.LabelPRICE.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPRICE.Location = New System.Drawing.Point(528, 225)
        Me.LabelPRICE.Name = "LabelPRICE"
        Me.LabelPRICE.Size = New System.Drawing.Size(186, 26)
        Me.LabelPRICE.TabIndex = 9
        Me.LabelPRICE.Text = "Price ( per night )"
        '
        'LabelEMAILID
        '
        Me.LabelEMAILID.AutoSize = True
        Me.LabelEMAILID.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEMAILID.Location = New System.Drawing.Point(528, 158)
        Me.LabelEMAILID.Name = "LabelEMAILID"
        Me.LabelEMAILID.Size = New System.Drawing.Size(100, 26)
        Me.LabelEMAILID.TabIndex = 10
        Me.LabelEMAILID.Text = "Email-Id:"
        '
        'LabelSTATE
        '
        Me.LabelSTATE.AutoSize = True
        Me.LabelSTATE.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSTATE.Location = New System.Drawing.Point(44, 522)
        Me.LabelSTATE.Name = "LabelSTATE"
        Me.LabelSTATE.Size = New System.Drawing.Size(69, 26)
        Me.LabelSTATE.TabIndex = 11
        Me.LabelSTATE.Text = "State:"
        '
        'LabelCITY
        '
        Me.LabelCITY.AutoSize = True
        Me.LabelCITY.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCITY.Location = New System.Drawing.Point(44, 461)
        Me.LabelCITY.Name = "LabelCITY"
        Me.LabelCITY.Size = New System.Drawing.Size(55, 26)
        Me.LabelCITY.TabIndex = 12
        Me.LabelCITY.Text = "City:"
        '
        'LabelPHONENO
        '
        Me.LabelPHONENO.AutoSize = True
        Me.LabelPHONENO.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPHONENO.Location = New System.Drawing.Point(528, 416)
        Me.LabelPHONENO.Name = "LabelPHONENO"
        Me.LabelPHONENO.Size = New System.Drawing.Size(112, 26)
        Me.LabelPHONENO.TabIndex = 13
        Me.LabelPHONENO.Text = "Phone no:"
        '
        'LabelNAME
        '
        Me.LabelNAME.AutoSize = True
        Me.LabelNAME.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNAME.Location = New System.Drawing.Point(44, 225)
        Me.LabelNAME.Name = "LabelNAME"
        Me.LabelNAME.Size = New System.Drawing.Size(79, 26)
        Me.LabelNAME.TabIndex = 14
        Me.LabelNAME.Text = "Name:"
        '
        'LabelADDRESS
        '
        Me.LabelADDRESS.AutoSize = True
        Me.LabelADDRESS.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelADDRESS.Location = New System.Drawing.Point(44, 355)
        Me.LabelADDRESS.Name = "LabelADDRESS"
        Me.LabelADDRESS.Size = New System.Drawing.Size(95, 26)
        Me.LabelADDRESS.TabIndex = 15
        Me.LabelADDRESS.Text = "Address:"
        '
        'CBoxVENUETYPE
        '
        Me.CBoxVENUETYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxVENUETYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxVENUETYPE.FormattingEnabled = True
        Me.CBoxVENUETYPE.Location = New System.Drawing.Point(192, 147)
        Me.CBoxVENUETYPE.Name = "CBoxVENUETYPE"
        Me.CBoxVENUETYPE.Size = New System.Drawing.Size(238, 37)
        Me.CBoxVENUETYPE.TabIndex = 16
        '
        'VENUE_NAME
        '
        Me.VENUE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VENUE_NAME.Location = New System.Drawing.Point(192, 217)
        Me.VENUE_NAME.Name = "VENUE_NAME"
        Me.VENUE_NAME.Size = New System.Drawing.Size(238, 34)
        Me.VENUE_NAME.TabIndex = 17
        '
        'PHONE_NO
        '
        Me.PHONE_NO.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHONE_NO.Location = New System.Drawing.Point(770, 408)
        Me.PHONE_NO.Name = "PHONE_NO"
        Me.PHONE_NO.Size = New System.Drawing.Size(238, 34)
        Me.PHONE_NO.TabIndex = 18
        '
        'ADDRESS
        '
        Me.ADDRESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRESS.Location = New System.Drawing.Point(192, 355)
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.Size = New System.Drawing.Size(238, 73)
        Me.ADDRESS.TabIndex = 19
        Me.ADDRESS.Text = ""
        '
        'CITY
        '
        Me.CITY.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CITY.Location = New System.Drawing.Point(192, 453)
        Me.CITY.Name = "CITY"
        Me.CITY.Size = New System.Drawing.Size(238, 34)
        Me.CITY.TabIndex = 20
        '
        'PINCODE
        '
        Me.PINCODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PINCODE.Location = New System.Drawing.Point(192, 573)
        Me.PINCODE.Name = "PINCODE"
        Me.PINCODE.Size = New System.Drawing.Size(238, 34)
        Me.PINCODE.TabIndex = 22
        '
        'BtnUPLOADPICTURES
        '
        Me.BtnUPLOADPICTURES.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUPLOADPICTURES.Location = New System.Drawing.Point(493, 559)
        Me.BtnUPLOADPICTURES.Name = "BtnUPLOADPICTURES"
        Me.BtnUPLOADPICTURES.Size = New System.Drawing.Size(239, 48)
        Me.BtnUPLOADPICTURES.TabIndex = 24
        Me.BtnUPLOADPICTURES.Text = "Upload Pictures"
        Me.BtnUPLOADPICTURES.UseVisualStyleBackColor = True
        '
        'BtnREGISTER
        '
        Me.BtnREGISTER.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnREGISTER.Location = New System.Drawing.Point(747, 559)
        Me.BtnREGISTER.Name = "BtnREGISTER"
        Me.BtnREGISTER.Size = New System.Drawing.Size(239, 48)
        Me.BtnREGISTER.TabIndex = 25
        Me.BtnREGISTER.Text = "Register"
        Me.BtnREGISTER.UseVisualStyleBackColor = True
        '
        'GUESTS
        '
        Me.GUESTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUESTS.Location = New System.Drawing.Point(770, 316)
        Me.GUESTS.Name = "GUESTS"
        Me.GUESTS.Size = New System.Drawing.Size(238, 34)
        Me.GUESTS.TabIndex = 26
        '
        'PRICE
        '
        Me.PRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRICE.Location = New System.Drawing.Point(847, 217)
        Me.PRICE.Name = "PRICE"
        Me.PRICE.Size = New System.Drawing.Size(97, 34)
        Me.PRICE.TabIndex = 27
        '
        'EMAIL_ID
        '
        Me.EMAIL_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAIL_ID.Location = New System.Drawing.Point(770, 150)
        Me.EMAIL_ID.Name = "EMAIL_ID"
        Me.EMAIL_ID.Size = New System.Drawing.Size(238, 34)
        Me.EMAIL_ID.TabIndex = 28
        '
        'STATE
        '
        Me.STATE.DropDownHeight = 150
        Me.STATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.STATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STATE.FormattingEnabled = True
        Me.STATE.IntegralHeight = False
        Me.STATE.Location = New System.Drawing.Point(192, 511)
        Me.STATE.Name = "STATE"
        Me.STATE.Size = New System.Drawing.Size(238, 37)
        Me.STATE.TabIndex = 29
        '
        'LabelLOGINPWD
        '
        Me.LabelLOGINPWD.AutoSize = True
        Me.LabelLOGINPWD.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLOGINPWD.Location = New System.Drawing.Point(44, 290)
        Me.LabelLOGINPWD.Name = "LabelLOGINPWD"
        Me.LabelLOGINPWD.Size = New System.Drawing.Size(172, 26)
        Me.LabelLOGINPWD.TabIndex = 31
        Me.LabelLOGINPWD.Text = "Login Password:"
        '
        'PWD
        '
        Me.PWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PWD.Location = New System.Drawing.Point(222, 282)
        Me.PWD.Name = "PWD"
        Me.PWD.Size = New System.Drawing.Size(208, 34)
        Me.PWD.TabIndex = 32
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BtnSHOWHIDE
        '
        Me.BtnSHOWHIDE.FlatAppearance.BorderSize = 0
        Me.BtnSHOWHIDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSHOWHIDE.Image = Global.BookMyVenue.My.Resources.Resources.hide
        Me.BtnSHOWHIDE.Location = New System.Drawing.Point(436, 277)
        Me.BtnSHOWHIDE.Name = "BtnSHOWHIDE"
        Me.BtnSHOWHIDE.Size = New System.Drawing.Size(41, 43)
        Me.BtnSHOWHIDE.TabIndex = 33
        Me.BtnSHOWHIDE.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnDONE)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnUPLOAD)
        Me.Panel1.Location = New System.Drawing.Point(87, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 516)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Visible = False
        '
        'BtnDONE
        '
        Me.BtnDONE.Enabled = False
        Me.BtnDONE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDONE.Location = New System.Drawing.Point(418, 405)
        Me.BtnDONE.Name = "BtnDONE"
        Me.BtnDONE.Size = New System.Drawing.Size(218, 48)
        Me.BtnDONE.TabIndex = 5
        Me.BtnDONE.Text = "DONE"
        Me.BtnDONE.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(53, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(736, 358)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BtnUPLOAD
        '
        Me.BtnUPLOAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUPLOAD.Location = New System.Drawing.Point(159, 405)
        Me.BtnUPLOAD.Name = "BtnUPLOAD"
        Me.BtnUPLOAD.Size = New System.Drawing.Size(218, 48)
        Me.BtnUPLOAD.TabIndex = 1
        Me.BtnUPLOAD.Text = "UPLOAD"
        Me.BtnUPLOAD.UseVisualStyleBackColor = True
        '
        'opf
        '
        Me.opf.FileName = "OpenFileDialog1"
        '
        'VENUEOWNER_REGISTRATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(1044, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSHOWHIDE)
        Me.Controls.Add(Me.PWD)
        Me.Controls.Add(Me.LabelLOGINPWD)
        Me.Controls.Add(Me.STATE)
        Me.Controls.Add(Me.EMAIL_ID)
        Me.Controls.Add(Me.PRICE)
        Me.Controls.Add(Me.GUESTS)
        Me.Controls.Add(Me.BtnREGISTER)
        Me.Controls.Add(Me.BtnUPLOADPICTURES)
        Me.Controls.Add(Me.PINCODE)
        Me.Controls.Add(Me.CITY)
        Me.Controls.Add(Me.ADDRESS)
        Me.Controls.Add(Me.PHONE_NO)
        Me.Controls.Add(Me.VENUE_NAME)
        Me.Controls.Add(Me.CBoxVENUETYPE)
        Me.Controls.Add(Me.LabelADDRESS)
        Me.Controls.Add(Me.LabelNAME)
        Me.Controls.Add(Me.LabelPHONENO)
        Me.Controls.Add(Me.LabelCITY)
        Me.Controls.Add(Me.LabelSTATE)
        Me.Controls.Add(Me.LabelEMAILID)
        Me.Controls.Add(Me.LabelPRICE)
        Me.Controls.Add(Me.LabelGUESTS)
        Me.Controls.Add(Me.LabelPINCODE)
        Me.Controls.Add(Me.LabelSELECTTYPE)
        Me.Controls.Add(Me.PanelHEAD)
        Me.Name = "VENUEOWNER_REGISTRATION"
        Me.Text = "VENUEOWNER_REGISTRATION"
        Me.PanelHEAD.ResumeLayout(False)
        Me.PanelHEAD.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelVENUEOWNERREGIS As Label
    Friend WithEvents PanelHEAD As Panel
    Friend WithEvents LabelSELECTTYPE As Label
    Friend WithEvents LabelPINCODE As Label
    Friend WithEvents LabelGUESTS As Label
    Friend WithEvents LabelPRICE As Label
    Friend WithEvents LabelEMAILID As Label
    Friend WithEvents LabelSTATE As Label
    Friend WithEvents LabelCITY As Label
    Friend WithEvents LabelPHONENO As Label
    Friend WithEvents LabelNAME As Label
    Friend WithEvents LabelADDRESS As Label
    Friend WithEvents CBoxVENUETYPE As ComboBox
    Friend WithEvents VENUE_NAME As TextBox
    Friend WithEvents PHONE_NO As TextBox
    Friend WithEvents ADDRESS As RichTextBox
    Friend WithEvents CITY As TextBox
    Friend WithEvents PINCODE As TextBox
    Friend WithEvents BtnUPLOADPICTURES As Button
    Friend WithEvents BtnREGISTER As Button
    Friend WithEvents GUESTS As TextBox
    Friend WithEvents PRICE As TextBox
    Friend WithEvents EMAIL_ID As TextBox
    Friend WithEvents STATE As ComboBox
    Friend WithEvents LabelLOGINPWD As Label
    Friend WithEvents PWD As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BtnSHOWHIDE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnUPLOAD As Button
    Friend WithEvents BtnDONE As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents opf As OpenFileDialog
End Class

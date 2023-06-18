<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NEWBOOKING
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnRESORT = New System.Windows.Forms.Button()
        Me.BtnVILLA = New System.Windows.Forms.Button()
        Me.BtnAPARTMENT = New System.Windows.Forms.Button()
        Me.BtnBANQUETHALL = New System.Windows.Forms.Button()
        Me.BtnGARDEN = New System.Windows.Forms.Button()
        Me.BtnCLUBHOUSE = New System.Windows.Forms.Button()
        Me.BtnCAFE = New System.Windows.Forms.Button()
        Me.LabelCAFE = New System.Windows.Forms.Label()
        Me.LabelVILLA = New System.Windows.Forms.Label()
        Me.LabelRESORT = New System.Windows.Forms.Label()
        Me.LabelBANQUETHALL = New System.Windows.Forms.Label()
        Me.LabelGARDEN = New System.Windows.Forms.Label()
        Me.LabelCLUBHOUSE = New System.Windows.Forms.Label()
        Me.LabelAPARTMENT = New System.Windows.Forms.Label()
        Me.LabelSELECTTHEVENUETYPE = New System.Windows.Forms.Label()
        Me.PanelHEAD = New System.Windows.Forms.Panel()
        Me.PanelVENUELIST = New System.Windows.Forms.Panel()
        Me.PanelBOOK = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelCUSTOMERID = New System.Windows.Forms.Label()
        Me.BtnBOOK = New System.Windows.Forms.Button()
        Me.DtpCHECKOUT = New System.Windows.Forms.DateTimePicker()
        Me.DtpCHECKIN = New System.Windows.Forms.DateTimePicker()
        Me.LabelCHECKOUT = New System.Windows.Forms.Label()
        Me.LabelCHECKIN = New System.Windows.Forms.Label()
        Me.DgvCAFE = New System.Windows.Forms.DataGridView()
        Me.Selectbooktobookthevenue = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PanelHEAD.SuspendLayout()
        Me.PanelVENUELIST.SuspendLayout()
        Me.PanelBOOK.SuspendLayout()
        CType(Me.DgvCAFE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRESORT
        '
        Me.BtnRESORT.Image = Global.BookMyVenue.My.Resources.Resources.resort
        Me.BtnRESORT.Location = New System.Drawing.Point(405, 210)
        Me.BtnRESORT.Name = "BtnRESORT"
        Me.BtnRESORT.Size = New System.Drawing.Size(162, 167)
        Me.BtnRESORT.TabIndex = 7
        Me.BtnRESORT.UseVisualStyleBackColor = True
        '
        'BtnVILLA
        '
        Me.BtnVILLA.Image = Global.BookMyVenue.My.Resources.Resources.villas
        Me.BtnVILLA.Location = New System.Drawing.Point(211, 210)
        Me.BtnVILLA.Name = "BtnVILLA"
        Me.BtnVILLA.Size = New System.Drawing.Size(158, 167)
        Me.BtnVILLA.TabIndex = 6
        Me.BtnVILLA.UseVisualStyleBackColor = True
        '
        'BtnAPARTMENT
        '
        Me.BtnAPARTMENT.Image = Global.BookMyVenue.My.Resources.Resources.apartment_flat1
        Me.BtnAPARTMENT.Location = New System.Drawing.Point(512, 436)
        Me.BtnAPARTMENT.Name = "BtnAPARTMENT"
        Me.BtnAPARTMENT.Size = New System.Drawing.Size(158, 159)
        Me.BtnAPARTMENT.TabIndex = 5
        Me.BtnAPARTMENT.UseVisualStyleBackColor = True
        '
        'BtnBANQUETHALL
        '
        Me.BtnBANQUETHALL.Image = Global.BookMyVenue.My.Resources.Resources.banquethall
        Me.BtnBANQUETHALL.Location = New System.Drawing.Point(616, 210)
        Me.BtnBANQUETHALL.Name = "BtnBANQUETHALL"
        Me.BtnBANQUETHALL.Size = New System.Drawing.Size(157, 167)
        Me.BtnBANQUETHALL.TabIndex = 4
        Me.BtnBANQUETHALL.UseVisualStyleBackColor = True
        '
        'BtnGARDEN
        '
        Me.BtnGARDEN.Image = Global.BookMyVenue.My.Resources.Resources.gardens
        Me.BtnGARDEN.Location = New System.Drawing.Point(119, 436)
        Me.BtnGARDEN.Name = "BtnGARDEN"
        Me.BtnGARDEN.Size = New System.Drawing.Size(151, 159)
        Me.BtnGARDEN.TabIndex = 3
        Me.BtnGARDEN.UseVisualStyleBackColor = True
        '
        'BtnCLUBHOUSE
        '
        Me.BtnCLUBHOUSE.Image = Global.BookMyVenue.My.Resources.Resources.clubhouse
        Me.BtnCLUBHOUSE.Location = New System.Drawing.Point(311, 436)
        Me.BtnCLUBHOUSE.Name = "BtnCLUBHOUSE"
        Me.BtnCLUBHOUSE.Size = New System.Drawing.Size(155, 159)
        Me.BtnCLUBHOUSE.TabIndex = 2
        Me.BtnCLUBHOUSE.UseVisualStyleBackColor = True
        '
        'BtnCAFE
        '
        Me.BtnCAFE.Image = Global.BookMyVenue.My.Resources.Resources.cafe
        Me.BtnCAFE.Location = New System.Drawing.Point(25, 210)
        Me.BtnCAFE.Name = "BtnCAFE"
        Me.BtnCAFE.Size = New System.Drawing.Size(158, 167)
        Me.BtnCAFE.TabIndex = 1
        Me.BtnCAFE.UseVisualStyleBackColor = True
        '
        'LabelCAFE
        '
        Me.LabelCAFE.AutoSize = True
        Me.LabelCAFE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCAFE.Location = New System.Drawing.Point(20, 173)
        Me.LabelCAFE.Name = "LabelCAFE"
        Me.LabelCAFE.Size = New System.Drawing.Size(163, 25)
        Me.LabelCAFE.TabIndex = 8
        Me.LabelCAFE.Text = "Cafe | Restaurant"
        '
        'LabelVILLA
        '
        Me.LabelVILLA.AutoSize = True
        Me.LabelVILLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVILLA.Location = New System.Drawing.Point(264, 173)
        Me.LabelVILLA.Name = "LabelVILLA"
        Me.LabelVILLA.Size = New System.Drawing.Size(49, 25)
        Me.LabelVILLA.TabIndex = 9
        Me.LabelVILLA.Text = "Villa"
        '
        'LabelRESORT
        '
        Me.LabelRESORT.AutoSize = True
        Me.LabelRESORT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRESORT.Location = New System.Drawing.Point(454, 173)
        Me.LabelRESORT.Name = "LabelRESORT"
        Me.LabelRESORT.Size = New System.Drawing.Size(68, 25)
        Me.LabelRESORT.TabIndex = 10
        Me.LabelRESORT.Text = "Resort"
        '
        'LabelBANQUETHALL
        '
        Me.LabelBANQUETHALL.AutoSize = True
        Me.LabelBANQUETHALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBANQUETHALL.Location = New System.Drawing.Point(625, 173)
        Me.LabelBANQUETHALL.Name = "LabelBANQUETHALL"
        Me.LabelBANQUETHALL.Size = New System.Drawing.Size(123, 25)
        Me.LabelBANQUETHALL.TabIndex = 11
        Me.LabelBANQUETHALL.Text = "Banquet Hall"
        '
        'LabelGARDEN
        '
        Me.LabelGARDEN.AutoSize = True
        Me.LabelGARDEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGARDEN.Location = New System.Drawing.Point(122, 401)
        Me.LabelGARDEN.Name = "LabelGARDEN"
        Me.LabelGARDEN.Size = New System.Drawing.Size(148, 25)
        Me.LabelGARDEN.TabIndex = 12
        Me.LabelGARDEN.Text = "Garden | Beach"
        '
        'LabelCLUBHOUSE
        '
        Me.LabelCLUBHOUSE.AutoSize = True
        Me.LabelCLUBHOUSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCLUBHOUSE.Location = New System.Drawing.Point(336, 401)
        Me.LabelCLUBHOUSE.Name = "LabelCLUBHOUSE"
        Me.LabelCLUBHOUSE.Size = New System.Drawing.Size(115, 25)
        Me.LabelCLUBHOUSE.TabIndex = 13
        Me.LabelCLUBHOUSE.Text = "Club House"
        '
        'LabelAPARTMENT
        '
        Me.LabelAPARTMENT.AutoSize = True
        Me.LabelAPARTMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAPARTMENT.Location = New System.Drawing.Point(521, 401)
        Me.LabelAPARTMENT.Name = "LabelAPARTMENT"
        Me.LabelAPARTMENT.Size = New System.Drawing.Size(149, 25)
        Me.LabelAPARTMENT.TabIndex = 14
        Me.LabelAPARTMENT.Text = "Apartment | Flat"
        '
        'LabelSELECTTHEVENUETYPE
        '
        Me.LabelSELECTTHEVENUETYPE.AutoSize = True
        Me.LabelSELECTTHEVENUETYPE.Font = New System.Drawing.Font("Segoe Print", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSELECTTHEVENUETYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.LabelSELECTTHEVENUETYPE.Location = New System.Drawing.Point(55, 12)
        Me.LabelSELECTTHEVENUETYPE.Name = "LabelSELECTTHEVENUETYPE"
        Me.LabelSELECTTHEVENUETYPE.Size = New System.Drawing.Size(728, 58)
        Me.LabelSELECTTHEVENUETYPE.TabIndex = 15
        Me.LabelSELECTTHEVENUETYPE.Text = "Select the type of venue you want to book"
        '
        'PanelHEAD
        '
        Me.PanelHEAD.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.PanelHEAD.Controls.Add(Me.LabelSELECTTHEVENUETYPE)
        Me.PanelHEAD.Location = New System.Drawing.Point(0, 48)
        Me.PanelHEAD.Name = "PanelHEAD"
        Me.PanelHEAD.Size = New System.Drawing.Size(1046, 87)
        Me.PanelHEAD.TabIndex = 16
        '
        'PanelVENUELIST
        '
        Me.PanelVENUELIST.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelVENUELIST.Controls.Add(Me.PanelBOOK)
        Me.PanelVENUELIST.Controls.Add(Me.DgvCAFE)
        Me.PanelVENUELIST.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelVENUELIST.Location = New System.Drawing.Point(0, 2)
        Me.PanelVENUELIST.Name = "PanelVENUELIST"
        Me.PanelVENUELIST.Size = New System.Drawing.Size(824, 608)
        Me.PanelVENUELIST.TabIndex = 17
        '
        'PanelBOOK
        '
        Me.PanelBOOK.Controls.Add(Me.ComboBox1)
        Me.PanelBOOK.Controls.Add(Me.LabelCUSTOMERID)
        Me.PanelBOOK.Controls.Add(Me.BtnBOOK)
        Me.PanelBOOK.Controls.Add(Me.DtpCHECKOUT)
        Me.PanelBOOK.Controls.Add(Me.DtpCHECKIN)
        Me.PanelBOOK.Controls.Add(Me.LabelCHECKOUT)
        Me.PanelBOOK.Controls.Add(Me.LabelCHECKIN)
        Me.PanelBOOK.Location = New System.Drawing.Point(3, 4)
        Me.PanelBOOK.Name = "PanelBOOK"
        Me.PanelBOOK.Size = New System.Drawing.Size(809, 604)
        Me.PanelBOOK.TabIndex = 14
        Me.PanelBOOK.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(340, 100)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(217, 37)
        Me.ComboBox1.TabIndex = 13
        '
        'LabelCUSTOMERID
        '
        Me.LabelCUSTOMERID.AutoSize = True
        Me.LabelCUSTOMERID.Location = New System.Drawing.Point(72, 108)
        Me.LabelCUSTOMERID.Name = "LabelCUSTOMERID"
        Me.LabelCUSTOMERID.Size = New System.Drawing.Size(146, 29)
        Me.LabelCUSTOMERID.TabIndex = 12
        Me.LabelCUSTOMERID.Text = "Customer ID"
        '
        'BtnBOOK
        '
        Me.BtnBOOK.Location = New System.Drawing.Point(268, 448)
        Me.BtnBOOK.Name = "BtnBOOK"
        Me.BtnBOOK.Size = New System.Drawing.Size(228, 62)
        Me.BtnBOOK.TabIndex = 11
        Me.BtnBOOK.Text = "BOOK"
        Me.BtnBOOK.UseVisualStyleBackColor = True
        '
        'DtpCHECKOUT
        '
        Me.DtpCHECKOUT.Location = New System.Drawing.Point(340, 268)
        Me.DtpCHECKOUT.Name = "DtpCHECKOUT"
        Me.DtpCHECKOUT.Size = New System.Drawing.Size(395, 34)
        Me.DtpCHECKOUT.TabIndex = 10
        '
        'DtpCHECKIN
        '
        Me.DtpCHECKIN.Location = New System.Drawing.Point(340, 181)
        Me.DtpCHECKIN.Name = "DtpCHECKIN"
        Me.DtpCHECKIN.Size = New System.Drawing.Size(395, 34)
        Me.DtpCHECKIN.TabIndex = 9
        '
        'LabelCHECKOUT
        '
        Me.LabelCHECKOUT.AutoSize = True
        Me.LabelCHECKOUT.Location = New System.Drawing.Point(72, 273)
        Me.LabelCHECKOUT.Name = "LabelCHECKOUT"
        Me.LabelCHECKOUT.Size = New System.Drawing.Size(178, 29)
        Me.LabelCHECKOUT.TabIndex = 8
        Me.LabelCHECKOUT.Text = "Check-out Date"
        '
        'LabelCHECKIN
        '
        Me.LabelCHECKIN.AutoSize = True
        Me.LabelCHECKIN.Location = New System.Drawing.Point(72, 195)
        Me.LabelCHECKIN.Name = "LabelCHECKIN"
        Me.LabelCHECKIN.Size = New System.Drawing.Size(164, 29)
        Me.LabelCHECKIN.TabIndex = 7
        Me.LabelCHECKIN.Text = "Check-in Date"
        '
        'DgvCAFE
        '
        Me.DgvCAFE.BackgroundColor = System.Drawing.Color.BlanchedAlmond
        Me.DgvCAFE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCAFE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selectbooktobookthevenue})
        Me.DgvCAFE.Location = New System.Drawing.Point(19, 24)
        Me.DgvCAFE.Name = "DgvCAFE"
        Me.DgvCAFE.RowTemplate.Height = 24
        Me.DgvCAFE.Size = New System.Drawing.Size(771, 550)
        Me.DgvCAFE.TabIndex = 15
        '
        'Selectbooktobookthevenue
        '
        Me.Selectbooktobookthevenue.HeaderText = "Select Book to book the venue"
        Me.Selectbooktobookthevenue.Name = "Selectbooktobookthevenue"
        Me.Selectbooktobookthevenue.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Selectbooktobookthevenue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Selectbooktobookthevenue.Text = "Book"
        Me.Selectbooktobookthevenue.UseColumnTextForButtonValue = True
        '
        'NEWBOOKING
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 607)
        Me.Controls.Add(Me.PanelVENUELIST)
        Me.Controls.Add(Me.PanelHEAD)
        Me.Controls.Add(Me.LabelAPARTMENT)
        Me.Controls.Add(Me.LabelCLUBHOUSE)
        Me.Controls.Add(Me.LabelGARDEN)
        Me.Controls.Add(Me.LabelBANQUETHALL)
        Me.Controls.Add(Me.LabelRESORT)
        Me.Controls.Add(Me.LabelVILLA)
        Me.Controls.Add(Me.LabelCAFE)
        Me.Controls.Add(Me.BtnRESORT)
        Me.Controls.Add(Me.BtnVILLA)
        Me.Controls.Add(Me.BtnAPARTMENT)
        Me.Controls.Add(Me.BtnBANQUETHALL)
        Me.Controls.Add(Me.BtnGARDEN)
        Me.Controls.Add(Me.BtnCLUBHOUSE)
        Me.Controls.Add(Me.BtnCAFE)
        Me.Name = "NEWBOOKING"
        Me.Text = "NEWBOOKING"
        Me.PanelHEAD.ResumeLayout(False)
        Me.PanelHEAD.PerformLayout()
        Me.PanelVENUELIST.ResumeLayout(False)
        Me.PanelBOOK.ResumeLayout(False)
        Me.PanelBOOK.PerformLayout()
        CType(Me.DgvCAFE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCAFE As Button
    Friend WithEvents BtnCLUBHOUSE As Button
    Friend WithEvents BtnGARDEN As Button
    Friend WithEvents BtnBANQUETHALL As Button
    Friend WithEvents BtnAPARTMENT As Button
    Friend WithEvents BtnVILLA As Button
    Friend WithEvents BtnRESORT As Button
    Friend WithEvents LabelCAFE As Label
    Friend WithEvents LabelVILLA As Label
    Friend WithEvents LabelRESORT As Label
    Friend WithEvents LabelBANQUETHALL As Label
    Friend WithEvents LabelGARDEN As Label
    Friend WithEvents LabelCLUBHOUSE As Label
    Friend WithEvents LabelAPARTMENT As Label
    Friend WithEvents LabelSELECTTHEVENUETYPE As Label
    Friend WithEvents PanelHEAD As Panel
    Friend WithEvents PanelVENUELIST As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelCUSTOMERID As Label
    Friend WithEvents BtnBOOK As Button
    Friend WithEvents DtpCHECKOUT As DateTimePicker
    Friend WithEvents DtpCHECKIN As DateTimePicker
    Friend WithEvents LabelCHECKOUT As Label
    Friend WithEvents LabelCHECKIN As Label
    Friend WithEvents PanelBOOK As Panel
    Friend WithEvents DgvCAFE As DataGridView
    Friend WithEvents Selectbooktobookthevenue As DataGridViewButtonColumn
End Class

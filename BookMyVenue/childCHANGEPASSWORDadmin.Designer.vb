<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class childCHANGEPASSWORDadmin
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
        Me.BtnCONFIRM = New System.Windows.Forms.Button()
        Me.BtnCANCEL = New System.Windows.Forms.Button()
        Me.BtnRESET = New System.Windows.Forms.Button()
        Me.LabelCHANGEPASSWORD = New System.Windows.Forms.Label()
        Me.LabelOLDPWD = New System.Windows.Forms.Label()
        Me.TxtOLDPWD = New System.Windows.Forms.TextBox()
        Me.BtnOLDPWD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNEWPWD = New System.Windows.Forms.TextBox()
        Me.TxtRENEWPWD = New System.Windows.Forms.TextBox()
        Me.BtnNEWPWD = New System.Windows.Forms.Button()
        Me.BtnRENEWPWD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCONFIRM
        '
        Me.BtnCONFIRM.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCONFIRM.Location = New System.Drawing.Point(362, 585)
        Me.BtnCONFIRM.Name = "BtnCONFIRM"
        Me.BtnCONFIRM.Size = New System.Drawing.Size(176, 54)
        Me.BtnCONFIRM.TabIndex = 0
        Me.BtnCONFIRM.Text = "Confirm"
        Me.BtnCONFIRM.UseVisualStyleBackColor = True
        '
        'BtnCANCEL
        '
        Me.BtnCANCEL.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCANCEL.Location = New System.Drawing.Point(830, 585)
        Me.BtnCANCEL.Name = "BtnCANCEL"
        Me.BtnCANCEL.Size = New System.Drawing.Size(176, 54)
        Me.BtnCANCEL.TabIndex = 1
        Me.BtnCANCEL.Text = "Cancel"
        Me.BtnCANCEL.UseVisualStyleBackColor = True
        '
        'BtnRESET
        '
        Me.BtnRESET.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRESET.Location = New System.Drawing.Point(601, 585)
        Me.BtnRESET.Name = "BtnRESET"
        Me.BtnRESET.Size = New System.Drawing.Size(176, 54)
        Me.BtnRESET.TabIndex = 2
        Me.BtnRESET.Text = "Reset"
        Me.BtnRESET.UseVisualStyleBackColor = True
        '
        'LabelCHANGEPASSWORD
        '
        Me.LabelCHANGEPASSWORD.AutoSize = True
        Me.LabelCHANGEPASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCHANGEPASSWORD.Location = New System.Drawing.Point(337, 109)
        Me.LabelCHANGEPASSWORD.Name = "LabelCHANGEPASSWORD"
        Me.LabelCHANGEPASSWORD.Size = New System.Drawing.Size(343, 44)
        Me.LabelCHANGEPASSWORD.TabIndex = 3
        Me.LabelCHANGEPASSWORD.Text = "Change Password"
        '
        'LabelOLDPWD
        '
        Me.LabelOLDPWD.AutoSize = True
        Me.LabelOLDPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOLDPWD.Location = New System.Drawing.Point(146, 242)
        Me.LabelOLDPWD.Name = "LabelOLDPWD"
        Me.LabelOLDPWD.Size = New System.Drawing.Size(274, 32)
        Me.LabelOLDPWD.TabIndex = 4
        Me.LabelOLDPWD.Text = "Enter Old Password:"
        '
        'TxtOLDPWD
        '
        Me.TxtOLDPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOLDPWD.Location = New System.Drawing.Point(496, 236)
        Me.TxtOLDPWD.Name = "TxtOLDPWD"
        Me.TxtOLDPWD.Size = New System.Drawing.Size(332, 38)
        Me.TxtOLDPWD.TabIndex = 5
        Me.TxtOLDPWD.UseSystemPasswordChar = True
        '
        'BtnOLDPWD
        '
        Me.BtnOLDPWD.FlatAppearance.BorderSize = 0
        Me.BtnOLDPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOLDPWD.Image = Global.BookMyVenue.My.Resources.Resources.hide
        Me.BtnOLDPWD.Location = New System.Drawing.Point(852, 236)
        Me.BtnOLDPWD.Name = "BtnOLDPWD"
        Me.BtnOLDPWD.Size = New System.Drawing.Size(38, 38)
        Me.BtnOLDPWD.TabIndex = 6
        Me.BtnOLDPWD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 430)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Re-enter New Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter New Password:"
        '
        'TxtNEWPWD
        '
        Me.TxtNEWPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNEWPWD.Location = New System.Drawing.Point(496, 346)
        Me.TxtNEWPWD.Name = "TxtNEWPWD"
        Me.TxtNEWPWD.Size = New System.Drawing.Size(332, 38)
        Me.TxtNEWPWD.TabIndex = 9
        Me.TxtNEWPWD.UseSystemPasswordChar = True
        '
        'TxtRENEWPWD
        '
        Me.TxtRENEWPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRENEWPWD.Location = New System.Drawing.Point(496, 424)
        Me.TxtRENEWPWD.Name = "TxtRENEWPWD"
        Me.TxtRENEWPWD.Size = New System.Drawing.Size(332, 38)
        Me.TxtRENEWPWD.TabIndex = 10
        Me.TxtRENEWPWD.UseSystemPasswordChar = True
        '
        'BtnNEWPWD
        '
        Me.BtnNEWPWD.FlatAppearance.BorderSize = 0
        Me.BtnNEWPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNEWPWD.Image = Global.BookMyVenue.My.Resources.Resources.hide
        Me.BtnNEWPWD.Location = New System.Drawing.Point(852, 346)
        Me.BtnNEWPWD.Name = "BtnNEWPWD"
        Me.BtnNEWPWD.Size = New System.Drawing.Size(38, 38)
        Me.BtnNEWPWD.TabIndex = 11
        Me.BtnNEWPWD.UseVisualStyleBackColor = True
        '
        'BtnRENEWPWD
        '
        Me.BtnRENEWPWD.FlatAppearance.BorderSize = 0
        Me.BtnRENEWPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRENEWPWD.Image = Global.BookMyVenue.My.Resources.Resources.hide
        Me.BtnRENEWPWD.Location = New System.Drawing.Point(852, 424)
        Me.BtnRENEWPWD.Name = "BtnRENEWPWD"
        Me.BtnRENEWPWD.Size = New System.Drawing.Size(38, 38)
        Me.BtnRENEWPWD.TabIndex = 12
        Me.BtnRENEWPWD.UseVisualStyleBackColor = True
        '
        'childCHANGEPASSWORDadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1044, 736)
        Me.Controls.Add(Me.BtnRENEWPWD)
        Me.Controls.Add(Me.BtnNEWPWD)
        Me.Controls.Add(Me.TxtRENEWPWD)
        Me.Controls.Add(Me.TxtNEWPWD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOLDPWD)
        Me.Controls.Add(Me.TxtOLDPWD)
        Me.Controls.Add(Me.LabelOLDPWD)
        Me.Controls.Add(Me.LabelCHANGEPASSWORD)
        Me.Controls.Add(Me.BtnRESET)
        Me.Controls.Add(Me.BtnCANCEL)
        Me.Controls.Add(Me.BtnCONFIRM)
        Me.Name = "childCHANGEPASSWORDadmin"
        Me.Text = "childCHANGEPASSWORDadmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCONFIRM As Button
    Friend WithEvents BtnCANCEL As Button
    Friend WithEvents BtnRESET As Button
    Friend WithEvents LabelCHANGEPASSWORD As Label
    Friend WithEvents LabelOLDPWD As Label
    Friend WithEvents TxtOLDPWD As TextBox
    Friend WithEvents BtnOLDPWD As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNEWPWD As TextBox
    Friend WithEvents TxtRENEWPWD As TextBox
    Friend WithEvents BtnNEWPWD As Button
    Friend WithEvents BtnRENEWPWD As Button
End Class

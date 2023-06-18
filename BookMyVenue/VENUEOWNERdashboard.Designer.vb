<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VENUEOWNERdashboard
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
        Me.PanelEDGE = New System.Windows.Forms.Panel()
        Me.PanelHEAD = New System.Windows.Forms.Panel()
        Me.PanelCHILD = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnVIEWBOOKINGS = New System.Windows.Forms.Button()
        Me.BtnCHANGEPASSWORD = New System.Windows.Forms.Button()
        Me.PanelVIEWBOOKINGS = New System.Windows.Forms.Panel()
        Me.PanelCHANGEPASSWORD = New System.Windows.Forms.Panel()
        Me.BtnLOGOUT = New System.Windows.Forms.Button()
        Me.LabelWELCOME = New System.Windows.Forms.Label()
        Me.PanelEDGE.SuspendLayout()
        Me.PanelHEAD.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEDGE
        '
        Me.PanelEDGE.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelEDGE.Controls.Add(Me.PanelVIEWBOOKINGS)
        Me.PanelEDGE.Controls.Add(Me.BtnCHANGEPASSWORD)
        Me.PanelEDGE.Controls.Add(Me.BtnVIEWBOOKINGS)
        Me.PanelEDGE.Controls.Add(Me.PictureBox1)
        Me.PanelEDGE.Location = New System.Drawing.Point(1, 2)
        Me.PanelEDGE.Name = "PanelEDGE"
        Me.PanelEDGE.Size = New System.Drawing.Size(198, 733)
        Me.PanelEDGE.TabIndex = 0
        '
        'PanelHEAD
        '
        Me.PanelHEAD.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PanelHEAD.Controls.Add(Me.LabelWELCOME)
        Me.PanelHEAD.Controls.Add(Me.BtnLOGOUT)
        Me.PanelHEAD.Location = New System.Drawing.Point(198, 2)
        Me.PanelHEAD.Name = "PanelHEAD"
        Me.PanelHEAD.Size = New System.Drawing.Size(846, 63)
        Me.PanelHEAD.TabIndex = 1
        '
        'PanelCHILD
        '
        Me.PanelCHILD.BackColor = System.Drawing.Color.MintCream
        Me.PanelCHILD.Location = New System.Drawing.Point(198, 61)
        Me.PanelCHILD.Name = "PanelCHILD"
        Me.PanelCHILD.Size = New System.Drawing.Size(845, 673)
        Me.PanelCHILD.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.BookMyVenue.My.Resources.Resources.croplogo
        Me.PictureBox1.Location = New System.Drawing.Point(24, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'BtnVIEWBOOKINGS
        '
        Me.BtnVIEWBOOKINGS.FlatAppearance.BorderSize = 0
        Me.BtnVIEWBOOKINGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVIEWBOOKINGS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVIEWBOOKINGS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVIEWBOOKINGS.Location = New System.Drawing.Point(0, 154)
        Me.BtnVIEWBOOKINGS.Name = "BtnVIEWBOOKINGS"
        Me.BtnVIEWBOOKINGS.Size = New System.Drawing.Size(198, 48)
        Me.BtnVIEWBOOKINGS.TabIndex = 12
        Me.BtnVIEWBOOKINGS.Text = "View Bookings"
        Me.BtnVIEWBOOKINGS.UseVisualStyleBackColor = True
        '
        'BtnCHANGEPASSWORD
        '
        Me.BtnCHANGEPASSWORD.FlatAppearance.BorderSize = 0
        Me.BtnCHANGEPASSWORD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCHANGEPASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCHANGEPASSWORD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCHANGEPASSWORD.Location = New System.Drawing.Point(0, 208)
        Me.BtnCHANGEPASSWORD.Name = "BtnCHANGEPASSWORD"
        Me.BtnCHANGEPASSWORD.Size = New System.Drawing.Size(198, 48)
        Me.BtnCHANGEPASSWORD.TabIndex = 13
        Me.BtnCHANGEPASSWORD.Text = "Change Password"
        Me.BtnCHANGEPASSWORD.UseVisualStyleBackColor = True
        '
        'PanelVIEWBOOKINGS
        '
        Me.PanelVIEWBOOKINGS.BackColor = System.Drawing.Color.MintCream
        Me.PanelVIEWBOOKINGS.Location = New System.Drawing.Point(0, 154)
        Me.PanelVIEWBOOKINGS.Name = "PanelVIEWBOOKINGS"
        Me.PanelVIEWBOOKINGS.Size = New System.Drawing.Size(10, 48)
        Me.PanelVIEWBOOKINGS.TabIndex = 14
        '
        'PanelCHANGEPASSWORD
        '
        Me.PanelCHANGEPASSWORD.BackColor = System.Drawing.Color.MintCream
        Me.PanelCHANGEPASSWORD.Location = New System.Drawing.Point(1, 210)
        Me.PanelCHANGEPASSWORD.Name = "PanelCHANGEPASSWORD"
        Me.PanelCHANGEPASSWORD.Size = New System.Drawing.Size(10, 48)
        Me.PanelCHANGEPASSWORD.TabIndex = 15
        '
        'BtnLOGOUT
        '
        Me.BtnLOGOUT.FlatAppearance.BorderSize = 0
        Me.BtnLOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLOGOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLOGOUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLOGOUT.Location = New System.Drawing.Point(687, 10)
        Me.BtnLOGOUT.Name = "BtnLOGOUT"
        Me.BtnLOGOUT.Size = New System.Drawing.Size(147, 43)
        Me.BtnLOGOUT.TabIndex = 0
        Me.BtnLOGOUT.Text = "Logout"
        Me.BtnLOGOUT.UseVisualStyleBackColor = True
        '
        'LabelWELCOME
        '
        Me.LabelWELCOME.AutoSize = True
        Me.LabelWELCOME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWELCOME.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelWELCOME.Location = New System.Drawing.Point(21, 20)
        Me.LabelWELCOME.Name = "LabelWELCOME"
        Me.LabelWELCOME.Size = New System.Drawing.Size(0, 25)
        Me.LabelWELCOME.TabIndex = 1
        '
        'VENUEOWNERdashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1044, 736)
        Me.Controls.Add(Me.PanelCHANGEPASSWORD)
        Me.Controls.Add(Me.PanelCHILD)
        Me.Controls.Add(Me.PanelHEAD)
        Me.Controls.Add(Me.PanelEDGE)
        Me.Name = "VENUEOWNERdashboard"
        Me.Text = "VENUEOWNERdashboard"
        Me.PanelEDGE.ResumeLayout(False)
        Me.PanelHEAD.ResumeLayout(False)
        Me.PanelHEAD.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEDGE As Panel
    Friend WithEvents PanelHEAD As Panel
    Friend WithEvents PanelCHILD As Panel
    Friend WithEvents PanelVIEWBOOKINGS As Panel
    Friend WithEvents BtnCHANGEPASSWORD As Button
    Friend WithEvents BtnVIEWBOOKINGS As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelWELCOME As Label
    Friend WithEvents BtnLOGOUT As Button
    Friend WithEvents PanelCHANGEPASSWORD As Panel
End Class

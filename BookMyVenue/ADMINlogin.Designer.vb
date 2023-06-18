<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMINlogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CboxSHOWPWD = New System.Windows.Forms.CheckBox()
        Me.TxtUSERNAME = New System.Windows.Forms.TextBox()
        Me.TxtPWD = New System.Windows.Forms.TextBox()
        Me.LabelPWD = New System.Windows.Forms.Label()
        Me.LabelUSERID = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelADMINLOGIN = New System.Windows.Forms.Label()
        Me.BtnLOGIN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Controls.Add(Me.CboxSHOWPWD)
        Me.Panel1.Controls.Add(Me.TxtUSERNAME)
        Me.Panel1.Controls.Add(Me.TxtPWD)
        Me.Panel1.Controls.Add(Me.LabelPWD)
        Me.Panel1.Controls.Add(Me.LabelUSERID)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(203, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 303)
        Me.Panel1.TabIndex = 0
        '
        'CboxSHOWPWD
        '
        Me.CboxSHOWPWD.AutoSize = True
        Me.CboxSHOWPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxSHOWPWD.Location = New System.Drawing.Point(267, 174)
        Me.CboxSHOWPWD.Name = "CboxSHOWPWD"
        Me.CboxSHOWPWD.Size = New System.Drawing.Size(149, 24)
        Me.CboxSHOWPWD.TabIndex = 5
        Me.CboxSHOWPWD.Text = "Show password"
        Me.CboxSHOWPWD.UseVisualStyleBackColor = True
        '
        'TxtUSERNAME
        '
        Me.TxtUSERNAME.Location = New System.Drawing.Point(208, 76)
        Me.TxtUSERNAME.Name = "TxtUSERNAME"
        Me.TxtUSERNAME.Size = New System.Drawing.Size(208, 34)
        Me.TxtUSERNAME.TabIndex = 4
        '
        'TxtPWD
        '
        Me.TxtPWD.Location = New System.Drawing.Point(208, 134)
        Me.TxtPWD.Name = "TxtPWD"
        Me.TxtPWD.Size = New System.Drawing.Size(208, 34)
        Me.TxtPWD.TabIndex = 3
        Me.TxtPWD.UseSystemPasswordChar = True
        '
        'LabelPWD
        '
        Me.LabelPWD.AutoSize = True
        Me.LabelPWD.Location = New System.Drawing.Point(52, 139)
        Me.LabelPWD.Name = "LabelPWD"
        Me.LabelPWD.Size = New System.Drawing.Size(120, 29)
        Me.LabelPWD.TabIndex = 2
        Me.LabelPWD.Text = "Password"
        '
        'LabelUSERID
        '
        Me.LabelUSERID.AutoSize = True
        Me.LabelUSERID.Location = New System.Drawing.Point(52, 81)
        Me.LabelUSERID.Name = "LabelUSERID"
        Me.LabelUSERID.Size = New System.Drawing.Size(124, 29)
        Me.LabelUSERID.TabIndex = 0
        Me.LabelUSERID.Text = "Username"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.Controls.Add(Me.LabelADMINLOGIN)
        Me.Panel2.Location = New System.Drawing.Point(236, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 87)
        Me.Panel2.TabIndex = 1
        '
        'LabelADMINLOGIN
        '
        Me.LabelADMINLOGIN.AutoSize = True
        Me.LabelADMINLOGIN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelADMINLOGIN.Location = New System.Drawing.Point(39, 21)
        Me.LabelADMINLOGIN.Name = "LabelADMINLOGIN"
        Me.LabelADMINLOGIN.Size = New System.Drawing.Size(318, 50)
        Me.LabelADMINLOGIN.TabIndex = 0
        Me.LabelADMINLOGIN.Text = "ADMIN LOGIN"
        '
        'BtnLOGIN
        '
        Me.BtnLOGIN.BackColor = System.Drawing.Color.Honeydew
        Me.BtnLOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLOGIN.Location = New System.Drawing.Point(320, 516)
        Me.BtnLOGIN.Name = "BtnLOGIN"
        Me.BtnLOGIN.Size = New System.Drawing.Size(261, 62)
        Me.BtnLOGIN.TabIndex = 2
        Me.BtnLOGIN.Text = "Login"
        Me.BtnLOGIN.UseVisualStyleBackColor = False
        '
        'ADMINlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BookMyVenue.My.Resources.Resources.Free_download_Pastel_Green_Aesthetic_Wallpaper_HD_768x480
        Me.ClientSize = New System.Drawing.Size(888, 632)
        Me.Controls.Add(Me.BtnLOGIN)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ADMINlogin"
        Me.Text = "ADMINlogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtUSERNAME As TextBox
    Friend WithEvents TxtPWD As TextBox
    Friend WithEvents LabelPWD As Label
    Friend WithEvents LabelUSERID As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelADMINLOGIN As Label
    Friend WithEvents BtnLOGIN As Button
    Friend WithEvents CboxSHOWPWD As CheckBox
End Class

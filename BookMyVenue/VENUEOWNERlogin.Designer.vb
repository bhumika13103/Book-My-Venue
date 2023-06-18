<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENUEOWNERlogin
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
        Me.Pboxballoon = New System.Windows.Forms.PictureBox()
        Me.LabelVENUEOWNERLOGIN = New System.Windows.Forms.Label()
        Me.PanelHEAD = New System.Windows.Forms.Panel()
        Me.PanelLOGIN = New System.Windows.Forms.Panel()
        Me.CboxSHOWPWD = New System.Windows.Forms.CheckBox()
        Me.LlabelFORGOTPWD = New System.Windows.Forms.LinkLabel()
        Me.TxtPWD = New System.Windows.Forms.TextBox()
        Me.TxtUSERID = New System.Windows.Forms.TextBox()
        Me.LabelPWD = New System.Windows.Forms.Label()
        Me.LabelUSERID = New System.Windows.Forms.Label()
        Me.BtnVENUELOGIN = New System.Windows.Forms.Button()
        CType(Me.Pboxballoon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHEAD.SuspendLayout()
        Me.PanelLOGIN.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pboxballoon
        '
        Me.Pboxballoon.Image = Global.BookMyVenue.My.Resources.Resources.bg1
        Me.Pboxballoon.Location = New System.Drawing.Point(5, 6)
        Me.Pboxballoon.Name = "Pboxballoon"
        Me.Pboxballoon.Size = New System.Drawing.Size(918, 590)
        Me.Pboxballoon.TabIndex = 0
        Me.Pboxballoon.TabStop = False
        '
        'LabelVENUEOWNERLOGIN
        '
        Me.LabelVENUEOWNERLOGIN.AutoSize = True
        Me.LabelVENUEOWNERLOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVENUEOWNERLOGIN.Location = New System.Drawing.Point(17, 20)
        Me.LabelVENUEOWNERLOGIN.Name = "LabelVENUEOWNERLOGIN"
        Me.LabelVENUEOWNERLOGIN.Size = New System.Drawing.Size(360, 36)
        Me.LabelVENUEOWNERLOGIN.TabIndex = 1
        Me.LabelVENUEOWNERLOGIN.Text = "VENUE OWNER LOGIN"
        '
        'PanelHEAD
        '
        Me.PanelHEAD.Controls.Add(Me.LabelVENUEOWNERLOGIN)
        Me.PanelHEAD.Location = New System.Drawing.Point(269, 65)
        Me.PanelHEAD.Name = "PanelHEAD"
        Me.PanelHEAD.Size = New System.Drawing.Size(401, 69)
        Me.PanelHEAD.TabIndex = 2
        '
        'PanelLOGIN
        '
        Me.PanelLOGIN.Controls.Add(Me.CboxSHOWPWD)
        Me.PanelLOGIN.Controls.Add(Me.LlabelFORGOTPWD)
        Me.PanelLOGIN.Controls.Add(Me.TxtPWD)
        Me.PanelLOGIN.Controls.Add(Me.TxtUSERID)
        Me.PanelLOGIN.Controls.Add(Me.LabelPWD)
        Me.PanelLOGIN.Controls.Add(Me.LabelUSERID)
        Me.PanelLOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelLOGIN.Location = New System.Drawing.Point(243, 170)
        Me.PanelLOGIN.Name = "PanelLOGIN"
        Me.PanelLOGIN.Size = New System.Drawing.Size(448, 268)
        Me.PanelLOGIN.TabIndex = 3
        '
        'CboxSHOWPWD
        '
        Me.CboxSHOWPWD.AutoSize = True
        Me.CboxSHOWPWD.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CboxSHOWPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxSHOWPWD.Location = New System.Drawing.Point(240, 158)
        Me.CboxSHOWPWD.Name = "CboxSHOWPWD"
        Me.CboxSHOWPWD.Size = New System.Drawing.Size(137, 22)
        Me.CboxSHOWPWD.TabIndex = 5
        Me.CboxSHOWPWD.Text = "Show password"
        Me.CboxSHOWPWD.UseVisualStyleBackColor = False
        '
        'LlabelFORGOTPWD
        '
        Me.LlabelFORGOTPWD.AutoSize = True
        Me.LlabelFORGOTPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlabelFORGOTPWD.Location = New System.Drawing.Point(147, 221)
        Me.LlabelFORGOTPWD.Name = "LlabelFORGOTPWD"
        Me.LlabelFORGOTPWD.Size = New System.Drawing.Size(131, 18)
        Me.LlabelFORGOTPWD.TabIndex = 4
        Me.LlabelFORGOTPWD.TabStop = True
        Me.LlabelFORGOTPWD.Text = "Forgot Password?"
        '
        'TxtPWD
        '
        Me.TxtPWD.Location = New System.Drawing.Point(194, 122)
        Me.TxtPWD.Name = "TxtPWD"
        Me.TxtPWD.Size = New System.Drawing.Size(183, 30)
        Me.TxtPWD.TabIndex = 3
        '
        'TxtUSERID
        '
        Me.TxtUSERID.Location = New System.Drawing.Point(194, 68)
        Me.TxtUSERID.Name = "TxtUSERID"
        Me.TxtUSERID.Size = New System.Drawing.Size(183, 30)
        Me.TxtUSERID.TabIndex = 2
        '
        'LabelPWD
        '
        Me.LabelPWD.AutoSize = True
        Me.LabelPWD.Location = New System.Drawing.Point(67, 127)
        Me.LabelPWD.Name = "LabelPWD"
        Me.LabelPWD.Size = New System.Drawing.Size(98, 25)
        Me.LabelPWD.TabIndex = 1
        Me.LabelPWD.Text = "Password"
        '
        'LabelUSERID
        '
        Me.LabelUSERID.AutoSize = True
        Me.LabelUSERID.Location = New System.Drawing.Point(67, 73)
        Me.LabelUSERID.Name = "LabelUSERID"
        Me.LabelUSERID.Size = New System.Drawing.Size(77, 25)
        Me.LabelUSERID.TabIndex = 0
        Me.LabelUSERID.Text = "User ID"
        '
        'BtnVENUELOGIN
        '
        Me.BtnVENUELOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVENUELOGIN.Location = New System.Drawing.Point(335, 482)
        Me.BtnVENUELOGIN.Name = "BtnVENUELOGIN"
        Me.BtnVENUELOGIN.Size = New System.Drawing.Size(250, 61)
        Me.BtnVENUELOGIN.TabIndex = 4
        Me.BtnVENUELOGIN.Text = "Login"
        Me.BtnVENUELOGIN.UseVisualStyleBackColor = True
        '
        'VENUEOWNERlogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(929, 602)
        Me.Controls.Add(Me.BtnVENUELOGIN)
        Me.Controls.Add(Me.PanelLOGIN)
        Me.Controls.Add(Me.PanelHEAD)
        Me.Controls.Add(Me.Pboxballoon)
        Me.Name = "VENUEOWNERlogin"
        Me.Text = "VENUEOWNERlogin"
        CType(Me.Pboxballoon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHEAD.ResumeLayout(False)
        Me.PanelHEAD.PerformLayout()
        Me.PanelLOGIN.ResumeLayout(False)
        Me.PanelLOGIN.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pboxballoon As PictureBox
    Friend WithEvents LabelVENUEOWNERLOGIN As Label
    Friend WithEvents PanelHEAD As Panel
    Friend WithEvents PanelLOGIN As Panel
    Friend WithEvents BtnVENUELOGIN As Button
    Friend WithEvents CboxSHOWPWD As CheckBox
    Friend WithEvents LlabelFORGOTPWD As LinkLabel
    Friend WithEvents TxtPWD As TextBox
    Friend WithEvents TxtUSERID As TextBox
    Friend WithEvents LabelPWD As Label
    Friend WithEvents LabelUSERID As Label
End Class

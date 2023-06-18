<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CUSTOMERlogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CboxShowpwd = New System.Windows.Forms.CheckBox()
        Me.Llabforgot = New System.Windows.Forms.LinkLabel()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.TxtuserID = New System.Windows.Forms.TextBox()
        Me.Labpas = New System.Windows.Forms.Label()
        Me.LabuserID = New System.Windows.Forms.Label()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.Labcus = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CboxShowpwd)
        Me.Panel1.Controls.Add(Me.Llabforgot)
        Me.Panel1.Controls.Add(Me.Txtpass)
        Me.Panel1.Controls.Add(Me.TxtuserID)
        Me.Panel1.Controls.Add(Me.Labpas)
        Me.Panel1.Controls.Add(Me.LabuserID)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(222, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 254)
        Me.Panel1.TabIndex = 0
        '
        'CboxShowpwd
        '
        Me.CboxShowpwd.AutoSize = True
        Me.CboxShowpwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CboxShowpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxShowpwd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CboxShowpwd.Location = New System.Drawing.Point(279, 154)
        Me.CboxShowpwd.Name = "CboxShowpwd"
        Me.CboxShowpwd.Size = New System.Drawing.Size(149, 24)
        Me.CboxShowpwd.TabIndex = 7
        Me.CboxShowpwd.Text = "Show password"
        Me.CboxShowpwd.UseVisualStyleBackColor = True
        '
        'Llabforgot
        '
        Me.Llabforgot.AutoSize = True
        Me.Llabforgot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llabforgot.Location = New System.Drawing.Point(167, 203)
        Me.Llabforgot.Name = "Llabforgot"
        Me.Llabforgot.Size = New System.Drawing.Size(145, 20)
        Me.Llabforgot.TabIndex = 6
        Me.Llabforgot.TabStop = True
        Me.Llabforgot.Text = "Forgot Password?"
        '
        'Txtpass
        '
        Me.Txtpass.Location = New System.Drawing.Point(181, 118)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.Size = New System.Drawing.Size(247, 30)
        Me.Txtpass.TabIndex = 4
        Me.Txtpass.UseSystemPasswordChar = True
        '
        'TxtuserID
        '
        Me.TxtuserID.Location = New System.Drawing.Point(181, 64)
        Me.TxtuserID.Name = "TxtuserID"
        Me.TxtuserID.Size = New System.Drawing.Size(247, 30)
        Me.TxtuserID.TabIndex = 3
        '
        'Labpas
        '
        Me.Labpas.AutoSize = True
        Me.Labpas.Location = New System.Drawing.Point(55, 121)
        Me.Labpas.Name = "Labpas"
        Me.Labpas.Size = New System.Drawing.Size(98, 25)
        Me.Labpas.TabIndex = 2
        Me.Labpas.Text = "Password"
        '
        'LabuserID
        '
        Me.LabuserID.AutoSize = True
        Me.LabuserID.Location = New System.Drawing.Point(55, 67)
        Me.LabuserID.Name = "LabuserID"
        Me.LabuserID.Size = New System.Drawing.Size(77, 25)
        Me.LabuserID.TabIndex = 1
        Me.LabuserID.Text = "User ID"
        '
        'Btnlogin
        '
        Me.Btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogin.Location = New System.Drawing.Point(328, 463)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(290, 63)
        Me.Btnlogin.TabIndex = 5
        Me.Btnlogin.Text = "Login"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'Labcus
        '
        Me.Labcus.AutoSize = True
        Me.Labcus.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labcus.Location = New System.Drawing.Point(43, 11)
        Me.Labcus.Name = "Labcus"
        Me.Labcus.Size = New System.Drawing.Size(331, 38)
        Me.Labcus.TabIndex = 0
        Me.Labcus.Text = "CUSTOMER LOGIN"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Labcus)
        Me.Panel2.Location = New System.Drawing.Point(256, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 60)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BookMyVenue.My.Resources.Resources.bgg2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(905, 585)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'CUSTOMERlogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(929, 602)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CUSTOMERlogin"
        Me.Text = "Customer Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Llabforgot As LinkLabel
    Friend WithEvents Btnlogin As Button
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents TxtuserID As TextBox
    Friend WithEvents Labpas As Label
    Friend WithEvents LabuserID As Label
    Friend WithEvents Labcus As Label
    Friend WithEvents CustomerDETAILSTableAdapter1 As BookMyVenue.BookMyVenueDataSetTableAdapters.CustomerDETAILSTableAdapter
    Friend WithEvents BookMyVenueDataSet1 As BookMyVenue.BookMyVenueDataSet
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CboxShowpwd As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

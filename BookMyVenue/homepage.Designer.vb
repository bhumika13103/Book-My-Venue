<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homepage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnLOGIN = New System.Windows.Forms.Button()
        Me.BtnREGISTER = New System.Windows.Forms.Button()
        Me.BtnADMIN = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.BtnLOGIN)
        Me.Panel1.Controls.Add(Me.BtnREGISTER)
        Me.Panel1.Controls.Add(Me.BtnADMIN)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 80)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.BookMyVenue.My.Resources.Resources.croplogo
        Me.PictureBox2.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(164, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'BtnLOGIN
        '
        Me.BtnLOGIN.FlatAppearance.BorderSize = 0
        Me.BtnLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLOGIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLOGIN.Location = New System.Drawing.Point(710, 24)
        Me.BtnLOGIN.Name = "BtnLOGIN"
        Me.BtnLOGIN.Size = New System.Drawing.Size(113, 40)
        Me.BtnLOGIN.TabIndex = 2
        Me.BtnLOGIN.Text = "Login"
        Me.BtnLOGIN.UseVisualStyleBackColor = True
        '
        'BtnREGISTER
        '
        Me.BtnREGISTER.FlatAppearance.BorderSize = 0
        Me.BtnREGISTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnREGISTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnREGISTER.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnREGISTER.Location = New System.Drawing.Point(591, 24)
        Me.BtnREGISTER.Name = "BtnREGISTER"
        Me.BtnREGISTER.Size = New System.Drawing.Size(113, 40)
        Me.BtnREGISTER.TabIndex = 1
        Me.BtnREGISTER.Text = "Register"
        Me.BtnREGISTER.UseVisualStyleBackColor = True
        '
        'BtnADMIN
        '
        Me.BtnADMIN.FlatAppearance.BorderSize = 0
        Me.BtnADMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnADMIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnADMIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnADMIN.Location = New System.Drawing.Point(829, 24)
        Me.BtnADMIN.Name = "BtnADMIN"
        Me.BtnADMIN.Size = New System.Drawing.Size(113, 40)
        Me.BtnADMIN.TabIndex = 0
        Me.BtnADMIN.Text = "Admin"
        Me.BtnADMIN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.BookMyVenue.My.Resources.Resources.homepage3
        Me.PictureBox1.Location = New System.Drawing.Point(38, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(870, 534)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(954, 648)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "homepage"
        Me.Text = "homepage"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLOGIN As Button
    Friend WithEvents BtnREGISTER As Button
    Friend WithEvents BtnADMIN As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class

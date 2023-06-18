<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRATION
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
        Me.LabelWHOAREYOU = New System.Windows.Forms.Label()
        Me.BtnCUSTOMER = New System.Windows.Forms.Button()
        Me.BtnVENUEOWNER = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelWHOAREYOU
        '
        Me.LabelWHOAREYOU.AutoSize = True
        Me.LabelWHOAREYOU.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWHOAREYOU.Location = New System.Drawing.Point(24, 22)
        Me.LabelWHOAREYOU.Name = "LabelWHOAREYOU"
        Me.LabelWHOAREYOU.Size = New System.Drawing.Size(314, 47)
        Me.LabelWHOAREYOU.TabIndex = 0
        Me.LabelWHOAREYOU.Text = "WHO ARE YOU?"
        '
        'BtnCUSTOMER
        '
        Me.BtnCUSTOMER.AutoSize = True
        Me.BtnCUSTOMER.BackColor = System.Drawing.Color.Honeydew
        Me.BtnCUSTOMER.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.BtnCUSTOMER.FlatAppearance.BorderSize = 5
        Me.BtnCUSTOMER.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCUSTOMER.Location = New System.Drawing.Point(348, 277)
        Me.BtnCUSTOMER.Name = "BtnCUSTOMER"
        Me.BtnCUSTOMER.Size = New System.Drawing.Size(270, 63)
        Me.BtnCUSTOMER.TabIndex = 1
        Me.BtnCUSTOMER.Text = "Customer"
        Me.BtnCUSTOMER.UseVisualStyleBackColor = False
        '
        'BtnVENUEOWNER
        '
        Me.BtnVENUEOWNER.BackColor = System.Drawing.Color.Honeydew
        Me.BtnVENUEOWNER.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVENUEOWNER.Location = New System.Drawing.Point(348, 366)
        Me.BtnVENUEOWNER.Name = "BtnVENUEOWNER"
        Me.BtnVENUEOWNER.Size = New System.Drawing.Size(270, 63)
        Me.BtnVENUEOWNER.TabIndex = 2
        Me.BtnVENUEOWNER.Text = "Venue Owner"
        Me.BtnVENUEOWNER.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.BookMyVenue.My.Resources.Resources.Free_download_Pastel_Green_Aesthetic_Wallpaper_HD_768x480
        Me.PictureBox1.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(937, 640)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.LabelWHOAREYOU)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(301, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 87)
        Me.Panel1.TabIndex = 4
        '
        'REGISTRATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(955, 654)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnVENUEOWNER)
        Me.Controls.Add(Me.BtnCUSTOMER)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "REGISTRATION"
        Me.Text = "REGISTRATION"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelWHOAREYOU As Label
    Friend WithEvents BtnCUSTOMER As Button
    Friend WithEvents BtnVENUEOWNER As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCUSTOMER = New System.Windows.Forms.Button()
        Me.BtnVENUEOWNER = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(53, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN AS:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(304, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 74)
        Me.Panel1.TabIndex = 1
        '
        'BtnCUSTOMER
        '
        Me.BtnCUSTOMER.AutoSize = True
        Me.BtnCUSTOMER.BackColor = System.Drawing.Color.Honeydew
        Me.BtnCUSTOMER.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.BtnCUSTOMER.FlatAppearance.BorderSize = 5
        Me.BtnCUSTOMER.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCUSTOMER.Location = New System.Drawing.Point(324, 265)
        Me.BtnCUSTOMER.Name = "BtnCUSTOMER"
        Me.BtnCUSTOMER.Size = New System.Drawing.Size(270, 63)
        Me.BtnCUSTOMER.TabIndex = 2
        Me.BtnCUSTOMER.Text = "Customer"
        Me.BtnCUSTOMER.UseVisualStyleBackColor = False
        '
        'BtnVENUEOWNER
        '
        Me.BtnVENUEOWNER.BackColor = System.Drawing.Color.Honeydew
        Me.BtnVENUEOWNER.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVENUEOWNER.Location = New System.Drawing.Point(324, 387)
        Me.BtnVENUEOWNER.Name = "BtnVENUEOWNER"
        Me.BtnVENUEOWNER.Size = New System.Drawing.Size(270, 63)
        Me.BtnVENUEOWNER.TabIndex = 3
        Me.BtnVENUEOWNER.Text = "Venue Owner"
        Me.BtnVENUEOWNER.UseVisualStyleBackColor = False
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BookMyVenue.My.Resources.Resources.Free_download_Pastel_Green_Aesthetic_Wallpaper_HD_768x480
        Me.ClientSize = New System.Drawing.Size(919, 593)
        Me.Controls.Add(Me.BtnVENUEOWNER)
        Me.Controls.Add(Me.BtnCUSTOMER)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LOGIN"
        Me.Text = "LOGIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCUSTOMER As Button
    Friend WithEvents BtnVENUEOWNER As Button
End Class

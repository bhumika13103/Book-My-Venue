<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class childEDITVENUESADMIN
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
        Me.DgvEDITVENUE = New System.Windows.Forms.DataGridView()
        Me.BtnSAVECHANGES = New System.Windows.Forms.Button()
        Me.BtnEXIT = New System.Windows.Forms.Button()
        CType(Me.DgvEDITVENUE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvEDITVENUE
        '
        Me.DgvEDITVENUE.AllowUserToAddRows = False
        Me.DgvEDITVENUE.AllowUserToDeleteRows = False
        Me.DgvEDITVENUE.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.DgvEDITVENUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEDITVENUE.Location = New System.Drawing.Point(43, 66)
        Me.DgvEDITVENUE.Name = "DgvEDITVENUE"
        Me.DgvEDITVENUE.RowTemplate.Height = 24
        Me.DgvEDITVENUE.Size = New System.Drawing.Size(940, 484)
        Me.DgvEDITVENUE.TabIndex = 0
        '
        'BtnSAVECHANGES
        '
        Me.BtnSAVECHANGES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSAVECHANGES.Location = New System.Drawing.Point(257, 587)
        Me.BtnSAVECHANGES.Name = "BtnSAVECHANGES"
        Me.BtnSAVECHANGES.Size = New System.Drawing.Size(193, 53)
        Me.BtnSAVECHANGES.TabIndex = 1
        Me.BtnSAVECHANGES.Text = "Save Changes"
        Me.BtnSAVECHANGES.UseVisualStyleBackColor = True
        '
        'BtnEXIT
        '
        Me.BtnEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEXIT.Location = New System.Drawing.Point(597, 587)
        Me.BtnEXIT.Name = "BtnEXIT"
        Me.BtnEXIT.Size = New System.Drawing.Size(185, 53)
        Me.BtnEXIT.TabIndex = 3
        Me.BtnEXIT.Text = "Exit"
        Me.BtnEXIT.UseVisualStyleBackColor = True
        '
        'childEDITVENUESADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 675)
        Me.Controls.Add(Me.BtnEXIT)
        Me.Controls.Add(Me.BtnSAVECHANGES)
        Me.Controls.Add(Me.DgvEDITVENUE)
        Me.Name = "childEDITVENUESADMIN"
        Me.Text = "childEDITVENUESADMIN"
        CType(Me.DgvEDITVENUE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvEDITVENUE As DataGridView
    Friend WithEvents BtnSAVECHANGES As Button
    Friend WithEvents BtnEXIT As Button
End Class

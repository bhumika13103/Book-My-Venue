<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class childVIEWVENUESADMIN
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
        Me.BtnSHOW = New System.Windows.Forms.Button()
        Me.BtnEXIT = New System.Windows.Forms.Button()
        Me.DgvVIEWVENUES = New System.Windows.Forms.DataGridView()
        CType(Me.DgvVIEWVENUES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSHOW
        '
        Me.BtnSHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSHOW.Location = New System.Drawing.Point(240, 607)
        Me.BtnSHOW.Name = "BtnSHOW"
        Me.BtnSHOW.Size = New System.Drawing.Size(211, 53)
        Me.BtnSHOW.TabIndex = 1
        Me.BtnSHOW.Text = "Show"
        Me.BtnSHOW.UseVisualStyleBackColor = True
        '
        'BtnEXIT
        '
        Me.BtnEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEXIT.Location = New System.Drawing.Point(568, 606)
        Me.BtnEXIT.Name = "BtnEXIT"
        Me.BtnEXIT.Size = New System.Drawing.Size(211, 53)
        Me.BtnEXIT.TabIndex = 2
        Me.BtnEXIT.Text = "Exit"
        Me.BtnEXIT.UseVisualStyleBackColor = True
        '
        'DgvVIEWVENUES
        '
        Me.DgvVIEWVENUES.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.DgvVIEWVENUES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVIEWVENUES.Location = New System.Drawing.Point(53, 52)
        Me.DgvVIEWVENUES.Name = "DgvVIEWVENUES"
        Me.DgvVIEWVENUES.RowTemplate.Height = 24
        Me.DgvVIEWVENUES.Size = New System.Drawing.Size(916, 460)
        Me.DgvVIEWVENUES.TabIndex = 0
        '
        'childVIEWVENUESADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 736)
        Me.Controls.Add(Me.BtnEXIT)
        Me.Controls.Add(Me.BtnSHOW)
        Me.Controls.Add(Me.DgvVIEWVENUES)
        Me.Name = "childVIEWVENUESADMIN"
        Me.Text = " "
        CType(Me.DgvVIEWVENUES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSHOW As Button
    Friend WithEvents BtnEXIT As Button
    Friend WithEvents DgvVIEWVENUES As DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class childVIEWBOOKINGSvenue
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
        Me.DgvVIEWVENUEBOOKINGS = New System.Windows.Forms.DataGridView()
        Me.BtnCLOSE = New System.Windows.Forms.Button()
        CType(Me.DgvVIEWVENUEBOOKINGS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvVIEWVENUEBOOKINGS
        '
        Me.DgvVIEWVENUEBOOKINGS.BackgroundColor = System.Drawing.Color.Honeydew
        Me.DgvVIEWVENUEBOOKINGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVIEWVENUEBOOKINGS.Location = New System.Drawing.Point(26, 25)
        Me.DgvVIEWVENUEBOOKINGS.Name = "DgvVIEWVENUEBOOKINGS"
        Me.DgvVIEWVENUEBOOKINGS.RowTemplate.Height = 24
        Me.DgvVIEWVENUEBOOKINGS.Size = New System.Drawing.Size(773, 494)
        Me.DgvVIEWVENUEBOOKINGS.TabIndex = 0
        '
        'BtnCLOSE
        '
        Me.BtnCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCLOSE.Location = New System.Drawing.Point(313, 552)
        Me.BtnCLOSE.Name = "BtnCLOSE"
        Me.BtnCLOSE.Size = New System.Drawing.Size(212, 48)
        Me.BtnCLOSE.TabIndex = 1
        Me.BtnCLOSE.Text = "Close"
        Me.BtnCLOSE.UseVisualStyleBackColor = True
        '
        'childVIEWBOOKINGSvenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(827, 626)
        Me.Controls.Add(Me.BtnCLOSE)
        Me.Controls.Add(Me.DgvVIEWVENUEBOOKINGS)
        Me.Name = "childVIEWBOOKINGSvenue"
        Me.Text = "childVIEWBOOKINGSvenue"
        CType(Me.DgvVIEWVENUEBOOKINGS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvVIEWVENUEBOOKINGS As DataGridView
    Friend WithEvents BtnCLOSE As Button
End Class

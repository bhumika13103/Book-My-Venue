<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChildVIEWBOOKINGSADMINvb
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
        Me.DgvVIEWBOOKINGS = New System.Windows.Forms.DataGridView()
        Me.BtnSHOW = New System.Windows.Forms.Button()
        Me.BtnEXIT = New System.Windows.Forms.Button()
        CType(Me.DgvVIEWBOOKINGS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvVIEWBOOKINGS
        '
        Me.DgvVIEWBOOKINGS.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.DgvVIEWBOOKINGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVIEWBOOKINGS.Location = New System.Drawing.Point(39, 47)
        Me.DgvVIEWBOOKINGS.Name = "DgvVIEWBOOKINGS"
        Me.DgvVIEWBOOKINGS.RowTemplate.Height = 24
        Me.DgvVIEWBOOKINGS.Size = New System.Drawing.Size(940, 484)
        Me.DgvVIEWBOOKINGS.TabIndex = 0
        '
        'BtnSHOW
        '
        Me.BtnSHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSHOW.Location = New System.Drawing.Point(251, 596)
        Me.BtnSHOW.Name = "BtnSHOW"
        Me.BtnSHOW.Size = New System.Drawing.Size(224, 51)
        Me.BtnSHOW.TabIndex = 1
        Me.BtnSHOW.Text = "Show"
        Me.BtnSHOW.UseVisualStyleBackColor = True
        '
        'BtnEXIT
        '
        Me.BtnEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEXIT.Location = New System.Drawing.Point(586, 596)
        Me.BtnEXIT.Name = "BtnEXIT"
        Me.BtnEXIT.Size = New System.Drawing.Size(208, 51)
        Me.BtnEXIT.TabIndex = 2
        Me.BtnEXIT.Text = "Exit"
        Me.BtnEXIT.UseVisualStyleBackColor = True
        '
        'ChildVIEWBOOKINGSADMINvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1044, 736)
        Me.Controls.Add(Me.BtnEXIT)
        Me.Controls.Add(Me.BtnSHOW)
        Me.Controls.Add(Me.DgvVIEWBOOKINGS)
        Me.Name = "ChildVIEWBOOKINGSADMINvb"
        Me.Text = "ChildVIEWBOOKINGSADMINvb"
        CType(Me.DgvVIEWBOOKINGS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvVIEWBOOKINGS As DataGridView
    Friend WithEvents BtnSHOW As Button
    Friend WithEvents BtnEXIT As Button
End Class

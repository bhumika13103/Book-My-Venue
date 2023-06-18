<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildEDITBOOKINGSADMIN
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvEDITBOOKINGS = New System.Windows.Forms.DataGridView()
        Me.BtnSAVECHANGES = New System.Windows.Forms.Button()
        Me.BtnEXIT = New System.Windows.Forms.Button()
        CType(Me.DgvEDITBOOKINGS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvEDITBOOKINGS
        '
        Me.DgvEDITBOOKINGS.AllowUserToAddRows = False
        Me.DgvEDITBOOKINGS.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEDITBOOKINGS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvEDITBOOKINGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvEDITBOOKINGS.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvEDITBOOKINGS.Location = New System.Drawing.Point(12, 12)
        Me.DgvEDITBOOKINGS.Name = "DgvEDITBOOKINGS"
        Me.DgvEDITBOOKINGS.RowTemplate.Height = 24
        Me.DgvEDITBOOKINGS.Size = New System.Drawing.Size(751, 432)
        Me.DgvEDITBOOKINGS.TabIndex = 0
        '
        'BtnSAVECHANGES
        '
        Me.BtnSAVECHANGES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSAVECHANGES.Location = New System.Drawing.Point(148, 466)
        Me.BtnSAVECHANGES.Name = "BtnSAVECHANGES"
        Me.BtnSAVECHANGES.Size = New System.Drawing.Size(173, 50)
        Me.BtnSAVECHANGES.TabIndex = 1
        Me.BtnSAVECHANGES.Text = "Save Changes"
        Me.BtnSAVECHANGES.UseVisualStyleBackColor = True
        '
        'BtnEXIT
        '
        Me.BtnEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnEXIT.Location = New System.Drawing.Point(426, 466)
        Me.BtnEXIT.Name = "BtnEXIT"
        Me.BtnEXIT.Size = New System.Drawing.Size(173, 50)
        Me.BtnEXIT.TabIndex = 3
        Me.BtnEXIT.Text = "Exit"
        Me.BtnEXIT.UseVisualStyleBackColor = True
        '
        'ChildEDITBOOKINGSADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 541)
        Me.Controls.Add(Me.BtnEXIT)
        Me.Controls.Add(Me.BtnSAVECHANGES)
        Me.Controls.Add(Me.DgvEDITBOOKINGS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ChildEDITBOOKINGSADMIN"
        Me.Text = "ChildEDITBOOKINGSADMIN"
        CType(Me.DgvEDITBOOKINGS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvEDITBOOKINGS As DataGridView
    Friend WithEvents BtnSAVECHANGES As Button
    Friend WithEvents BtnEXIT As Button
End Class

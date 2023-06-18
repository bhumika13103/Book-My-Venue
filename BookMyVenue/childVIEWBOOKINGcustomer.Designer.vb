<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class childVIEWBOOKINGcustomer
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
        Me.DgvCUSTBOOKING = New System.Windows.Forms.DataGridView()
        Me.BtnEXIT = New System.Windows.Forms.Button()
        CType(Me.DgvCUSTBOOKING, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCUSTBOOKING
        '
        Me.DgvCUSTBOOKING.BackgroundColor = System.Drawing.Color.Moccasin
        Me.DgvCUSTBOOKING.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCUSTBOOKING.GridColor = System.Drawing.Color.SandyBrown
        Me.DgvCUSTBOOKING.Location = New System.Drawing.Point(24, 21)
        Me.DgvCUSTBOOKING.Name = "DgvCUSTBOOKING"
        Me.DgvCUSTBOOKING.RowTemplate.Height = 24
        Me.DgvCUSTBOOKING.Size = New System.Drawing.Size(775, 480)
        Me.DgvCUSTBOOKING.TabIndex = 0
        '
        'BtnEXIT
        '
        Me.BtnEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEXIT.Location = New System.Drawing.Point(283, 527)
        Me.BtnEXIT.Name = "BtnEXIT"
        Me.BtnEXIT.Size = New System.Drawing.Size(231, 54)
        Me.BtnEXIT.TabIndex = 1
        Me.BtnEXIT.Text = "Exit"
        Me.BtnEXIT.UseVisualStyleBackColor = True
        '
        'childVIEWBOOKINGcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(824, 607)
        Me.Controls.Add(Me.BtnEXIT)
        Me.Controls.Add(Me.DgvCUSTBOOKING)
        Me.Name = "childVIEWBOOKINGcustomer"
        Me.Text = "childVIEWBOOKINGcustomer"
        CType(Me.DgvCUSTBOOKING, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvCUSTBOOKING As DataGridView
    Friend WithEvents BtnEXIT As Button
End Class

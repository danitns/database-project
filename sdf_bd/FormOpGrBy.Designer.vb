<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOpGrBy
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewGrBy = New System.Windows.Forms.DataGridView()
        Me.IdSala = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalMediu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewGrBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 120)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 20.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(816, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SALARIUL MEDIU AL ANTRENORILOR PENTRU " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FIECARE SALA DIN SECTORUL 6"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DataGridViewGrBy)
        Me.Panel2.Location = New System.Drawing.Point(61, 170)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 511)
        Me.Panel2.TabIndex = 3
        '
        'DataGridViewGrBy
        '
        Me.DataGridViewGrBy.AllowUserToAddRows = False
        Me.DataGridViewGrBy.AllowUserToDeleteRows = False
        Me.DataGridViewGrBy.AllowUserToOrderColumns = True
        Me.DataGridViewGrBy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewGrBy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewGrBy.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewGrBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewGrBy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSala, Me.SalMediu})
        Me.DataGridViewGrBy.Location = New System.Drawing.Point(25, 40)
        Me.DataGridViewGrBy.Name = "DataGridViewGrBy"
        Me.DataGridViewGrBy.ReadOnly = True
        Me.DataGridViewGrBy.RowHeadersWidth = 51
        Me.DataGridViewGrBy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewGrBy.RowTemplate.Height = 24
        Me.DataGridViewGrBy.ShowEditingIcon = False
        Me.DataGridViewGrBy.Size = New System.Drawing.Size(834, 440)
        Me.DataGridViewGrBy.TabIndex = 0
        '
        'IdSala
        '
        Me.IdSala.DataPropertyName = "ID_SALA"
        Me.IdSala.HeaderText = "ID Sala"
        Me.IdSala.MinimumWidth = 6
        Me.IdSala.Name = "IdSala"
        Me.IdSala.ReadOnly = True
        '
        'SalMediu
        '
        Me.SalMediu.DataPropertyName = "SalMediu"
        Me.SalMediu.HeaderText = "Salariu Mediu"
        Me.SalMediu.MinimumWidth = 6
        Me.SalMediu.Name = "SalMediu"
        Me.SalMediu.ReadOnly = True
        '
        'FormOpGrBy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormOpGrBy"
        Me.Text = "FormOpGrBy"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewGrBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewGrBy As DataGridView
    Friend WithEvents IdSala As DataGridViewTextBoxColumn
    Friend WithEvents SalMediu As DataGridViewTextBoxColumn
End Class

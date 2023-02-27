<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAntrenor
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxIdSala = New System.Windows.Forms.ComboBox()
        Me.SALABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNume = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NumericUpDownSalariu = New System.Windows.Forms.NumericUpDown()
        Me.btnSalveaza = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrenume = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SALATableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.SALATableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.SALABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDownSalariu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(674, 120)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(125, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adauga un camp nou"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBoxIdSala
        '
        Me.ComboBoxIdSala.DataSource = Me.SALABindingSource
        Me.ComboBoxIdSala.DisplayMember = "ID_SALA"
        Me.ComboBoxIdSala.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.ComboBoxIdSala.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ComboBoxIdSala.FormattingEnabled = True
        Me.ComboBoxIdSala.Location = New System.Drawing.Point(77, 91)
        Me.ComboBoxIdSala.Name = "ComboBoxIdSala"
        Me.ComboBoxIdSala.Size = New System.Drawing.Size(469, 30)
        Me.ComboBoxIdSala.TabIndex = 11
        Me.ComboBoxIdSala.ValueMember = "ID_SALA"
        '
        'SALABindingSource
        '
        Me.SALABindingSource.DataMember = "SALA"
        Me.SALABindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
        '
        'SALA_DE_FITNESSDataSet
        '
        Me.SALA_DE_FITNESSDataSet.DataSetName = "SALA_DE_FITNESSDataSet"
        Me.SALA_DE_FITNESSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(77, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 22)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ID Sala:"
        '
        'txtNume
        '
        Me.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNume.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.txtNume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtNume.Location = New System.Drawing.Point(77, 203)
        Me.txtNume.Name = "txtNume"
        Me.txtNume.Size = New System.Drawing.Size(469, 28)
        Me.txtNume.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(77, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nume:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.NumericUpDownSalariu)
        Me.Panel2.Controls.Add(Me.ComboBoxIdSala)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnSalveaza)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtPrenume)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtNume)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(29, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(620, 628)
        Me.Panel2.TabIndex = 3
        '
        'NumericUpDownSalariu
        '
        Me.NumericUpDownSalariu.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.NumericUpDownSalariu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.NumericUpDownSalariu.Location = New System.Drawing.Point(77, 423)
        Me.NumericUpDownSalariu.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDownSalariu.Name = "NumericUpDownSalariu"
        Me.NumericUpDownSalariu.Size = New System.Drawing.Size(469, 28)
        Me.NumericUpDownSalariu.TabIndex = 12
        '
        'btnSalveaza
        '
        Me.btnSalveaza.BackColor = System.Drawing.Color.White
        Me.btnSalveaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalveaza.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.btnSalveaza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnSalveaza.Location = New System.Drawing.Point(252, 547)
        Me.btnSalveaza.Name = "btnSalveaza"
        Me.btnSalveaza.Size = New System.Drawing.Size(114, 48)
        Me.btnSalveaza.TabIndex = 0
        Me.btnSalveaza.Text = "Salveaza"
        Me.btnSalveaza.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(77, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Salariu:"
        '
        'txtPrenume
        '
        Me.txtPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrenume.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.txtPrenume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtPrenume.Location = New System.Drawing.Point(77, 313)
        Me.txtPrenume.Name = "txtPrenume"
        Me.txtPrenume.Size = New System.Drawing.Size(469, 28)
        Me.txtPrenume.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(77, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Prenume:"
        '
        'SALATableAdapter
        '
        Me.SALATableAdapter.ClearBeforeFill = True
        '
        'AddAntrenor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 794)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddAntrenor"
        Me.Text = "AddAntrenor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SALABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDownSalariu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxIdSala As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNume As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NumericUpDownSalariu As NumericUpDown
    Friend WithEvents btnSalveaza As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrenume As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents SALABindingSource As BindingSource
    Friend WithEvents SALATableAdapter As SALA_DE_FITNESSDataSetTableAdapters.SALATableAdapter
End Class

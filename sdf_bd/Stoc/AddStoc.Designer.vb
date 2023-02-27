<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStoc
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxSala = New System.Windows.Forms.ComboBox()
        Me.SALABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.ComboBoxSup = New System.Windows.Forms.ComboBox()
        Me.SUPLIMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalveaza = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SUPLIMENTTableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.SUPLIMENTTableAdapter()
        Me.SALATableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.SALATableAdapter()
        Me.STOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STOCTableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.STOCTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPLIMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(674, 117)
        Me.Panel1.TabIndex = 1
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
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Controls.Add(Me.ComboBoxSala)
        Me.Panel2.Controls.Add(Me.ComboBoxSup)
        Me.Panel2.Controls.Add(Me.btnSalveaza)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(32, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 632)
        Me.Panel2.TabIndex = 2
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.NumericUpDown1.Location = New System.Drawing.Point(71, 333)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(473, 28)
        Me.NumericUpDown1.TabIndex = 7
        '
        'ComboBoxSala
        '
        Me.ComboBoxSala.DataSource = Me.SALABindingSource
        Me.ComboBoxSala.DisplayMember = "ID_SALA"
        Me.ComboBoxSala.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.ComboBoxSala.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ComboBoxSala.FormattingEnabled = True
        Me.ComboBoxSala.Location = New System.Drawing.Point(71, 209)
        Me.ComboBoxSala.Name = "ComboBoxSala"
        Me.ComboBoxSala.Size = New System.Drawing.Size(473, 30)
        Me.ComboBoxSala.TabIndex = 6
        Me.ComboBoxSala.ValueMember = "ID_SALA"
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
        'ComboBoxSup
        '
        Me.ComboBoxSup.DataSource = Me.SUPLIMENTBindingSource
        Me.ComboBoxSup.DisplayMember = "ID_SUPLIMENT"
        Me.ComboBoxSup.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.ComboBoxSup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ComboBoxSup.FormattingEnabled = True
        Me.ComboBoxSup.Location = New System.Drawing.Point(71, 85)
        Me.ComboBoxSup.Name = "ComboBoxSup"
        Me.ComboBoxSup.Size = New System.Drawing.Size(473, 30)
        Me.ComboBoxSup.TabIndex = 5
        Me.ComboBoxSup.ValueMember = "ID_SUPLIMENT"
        '
        'SUPLIMENTBindingSource
        '
        Me.SUPLIMENTBindingSource.DataMember = "SUPLIMENT"
        Me.SUPLIMENTBindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(77, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cantitate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(77, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Sala:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(77, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Supliment:"
        '
        'SUPLIMENTTableAdapter
        '
        Me.SUPLIMENTTableAdapter.ClearBeforeFill = True
        '
        'SALATableAdapter
        '
        Me.SALATableAdapter.ClearBeforeFill = True
        '
        'STOCBindingSource
        '
        Me.STOCBindingSource.DataMember = "STOC"
        Me.STOCBindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
        '
        'STOCTableAdapter
        '
        Me.STOCTableAdapter.ClearBeforeFill = True
        '
        'AddStoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 794)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddStoc"
        Me.Text = "AddStoc"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPLIMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ComboBoxSala As ComboBox
    Friend WithEvents ComboBoxSup As ComboBox
    Friend WithEvents btnSalveaza As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents SUPLIMENTBindingSource As BindingSource
    Friend WithEvents SUPLIMENTTableAdapter As SALA_DE_FITNESSDataSetTableAdapters.SUPLIMENTTableAdapter
    Friend WithEvents SALABindingSource As BindingSource
    Friend WithEvents SALATableAdapter As SALA_DE_FITNESSDataSetTableAdapters.SALATableAdapter
    Friend WithEvents STOCBindingSource As BindingSource
    Friend WithEvents STOCTableAdapter As SALA_DE_FITNESSDataSetTableAdapters.STOCTableAdapter
End Class

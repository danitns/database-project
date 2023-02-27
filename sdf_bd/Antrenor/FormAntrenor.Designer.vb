<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAntrenor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DataGridViewAntrenor = New System.Windows.Forms.DataGridView()
        Me.ANTRENORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.txtCauta = New System.Windows.Forms.TextBox()
        Me.ANTRENORTableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.ANTRENORTableAdapter()
        Me.IDANTRENORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSALADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENUMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARIUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewAntrenor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANTRENORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 120)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 28.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Antrenor"
        '
        'btnAdauga
        '
        Me.btnAdauga.BackColor = System.Drawing.Color.White
        Me.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdauga.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.btnAdauga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAdauga.Location = New System.Drawing.Point(25, 19)
        Me.btnAdauga.Name = "btnAdauga"
        Me.btnAdauga.Size = New System.Drawing.Size(114, 48)
        Me.btnAdauga.TabIndex = 2
        Me.btnAdauga.Text = "Adauga"
        Me.btnAdauga.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.DataGridViewAntrenor)
        Me.Panel2.Controls.Add(Me.txtCauta)
        Me.Panel2.Controls.Add(Me.btnAdauga)
        Me.Panel2.Location = New System.Drawing.Point(63, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(890, 474)
        Me.Panel2.TabIndex = 3
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(184, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(114, 48)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'DataGridViewAntrenor
        '
        Me.DataGridViewAntrenor.AllowUserToAddRows = False
        Me.DataGridViewAntrenor.AllowUserToDeleteRows = False
        Me.DataGridViewAntrenor.AllowUserToOrderColumns = True
        Me.DataGridViewAntrenor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewAntrenor.AutoGenerateColumns = False
        Me.DataGridViewAntrenor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAntrenor.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewAntrenor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAntrenor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDANTRENORDataGridViewTextBoxColumn, Me.IDSALADataGridViewTextBoxColumn, Me.NUMEDataGridViewTextBoxColumn, Me.PRENUMEDataGridViewTextBoxColumn, Me.SALARIUDataGridViewTextBoxColumn, Me.btnDelete, Me.btnUpdate})
        Me.DataGridViewAntrenor.DataSource = Me.ANTRENORBindingSource
        Me.DataGridViewAntrenor.Location = New System.Drawing.Point(25, 94)
        Me.DataGridViewAntrenor.Name = "DataGridViewAntrenor"
        Me.DataGridViewAntrenor.ReadOnly = True
        Me.DataGridViewAntrenor.RowHeadersWidth = 51
        Me.DataGridViewAntrenor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewAntrenor.RowTemplate.Height = 24
        Me.DataGridViewAntrenor.ShowEditingIcon = False
        Me.DataGridViewAntrenor.Size = New System.Drawing.Size(833, 349)
        Me.DataGridViewAntrenor.TabIndex = 0
        '
        'ANTRENORBindingSource
        '
        Me.ANTRENORBindingSource.DataMember = "ANTRENOR"
        Me.ANTRENORBindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
        '
        'SALA_DE_FITNESSDataSet
        '
        Me.SALA_DE_FITNESSDataSet.DataSetName = "SALA_DE_FITNESSDataSet"
        Me.SALA_DE_FITNESSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCauta
        '
        Me.txtCauta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCauta.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.txtCauta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtCauta.Location = New System.Drawing.Point(674, 29)
        Me.txtCauta.Name = "txtCauta"
        Me.txtCauta.Size = New System.Drawing.Size(184, 28)
        Me.txtCauta.TabIndex = 1
        '
        'ANTRENORTableAdapter
        '
        Me.ANTRENORTableAdapter.ClearBeforeFill = True
        '
        'IDANTRENORDataGridViewTextBoxColumn
        '
        Me.IDANTRENORDataGridViewTextBoxColumn.DataPropertyName = "ID_ANTRENOR"
        Me.IDANTRENORDataGridViewTextBoxColumn.HeaderText = "ID_ANTRENOR"
        Me.IDANTRENORDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDANTRENORDataGridViewTextBoxColumn.Name = "IDANTRENORDataGridViewTextBoxColumn"
        Me.IDANTRENORDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDSALADataGridViewTextBoxColumn
        '
        Me.IDSALADataGridViewTextBoxColumn.DataPropertyName = "ID_SALA"
        Me.IDSALADataGridViewTextBoxColumn.HeaderText = "ID_SALA"
        Me.IDSALADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDSALADataGridViewTextBoxColumn.Name = "IDSALADataGridViewTextBoxColumn"
        Me.IDSALADataGridViewTextBoxColumn.ReadOnly = True
        '
        'NUMEDataGridViewTextBoxColumn
        '
        Me.NUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME"
        Me.NUMEDataGridViewTextBoxColumn.HeaderText = "NUME"
        Me.NUMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMEDataGridViewTextBoxColumn.Name = "NUMEDataGridViewTextBoxColumn"
        Me.NUMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRENUMEDataGridViewTextBoxColumn
        '
        Me.PRENUMEDataGridViewTextBoxColumn.DataPropertyName = "PRENUME"
        Me.PRENUMEDataGridViewTextBoxColumn.HeaderText = "PRENUME"
        Me.PRENUMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PRENUMEDataGridViewTextBoxColumn.Name = "PRENUMEDataGridViewTextBoxColumn"
        Me.PRENUMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SALARIUDataGridViewTextBoxColumn
        '
        Me.SALARIUDataGridViewTextBoxColumn.DataPropertyName = "SALARIU"
        Me.SALARIUDataGridViewTextBoxColumn.HeaderText = "SALARIU"
        Me.SALARIUDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SALARIUDataGridViewTextBoxColumn.Name = "SALARIUDataGridViewTextBoxColumn"
        Me.SALARIUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnDelete
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.btnDelete.DefaultCellStyle = DataGridViewCellStyle1
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.HeaderText = ""
        Me.btnDelete.MinimumWidth = 6
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ReadOnly = True
        Me.btnDelete.Text = "Sterge"
        Me.btnDelete.UseColumnTextForButtonValue = True
        '
        'btnUpdate
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.btnUpdate.DefaultCellStyle = DataGridViewCellStyle2
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.HeaderText = ""
        Me.btnUpdate.MinimumWidth = 6
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ReadOnly = True
        Me.btnUpdate.Text = "Modifica"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        '
        'FormAntrenor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 684)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAntrenor"
        Me.Text = "FormAntrenor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewAntrenor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANTRENORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdauga As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridViewAntrenor As DataGridView
    Friend WithEvents txtCauta As TextBox
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents ANTRENORBindingSource As BindingSource
    Friend WithEvents ANTRENORTableAdapter As SALA_DE_FITNESSDataSetTableAdapters.ANTRENORTableAdapter
    Friend WithEvents IDANTRENORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDSALADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRENUMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALARIUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class

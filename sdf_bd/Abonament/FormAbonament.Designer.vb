<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAbonament
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewAbonament = New System.Windows.Forms.DataGridView()
        Me.TIPABONAMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DURATADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAUNADataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SPADataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PISCINADataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ABONAMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.txtCauta = New System.Windows.Forms.TextBox()
        Me.ABONAMENTTableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.ABONAMENTTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewAbonament, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABONAMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1006, 120)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 28.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Abonament"
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
        Me.Panel2.Controls.Add(Me.DataGridViewAbonament)
        Me.Panel2.Controls.Add(Me.txtCauta)
        Me.Panel2.Controls.Add(Me.btnAdauga)
        Me.Panel2.Location = New System.Drawing.Point(63, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 511)
        Me.Panel2.TabIndex = 2
        '
        'DataGridViewAbonament
        '
        Me.DataGridViewAbonament.AllowUserToAddRows = False
        Me.DataGridViewAbonament.AllowUserToDeleteRows = False
        Me.DataGridViewAbonament.AllowUserToOrderColumns = True
        Me.DataGridViewAbonament.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewAbonament.AutoGenerateColumns = False
        Me.DataGridViewAbonament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAbonament.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewAbonament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAbonament.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPABONAMENTDataGridViewTextBoxColumn, Me.PRETDataGridViewTextBoxColumn, Me.DURATADataGridViewTextBoxColumn, Me.SAUNADataGridViewCheckBoxColumn, Me.SPADataGridViewCheckBoxColumn, Me.PISCINADataGridViewCheckBoxColumn, Me.btnDelete, Me.btnUpdate})
        Me.DataGridViewAbonament.DataSource = Me.ABONAMENTBindingSource
        Me.DataGridViewAbonament.Location = New System.Drawing.Point(25, 94)
        Me.DataGridViewAbonament.Name = "DataGridViewAbonament"
        Me.DataGridViewAbonament.ReadOnly = True
        Me.DataGridViewAbonament.RowHeadersWidth = 51
        Me.DataGridViewAbonament.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewAbonament.RowTemplate.Height = 24
        Me.DataGridViewAbonament.ShowEditingIcon = False
        Me.DataGridViewAbonament.Size = New System.Drawing.Size(834, 386)
        Me.DataGridViewAbonament.TabIndex = 0
        '
        'TIPABONAMENTDataGridViewTextBoxColumn
        '
        Me.TIPABONAMENTDataGridViewTextBoxColumn.DataPropertyName = "TIP_ABONAMENT"
        Me.TIPABONAMENTDataGridViewTextBoxColumn.HeaderText = "TIP_ABONAMENT"
        Me.TIPABONAMENTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TIPABONAMENTDataGridViewTextBoxColumn.Name = "TIPABONAMENTDataGridViewTextBoxColumn"
        Me.TIPABONAMENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRETDataGridViewTextBoxColumn
        '
        Me.PRETDataGridViewTextBoxColumn.DataPropertyName = "PRET"
        Me.PRETDataGridViewTextBoxColumn.HeaderText = "PRET"
        Me.PRETDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PRETDataGridViewTextBoxColumn.Name = "PRETDataGridViewTextBoxColumn"
        Me.PRETDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DURATADataGridViewTextBoxColumn
        '
        Me.DURATADataGridViewTextBoxColumn.DataPropertyName = "DURATA"
        Me.DURATADataGridViewTextBoxColumn.HeaderText = "DURATA"
        Me.DURATADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DURATADataGridViewTextBoxColumn.Name = "DURATADataGridViewTextBoxColumn"
        Me.DURATADataGridViewTextBoxColumn.ReadOnly = True
        '
        'SAUNADataGridViewCheckBoxColumn
        '
        Me.SAUNADataGridViewCheckBoxColumn.DataPropertyName = "SAUNA"
        Me.SAUNADataGridViewCheckBoxColumn.HeaderText = "SAUNA"
        Me.SAUNADataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.SAUNADataGridViewCheckBoxColumn.Name = "SAUNADataGridViewCheckBoxColumn"
        Me.SAUNADataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SPADataGridViewCheckBoxColumn
        '
        Me.SPADataGridViewCheckBoxColumn.DataPropertyName = "SPA"
        Me.SPADataGridViewCheckBoxColumn.HeaderText = "SPA"
        Me.SPADataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.SPADataGridViewCheckBoxColumn.Name = "SPADataGridViewCheckBoxColumn"
        Me.SPADataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PISCINADataGridViewCheckBoxColumn
        '
        Me.PISCINADataGridViewCheckBoxColumn.DataPropertyName = "PISCINA"
        Me.PISCINADataGridViewCheckBoxColumn.HeaderText = "PISCINA"
        Me.PISCINADataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.PISCINADataGridViewCheckBoxColumn.Name = "PISCINADataGridViewCheckBoxColumn"
        Me.PISCINADataGridViewCheckBoxColumn.ReadOnly = True
        '
        'btnDelete
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.btnDelete.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.btnUpdate.DefaultCellStyle = DataGridViewCellStyle6
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.HeaderText = ""
        Me.btnUpdate.MinimumWidth = 6
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ReadOnly = True
        Me.btnUpdate.Text = "Modifica"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        '
        'ABONAMENTBindingSource
        '
        Me.ABONAMENTBindingSource.DataMember = "ABONAMENT"
        Me.ABONAMENTBindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
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
        Me.txtCauta.Location = New System.Drawing.Point(675, 29)
        Me.txtCauta.Name = "txtCauta"
        Me.txtCauta.Size = New System.Drawing.Size(184, 28)
        Me.txtCauta.TabIndex = 1
        '
        'ABONAMENTTableAdapter
        '
        Me.ABONAMENTTableAdapter.ClearBeforeFill = True
        '
        'FormAbonament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAbonament"
        Me.Text = "FormAbonament"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewAbonament, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABONAMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAdauga As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewAbonament As DataGridView
    Friend WithEvents txtCauta As TextBox
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents ABONAMENTBindingSource As BindingSource
    Friend WithEvents ABONAMENTTableAdapter As SALA_DE_FITNESSDataSetTableAdapters.ABONAMENTTableAdapter
    Friend WithEvents TIPABONAMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRETDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DURATADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SAUNADataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SPADataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PISCINADataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class

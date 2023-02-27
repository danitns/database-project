<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTranzactie
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DataGridViewTranz = New System.Windows.Forms.DataGridView()
        Me.IDTRANZACTIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPABONAMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCLIENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATAINCEPUTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TRANZACTIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.txtCauta = New System.Windows.Forms.TextBox()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.TRANZACTIETableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.TRANZACTIETableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewTranz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANZACTIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 28.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tranzactie"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.DataGridViewTranz)
        Me.Panel2.Controls.Add(Me.txtCauta)
        Me.Panel2.Controls.Add(Me.btnAdauga)
        Me.Panel2.Location = New System.Drawing.Point(63, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 511)
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
        'DataGridViewTranz
        '
        Me.DataGridViewTranz.AllowUserToAddRows = False
        Me.DataGridViewTranz.AllowUserToDeleteRows = False
        Me.DataGridViewTranz.AllowUserToOrderColumns = True
        Me.DataGridViewTranz.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewTranz.AutoGenerateColumns = False
        Me.DataGridViewTranz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewTranz.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewTranz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTranz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTRANZACTIEDataGridViewTextBoxColumn, Me.TIPABONAMENTDataGridViewTextBoxColumn, Me.IDCLIENTDataGridViewTextBoxColumn, Me.DATAINCEPUTDataGridViewTextBoxColumn, Me.btnDelete, Me.btnUpdate})
        Me.DataGridViewTranz.DataSource = Me.TRANZACTIEBindingSource
        Me.DataGridViewTranz.Location = New System.Drawing.Point(25, 94)
        Me.DataGridViewTranz.Name = "DataGridViewTranz"
        Me.DataGridViewTranz.ReadOnly = True
        Me.DataGridViewTranz.RowHeadersWidth = 51
        Me.DataGridViewTranz.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewTranz.RowTemplate.Height = 24
        Me.DataGridViewTranz.ShowEditingIcon = False
        Me.DataGridViewTranz.Size = New System.Drawing.Size(834, 386)
        Me.DataGridViewTranz.TabIndex = 0
        '
        'IDTRANZACTIEDataGridViewTextBoxColumn
        '
        Me.IDTRANZACTIEDataGridViewTextBoxColumn.DataPropertyName = "ID_TRANZACTIE"
        Me.IDTRANZACTIEDataGridViewTextBoxColumn.HeaderText = "ID_TRANZACTIE"
        Me.IDTRANZACTIEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDTRANZACTIEDataGridViewTextBoxColumn.Name = "IDTRANZACTIEDataGridViewTextBoxColumn"
        Me.IDTRANZACTIEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TIPABONAMENTDataGridViewTextBoxColumn
        '
        Me.TIPABONAMENTDataGridViewTextBoxColumn.DataPropertyName = "TIP_ABONAMENT"
        Me.TIPABONAMENTDataGridViewTextBoxColumn.HeaderText = "TIP_ABONAMENT"
        Me.TIPABONAMENTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TIPABONAMENTDataGridViewTextBoxColumn.Name = "TIPABONAMENTDataGridViewTextBoxColumn"
        Me.TIPABONAMENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDCLIENTDataGridViewTextBoxColumn
        '
        Me.IDCLIENTDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENT"
        Me.IDCLIENTDataGridViewTextBoxColumn.HeaderText = "ID_CLIENT"
        Me.IDCLIENTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDCLIENTDataGridViewTextBoxColumn.Name = "IDCLIENTDataGridViewTextBoxColumn"
        Me.IDCLIENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DATAINCEPUTDataGridViewTextBoxColumn
        '
        Me.DATAINCEPUTDataGridViewTextBoxColumn.DataPropertyName = "DATA_INCEPUT"
        Me.DATAINCEPUTDataGridViewTextBoxColumn.HeaderText = "DATA_INCEPUT"
        Me.DATAINCEPUTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DATAINCEPUTDataGridViewTextBoxColumn.Name = "DATAINCEPUTDataGridViewTextBoxColumn"
        Me.DATAINCEPUTDataGridViewTextBoxColumn.ReadOnly = True
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
        'TRANZACTIEBindingSource
        '
        Me.TRANZACTIEBindingSource.DataMember = "TRANZACTIE"
        Me.TRANZACTIEBindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
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
        'TRANZACTIETableAdapter
        '
        Me.TRANZACTIETableAdapter.ClearBeforeFill = True
        '
        'FormTranzactie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormTranzactie"
        Me.Text = "FormTranzactie"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewTranz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANZACTIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridViewTranz As DataGridView
    Friend WithEvents txtCauta As TextBox
    Friend WithEvents btnAdauga As Button
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents TRANZACTIEBindingSource As BindingSource
    Friend WithEvents TRANZACTIETableAdapter As SALA_DE_FITNESSDataSetTableAdapters.TRANZACTIETableAdapter
    Friend WithEvents IDTRANZACTIEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPABONAMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDCLIENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATAINCEPUTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class

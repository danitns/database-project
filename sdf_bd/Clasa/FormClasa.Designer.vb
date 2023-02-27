<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClasa
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
        Me.DataGridViewClasa = New System.Windows.Forms.DataGridView()
        Me.IDCLASADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDANTRENORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DURATADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CLASABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.txtCauta = New System.Windows.Forms.TextBox()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.CLASATableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.CLASATableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewClasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLASABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(140, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clasa"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.DataGridViewClasa)
        Me.Panel2.Controls.Add(Me.txtCauta)
        Me.Panel2.Controls.Add(Me.btnAdauga)
        Me.Panel2.Location = New System.Drawing.Point(63, 171)
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
        'DataGridViewClasa
        '
        Me.DataGridViewClasa.AllowUserToAddRows = False
        Me.DataGridViewClasa.AllowUserToDeleteRows = False
        Me.DataGridViewClasa.AllowUserToOrderColumns = True
        Me.DataGridViewClasa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewClasa.AutoGenerateColumns = False
        Me.DataGridViewClasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewClasa.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewClasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClasa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCLASADataGridViewTextBoxColumn, Me.IDANTRENORDataGridViewTextBoxColumn, Me.NUMEDataGridViewTextBoxColumn, Me.DURATADataGridViewTextBoxColumn, Me.btnDelete, Me.btnUpdate})
        Me.DataGridViewClasa.DataSource = Me.CLASABindingSource
        Me.DataGridViewClasa.Location = New System.Drawing.Point(25, 94)
        Me.DataGridViewClasa.Name = "DataGridViewClasa"
        Me.DataGridViewClasa.ReadOnly = True
        Me.DataGridViewClasa.RowHeadersWidth = 51
        Me.DataGridViewClasa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewClasa.RowTemplate.Height = 24
        Me.DataGridViewClasa.ShowEditingIcon = False
        Me.DataGridViewClasa.Size = New System.Drawing.Size(833, 349)
        Me.DataGridViewClasa.TabIndex = 0
        '
        'IDCLASADataGridViewTextBoxColumn
        '
        Me.IDCLASADataGridViewTextBoxColumn.DataPropertyName = "ID_CLASA"
        Me.IDCLASADataGridViewTextBoxColumn.HeaderText = "ID_CLASA"
        Me.IDCLASADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDCLASADataGridViewTextBoxColumn.Name = "IDCLASADataGridViewTextBoxColumn"
        Me.IDCLASADataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDANTRENORDataGridViewTextBoxColumn
        '
        Me.IDANTRENORDataGridViewTextBoxColumn.DataPropertyName = "ID_ANTRENOR"
        Me.IDANTRENORDataGridViewTextBoxColumn.HeaderText = "ID_ANTRENOR"
        Me.IDANTRENORDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDANTRENORDataGridViewTextBoxColumn.Name = "IDANTRENORDataGridViewTextBoxColumn"
        Me.IDANTRENORDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NUMEDataGridViewTextBoxColumn
        '
        Me.NUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME"
        Me.NUMEDataGridViewTextBoxColumn.HeaderText = "NUME"
        Me.NUMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMEDataGridViewTextBoxColumn.Name = "NUMEDataGridViewTextBoxColumn"
        Me.NUMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DURATADataGridViewTextBoxColumn
        '
        Me.DURATADataGridViewTextBoxColumn.DataPropertyName = "DURATA"
        Me.DURATADataGridViewTextBoxColumn.HeaderText = "DURATA"
        Me.DURATADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DURATADataGridViewTextBoxColumn.Name = "DURATADataGridViewTextBoxColumn"
        Me.DURATADataGridViewTextBoxColumn.ReadOnly = True
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
        'CLASABindingSource
        '
        Me.CLASABindingSource.DataMember = "CLASA"
        Me.CLASABindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
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
        'CLASATableAdapter
        '
        Me.CLASATableAdapter.ClearBeforeFill = True
        '
        'FormClasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 684)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormClasa"
        Me.Text = "FormClasa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewClasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLASABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridViewClasa As DataGridView
    Friend WithEvents txtCauta As TextBox
    Friend WithEvents btnAdauga As Button
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents CLASABindingSource As BindingSource
    Friend WithEvents CLASATableAdapter As SALA_DE_FITNESSDataSetTableAdapters.CLASATableAdapter
    Friend WithEvents IDCLASADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDANTRENORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DURATADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class

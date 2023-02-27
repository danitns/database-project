<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMentenanta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DataGridViewMentenanta = New System.Windows.Forms.DataGridView()
        Me.MENTENANTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.txtCauta = New System.Windows.Forms.TextBox()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.MENTENANTATableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.MENTENANTATableAdapter()
        Me.IDANGAJATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSALADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENUMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARIUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCUPATIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewMentenanta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MENTENANTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 28.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mentenanta"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 120)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.DataGridViewMentenanta)
        Me.Panel2.Controls.Add(Me.txtCauta)
        Me.Panel2.Controls.Add(Me.btnAdauga)
        Me.Panel2.Location = New System.Drawing.Point(63, 171)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(890, 474)
        Me.Panel2.TabIndex = 2
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
        'DataGridViewMentenanta
        '
        Me.DataGridViewMentenanta.AllowUserToAddRows = False
        Me.DataGridViewMentenanta.AllowUserToDeleteRows = False
        Me.DataGridViewMentenanta.AllowUserToOrderColumns = True
        Me.DataGridViewMentenanta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMentenanta.AutoGenerateColumns = False
        Me.DataGridViewMentenanta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMentenanta.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewMentenanta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMentenanta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDANGAJATDataGridViewTextBoxColumn, Me.IDSALADataGridViewTextBoxColumn, Me.NUMEDataGridViewTextBoxColumn, Me.PRENUMEDataGridViewTextBoxColumn, Me.SALARIUDataGridViewTextBoxColumn, Me.OCUPATIEDataGridViewTextBoxColumn, Me.btnDelete, Me.btnUpdate})
        Me.DataGridViewMentenanta.DataSource = Me.MENTENANTABindingSource
        Me.DataGridViewMentenanta.Location = New System.Drawing.Point(25, 94)
        Me.DataGridViewMentenanta.Name = "DataGridViewMentenanta"
        Me.DataGridViewMentenanta.ReadOnly = True
        Me.DataGridViewMentenanta.RowHeadersWidth = 51
        Me.DataGridViewMentenanta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewMentenanta.RowTemplate.Height = 24
        Me.DataGridViewMentenanta.ShowEditingIcon = False
        Me.DataGridViewMentenanta.Size = New System.Drawing.Size(833, 349)
        Me.DataGridViewMentenanta.TabIndex = 0
        '
        'MENTENANTABindingSource
        '
        Me.MENTENANTABindingSource.DataMember = "MENTENANTA"
        Me.MENTENANTABindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
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
        'MENTENANTATableAdapter
        '
        Me.MENTENANTATableAdapter.ClearBeforeFill = True
        '
        'IDANGAJATDataGridViewTextBoxColumn
        '
        Me.IDANGAJATDataGridViewTextBoxColumn.DataPropertyName = "ID_ANGAJAT"
        Me.IDANGAJATDataGridViewTextBoxColumn.HeaderText = "ID_ANGAJAT"
        Me.IDANGAJATDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDANGAJATDataGridViewTextBoxColumn.Name = "IDANGAJATDataGridViewTextBoxColumn"
        Me.IDANGAJATDataGridViewTextBoxColumn.ReadOnly = True
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
        'OCUPATIEDataGridViewTextBoxColumn
        '
        Me.OCUPATIEDataGridViewTextBoxColumn.DataPropertyName = "OCUPATIE"
        Me.OCUPATIEDataGridViewTextBoxColumn.HeaderText = "OCUPATIE"
        Me.OCUPATIEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OCUPATIEDataGridViewTextBoxColumn.Name = "OCUPATIEDataGridViewTextBoxColumn"
        Me.OCUPATIEDataGridViewTextBoxColumn.ReadOnly = True
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
        'FormMentenanta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 684)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMentenanta"
        Me.Text = "FormMentenanta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewMentenanta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MENTENANTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridViewMentenanta As DataGridView
    Friend WithEvents txtCauta As TextBox
    Friend WithEvents btnAdauga As Button
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents MENTENANTABindingSource As BindingSource
    Friend WithEvents MENTENANTATableAdapter As SALA_DE_FITNESSDataSetTableAdapters.MENTENANTATableAdapter
    Friend WithEvents IDANGAJATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDSALADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRENUMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALARIUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OCUPATIEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class

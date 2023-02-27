<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProgram
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewProgram = New System.Windows.Forms.DataGridView()
        Me.IDCLASADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCLIENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZIORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PROGRAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.txtCauta = New System.Windows.Forms.TextBox()
        Me.PROGRAMTableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.PROGRAMTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewProgram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROGRAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(208, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program"
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
        Me.Panel2.Controls.Add(Me.DataGridViewProgram)
        Me.Panel2.Controls.Add(Me.txtCauta)
        Me.Panel2.Controls.Add(Me.btnAdauga)
        Me.Panel2.Location = New System.Drawing.Point(54, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 511)
        Me.Panel2.TabIndex = 3
        '
        'DataGridViewProgram
        '
        Me.DataGridViewProgram.AllowUserToAddRows = False
        Me.DataGridViewProgram.AllowUserToDeleteRows = False
        Me.DataGridViewProgram.AllowUserToOrderColumns = True
        Me.DataGridViewProgram.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewProgram.AutoGenerateColumns = False
        Me.DataGridViewProgram.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProgram.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProgram.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCLASADataGridViewTextBoxColumn, Me.IDCLIENTDataGridViewTextBoxColumn, Me.ZIORADataGridViewTextBoxColumn, Me.btnDelete, Me.btnUpdate})
        Me.DataGridViewProgram.DataSource = Me.PROGRAMBindingSource
        Me.DataGridViewProgram.Location = New System.Drawing.Point(25, 94)
        Me.DataGridViewProgram.Name = "DataGridViewProgram"
        Me.DataGridViewProgram.ReadOnly = True
        Me.DataGridViewProgram.RowHeadersWidth = 51
        Me.DataGridViewProgram.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewProgram.RowTemplate.Height = 24
        Me.DataGridViewProgram.ShowEditingIcon = False
        Me.DataGridViewProgram.Size = New System.Drawing.Size(834, 386)
        Me.DataGridViewProgram.TabIndex = 0
        '
        'IDCLASADataGridViewTextBoxColumn
        '
        Me.IDCLASADataGridViewTextBoxColumn.DataPropertyName = "ID_CLASA"
        Me.IDCLASADataGridViewTextBoxColumn.HeaderText = "ID_CLASA"
        Me.IDCLASADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDCLASADataGridViewTextBoxColumn.Name = "IDCLASADataGridViewTextBoxColumn"
        Me.IDCLASADataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDCLIENTDataGridViewTextBoxColumn
        '
        Me.IDCLIENTDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENT"
        Me.IDCLIENTDataGridViewTextBoxColumn.HeaderText = "ID_CLIENT"
        Me.IDCLIENTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDCLIENTDataGridViewTextBoxColumn.Name = "IDCLIENTDataGridViewTextBoxColumn"
        Me.IDCLIENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ZIORADataGridViewTextBoxColumn
        '
        Me.ZIORADataGridViewTextBoxColumn.DataPropertyName = "ZI_ORA"
        Me.ZIORADataGridViewTextBoxColumn.HeaderText = "ZI_ORA"
        Me.ZIORADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ZIORADataGridViewTextBoxColumn.Name = "ZIORADataGridViewTextBoxColumn"
        Me.ZIORADataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnDelete
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.btnDelete.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.NullValue = Nothing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.btnUpdate.DefaultCellStyle = DataGridViewCellStyle8
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.HeaderText = ""
        Me.btnUpdate.MinimumWidth = 6
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ReadOnly = True
        Me.btnUpdate.Text = "Modifica"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        '
        'PROGRAMBindingSource
        '
        Me.PROGRAMBindingSource.DataMember = "PROGRAM"
        Me.PROGRAMBindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
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
        'PROGRAMTableAdapter
        '
        Me.PROGRAMTableAdapter.ClearBeforeFill = True
        '
        'FormProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormProgram"
        Me.Text = "FormProgram"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewProgram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROGRAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAdauga As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewProgram As DataGridView
    Friend WithEvents txtCauta As TextBox
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents PROGRAMBindingSource As BindingSource
    Friend WithEvents PROGRAMTableAdapter As SALA_DE_FITNESSDataSetTableAdapters.PROGRAMTableAdapter
    Friend WithEvents IDCLASADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDCLIENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZIORADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class

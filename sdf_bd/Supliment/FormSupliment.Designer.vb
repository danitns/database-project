<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupliment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DataGridViewSup = New System.Windows.Forms.DataGridView()
        Me.IDSUPLIMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BRANDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SUPLIMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.txtCauta = New System.Windows.Forms.TextBox()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.SUPLIMENTTableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.SUPLIMENTTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewSup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPLIMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(240, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supliment"
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
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.DataGridViewSup)
        Me.Panel2.Controls.Add(Me.txtCauta)
        Me.Panel2.Controls.Add(Me.btnAdauga)
        Me.Panel2.Location = New System.Drawing.Point(63, 168)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 511)
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
        'DataGridViewSup
        '
        Me.DataGridViewSup.AllowUserToAddRows = False
        Me.DataGridViewSup.AllowUserToDeleteRows = False
        Me.DataGridViewSup.AllowUserToOrderColumns = True
        Me.DataGridViewSup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSup.AutoGenerateColumns = False
        Me.DataGridViewSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewSup.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSUPLIMENTDataGridViewTextBoxColumn, Me.BRANDDataGridViewTextBoxColumn, Me.NUMEDataGridViewTextBoxColumn, Me.PRETDataGridViewTextBoxColumn, Me.btnDelete, Me.btnUpdate})
        Me.DataGridViewSup.DataSource = Me.SUPLIMENTBindingSource
        Me.DataGridViewSup.Location = New System.Drawing.Point(25, 97)
        Me.DataGridViewSup.Name = "DataGridViewSup"
        Me.DataGridViewSup.ReadOnly = True
        Me.DataGridViewSup.RowHeadersWidth = 51
        Me.DataGridViewSup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewSup.RowTemplate.Height = 24
        Me.DataGridViewSup.ShowEditingIcon = False
        Me.DataGridViewSup.Size = New System.Drawing.Size(834, 386)
        Me.DataGridViewSup.TabIndex = 0
        '
        'IDSUPLIMENTDataGridViewTextBoxColumn
        '
        Me.IDSUPLIMENTDataGridViewTextBoxColumn.DataPropertyName = "ID_SUPLIMENT"
        Me.IDSUPLIMENTDataGridViewTextBoxColumn.HeaderText = "ID_SUPLIMENT"
        Me.IDSUPLIMENTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDSUPLIMENTDataGridViewTextBoxColumn.Name = "IDSUPLIMENTDataGridViewTextBoxColumn"
        Me.IDSUPLIMENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BRANDDataGridViewTextBoxColumn
        '
        Me.BRANDDataGridViewTextBoxColumn.DataPropertyName = "BRAND"
        Me.BRANDDataGridViewTextBoxColumn.HeaderText = "BRAND"
        Me.BRANDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BRANDDataGridViewTextBoxColumn.Name = "BRANDDataGridViewTextBoxColumn"
        Me.BRANDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NUMEDataGridViewTextBoxColumn
        '
        Me.NUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME"
        Me.NUMEDataGridViewTextBoxColumn.HeaderText = "NUME"
        Me.NUMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMEDataGridViewTextBoxColumn.Name = "NUMEDataGridViewTextBoxColumn"
        Me.NUMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRETDataGridViewTextBoxColumn
        '
        Me.PRETDataGridViewTextBoxColumn.DataPropertyName = "PRET"
        Me.PRETDataGridViewTextBoxColumn.HeaderText = "PRET"
        Me.PRETDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PRETDataGridViewTextBoxColumn.Name = "PRETDataGridViewTextBoxColumn"
        Me.PRETDataGridViewTextBoxColumn.ReadOnly = True
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
        'SUPLIMENTBindingSource
        '
        Me.SUPLIMENTBindingSource.DataMember = "SUPLIMENT"
        Me.SUPLIMENTBindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
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
        'SUPLIMENTTableAdapter
        '
        Me.SUPLIMENTTableAdapter.ClearBeforeFill = True
        '
        'FormSupliment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormSupliment"
        Me.Text = "FormSupliment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewSup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPLIMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridViewSup As DataGridView
    Friend WithEvents txtCauta As TextBox
    Friend WithEvents btnAdauga As Button
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents SUPLIMENTBindingSource As BindingSource
    Friend WithEvents SUPLIMENTTableAdapter As SALA_DE_FITNESSDataSetTableAdapters.SUPLIMENTTableAdapter
    Friend WithEvents IDSUPLIMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BRANDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRETDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class

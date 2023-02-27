<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVizComp
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewViz = New System.Windows.Forms.DataGridView()
        Me.ID_ANTRENOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENUME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARIU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUME_SALA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADRESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modifica = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Sterge = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SALA_DE_FITNESSDataSet1 = New sdf_bd.SALA_DE_FITNESSDataSet1()
        Me.btnAdauga = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtCauta = New System.Windows.Forms.TextBox()
        Me.V_SALA_ANTRENORTableAdapter = New sdf_bd.SALA_DE_FITNESSDataSet1TableAdapters.V_SALA_ANTRENORTableAdapter()
        Me.VSALAANTRENORBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSALADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewViz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALA_DE_FITNESSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.VSALAANTRENORBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 28.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vizualizare compusa"
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
        'DataGridViewViz
        '
        Me.DataGridViewViz.AllowUserToAddRows = False
        Me.DataGridViewViz.AllowUserToDeleteRows = False
        Me.DataGridViewViz.AllowUserToOrderColumns = True
        Me.DataGridViewViz.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewViz.AutoGenerateColumns = False
        Me.DataGridViewViz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewViz.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewViz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewViz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ANTRENOR, Me.IDSALADataGridViewTextBoxColumn, Me.NUMEDataGridViewTextBoxColumn, Me.PRENUME, Me.SALARIU, Me.NUME_SALA, Me.ADRESA, Me.EMAIL, Me.TELEFON, Me.Modifica, Me.Sterge})
        Me.DataGridViewViz.DataSource = Me.VSALAANTRENORBindingSource1
        Me.DataGridViewViz.Location = New System.Drawing.Point(25, 94)
        Me.DataGridViewViz.Name = "DataGridViewViz"
        Me.DataGridViewViz.ReadOnly = True
        Me.DataGridViewViz.RowHeadersWidth = 51
        Me.DataGridViewViz.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewViz.RowTemplate.Height = 24
        Me.DataGridViewViz.ShowEditingIcon = False
        Me.DataGridViewViz.Size = New System.Drawing.Size(834, 386)
        Me.DataGridViewViz.TabIndex = 0
        '
        'ID_ANTRENOR
        '
        Me.ID_ANTRENOR.DataPropertyName = "ID_ANTRENOR"
        Me.ID_ANTRENOR.HeaderText = "ID_ANTRENOR"
        Me.ID_ANTRENOR.MinimumWidth = 6
        Me.ID_ANTRENOR.Name = "ID_ANTRENOR"
        Me.ID_ANTRENOR.ReadOnly = True
        '
        'PRENUME
        '
        Me.PRENUME.DataPropertyName = "PRENUME"
        Me.PRENUME.HeaderText = "PRENUME"
        Me.PRENUME.MinimumWidth = 6
        Me.PRENUME.Name = "PRENUME"
        Me.PRENUME.ReadOnly = True
        '
        'SALARIU
        '
        Me.SALARIU.DataPropertyName = "SALARIU"
        Me.SALARIU.HeaderText = "SALARIU"
        Me.SALARIU.MinimumWidth = 6
        Me.SALARIU.Name = "SALARIU"
        Me.SALARIU.ReadOnly = True
        '
        'NUME_SALA
        '
        Me.NUME_SALA.DataPropertyName = "NUME_SALA"
        Me.NUME_SALA.HeaderText = "NUME_SALA"
        Me.NUME_SALA.MinimumWidth = 6
        Me.NUME_SALA.Name = "NUME_SALA"
        Me.NUME_SALA.ReadOnly = True
        '
        'ADRESA
        '
        Me.ADRESA.DataPropertyName = "ADRESA"
        Me.ADRESA.HeaderText = "ADRESA"
        Me.ADRESA.MinimumWidth = 6
        Me.ADRESA.Name = "ADRESA"
        Me.ADRESA.ReadOnly = True
        '
        'EMAIL
        '
        Me.EMAIL.DataPropertyName = "EMAIL"
        Me.EMAIL.HeaderText = "EMAIL"
        Me.EMAIL.MinimumWidth = 6
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        '
        'TELEFON
        '
        Me.TELEFON.DataPropertyName = "TELEFON"
        Me.TELEFON.HeaderText = "TELEFON"
        Me.TELEFON.MinimumWidth = 6
        Me.TELEFON.Name = "TELEFON"
        Me.TELEFON.ReadOnly = True
        '
        'Modifica
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.Modifica.DefaultCellStyle = DataGridViewCellStyle11
        Me.Modifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modifica.HeaderText = ""
        Me.Modifica.MinimumWidth = 6
        Me.Modifica.Name = "Modifica"
        Me.Modifica.ReadOnly = True
        Me.Modifica.Text = "Modifica"
        Me.Modifica.UseColumnTextForButtonValue = True
        '
        'Sterge
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Bookman Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sterge.DefaultCellStyle = DataGridViewCellStyle12
        Me.Sterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sterge.HeaderText = ""
        Me.Sterge.MinimumWidth = 6
        Me.Sterge.Name = "Sterge"
        Me.Sterge.ReadOnly = True
        Me.Sterge.Text = "Sterge"
        Me.Sterge.UseColumnTextForButtonValue = True
        '
        'SALA_DE_FITNESSDataSet1
        '
        Me.SALA_DE_FITNESSDataSet1.DataSetName = "SALA_DE_FITNESSDataSet1"
        Me.SALA_DE_FITNESSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Panel2.Controls.Add(Me.DataGridViewViz)
        Me.Panel2.Controls.Add(Me.txtCauta)
        Me.Panel2.Controls.Add(Me.btnAdauga)
        Me.Panel2.Location = New System.Drawing.Point(63, 171)
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
        'V_SALA_ANTRENORTableAdapter
        '
        Me.V_SALA_ANTRENORTableAdapter.ClearBeforeFill = True
        '
        'VSALAANTRENORBindingSource1
        '
        Me.VSALAANTRENORBindingSource1.DataMember = "V_SALA_ANTRENOR"
        Me.VSALAANTRENORBindingSource1.DataSource = Me.SALA_DE_FITNESSDataSet1
        '
        'NUMEDataGridViewTextBoxColumn
        '
        Me.NUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME"
        Me.NUMEDataGridViewTextBoxColumn.HeaderText = "NUME"
        Me.NUMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMEDataGridViewTextBoxColumn.Name = "NUMEDataGridViewTextBoxColumn"
        Me.NUMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDSALADataGridViewTextBoxColumn
        '
        Me.IDSALADataGridViewTextBoxColumn.DataPropertyName = "ID_SALA"
        Me.IDSALADataGridViewTextBoxColumn.HeaderText = "ID_SALA"
        Me.IDSALADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDSALADataGridViewTextBoxColumn.Name = "IDSALADataGridViewTextBoxColumn"
        Me.IDSALADataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormVizComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormVizComp"
        Me.Text = "FormVizComp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewViz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.VSALAANTRENORBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewViz As DataGridView
    Friend WithEvents btnAdauga As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtCauta As TextBox
    Friend WithEvents SALA_DE_FITNESSDataSet1 As SALA_DE_FITNESSDataSet1
    Friend WithEvents V_SALA_ANTRENORTableAdapter As SALA_DE_FITNESSDataSet1TableAdapters.V_SALA_ANTRENORTableAdapter
    Friend WithEvents ID_ANTRENOR As DataGridViewTextBoxColumn
    Friend WithEvents PRENUME As DataGridViewTextBoxColumn
    Friend WithEvents SALARIU As DataGridViewTextBoxColumn
    Friend WithEvents NUME_SALA As DataGridViewTextBoxColumn
    Friend WithEvents ADRESA As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents TELEFON As DataGridViewTextBoxColumn
    Friend WithEvents Modifica As DataGridViewButtonColumn
    Friend WithEvents Sterge As DataGridViewButtonColumn
    Friend WithEvents IDSALADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VSALAANTRENORBindingSource1 As BindingSource
End Class

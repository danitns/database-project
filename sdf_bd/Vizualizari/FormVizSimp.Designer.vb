<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVizSimp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewVizSimp = New System.Windows.Forms.DataGridView()
        Me.VMENTENANTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALADEFITNESSDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet1 = New sdf_bd.SALA_DE_FITNESSDataSet1()
        Me.V_MENTENANTATableAdapter = New sdf_bd.SALA_DE_FITNESSDataSet1TableAdapters.V_MENTENANTATableAdapter()
        Me.IDSALADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedieSalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewVizSimp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VMENTENANTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALADEFITNESSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALA_DE_FITNESSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 28.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vizualizare complexa"
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
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DataGridViewVizSimp)
        Me.Panel2.Location = New System.Drawing.Point(63, 178)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 511)
        Me.Panel2.TabIndex = 2
        '
        'DataGridViewVizSimp
        '
        Me.DataGridViewVizSimp.AllowUserToAddRows = False
        Me.DataGridViewVizSimp.AllowUserToDeleteRows = False
        Me.DataGridViewVizSimp.AllowUserToOrderColumns = True
        Me.DataGridViewVizSimp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewVizSimp.AutoGenerateColumns = False
        Me.DataGridViewVizSimp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVizSimp.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewVizSimp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVizSimp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSALADataGridViewTextBoxColumn, Me.MedieSalDataGridViewTextBoxColumn})
        Me.DataGridViewVizSimp.DataSource = Me.VMENTENANTABindingSource
        Me.DataGridViewVizSimp.Location = New System.Drawing.Point(25, 92)
        Me.DataGridViewVizSimp.Name = "DataGridViewVizSimp"
        Me.DataGridViewVizSimp.ReadOnly = True
        Me.DataGridViewVizSimp.RowHeadersWidth = 51
        Me.DataGridViewVizSimp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewVizSimp.RowTemplate.Height = 24
        Me.DataGridViewVizSimp.ShowEditingIcon = False
        Me.DataGridViewVizSimp.Size = New System.Drawing.Size(834, 388)
        Me.DataGridViewVizSimp.TabIndex = 0
        '
        'VMENTENANTABindingSource
        '
        Me.VMENTENANTABindingSource.DataMember = "V_MENTENANTA"
        Me.VMENTENANTABindingSource.DataSource = Me.SALADEFITNESSDataSet1BindingSource
        '
        'SALADEFITNESSDataSet1BindingSource
        '
        Me.SALADEFITNESSDataSet1BindingSource.DataSource = Me.SALA_DE_FITNESSDataSet1
        Me.SALADEFITNESSDataSet1BindingSource.Position = 0
        '
        'SALA_DE_FITNESSDataSet1
        '
        Me.SALA_DE_FITNESSDataSet1.DataSetName = "SALA_DE_FITNESSDataSet1"
        Me.SALA_DE_FITNESSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_MENTENANTATableAdapter
        '
        Me.V_MENTENANTATableAdapter.ClearBeforeFill = True
        '
        'IDSALADataGridViewTextBoxColumn
        '
        Me.IDSALADataGridViewTextBoxColumn.DataPropertyName = "ID_SALA"
        Me.IDSALADataGridViewTextBoxColumn.HeaderText = "ID_SALA"
        Me.IDSALADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDSALADataGridViewTextBoxColumn.Name = "IDSALADataGridViewTextBoxColumn"
        Me.IDSALADataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedieSalDataGridViewTextBoxColumn
        '
        Me.MedieSalDataGridViewTextBoxColumn.DataPropertyName = "MedieSal"
        Me.MedieSalDataGridViewTextBoxColumn.HeaderText = "MedieSal"
        Me.MedieSalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MedieSalDataGridViewTextBoxColumn.Name = "MedieSalDataGridViewTextBoxColumn"
        Me.MedieSalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 18.2!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(810, 72)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salariul mediu al angajatilor din tabelul MENTENANTA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pentru fiecare sala."
        '
        'FormVizSimp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormVizSimp"
        Me.Text = "FormVizSimp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewVizSimp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VMENTENANTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALADEFITNESSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewVizSimp As DataGridView
    Friend WithEvents SALA_DE_FITNESSDataSet1 As SALA_DE_FITNESSDataSet1
    Friend WithEvents SALADEFITNESSDataSet1BindingSource As BindingSource
    Friend WithEvents VMENTENANTABindingSource As BindingSource
    Friend WithEvents V_MENTENANTATableAdapter As SALA_DE_FITNESSDataSet1TableAdapters.V_MENTENANTATableAdapter
    Friend WithEvents IDSALADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedieSalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class

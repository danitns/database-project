<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProgram
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
        Me.DateTimeziora = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxIdClient = New System.Windows.Forms.ComboBox()
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.ComboBoxIdCls = New System.Windows.Forms.ComboBox()
        Me.CLASABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalveaza = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CLASATableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.CLASATableAdapter()
        Me.CLIENTTableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.CLIENTTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLASABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 2
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
        Me.Panel2.Controls.Add(Me.DateTimeziora)
        Me.Panel2.Controls.Add(Me.ComboBoxIdClient)
        Me.Panel2.Controls.Add(Me.ComboBoxIdCls)
        Me.Panel2.Controls.Add(Me.btnSalveaza)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(36, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(606, 626)
        Me.Panel2.TabIndex = 3
        '
        'DateTimeziora
        '
        Me.DateTimeziora.CalendarFont = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.DateTimeziora.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.DateTimeziora.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.DateTimeziora.CustomFormat = "dd.MM.yyyy HH:mm"
        Me.DateTimeziora.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.DateTimeziora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeziora.Location = New System.Drawing.Point(71, 329)
        Me.DateTimeziora.Name = "DateTimeziora"
        Me.DateTimeziora.Size = New System.Drawing.Size(473, 28)
        Me.DateTimeziora.TabIndex = 7
        '
        'ComboBoxIdClient
        '
        Me.ComboBoxIdClient.DataSource = Me.CLIENTBindingSource
        Me.ComboBoxIdClient.DisplayMember = "ID_CLIENT"
        Me.ComboBoxIdClient.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.ComboBoxIdClient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ComboBoxIdClient.FormattingEnabled = True
        Me.ComboBoxIdClient.Location = New System.Drawing.Point(71, 209)
        Me.ComboBoxIdClient.Name = "ComboBoxIdClient"
        Me.ComboBoxIdClient.Size = New System.Drawing.Size(473, 30)
        Me.ComboBoxIdClient.TabIndex = 6
        Me.ComboBoxIdClient.ValueMember = "ID_CLIENT"
        '
        'CLIENTBindingSource
        '
        Me.CLIENTBindingSource.DataMember = "CLIENT"
        Me.CLIENTBindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
        '
        'SALA_DE_FITNESSDataSet
        '
        Me.SALA_DE_FITNESSDataSet.DataSetName = "SALA_DE_FITNESSDataSet"
        Me.SALA_DE_FITNESSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxIdCls
        '
        Me.ComboBoxIdCls.DataSource = Me.CLASABindingSource
        Me.ComboBoxIdCls.DisplayMember = "ID_CLASA"
        Me.ComboBoxIdCls.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.ComboBoxIdCls.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ComboBoxIdCls.FormattingEnabled = True
        Me.ComboBoxIdCls.Location = New System.Drawing.Point(71, 85)
        Me.ComboBoxIdCls.Name = "ComboBoxIdCls"
        Me.ComboBoxIdCls.Size = New System.Drawing.Size(473, 30)
        Me.ComboBoxIdCls.TabIndex = 5
        Me.ComboBoxIdCls.ValueMember = "ID_CLASA"
        '
        'CLASABindingSource
        '
        Me.CLASABindingSource.DataMember = "CLASA"
        Me.CLASABindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
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
        Me.Label4.Size = New System.Drawing.Size(98, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ziua si Ora:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(77, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Client:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(77, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Clasa:"
        '
        'CLASATableAdapter
        '
        Me.CLASATableAdapter.ClearBeforeFill = True
        '
        'CLIENTTableAdapter
        '
        Me.CLIENTTableAdapter.ClearBeforeFill = True
        '
        'AddProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 794)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddProgram"
        Me.Text = "AddProgram"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLASABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBoxIdClient As ComboBox
    Friend WithEvents ComboBoxIdCls As ComboBox
    Friend WithEvents btnSalveaza As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimeziora As DateTimePicker
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents CLASABindingSource As BindingSource
    Friend WithEvents CLASATableAdapter As SALA_DE_FITNESSDataSetTableAdapters.CLASATableAdapter
    Friend WithEvents CLIENTBindingSource As BindingSource
    Friend WithEvents CLIENTTableAdapter As SALA_DE_FITNESSDataSetTableAdapters.CLIENTTableAdapter
End Class

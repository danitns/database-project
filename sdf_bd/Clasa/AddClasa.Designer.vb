<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClasa
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
        Me.DateTimeDurata = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxIdAntr = New System.Windows.Forms.ComboBox()
        Me.ANTRENORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSalveaza = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdClasa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNume = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ANTRENORTableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.ANTRENORTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(674, 120)
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
        Me.Panel2.Controls.Add(Me.DateTimeDurata)
        Me.Panel2.Controls.Add(Me.ComboBoxIdAntr)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnSalveaza)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtIdClasa)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtNume)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(28, 140)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(620, 628)
        Me.Panel2.TabIndex = 3
        '
        'DateTimeDurata
        '
        Me.DateTimeDurata.CustomFormat = "HH:mm:ss"
        Me.DateTimeDurata.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.DateTimeDurata.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeDurata.Location = New System.Drawing.Point(81, 460)
        Me.DateTimeDurata.Name = "DateTimeDurata"
        Me.DateTimeDurata.ShowUpDown = True
        Me.DateTimeDurata.Size = New System.Drawing.Size(200, 28)
        Me.DateTimeDurata.TabIndex = 13
        Me.DateTimeDurata.Value = New Date(2023, 1, 4, 0, 0, 0, 0)
        '
        'ComboBoxIdAntr
        '
        Me.ComboBoxIdAntr.DataSource = Me.ANTRENORBindingSource
        Me.ComboBoxIdAntr.DisplayMember = "ID_ANTRENOR"
        Me.ComboBoxIdAntr.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.ComboBoxIdAntr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ComboBoxIdAntr.FormattingEnabled = True
        Me.ComboBoxIdAntr.Location = New System.Drawing.Point(77, 226)
        Me.ComboBoxIdAntr.Name = "ComboBoxIdAntr"
        Me.ComboBoxIdAntr.Size = New System.Drawing.Size(469, 30)
        Me.ComboBoxIdAntr.TabIndex = 11
        Me.ComboBoxIdAntr.ValueMember = "ID_ANTRENOR"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(77, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 22)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ID Antrenor:"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(77, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ID Clasa:"
        '
        'txtIdClasa
        '
        Me.txtIdClasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdClasa.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.txtIdClasa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtIdClasa.Location = New System.Drawing.Point(77, 110)
        Me.txtIdClasa.Name = "txtIdClasa"
        Me.txtIdClasa.Size = New System.Drawing.Size(469, 28)
        Me.txtIdClasa.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(77, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Durata:"
        '
        'txtNume
        '
        Me.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNume.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.txtNume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtNume.Location = New System.Drawing.Point(77, 344)
        Me.txtNume.Name = "txtNume"
        Me.txtNume.Size = New System.Drawing.Size(469, 28)
        Me.txtNume.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(77, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nume:"
        '
        'ANTRENORTableAdapter
        '
        Me.ANTRENORTableAdapter.ClearBeforeFill = True
        '
        'AddClasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 794)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddClasa"
        Me.Text = "AddClasa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ANTRENORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimeDurata As DateTimePicker
    Friend WithEvents ComboBoxIdAntr As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSalveaza As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdClasa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNume As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents ANTRENORBindingSource As BindingSource
    Friend WithEvents ANTRENORTableAdapter As SALA_DE_FITNESSDataSetTableAdapters.ANTRENORTableAdapter
End Class

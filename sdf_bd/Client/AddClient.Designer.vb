<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClient
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
        Me.ComboIDTr = New System.Windows.Forms.ComboBox()
        Me.txtPrenume = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSalveaza = New System.Windows.Forms.Button()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNume = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SALA_DE_FITNESSDataSet = New sdf_bd.SALA_DE_FITNESSDataSet()
        Me.TRANZACTIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRANZACTIETableAdapter = New sdf_bd.SALA_DE_FITNESSDataSetTableAdapters.TRANZACTIETableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANZACTIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
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
        Me.Panel2.Controls.Add(Me.ComboIDTr)
        Me.Panel2.Controls.Add(Me.txtPrenume)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnSalveaza)
        Me.Panel2.Controls.Add(Me.txtTelefon)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtNume)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(26, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(620, 628)
        Me.Panel2.TabIndex = 2
        '
        'ComboIDTr
        '
        Me.ComboIDTr.DataSource = Me.TRANZACTIEBindingSource
        Me.ComboIDTr.DisplayMember = "ID_TRANZACTIE"
        Me.ComboIDTr.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.ComboIDTr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ComboIDTr.FormattingEnabled = True
        Me.ComboIDTr.Location = New System.Drawing.Point(77, 74)
        Me.ComboIDTr.Name = "ComboIDTr"
        Me.ComboIDTr.Size = New System.Drawing.Size(469, 30)
        Me.ComboIDTr.TabIndex = 15
        Me.ComboIDTr.ValueMember = "ID_TRANZACTIE"
        '
        'txtPrenume
        '
        Me.txtPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrenume.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.txtPrenume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtPrenume.Location = New System.Drawing.Point(77, 280)
        Me.txtPrenume.Name = "txtPrenume"
        Me.txtPrenume.Size = New System.Drawing.Size(469, 28)
        Me.txtPrenume.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(77, 380)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(469, 28)
        Me.txtEmail.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(77, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 22)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "E-Mail:"
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
        'txtTelefon
        '
        Me.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefon.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.txtTelefon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtTelefon.Location = New System.Drawing.Point(77, 480)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(469, 28)
        Me.txtTelefon.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(77, 433)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Telefon:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(77, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Prenume:"
        '
        'txtNume
        '
        Me.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNume.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.txtNume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtNume.Location = New System.Drawing.Point(77, 180)
        Me.txtNume.Name = "txtNume"
        Me.txtNume.Size = New System.Drawing.Size(469, 28)
        Me.txtNume.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(77, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nume:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(77, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Tranzactie:"
        '
        'SALA_DE_FITNESSDataSet
        '
        Me.SALA_DE_FITNESSDataSet.DataSetName = "SALA_DE_FITNESSDataSet"
        Me.SALA_DE_FITNESSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TRANZACTIEBindingSource
        '
        Me.TRANZACTIEBindingSource.DataMember = "TRANZACTIE"
        Me.TRANZACTIEBindingSource.DataSource = Me.SALA_DE_FITNESSDataSet
        '
        'TRANZACTIETableAdapter
        '
        Me.TRANZACTIETableAdapter.ClearBeforeFill = True
        '
        'AddClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 794)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddClient"
        Me.Text = "AddClient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SALA_DE_FITNESSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANZACTIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSalveaza As Button
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNume As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrenume As TextBox
    Friend WithEvents ComboIDTr As ComboBox
    Friend WithEvents SALA_DE_FITNESSDataSet As SALA_DE_FITNESSDataSet
    Friend WithEvents TRANZACTIEBindingSource As BindingSource
    Friend WithEvents TRANZACTIETableAdapter As SALA_DE_FITNESSDataSetTableAdapters.TRANZACTIETableAdapter
End Class

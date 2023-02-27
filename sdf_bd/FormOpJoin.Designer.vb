<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOpJoin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewJoin = New System.Windows.Forms.DataGridView()
        Me.Nume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipAbonament = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Durata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataInceput = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewJoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 20.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(819, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLIENTII CARE AU ABONAMENT ""GOLD"" ACTIV"
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
        'DataGridViewJoin
        '
        Me.DataGridViewJoin.AllowUserToAddRows = False
        Me.DataGridViewJoin.AllowUserToDeleteRows = False
        Me.DataGridViewJoin.AllowUserToOrderColumns = True
        Me.DataGridViewJoin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewJoin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewJoin.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJoin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nume, Me.Prenume, Me.TipAbonament, Me.Durata, Me.DataInceput})
        Me.DataGridViewJoin.Location = New System.Drawing.Point(25, 40)
        Me.DataGridViewJoin.Name = "DataGridViewJoin"
        Me.DataGridViewJoin.ReadOnly = True
        Me.DataGridViewJoin.RowHeadersWidth = 51
        Me.DataGridViewJoin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewJoin.RowTemplate.Height = 24
        Me.DataGridViewJoin.ShowEditingIcon = False
        Me.DataGridViewJoin.Size = New System.Drawing.Size(834, 440)
        Me.DataGridViewJoin.TabIndex = 0
        '
        'Nume
        '
        Me.Nume.DataPropertyName = "NUME"
        Me.Nume.HeaderText = "Nume"
        Me.Nume.MinimumWidth = 6
        Me.Nume.Name = "Nume"
        Me.Nume.ReadOnly = True
        '
        'Prenume
        '
        Me.Prenume.DataPropertyName = "PRENUME"
        Me.Prenume.HeaderText = "Prenume"
        Me.Prenume.MinimumWidth = 6
        Me.Prenume.Name = "Prenume"
        Me.Prenume.ReadOnly = True
        '
        'TipAbonament
        '
        Me.TipAbonament.DataPropertyName = "TIP_ABONAMENT"
        Me.TipAbonament.HeaderText = "Tip Abonament"
        Me.TipAbonament.MinimumWidth = 6
        Me.TipAbonament.Name = "TipAbonament"
        Me.TipAbonament.ReadOnly = True
        '
        'Durata
        '
        Me.Durata.DataPropertyName = "DURATA"
        Me.Durata.HeaderText = "Durata"
        Me.Durata.MinimumWidth = 6
        Me.Durata.Name = "Durata"
        Me.Durata.ReadOnly = True
        '
        'DataInceput
        '
        Me.DataInceput.DataPropertyName = "DATA_INCEPUT"
        Me.DataInceput.HeaderText = "Data Inceput"
        Me.DataInceput.MinimumWidth = 6
        Me.DataInceput.Name = "DataInceput"
        Me.DataInceput.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DataGridViewJoin)
        Me.Panel2.Location = New System.Drawing.Point(61, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 511)
        Me.Panel2.TabIndex = 2
        '
        'FormOpJoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormOpJoin"
        Me.Text = "FormOpJoin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewJoin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewJoin As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Nume As DataGridViewTextBoxColumn
    Friend WithEvents Prenume As DataGridViewTextBoxColumn
    Friend WithEvents TipAbonament As DataGridViewTextBoxColumn
    Friend WithEvents Durata As DataGridViewTextBoxColumn
    Friend WithEvents DataInceput As DataGridViewTextBoxColumn
End Class

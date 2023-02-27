<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAbonament
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckPiscina = New System.Windows.Forms.CheckBox()
        Me.CheckSpa = New System.Windows.Forms.CheckBox()
        Me.CheckSauna = New System.Windows.Forms.CheckBox()
        Me.NumericDurata = New System.Windows.Forms.NumericUpDown()
        Me.NumericPret = New System.Windows.Forms.NumericUpDown()
        Me.btnSalveaza = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericDurata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericPret, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Controls.Add(Me.CheckPiscina)
        Me.Panel2.Controls.Add(Me.CheckSpa)
        Me.Panel2.Controls.Add(Me.CheckSauna)
        Me.Panel2.Controls.Add(Me.NumericDurata)
        Me.Panel2.Controls.Add(Me.NumericPret)
        Me.Panel2.Controls.Add(Me.btnSalveaza)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtTip)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(24, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(620, 628)
        Me.Panel2.TabIndex = 2
        '
        'CheckPiscina
        '
        Me.CheckPiscina.AutoSize = True
        Me.CheckPiscina.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.CheckPiscina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CheckPiscina.Location = New System.Drawing.Point(77, 449)
        Me.CheckPiscina.Name = "CheckPiscina"
        Me.CheckPiscina.Size = New System.Drawing.Size(86, 26)
        Me.CheckPiscina.TabIndex = 15
        Me.CheckPiscina.Text = "Piscina"
        Me.CheckPiscina.UseVisualStyleBackColor = True
        '
        'CheckSpa
        '
        Me.CheckSpa.AutoSize = True
        Me.CheckSpa.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.CheckSpa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CheckSpa.Location = New System.Drawing.Point(77, 401)
        Me.CheckSpa.Name = "CheckSpa"
        Me.CheckSpa.Size = New System.Drawing.Size(60, 26)
        Me.CheckSpa.TabIndex = 14
        Me.CheckSpa.Text = "Spa"
        Me.CheckSpa.UseVisualStyleBackColor = True
        '
        'CheckSauna
        '
        Me.CheckSauna.AutoSize = True
        Me.CheckSauna.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.CheckSauna.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CheckSauna.Location = New System.Drawing.Point(77, 353)
        Me.CheckSauna.Name = "CheckSauna"
        Me.CheckSauna.Size = New System.Drawing.Size(79, 26)
        Me.CheckSauna.TabIndex = 13
        Me.CheckSauna.Text = "Sauna"
        Me.CheckSauna.UseVisualStyleBackColor = True
        '
        'NumericDurata
        '
        Me.NumericDurata.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.NumericDurata.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.NumericDurata.Location = New System.Drawing.Point(77, 259)
        Me.NumericDurata.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.NumericDurata.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericDurata.Name = "NumericDurata"
        Me.NumericDurata.Size = New System.Drawing.Size(469, 28)
        Me.NumericDurata.TabIndex = 12
        Me.NumericDurata.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericPret
        '
        Me.NumericPret.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.NumericPret.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.NumericPret.Location = New System.Drawing.Point(77, 165)
        Me.NumericPret.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericPret.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericPret.Name = "NumericPret"
        Me.NumericPret.Size = New System.Drawing.Size(469, 28)
        Me.NumericPret.TabIndex = 11
        Me.NumericPret.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.Label5.Location = New System.Drawing.Point(77, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sauna:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(77, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Durata:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(77, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pret:"
        '
        'txtTip
        '
        Me.txtTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTip.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.txtTip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.txtTip.Location = New System.Drawing.Point(77, 71)
        Me.txtTip.Name = "txtTip"
        Me.txtTip.Size = New System.Drawing.Size(469, 28)
        Me.txtTip.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(77, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tip Abonament:"
        '
        'AddAbonament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 794)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddAbonament"
        Me.Text = "AddAbonament"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericDurata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericPret, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSalveaza As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTip As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckPiscina As CheckBox
    Friend WithEvents CheckSpa As CheckBox
    Friend WithEvents CheckSauna As CheckBox
    Friend WithEvents NumericDurata As NumericUpDown
    Friend WithEvents NumericPret As NumericUpDown
End Class

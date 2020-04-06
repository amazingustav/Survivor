<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pgto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pgto))
        Me.rdbCartao = New System.Windows.Forms.RadioButton()
        Me.rdbDinheiro = New System.Windows.Forms.RadioButton()
        Me.rdbVisa = New System.Windows.Forms.RadioButton()
        Me.rdbMastercard = New System.Windows.Forms.RadioButton()
        Me.rdbDriversClub = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.PictureBox()
        Me.btnEND = New System.Windows.Forms.PictureBox()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.txtParcelas = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbxFinalizar = New System.Windows.Forms.PictureBox()
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbxFinalizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbCartao
        '
        Me.rdbCartao.AutoSize = True
        Me.rdbCartao.BackColor = System.Drawing.Color.Transparent
        Me.rdbCartao.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCartao.Location = New System.Drawing.Point(227, 10)
        Me.rdbCartao.Name = "rdbCartao"
        Me.rdbCartao.Size = New System.Drawing.Size(14, 13)
        Me.rdbCartao.TabIndex = 1
        Me.rdbCartao.TabStop = True
        Me.rdbCartao.UseVisualStyleBackColor = False
        '
        'rdbDinheiro
        '
        Me.rdbDinheiro.AutoSize = True
        Me.rdbDinheiro.BackColor = System.Drawing.Color.Transparent
        Me.rdbDinheiro.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDinheiro.Location = New System.Drawing.Point(6, 10)
        Me.rdbDinheiro.Name = "rdbDinheiro"
        Me.rdbDinheiro.Size = New System.Drawing.Size(14, 13)
        Me.rdbDinheiro.TabIndex = 2
        Me.rdbDinheiro.TabStop = True
        Me.rdbDinheiro.UseVisualStyleBackColor = False
        '
        'rdbVisa
        '
        Me.rdbVisa.AutoSize = True
        Me.rdbVisa.BackColor = System.Drawing.Color.Transparent
        Me.rdbVisa.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbVisa.Location = New System.Drawing.Point(9, 8)
        Me.rdbVisa.Name = "rdbVisa"
        Me.rdbVisa.Size = New System.Drawing.Size(14, 13)
        Me.rdbVisa.TabIndex = 4
        Me.rdbVisa.TabStop = True
        Me.rdbVisa.UseVisualStyleBackColor = False
        Me.rdbVisa.Visible = False
        '
        'rdbMastercard
        '
        Me.rdbMastercard.AutoSize = True
        Me.rdbMastercard.BackColor = System.Drawing.Color.Transparent
        Me.rdbMastercard.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMastercard.Location = New System.Drawing.Point(9, 74)
        Me.rdbMastercard.Name = "rdbMastercard"
        Me.rdbMastercard.Size = New System.Drawing.Size(14, 13)
        Me.rdbMastercard.TabIndex = 5
        Me.rdbMastercard.TabStop = True
        Me.rdbMastercard.UseVisualStyleBackColor = False
        Me.rdbMastercard.Visible = False
        '
        'rdbDriversClub
        '
        Me.rdbDriversClub.AutoSize = True
        Me.rdbDriversClub.BackColor = System.Drawing.Color.Transparent
        Me.rdbDriversClub.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDriversClub.Location = New System.Drawing.Point(9, 39)
        Me.rdbDriversClub.Name = "rdbDriversClub"
        Me.rdbDriversClub.Size = New System.Drawing.Size(14, 13)
        Me.rdbDriversClub.TabIndex = 8
        Me.rdbDriversClub.TabStop = True
        Me.rdbDriversClub.UseVisualStyleBackColor = False
        Me.rdbDriversClub.Visible = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Location = New System.Drawing.Point(287, 289)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(69, 100)
        Me.btnOK.TabIndex = 107
        Me.btnOK.TabStop = False
        '
        'btnEND
        '
        Me.btnEND.BackColor = System.Drawing.Color.Transparent
        Me.btnEND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEND.Location = New System.Drawing.Point(621, 10)
        Me.btnEND.Name = "btnEND"
        Me.btnEND.Size = New System.Drawing.Size(22, 22)
        Me.btnEND.TabIndex = 108
        Me.btnEND.TabStop = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnHelp.Location = New System.Drawing.Point(597, 10)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(22, 22)
        Me.btnHelp.TabIndex = 109
        Me.btnHelp.TabStop = False
        '
        'txtParcelas
        '
        Me.txtParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtParcelas.Enabled = False
        Me.txtParcelas.Location = New System.Drawing.Point(498, 271)
        Me.txtParcelas.Name = "txtParcelas"
        Me.txtParcelas.Size = New System.Drawing.Size(121, 13)
        Me.txtParcelas.TabIndex = 110
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.rdbCartao)
        Me.Panel1.Controls.Add(Me.rdbDinheiro)
        Me.Panel1.Location = New System.Drawing.Point(174, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 41)
        Me.Panel1.TabIndex = 111
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.rdbDriversClub)
        Me.Panel2.Controls.Add(Me.rdbMastercard)
        Me.Panel2.Controls.Add(Me.rdbVisa)
        Me.Panel2.Location = New System.Drawing.Point(464, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(38, 103)
        Me.Panel2.TabIndex = 112
        '
        'pbxFinalizar
        '
        Me.pbxFinalizar.BackColor = System.Drawing.Color.Transparent
        Me.pbxFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxFinalizar.Image = CType(resources.GetObject("pbxFinalizar.Image"), System.Drawing.Image)
        Me.pbxFinalizar.Location = New System.Drawing.Point(271, 237)
        Me.pbxFinalizar.Name = "pbxFinalizar"
        Me.pbxFinalizar.Size = New System.Drawing.Size(128, 63)
        Me.pbxFinalizar.TabIndex = 113
        Me.pbxFinalizar.TabStop = False
        Me.pbxFinalizar.Visible = False
        '
        'Pgto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 503)
        Me.Controls.Add(Me.pbxFinalizar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtParcelas)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnEND)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pgto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forma de Pagamento"
        Me.TopMost = True
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbxFinalizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbCartao As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDinheiro As System.Windows.Forms.RadioButton
    Friend WithEvents rdbVisa As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMastercard As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDriversClub As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.PictureBox
    Friend WithEvents btnEND As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelp As System.Windows.Forms.PictureBox
    Friend WithEvents txtParcelas As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pbxFinalizar As System.Windows.Forms.PictureBox
End Class

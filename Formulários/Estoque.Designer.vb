<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estoque
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estoque))
        Me.txtNomeLivro = New System.Windows.Forms.TextBox
        Me.mskData = New System.Windows.Forms.MaskedTextBox
        Me.txtAno = New System.Windows.Forms.TextBox
        Me.txtMes = New System.Windows.Forms.TextBox
        Me.rdbAnual = New System.Windows.Forms.RadioButton
        Me.rdbMensal = New System.Windows.Forms.RadioButton
        Me.rdbDiario = New System.Windows.Forms.RadioButton
        Me.lblStatus = New System.Windows.Forms.Label
        Me.dtgEstoque = New System.Windows.Forms.DataGridView
        Me.btnPesquisaLivro = New System.Windows.Forms.PictureBox
        Me.btnPesquisaData = New System.Windows.Forms.PictureBox
        Me.pbxPesquisar1 = New System.Windows.Forms.PictureBox
        CType(Me.dtgEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisaLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisaData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomeLivro
        '
        Me.txtNomeLivro.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNomeLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeLivro.Location = New System.Drawing.Point(83, 134)
        Me.txtNomeLivro.Name = "txtNomeLivro"
        Me.txtNomeLivro.Size = New System.Drawing.Size(191, 13)
        Me.txtNomeLivro.TabIndex = 98
        '
        'mskData
        '
        Me.mskData.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.mskData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskData.Location = New System.Drawing.Point(499, 114)
        Me.mskData.Mask = "00/00/0000"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(75, 13)
        Me.mskData.TabIndex = 100
        '
        'txtAno
        '
        Me.txtAno.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAno.Location = New System.Drawing.Point(499, 159)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(75, 13)
        Me.txtAno.TabIndex = 99
        '
        'txtMes
        '
        Me.txtMes.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtMes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMes.Location = New System.Drawing.Point(499, 136)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(75, 13)
        Me.txtMes.TabIndex = 97
        '
        'rdbAnual
        '
        Me.rdbAnual.AutoSize = True
        Me.rdbAnual.Location = New System.Drawing.Point(363, 159)
        Me.rdbAnual.Name = "rdbAnual"
        Me.rdbAnual.Size = New System.Drawing.Size(14, 13)
        Me.rdbAnual.TabIndex = 3
        Me.rdbAnual.TabStop = True
        Me.rdbAnual.UseVisualStyleBackColor = True
        '
        'rdbMensal
        '
        Me.rdbMensal.AutoSize = True
        Me.rdbMensal.Location = New System.Drawing.Point(363, 135)
        Me.rdbMensal.Name = "rdbMensal"
        Me.rdbMensal.Size = New System.Drawing.Size(14, 13)
        Me.rdbMensal.TabIndex = 2
        Me.rdbMensal.TabStop = True
        Me.rdbMensal.UseVisualStyleBackColor = True
        '
        'rdbDiario
        '
        Me.rdbDiario.AutoSize = True
        Me.rdbDiario.Location = New System.Drawing.Point(363, 112)
        Me.rdbDiario.Name = "rdbDiario"
        Me.rdbDiario.Size = New System.Drawing.Size(14, 13)
        Me.rdbDiario.TabIndex = 0
        Me.rdbDiario.TabStop = True
        Me.rdbDiario.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblStatus.Location = New System.Drawing.Point(341, 30)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(46, 23)
        Me.lblStatus.TabIndex = 105
        Me.lblStatus.Text = "000"
        '
        'dtgEstoque
        '
        Me.dtgEstoque.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgEstoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEstoque.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dtgEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgEstoque.Location = New System.Drawing.Point(35, 238)
        Me.dtgEstoque.Name = "dtgEstoque"
        Me.dtgEstoque.Size = New System.Drawing.Size(573, 190)
        Me.dtgEstoque.TabIndex = 6
        '
        'btnPesquisaLivro
        '
        Me.btnPesquisaLivro.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaLivro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaLivro.Location = New System.Drawing.Point(288, 114)
        Me.btnPesquisaLivro.Name = "btnPesquisaLivro"
        Me.btnPesquisaLivro.Size = New System.Drawing.Size(45, 50)
        Me.btnPesquisaLivro.TabIndex = 121
        Me.btnPesquisaLivro.TabStop = False
        '
        'btnPesquisaData
        '
        Me.btnPesquisaData.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaData.Location = New System.Drawing.Point(597, 112)
        Me.btnPesquisaData.Name = "btnPesquisaData"
        Me.btnPesquisaData.Size = New System.Drawing.Size(45, 50)
        Me.btnPesquisaData.TabIndex = 122
        Me.btnPesquisaData.TabStop = False
        '
        'pbxPesquisar1
        '
        Me.pbxPesquisar1.AccessibleDescription = " "
        Me.pbxPesquisar1.BackColor = System.Drawing.Color.Transparent
        Me.pbxPesquisar1.Enabled = False
        Me.pbxPesquisar1.Image = CType(resources.GetObject("pbxPesquisar1.Image"), System.Drawing.Image)
        Me.pbxPesquisar1.Location = New System.Drawing.Point(304, 128)
        Me.pbxPesquisar1.Name = "pbxPesquisar1"
        Me.pbxPesquisar1.Size = New System.Drawing.Size(113, 44)
        Me.pbxPesquisar1.TabIndex = 128
        Me.pbxPesquisar1.TabStop = False
        Me.pbxPesquisar1.Visible = False
        '
        'Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(666, 503)
        Me.Controls.Add(Me.pbxPesquisar1)
        Me.Controls.Add(Me.btnPesquisaData)
        Me.Controls.Add(Me.btnPesquisaLivro)
        Me.Controls.Add(Me.dtgEstoque)
        Me.Controls.Add(Me.txtNomeLivro)
        Me.Controls.Add(Me.mskData)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.rdbAnual)
        Me.Controls.Add(Me.rdbMensal)
        Me.Controls.Add(Me.rdbDiario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque"
        Me.TopMost = True
        CType(Me.dtgEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisaLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisaData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomeLivro As System.Windows.Forms.TextBox
    Friend WithEvents mskData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents rdbAnual As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMensal As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDiario As System.Windows.Forms.RadioButton
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents dtgEstoque As System.Windows.Forms.DataGridView
    Friend WithEvents btnPesquisaLivro As System.Windows.Forms.PictureBox
    Friend WithEvents btnPesquisaData As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPesquisar1 As System.Windows.Forms.PictureBox
End Class

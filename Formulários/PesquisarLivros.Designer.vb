<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisarLivros
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PesquisarLivros))
        Me.dtgLivro = New System.Windows.Forms.DataGridView()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.btnPesquisar = New System.Windows.Forms.PictureBox()
        Me.cboPesquisa = New System.Windows.Forms.TextBox()
        Me.pbxPesquisar = New System.Windows.Forms.PictureBox()
        CType(Me.dtgLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgLivro
        '
        Me.dtgLivro.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtgLivro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgLivro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgLivro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgLivro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLivro.Cursor = System.Windows.Forms.Cursors.Cross
        Me.dtgLivro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgLivro.Location = New System.Drawing.Point(34, 72)
        Me.dtgLivro.Name = "dtgLivro"
        Me.dtgLivro.Size = New System.Drawing.Size(573, 127)
        Me.dtgLivro.TabIndex = 12
        '
        'txtPesquisar
        '
        Me.txtPesquisar.BackColor = System.Drawing.Color.Silver
        Me.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisar.Location = New System.Drawing.Point(280, 40)
        Me.txtPesquisar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(226, 13)
        Me.txtPesquisar.TabIndex = 2
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.Location = New System.Drawing.Point(528, 30)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(47, 37)
        Me.btnPesquisar.TabIndex = 92
        Me.btnPesquisar.TabStop = False
        '
        'cboPesquisa
        '
        Me.cboPesquisa.AutoCompleteCustomSource.AddRange(New String() {"Título", "Autor", "Editora", "Gênero", "ISBN"})
        Me.cboPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPesquisa.BackColor = System.Drawing.Color.Silver
        Me.cboPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cboPesquisa.Location = New System.Drawing.Point(101, 40)
        Me.cboPesquisa.Name = "cboPesquisa"
        Me.cboPesquisa.Size = New System.Drawing.Size(133, 13)
        Me.cboPesquisa.TabIndex = 1
        '
        'pbxPesquisar
        '
        Me.pbxPesquisar.AccessibleDescription = " "
        Me.pbxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.pbxPesquisar.Enabled = False
        Me.pbxPesquisar.Image = CType(resources.GetObject("pbxPesquisar.Image"), System.Drawing.Image)
        Me.pbxPesquisar.Location = New System.Drawing.Point(501, -5)
        Me.pbxPesquisar.Name = "pbxPesquisar"
        Me.pbxPesquisar.Size = New System.Drawing.Size(148, 58)
        Me.pbxPesquisar.TabIndex = 97
        Me.pbxPesquisar.TabStop = False
        Me.pbxPesquisar.Visible = False
        '
        'PesquisarLivros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(646, 479)
        Me.Controls.Add(Me.pbxPesquisar)
        Me.Controls.Add(Me.cboPesquisa)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Controls.Add(Me.dtgLivro)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PesquisarLivros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        CType(Me.dtgLivro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgLivro As System.Windows.Forms.DataGridView
    Friend WithEvents txtPesquisar As System.Windows.Forms.TextBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.PictureBox
    Friend WithEvents cboPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents pbxPesquisar As System.Windows.Forms.PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnEntrar = New System.Windows.Forms.PictureBox()
        Me.btnSair = New System.Windows.Forms.PictureBox()
        Me.pbxAjuda = New System.Windows.Forms.PictureBox()
        CType(Me.btnEntrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAjuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.Silver
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(478, 341)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(136, 19)
        Me.txtUsuario.TabIndex = 4
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.Silver
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(478, 380)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtSenha.Size = New System.Drawing.Size(136, 19)
        Me.txtSenha.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.Location = New System.Drawing.Point(377, 429)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(126, 33)
        Me.btnEntrar.TabIndex = 17
        Me.btnEntrar.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Transparent
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Location = New System.Drawing.Point(548, 426)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(126, 33)
        Me.btnSair.TabIndex = 18
        Me.btnSair.TabStop = False
        '
        'pbxAjuda
        '
        Me.pbxAjuda.BackColor = System.Drawing.Color.Transparent
        Me.pbxAjuda.BackgroundImage = CType(resources.GetObject("pbxAjuda.BackgroundImage"), System.Drawing.Image)
        Me.pbxAjuda.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pbxAjuda.Enabled = False
        Me.pbxAjuda.Location = New System.Drawing.Point(1137, 157)
        Me.pbxAjuda.Name = "pbxAjuda"
        Me.pbxAjuda.Size = New System.Drawing.Size(104, 128)
        Me.pbxAjuda.TabIndex = 109
        Me.pbxAjuda.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1071, 701)
        Me.Controls.Add(Me.pbxAjuda)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtSenha)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.btnEntrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAjuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnEntrar As System.Windows.Forms.PictureBox
    Friend WithEvents btnSair As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAjuda As System.Windows.Forms.PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
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

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        EmailCadastrar = New MaskedTextBox()
        SenhaCadastrar = New MaskedTextBox()
        ConfirmarSenhaCadastrar = New MaskedTextBox()
        Button1 = New Button()
        LinkLogin = New LinkLabel()
        Label5 = New Label()
        ToolTip1 = New ToolTip(components)
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(304, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 18)
        Label1.TabIndex = 0
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(297, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 18)
        Label2.TabIndex = 1
        Label2.Text = "Senha:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(258, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 18)
        Label3.TabIndex = 2
        Label3.Text = "Confirmar Senha:"
        ' 
        ' EmailCadastrar
        ' 
        EmailCadastrar.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        EmailCadastrar.Location = New Point(176, 94)
        EmailCadastrar.Margin = New Padding(3, 4, 3, 4)
        EmailCadastrar.Name = "EmailCadastrar"
        EmailCadastrar.Size = New Size(300, 26)
        EmailCadastrar.TabIndex = 3
        ' 
        ' SenhaCadastrar
        ' 
        SenhaCadastrar.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        SenhaCadastrar.Location = New Point(215, 157)
        SenhaCadastrar.Margin = New Padding(3, 4, 3, 4)
        SenhaCadastrar.Name = "SenhaCadastrar"
        SenhaCadastrar.PasswordChar = "*"c
        SenhaCadastrar.Size = New Size(217, 26)
        SenhaCadastrar.TabIndex = 4
        ' 
        ' ConfirmarSenhaCadastrar
        ' 
        ConfirmarSenhaCadastrar.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        ConfirmarSenhaCadastrar.Location = New Point(215, 216)
        ConfirmarSenhaCadastrar.Margin = New Padding(3, 4, 3, 4)
        ConfirmarSenhaCadastrar.Name = "ConfirmarSenhaCadastrar"
        ConfirmarSenhaCadastrar.PasswordChar = "*"c
        ConfirmarSenhaCadastrar.Size = New Size(217, 26)
        ConfirmarSenhaCadastrar.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(258, 260)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 39)
        Button1.TabIndex = 7
        Button1.Text = "Cadastrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLogin
        ' 
        LinkLogin.AutoSize = True
        LinkLogin.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLogin.Location = New Point(270, 332)
        LinkLogin.Name = "LinkLogin"
        LinkLogin.Size = New Size(109, 21)
        LinkLogin.TabIndex = 8
        LinkLogin.TabStop = True
        LinkLogin.Text = "Fazer Login"
        LinkLogin.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(241, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 18)
        Label5.TabIndex = 9
        Label5.Text = "Já possui uma conta?"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(354, 16)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(247, 117)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(EmailCadastrar)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(LinkLogin)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(SenhaCadastrar)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(ConfirmarSenhaCadastrar)
        GroupBox1.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(169, 141)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(616, 369)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cadastrar"
        ' 
        ' Cadastro
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(914, 600)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Cadastro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastrar - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLogin As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents EmailCadastrar As MaskedTextBox
    Friend WithEvents SenhaCadastrar As MaskedTextBox
    Friend WithEvents ConfirmarSenhaCadastrar As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaInicial))
        MenuStrip1 = New MenuStrip()
        UsuarioToolStripMenuItem = New ToolStripMenuItem()
        CadastrarDadosToolStripMenuItem = New ToolStripMenuItem()
        EditarSenharToolStripMenuItem = New ToolStripMenuItem()
        SairToolStripMenuItem = New ToolStripMenuItem()
        TreinoToolStripMenuItem = New ToolStripMenuItem()
        GerenciadorDeTreinosToolStripMenuItem = New ToolStripMenuItem()
        MeusTreinosToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        meustreinosbtn = New Button()
        cadastrobtn = New Button()
        montartreinobtn = New Button()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.SlateBlue
        MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), Image)
        MenuStrip1.Font = New Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {UsuarioToolStripMenuItem, TreinoToolStripMenuItem, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(914, 32)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' UsuarioToolStripMenuItem
        ' 
        UsuarioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CadastrarDadosToolStripMenuItem, EditarSenharToolStripMenuItem, SairToolStripMenuItem})
        UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        UsuarioToolStripMenuItem.Size = New Size(83, 26)
        UsuarioToolStripMenuItem.Text = "&Usuário"
        ' 
        ' CadastrarDadosToolStripMenuItem
        ' 
        CadastrarDadosToolStripMenuItem.Name = "CadastrarDadosToolStripMenuItem"
        CadastrarDadosToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F1
        CadastrarDadosToolStripMenuItem.Size = New Size(290, 26)
        CadastrarDadosToolStripMenuItem.Text = "&Cadastrar dados"
        ' 
        ' EditarSenharToolStripMenuItem
        ' 
        EditarSenharToolStripMenuItem.Name = "EditarSenharToolStripMenuItem"
        EditarSenharToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F2
        EditarSenharToolStripMenuItem.Size = New Size(290, 26)
        EditarSenharToolStripMenuItem.Text = "&Editar Senha"
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        SairToolStripMenuItem.Size = New Size(290, 26)
        SairToolStripMenuItem.Text = "&Sair"
        ' 
        ' TreinoToolStripMenuItem
        ' 
        TreinoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GerenciadorDeTreinosToolStripMenuItem, MeusTreinosToolStripMenuItem})
        TreinoToolStripMenuItem.Name = "TreinoToolStripMenuItem"
        TreinoToolStripMenuItem.Size = New Size(74, 26)
        TreinoToolStripMenuItem.Text = "&Treino"
        ' 
        ' GerenciadorDeTreinosToolStripMenuItem
        ' 
        GerenciadorDeTreinosToolStripMenuItem.Name = "GerenciadorDeTreinosToolStripMenuItem"
        GerenciadorDeTreinosToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.G
        GerenciadorDeTreinosToolStripMenuItem.Size = New Size(338, 26)
        GerenciadorDeTreinosToolStripMenuItem.Text = "&Gerenciador de Treinos"
        ' 
        ' MeusTreinosToolStripMenuItem
        ' 
        MeusTreinosToolStripMenuItem.Name = "MeusTreinosToolStripMenuItem"
        MeusTreinosToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.T
        MeusTreinosToolStripMenuItem.Size = New Size(338, 26)
        MeusTreinosToolStripMenuItem.Text = "&Meus Treinos"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(69, 26)
        ToolStripMenuItem1.Text = "&Sobre"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(306, 36)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(384, 165)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(meustreinosbtn)
        GroupBox1.Controls.Add(cadastrobtn)
        GroupBox1.Controls.Add(montartreinobtn)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(306, 180)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(384, 391)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(93, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 29)
        Label2.TabIndex = 5
        Label2.Text = "Selecione uma Opção:"
        ' 
        ' meustreinosbtn
        ' 
        meustreinosbtn.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        meustreinosbtn.Location = New Point(112, 331)
        meustreinosbtn.Margin = New Padding(3, 4, 3, 4)
        meustreinosbtn.Name = "meustreinosbtn"
        meustreinosbtn.Size = New Size(160, 31)
        meustreinosbtn.TabIndex = 4
        meustreinosbtn.Text = "Meus Treinos"
        meustreinosbtn.UseVisualStyleBackColor = True
        ' 
        ' cadastrobtn
        ' 
        cadastrobtn.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cadastrobtn.Location = New Point(112, 252)
        cadastrobtn.Margin = New Padding(3, 4, 3, 4)
        cadastrobtn.Name = "cadastrobtn"
        cadastrobtn.Size = New Size(160, 31)
        cadastrobtn.TabIndex = 3
        cadastrobtn.Text = "Cadastro"
        cadastrobtn.UseVisualStyleBackColor = True
        ' 
        ' montartreinobtn
        ' 
        montartreinobtn.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        montartreinobtn.Location = New Point(112, 291)
        montartreinobtn.Margin = New Padding(3, 4, 3, 4)
        montartreinobtn.Name = "montartreinobtn"
        montartreinobtn.Size = New Size(161, 32)
        montartreinobtn.TabIndex = 2
        montartreinobtn.Text = "Montar Treino"
        montartreinobtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(0, 29)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(377, 187)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(73, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 29)
        Label1.TabIndex = 0
        Label1.Text = "Bem vindo ao Projetinho"
        ' 
        ' TelaInicial
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(914, 600)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "TelaInicial"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bem vindo - Projetinho"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarDadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarSenharToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciadorDeTreinosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents montartreinobtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents meustreinosbtn As Button
    Friend WithEvents cadastrobtn As Button
    Friend WithEvents MeusTreinosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class

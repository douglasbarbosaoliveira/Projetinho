<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MeusTreinos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MeusTreinos))
        PictureBox1 = New PictureBox()
        DGV_Treinos = New DataGridView()
        Label1 = New Label()
        DataMeusTreinos = New DateTimePicker()
        PrintDocument1 = New Printing.PrintDocument()
        PictureBox2 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGV_Treinos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(275, 0)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(402, 213)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DGV_Treinos
        ' 
        DGV_Treinos.AllowUserToAddRows = False
        DGV_Treinos.AllowUserToDeleteRows = False
        DGV_Treinos.BackgroundColor = Color.MediumPurple
        DGV_Treinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Treinos.GridColor = Color.MediumPurple
        DGV_Treinos.Location = New Point(34, 295)
        DGV_Treinos.Margin = New Padding(3, 4, 3, 4)
        DGV_Treinos.Name = "DGV_Treinos"
        DGV_Treinos.ReadOnly = True
        DGV_Treinos.RowHeadersWidth = 51
        DGV_Treinos.RowTemplate.Height = 25
        DGV_Treinos.Size = New Size(866, 289)
        DGV_Treinos.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(402, 217)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 29)
        Label1.TabIndex = 2
        Label1.Text = "MEUS TREINOS"
        ' 
        ' DataMeusTreinos
        ' 
        DataMeusTreinos.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataMeusTreinos.Location = New Point(300, 250)
        DataMeusTreinos.Margin = New Padding(3, 4, 3, 4)
        DataMeusTreinos.Name = "DataMeusTreinos"
        DataMeusTreinos.Size = New Size(328, 26)
        DataMeusTreinos.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(836, 238)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 49)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = SystemColors.MenuHighlight
        LinkLabel1.Location = New Point(2, 9)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(63, 24)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Voltar"
        ' 
        ' MeusTreinos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(914, 600)
        Controls.Add(LinkLabel1)
        Controls.Add(PictureBox2)
        Controls.Add(DataMeusTreinos)
        Controls.Add(Label1)
        Controls.Add(DGV_Treinos)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "MeusTreinos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Meus treinos - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGV_Treinos, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGV_Treinos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DataMeusTreinos As DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class

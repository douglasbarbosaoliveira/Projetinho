<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sobre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sobre))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(240, 13)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(251, 132)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(148, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(411, 16)
        Label1.TabIndex = 9
        Label1.Text = "Projeto em .NET para criar treinos diários para usuários de academias"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(324, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 18)
        Label2.TabIndex = 10
        Label2.Text = "O que é?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(183, 377)
        Label3.Name = "Label3"
        Label3.Size = New Size(362, 18)
        Label3.TabIndex = 11
        Label3.Text = "Faculdade de Tecnologia de Mauá - FATEC Mauá"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(285, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(143, 18)
        Label4.TabIndex = 12
        Label4.Text = "Desenvolvido por:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(273, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(167, 16)
        Label5.TabIndex = 13
        Label5.Text = "Douglas Barbosa de Oliveira"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(272, 277)
        Label6.Name = "Label6"
        Label6.Size = New Size(169, 16)
        Label6.TabIndex = 14
        Label6.Text = "Luís Fernando França Farias"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(297, 305)
        Label7.Name = "Label7"
        Label7.Size = New Size(130, 16)
        Label7.TabIndex = 15
        Label7.Text = "Ryan Pereira da Mota"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(65, 340)
        Label8.Name = "Label8"
        Label8.Size = New Size(579, 18)
        Label8.TabIndex = 16
        Label8.Text = "Disciplina: Técnicas de Programação II - Professor: Humberto Luiz de Toledo"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(336, 409)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 18)
        Label9.TabIndex = 17
        Label9.Text = "2025"
        ' 
        ' Sobre
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(707, 459)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Sobre"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sobre - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class

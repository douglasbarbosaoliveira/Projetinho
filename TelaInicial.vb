Public Class TelaInicial
    Private Sub cadastrobtn_Click(sender As Object, e As EventArgs) Handles cadastrobtn.Click

        Dim novoForm As New Formulario()
        novoForm.Show()
        Me.Close()

    End Sub

    Private Sub montartreinobtn_Click(sender As Object, e As EventArgs) Handles montartreinobtn.Click
        sql = "Select * FROM DadosUsuario where Email = '" & EmailUsuario & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Dim novoForm As New Gerenciador_Treinos()
            novoForm.Show()
            Me.Close()
        Else
            MsgBox("Por Favor Cadastre Seus Dados Antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha Os Dados!")
        End If

    End Sub

    Private Sub meustreinosbtn_Click(sender As Object, e As EventArgs) Handles meustreinosbtn.Click
        sql = "Select * FROM DadosUsuario where Email = '" & EmailUsuario & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Dim novoForm As New MeusTreinos()
            novoForm.Show()
            Me.Close()
        Else
            MsgBox("Por Favor Cadastre Seus Dados Antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha Os Dados!")
        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CadastrarDadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarDadosToolStripMenuItem.Click
        Dim novoForm As New Formulario()
        novoForm.Show()
        Me.Close()
    End Sub

    Private Sub GerenciadorDeTreinosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciadorDeTreinosToolStripMenuItem.Click
        sql = "Select * FROM DadosUsuario where Email = '" & EmailUsuario & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Dim novoForm As New Gerenciador_Treinos()
            novoForm.Show()
            Me.Close()
        Else
            MsgBox("Por Favor Cadastre Seus Dados Antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha Os Dados!")
        End If
    End Sub

    Private Sub MeusTreinosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeusTreinosToolStripMenuItem.Click
        sql = "Select * FROM DadosUsuario where Email = '" & EmailUsuario & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Dim novoForm As New MeusTreinos()
            novoForm.Show()
            Me.Close()
        Else
            MsgBox("Por Favor Cadastre Seus Dados Antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha Os Dados!")
        End If
    End Sub

    Private Sub EditarSenharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarSenharToolStripMenuItem.Click
        Dim novoForm As New EditarSenha()
        novoForm.Show()
        Me.Close()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim janelaSobre As New Sobre()
        janelaSobre.ShowDialog()
    End Sub
End Class
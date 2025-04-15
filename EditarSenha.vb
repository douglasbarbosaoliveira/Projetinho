Public Class EditarSenha
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnatualizar.Click
        Try
            ConectarBanco()
            sql = "SELECT senha FROM login where Email = '" & EmailRecuperar.Text & "'"
            rs = db.Execute(sql)
            Dim senhaUsuario As String = rs("senha").Value.ToString()

            If SenhaAntigaRecuperar.Text = senhaUsuario Then
                sql = "UPDATE login SET senha = '" & NovaSenhaRecuperar.Text & "' WHERE Email = '" & EmailRecuperar.Text & "'"

                db.Execute(sql)
                Dim novoForm As New Login()
                novoForm.Show()
                Me.Hide()
                MsgBox("Senha Atualizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Por Favor Reconecte-se!")
            Else
                MsgBox("As senhas não coincidem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End If

        Catch ex As Exception
            MsgBox("Erro ao Cadastrar Nova Senha: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim novoForm As New TelaInicial()
        novoForm.Show()
        Me.Close()
    End Sub
End Class
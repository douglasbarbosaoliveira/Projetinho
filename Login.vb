Imports ADODB

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarBanco()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ConectarBanco()
            sql = "SELECT * FROM Login WHERE email = '" & EmailLoginBox.Text & "' AND senha = '" & SenhaLoginBox.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                MsgBox("Login efetuado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso!")
                Modulo_global.EmailUsuario = EmailLoginBox.Text
                Dim novoForm As New TelaInicial()
                novoForm.Show()
                Me.Hide()
                EmailLoginBox.Clear()
                SenhaLoginBox.Clear()
            Else
                MsgBox("E-mail ou senha incorretos. Tente novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro!")
            End If

        Catch ex As Exception
            MsgBox("Tente novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro!")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkCadastrar.LinkClicked

        Try
            Dim novoForm As New Cadastro()
            novoForm.Show()
            Me.Hide()
            EmailLoginBox.Clear()
            SenhaLoginBox.Clear()
        Catch ex As Exception
            MsgBox("Tente novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro!")
        End Try




    End Sub
End Class
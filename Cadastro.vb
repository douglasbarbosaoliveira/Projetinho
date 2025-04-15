Imports System.Windows
Imports ADODB


Public Class Cadastro


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ConectarBanco()
            If SenhaCadastrar.Text = ConfirmarSenhaCadastrar.Text Then
                sql = "Insert into login (Email, senha) Values ('" & EmailCadastrar.Text & "','" & SenhaCadastrar.Text & "')"
                db.Execute(sql)
                Dim novoForm As New Login()
                novoForm.Show()
                Me.Hide()
                MsgBox("Conta criada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso!")
            Else
                MsgBox("As senhas não coincidem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End If

        Catch ex As Exception
            MsgBox("Erro ao Cadastrar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim novoForm As New Formulario

        novoForm.Show()
        Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogin.LinkClicked
        Dim novoForm As New Login()
        novoForm.Show()
        Me.Hide()
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
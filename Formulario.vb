Imports ADODB

Public Class Formulario
    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = "SELECT * FROM DadosUsuario WHERE Email = '" & EmailUsuario & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                preenchido = True
                NomePerfil.Text = rs("Nome").Value.ToString()
                SexoPerfil.Text = rs("Sexo").Value.ToString()
                DateTimePerfil.Value = Convert.ToDateTime(rs("DataNasc").Value)
                AlturaPerfil.Text = rs("Altura").Value.ToString()
                PesoPerfil.Text = rs("Peso").Value.ToString()

                Dim caminhoImagem As String = rs("Imagem").Value.ToString()
                img_foto.Load(caminhoImagem)



                img_foto.Enabled = False
                NomePerfil.Enabled = False
                SexoPerfil.Enabled = False
                DateTimePerfil.Enabled = False
                AlturaPerfil.Enabled = False
                PesoPerfil.Enabled = False
                Button2.Enabled = False
            End If

        Catch ex As Exception


        End Try



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim altura As Double = Convert.ToDouble(AlturaPerfil.Text.Replace(",", "."))
            Dim peso As Double = Convert.ToDouble(PesoPerfil.Text.Replace(",", "."))

            If preenchido = False Then
                sql = "Insert Into DadosUsuario (Email,Nome,Sexo,DataNasc,Altura,Peso,Imagem) Values ('" & EmailUsuario & "','" & NomePerfil.Text & "','" & SexoPerfil.Text & "','" & DateTimePerfil.Value.ToString("yyyy-MM-dd") & "'," & altura & "," & peso & ",'" & diretorio & "')"
                rs = db.Execute(sql)
                MsgBox("Dados Cadastrados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso!")
                img_foto.Enabled = False
                NomePerfil.Enabled = False
                SexoPerfil.Enabled = False
                DateTimePerfil.Enabled = False
                AlturaPerfil.Enabled = False
                PesoPerfil.Enabled = False
                Button2.Enabled = False
            Else
                sql = "UPDATE DadosUsuario SET Nome='" & NomePerfil.Text & "', Sexo='" & SexoPerfil.Text & "', DataNasc='" & DateTimePerfil.Value.ToString("yyyy-MM-dd") & "', Altura=" & altura & ", Peso=" & peso & ", Imagem='" & diretorio & "' WHERE Email='" & EmailUsuario & "'"
                rs = db.Execute(sql)
                MsgBox("Dados Atualizados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso!")
                img_foto.Enabled = False
                NomePerfil.Enabled = False
                SexoPerfil.Enabled = False
                DateTimePerfil.Enabled = False
                AlturaPerfil.Enabled = False
                PesoPerfil.Enabled = False
                Button2.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao Cadastrar: " & ex.Message)
        End Try
    End Sub


    Private Sub AlturaPerfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AlturaPerfil.KeyPress
        ' Permite apenas números, vírgula, ponto e Backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If

        ' Evita digitar mais de um ponto ou vírgula
        If (e.KeyChar = "." OrElse e.KeyChar = ",") AndAlso CType(sender, TextBox).Text.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PesoPerfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PesoPerfil.KeyPress
        ' Permite apenas números, vírgula, ponto e Backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If

        ' Evita digitar mais de um ponto ou vírgula
        If (e.KeyChar = "." OrElse e.KeyChar = ",") AndAlso CType(sender, TextBox).Text.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        If OpenFileDialog1 Is Nothing Then
            OpenFileDialog1 = New OpenFileDialog()
        End If
        With OpenFileDialog1
            .Title = "Selecione uma foto"
            .InitialDirectory = Application.StartupPath & "\fotos\"
            .Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp"
            .Multiselect = False
            .ShowDialog()
            diretorio = .FileName
            If System.IO.File.Exists(diretorio) Then
                img_foto.Load(diretorio)
            Else
                MsgBox("Arquivo não encontrado.", MsgBoxStyle.Exclamation)
            End If

        End With
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        img_foto.Enabled = True
        NomePerfil.Enabled = True
        SexoPerfil.Enabled = True
        DateTimePerfil.Enabled = True
        AlturaPerfil.Enabled = True
        PesoPerfil.Enabled = True
        Button2.Enabled = True

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim novoform As New TelaInicial()
        novoform.show()
        Me.Close()
    End Sub

    Private Sub PesoPerfil_TextChanged(sender As Object, e As EventArgs) Handles PesoPerfil.TextChanged

    End Sub
End Class
Imports ADODB

Public Class Gerenciador_Treinos
    Public Sub GerarTreino(tipo As String, sexo As String)
        Dim gruposMusculares As String() = {"Peito", "Costas", "Ombro", "Perna", "Bíceps", "Tríceps"}
        Dim dataBase As Date = Date.Now

        ' Garante que a data comece em uma segunda-feira
        Do While dataBase.DayOfWeek <> DayOfWeek.Monday
            dataBase = dataBase.AddDays(1)
        Loop

        ' Definindo os exercícios
        Dim exercicios As New Dictionary(Of String, List(Of String))

        If tipo = "iniciante" And sexo = "Masculino" Then
            exercicios("Peito") = New List(Of String) From {"Supino Reto com Barra", "Crucifixo Reto"}
            exercicios("Costas") = New List(Of String) From {"Puxada na Frente", "Remada Baixa"}
            exercicios("Ombro") = New List(Of String) From {"Elevação Lateral", "Desenvolvimento com Halteres"}
            exercicios("Perna") = New List(Of String) From {"Agachamento Livre", "Cadeira Extensora"}
            exercicios("Bíceps") = New List(Of String) From {"Rosca Direta", "Rosca Martelo"}
            exercicios("Tríceps") = New List(Of String) From {"Tríceps Pulley", "Tríceps Testa"}
        ElseIf tipo = "iniciante" And sexo = "Feminino" Then
            exercicios("Peito") = New List(Of String) From {"Flexão de Braço", "Crucifixo Reto"}
            exercicios("Costas") = New List(Of String) From {"Puxada Frente", "Remada Unilateral"}
            exercicios("Ombro") = New List(Of String) From {"Elevação Lateral", "Desenvolvimento com Halteres"}
            exercicios("Perna") = New List(Of String) From {"Agachamento Livre", "Glúteo na Máquina"}
            exercicios("Bíceps") = New List(Of String) From {"Rosca Direta", "Rosca Alternada"}
            exercicios("Tríceps") = New List(Of String) From {"Tríceps Pulley", "Tríceps Francês"}
        End If

        ' Inserção no banco de dados (simplificado)
        For i As Integer = 0 To 4 ' Segunda a sexta
            Dim grupo = gruposMusculares(i)
            Dim diaTreino As String = dataBase.AddDays(i).ToShortDateString()

            For Each exercicio In exercicios(grupo)
                Dim carga As String = If(tipo = "iniciante", "10KG", "15KG")
                Dim repeticoes As String = If(tipo = "iniciante", "10", "12")
                Dim descanso As String = If(tipo = "iniciante", "30s", "45s")

                ' Monta o SQL para inserir os dados diretamente
                Dim sql As String = $"INSERT INTO Treino (Email, Musculo, Exercicio, Carga, Repeticoes, Descanso, Data) " &
                                $"VALUES ('{EmailUsuario}', '{grupo}', '{exercicio}', '{carga}', '{repeticoes}', '{descanso}', '{diaTreino}')"

                ' Executa o SQL diretamente
                db.Execute(sql)
            Next
        Next

        MsgBox("Treino gerado com sucesso!", MsgBoxStyle.Information, "OK")
    End Sub

    Private Sub Gerenciado_Treinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
        sql = "SELECT * FROM DadosUsuario WHERE Email = '" & EmailUsuario & "'"
        rs = db.Execute(sql)
        Dim sexoUsuario As String = rs.Fields("Sexo").Value.ToString()
        sexo = sexoUsuario.Trim().ToLower()


        If sexo = "masculino" Then
            avancadoM.Visible = False
            inicianteM.Visible = False
            intermediarioM.Visible = False
        Else
            avancadoH.Visible = False
            inicianteH.Visible = False
            intermediarioH.Visible = False
        End If


    End Sub


    Private Sub btnTipoTreino_Click(sender As Object, e As EventArgs) Handles btnTipoTreino.Click
        Try

            DataSelecionada = DataTreino.Value.ToShortDateString

            ' Define o tipo de treino
            If inicianteCheck.Checked Then
                tipoTreino = 1

            ElseIf intermediarioCheck.Checked Then
                tipoTreino = 2
            ElseIf avancadoCheck.Checked Then ' ← Adicione isso se estiver usando uma opção "avançado"
                tipoTreino = 3
            Else
                MessageBox.Show("Selecione uma opção de treino.")
                Exit Sub
            End If

            ' Abre o formulário de montagem do treino
            Dim novoForm As New montarTreino()
            novoForm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao montar o treino: " & ex.Message)
        End Try
    End Sub





    Private Sub inicianteCheck_CheckedChanged(sender As Object, e As EventArgs) Handles inicianteCheck.CheckedChanged
        If inicianteCheck.Checked Then
            intermediarioCheck.Checked = False
            avancadoCheck.Checked = False
        End If


    End Sub

    Private Sub intermediarioCheck_CheckedChanged(sender As Object, e As EventArgs) Handles intermediarioCheck.CheckedChanged
        If intermediarioCheck.Checked Then
            inicianteCheck.Checked = False
            avancadoCheck.Checked = False
        End If

    End Sub

    Private Sub avancadoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles avancadoCheck.CheckedChanged
        If avancadoCheck.Checked Then
            intermediarioCheck.Checked = False
            inicianteCheck.Checked = False
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim novoForm As New TelaInicial()
        novoForm.Show()
        Me.Close()
    End Sub

    Private Sub DataTreino_ValueChanged(sender As Object, e As EventArgs) Handles DataTreino.ValueChanged

    End Sub
End Class
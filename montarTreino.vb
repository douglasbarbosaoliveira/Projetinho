Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ADODB

Public Class montarTreino
    Private Sub Treino1Load()
        Try
            ' Limpa o DataGridView antes de adicionar novos dados
            DGV_Treino1.Rows.Clear()

            ' Consulta para buscar os dados atualizados


            sql = "SELECT * FROM Treino WHERE Email='" & EmailUsuario & "' AND Data='" & DataSelecionada & "' ORDER BY Musculo"
            rs = db.Execute(sql)

            ' Preenche o DataGridView com os dados retornados
            Do While Not rs.EOF
                DGV_Treino1.Rows.Add(
                rs("Musculo").Value,
                rs("Exercicio").Value,
                rs("Carga").Value,
                rs("Repeticoes").Value,
                rs("Descanso").Value,
                rs("Data").Value,
                  "🗑️"
)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro ao carregar os dados: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub


    Private Sub MontarTreino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConectarBanco()

            TabControl1.TabPages(0).Text = "Treino "
            musculoOpc1.SelectedItem = Musculo1

            With DGV_Treino1
                .Rows.Clear()

                If .Columns.Count = 0 Then
                    With .Columns
                        .Add("Musculo", "Músculo")
                        .Add("Exercicio", "Exercício")
                        .Add("Repeticoes", "Repetições")
                        .Add("Carga", "Carga")
                        .Add("Descanso", "Descanso")
                        .Add("Data", "Data")
                        .Add("Excluir", "Excluir")
                    End With
                End If

                .DefaultCellStyle.ForeColor = Color.Black
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .RowHeadersVisible = False
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .RowTemplate.Height = 30
            End With

            ' Gerar treino automático com base no tipo e sexo
            If tipoTreino = 1 Then
                GerarTreino("iniciante", sexo)
            ElseIf tipoTreino = 2 Then
                GerarTreino("intermediario", sexo)
            End If


            Treino1Load()

        Catch ex As Exception
            MsgBox("Erro ao carregar treino: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Sub GerarTreino(tipo As String, sexo As String)
        Dim exercicios As New Dictionary(Of String, List(Of String))

        exercicios("Peito") = New List(Of String) From {
        "Supino Reto com Barra",
        "Supino Inclinado com Halteres",
        "Crucifixo Reto"
    }

        exercicios("Costas") = New List(Of String) From {
        "Puxada na Frente com Pegada Aberta",
        "Remada Curvada com Barra",
        "Levantamento Terra"
    }

        exercicios("Ombro") = New List(Of String) From {
        "Desenvolvimento com Halteres",
        "Elevação Lateral com Halteres",
        "Crucifixo Inverso com Halteres"
    }

        exercicios("Perna") = New List(Of String) From {
        "Agachamento Livre",
        "Cadeira Extensora",
        "Mesa Flexora"
    }

        exercicios("Biceps") = New List(Of String) From {
        "Rosca Direta com Barra",
        "Rosca Alternada",
        "Rosca Scott com Barra"
    }

        exercicios("Triceps") = New List(Of String) From {
        "Tríceps Corda",
        "Tríceps Testa com Halteres",
        "Tríceps Banco"
    }

        Dim plano() As String = {"Peito", "Costas", "Ombro", "Perna", "Biceps", "Triceps"}
        Dim dataBase As Date = Date.Parse(DataSelecionada)

        For i = 0 To 4 ' Segunda a Sexta
            Dim musculo As String = plano(i)
            Dim dataTreino As String = dataBase.AddDays(i).ToShortDateString()

            For Each ex In exercicios(musculo)
                sql = "INSERT INTO Treino (Email, Musculo, Exercicio, Carga, Repeticoes, Descanso, Data) VALUES " &
                  "('" & EmailUsuario & "', '" & musculo & "', '" & ex & "', '10kg', '10', '60s', '" & dataTreino & "')"
                db.Execute(sql)
            Next
        Next
    End Sub


    Private Function BuscarExercicioAleatorio(musculo As String, tipo As String, sexo As String) As String
        Dim listaExercicios As New List(Of String)

        ' Aqui você pode refinar os exercícios por sexo/tipo se quiser
        Select Case musculo
            Case "Peito"
                listaExercicios.AddRange({"Supino Reto com Barra", "Supino Inclinado com Halteres", "Crucifixo Reto"})
            Case "Costas"
                listaExercicios.AddRange({"Puxada na Frente com Pegada Aberta", "Remada Curvada com Barra", "Remada Unilateral com Halter"})
            Case "Ombro"
                listaExercicios.AddRange({"Desenvolvimento com Halteres", "Elevação Lateral com Halteres", "Remada Alta com Barra"})
            Case "Perna"
                listaExercicios.AddRange({"Agachamento Livre", "Leg Press 45°", "Cadeira Extensora"})
            Case "Biceps"
                listaExercicios.AddRange({"Rosca Direta com Barra", "Rosca Alternada", "Rosca Martelo"})
            Case "Triceps"
                listaExercicios.AddRange({"Tríceps Corda", "Tríceps Testa com Barra W", "Tríceps Banco"})
        End Select

        Dim rand As New Random()
        Return listaExercicios(rand.Next(listaExercicios.Count))
    End Function

    Sub exercicios()

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles musculoOpc1.SelectedIndexChanged
        ExOpc1.Items.Clear()

        Select Case musculoOpc1.SelectedItem.ToString()

            Case "Peito"
                ExOpc1.Items.AddRange(New String() {
                    "Supino Reto com Barra",
                    "Supino Inclinado com Barra",
                    "Supino Declinado com Barra",
                    "Supino Reto com Halteres",
                    "Supino Inclinado com Halteres",
                    "Supino Declinado com Halteres",
                    "Crucifixo Reto",
                    "Crucifixo Inclinado",
                    "Crucifixo Declinado",
                    "Cross Over Alto",
                    "Cross Over Médio",
                    "Cross Over Baixo",
                    "Peck Deck",
                    "Flexão de Braço Tradicional",
                    "Flexão de Braço com Pés Elevados",
                    "Pullover com Halter",
                    "Pressão na Máquina",
                    "Flexão com Pegada Aberta",
                    "Flexão com Pegada Fechada",
                    "Flexão Explosiva"
                })

            Case "Costas"
                ExOpc1.Items.AddRange(New String() {
                    "Puxada na Frente com Pegada Aberta",
                    "Puxada na Frente com Pegada Fechada",
                    "Puxada Atrás da Nuca",
                    "Remada Curvada com Barra",
                    "Remada Curvada com Pegada Invertida",
                    "Remada Unilateral com Halter",
                    "Remada Baixa na Polia",
                    "Remada Máquina Hammer",
                    "Levantamento Terra",
                    "Remada Cavalinho",
                    "Barra Fixa Pronada",
                    "Barra Fixa Supinada",
                    "Barra Fixa com Peso",
                    "Remada Serrote",
                    "Pull Down na Polia Alta",
                    "Pull Over com Halter",
                    "Encolhimento para Trapézio",
                    "Good Morning com Barra",
                    "Deadlift com Pegada Sumô",
                    "Remada Alta com Corda"
                })

            Case "Ombro"
                ExOpc1.Items.AddRange(New String() {
                    "Desenvolvimento com Halteres",
                    "Desenvolvimento com Barra",
                    "Desenvolvimento na Máquina",
                    "Desenvolvimento Arnold",
                    "Elevação Lateral com Halteres",
                    "Elevação Lateral na Polia",
                    "Elevação Frontal com Halteres",
                    "Elevação Frontal na Polia",
                    "Remada Alta com Barra",
                    "Remada Alta com Corda",
                    "Crucifixo Inverso com Halteres",
                    "Crucifixo Inverso na Máquina",
                    "Crucifixo Inverso na Polia",
                    "Encolhimento com Halteres",
                    "Encolhimento na Barra",
                    "Encolhimento na Máquina",
                    "Desenvolvimento Militar",
                    "Desenvolvimento com Pegada Fechada",
                    "Rotação Externa com Halteres",
                    "Rotação Interna com Halteres"
                })

            Case "Perna"
                ExOpc1.Items.AddRange(New String() {
                    "Agachamento Livre",
                    "Agachamento no Smith",
                    "Agachamento Hack",
                    "Afundo com Halteres",
                    "Afundo no Smith",
                    "Cadeira Extensora",
                    "Mesa Flexora",
                    "Leg Press 45°",
                    "Leg Press Horizontal",
                    "Stiff com Halteres",
                    "Stiff com Barra",
                    "Passada no Step",
                    "Agachamento Búlgaro",
                    "Sumô com Halteres",
                    "Glúteo no Cabo",
                    "Glúteo na Máquina",
                    "Panturrilha Sentado",
                    "Panturrilha em Pé",
                    "Panturrilha no Leg Press",
                    "Elevação de Quadril com Barra"
                })

            Case "Triceps"
                ExOpc1.Items.AddRange(New String() {
                    "Tríceps Corda",
                    "Tríceps Pulley com Barra",
                    "Tríceps Pulley Inverso",
                    "Tríceps Testa com Barra W",
                    "Tríceps Testa com Halteres",
                    "Tríceps Banco",
                    "Tríceps Francês com Halter",
                    "Tríceps Francês com Barra",
                    "Tríceps Coice com Halteres",
                    "Tríceps Paralela",
                    "Mergulho entre Bancos",
                    "Kickback no Cabo",
                    "Pulley Unilateral",
                    "Tríceps Máquina",
                    "Tríceps na Polia Alta",
                    "Tríceps no Smith Invertido",
                    "Pressão de Tríceps com Pegada Invertida",
                    "Tríceps deitado com Corda",
                    "Tríceps 21s",
                    "Pressão de Tríceps com Pegada Martelo"
                })

            Case "Biceps"
                ExOpc1.Items.AddRange(New String() {
                    "Rosca Direta com Barra",
                    "Rosca Direta com Halteres",
                    "Rosca Alternada",
                    "Rosca Martelo",
                    "Rosca Concentrada",
                    "Rosca Scott com Barra",
                    "Rosca Scott com Halteres",
                    "Rosca Inversa com Barra",
                    "Rosca Inversa na Polia",
                    "Rosca no Cabo com Barra",
                    "Rosca 21s",
                    "Rosca no Banco Inclinado",
                    "Rosca Simultânea",
                    "Rosca no Cabo com Corda",
                    "Rosca Martelo Alternada",
                    "Rosca com Pegada Supinada",
                    "Rosca Máquina",
                    "Rosca com Pegada Fechada",
                    "Rosca com Pegada Aberta",
                    "Rosca Spider"
                })

        End Select

    End Sub

    Private Sub BtnTreino1_Click(sender As Object, e As EventArgs) Handles BtnTreino1.Click
        Try

            sql = "INSERT INTO Treino (Email, Musculo, Exercicio, Carga, Repeticoes, Descanso, Data) VALUES ('" & EmailUsuario & "','" & musculoOpc1.SelectedItem.ToString & "','" & ExOpc1.SelectedItem.ToString() & "','" & CargaOpc1.SelectedItem.ToString() & "','" & RepOpc1.SelectedItem.ToString() & "', '" & TempoOpc1.SelectedItem & "','" & DataSelecionada & "')"
            rs = db.Execute(sql)
            MsgBox("Treino salvo com sucesso!", MsgBoxStyle.Information, "Confirmação")
            Treino1Load()
        Catch ex As Exception
            MsgBox("Erro ao salvar treino: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub DGV_Treino1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Treino1.CellContentClick

        ' Verifica se clicou na coluna de excluir (última coluna)
        If e.ColumnIndex = DGV_Treino1.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            ' Confirma com o usuário
            If MsgBox("Deseja realmente excluir este treino?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmação") = MsgBoxResult.Yes Then
                Try
                    ' Pega os dados da linha clicada
                    Dim musculo As String = DGV_Treino1.Rows(e.RowIndex).Cells(0).Value.ToString()
                    Dim exercicio As String = DGV_Treino1.Rows(e.RowIndex).Cells(1).Value.ToString()
                    Dim dataTreino As String = DGV_Treino1.Rows(e.RowIndex).Cells(5).Value.ToString()

                    ' Executa o comando de exclusão
                    Dim sqlDelete As String = "DELETE FROM Treino WHERE Email='" & EmailUsuario & "' AND Data='" & dataTreino & "' AND Musculo='" & musculo & "' AND Exercicio='" & exercicio & "'"
                    db.Execute(sqlDelete)

                    ' Recarrega o DataGridView
                    Treino1Load()
                    MsgBox("Treino excluído com sucesso!", MsgBoxStyle.Information, "Removido")
                Catch ex As Exception
                    MsgBox("Erro ao excluir treino: " & ex.Message, MsgBoxStyle.Critical, "Erro")
                End Try
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim novoForm As New TelaInicial()
        novoForm.Show()
        Me.Close()
    End Sub
End Class
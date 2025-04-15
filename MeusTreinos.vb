Imports ADODB
Imports System.Drawing.Printing

Public Class MeusTreinos
    Dim documento As New PrintDocument()
    Dim linhaAtual As Integer = 0
    Dim nomeUsuario As String = ""

    Private Sub MeusTreinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
        AddHandler documento.PrintPage, AddressOf PrintDocument1_PrintPage

        With DGV_Treinos
            .Rows.Clear()

            If .Columns.Count = 0 Then
                With .Columns
                    .Add("Musculo", "Músculo")
                    .Add("Exercicio", "Exercício")
                    .Add("Repeticoes", "Repetições")
                    .Add("Carga", "Carga")
                    .Add("Descanso", "Descanso")
                    .Add("Data", "Data")
                End With
            End If

            With DGV_Treinos
                .GridColor = Color.White
                .CellBorderStyle = DataGridViewCellBorderStyle.None
                .RowHeadersVisible = False
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                .EnableHeadersVisualStyles = False

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                .BackgroundColor = Me.BackColor
                .BorderStyle = BorderStyle.None
                .DefaultCellStyle.BackColor = Me.BackColor
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.LightGray
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
                .RowTemplate.Height = 40
            End With
        End With

        carregarTreinos()
    End Sub

    Sub carregarTreinos()
        Try
            sql = "SELECT * FROM Treino WHERE Email='" & EmailUsuario & "' AND Data='" & DataMeusTreinos.Value.ToShortDateString() & "' ORDER BY Musculo"
            rs = db.Execute(sql)

            With DGV_Treinos
                .Rows.Clear()
                Do While Not rs.EOF
                    .Rows.Add(
                        rs("Musculo").Value,
                        rs("Exercicio").Value,
                        rs("Repeticoes").Value,
                        rs("Carga").Value,
                        rs("Descanso").Value,
                        rs("Data").Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar os treinos: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub DataMeusTreinos_ValueChanged_1(sender As Object, e As EventArgs) Handles DataMeusTreinos.ValueChanged
        carregarTreinos()
    End Sub

    Private Sub BuscarNomeUsuario()
        Try
            Dim sqlNome As String
            sqlNome = "SELECT Nome FROM DadosUsuario WHERE Email='" & EmailUsuario & "'"
            Dim rsNome As New ADODB.Recordset
            rsNome.Open(sqlNome, db, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

            If Not rsNome.EOF Then
                nomeUsuario = rsNome("Nome").Value.ToString()
            End If

            rsNome.Close()
        Catch ex As Exception
            MsgBox("Erro ao buscar nome do usuário: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim fonteTitulo As New Font("Arial", 18, FontStyle.Bold)
        Dim fonteCabecalho As New Font("Arial", 10, FontStyle.Bold)
        Dim fonteConteudo As New Font("Arial", 10)

        Dim alturaLinha As Integer = fonteConteudo.GetHeight(e.Graphics) + 10
        Dim margemEsquerda As Integer = e.MarginBounds.Left
        Dim margemTopo As Integer = e.MarginBounds.Top
        Dim linhaY As Integer = margemTopo

        ' LARGURAS DAS COLUNAS
        Dim largurasColunas() As Integer = {100, 300, 80, 80, 80}

        ' TÍTULO
        Dim textoTitulo As String = "Meu Treino"
        Dim larguraTitulo As SizeF = e.Graphics.MeasureString(textoTitulo, fonteTitulo)
        Dim posicaoTituloX As Integer = margemEsquerda + (e.MarginBounds.Width - larguraTitulo.Width) \ 2
        e.Graphics.DrawString(textoTitulo, fonteTitulo, Brushes.Black, posicaoTituloX, linhaY)

        linhaY += CInt(fonteTitulo.GetHeight(e.Graphics)) + 10

        ' NOME DO USUÁRIO
        e.Graphics.DrawString("Usuário: " & nomeUsuario, fonteConteudo, Brushes.Black, margemEsquerda, linhaY)
        linhaY += alturaLinha

        ' DATA DO TREINO
        Dim dataSelecionada As String = DataMeusTreinos.Value.ToString("dd/MM/yyyy")
        e.Graphics.DrawString("Data do treino: " & dataSelecionada, fonteConteudo, Brushes.Black, margemEsquerda, linhaY)
        linhaY += alturaLinha + 10

        ' CABEÇALHOS
        Dim posX As Integer = margemEsquerda
        For i As Integer = 0 To DGV_Treinos.Columns.Count - 2
            Dim textoCabecalho As String = DGV_Treinos.Columns(i).HeaderText
            e.Graphics.DrawString(textoCabecalho, fonteCabecalho, Brushes.Black, posX, linhaY)
            posX += largurasColunas(i)
        Next

        linhaY += alturaLinha

        ' CONTEÚDO
        While linhaAtual < DGV_Treinos.Rows.Count
            Dim row = DGV_Treinos.Rows(linhaAtual)
            If row.IsNewRow Then Exit While

            posX = margemEsquerda
            For i As Integer = 0 To DGV_Treinos.Columns.Count - 2
                Dim valor As String = row.Cells(i).Value?.ToString()
                e.Graphics.DrawString(valor, fonteConteudo, Brushes.Black, posX, linhaY)
                posX += largurasColunas(i)
            Next

            linhaY += alturaLinha
            linhaAtual += 1

            If linhaY + alturaLinha > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If
        End While

        e.HasMorePages = False
        linhaAtual = 0
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        BuscarNomeUsuario()

        Dim dialogo As New PrintDialog()
        dialogo.Document = documento

        If dialogo.ShowDialog() = DialogResult.OK Then
            documento.Print()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim novoForm As New TelaInicial()
        novoForm.Show()
        Me.Close()
    End Sub
End Class

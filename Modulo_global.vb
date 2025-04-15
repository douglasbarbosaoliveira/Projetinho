Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports ADODB
Module Modulo_global
    Public diretorio, sql, resp, EmailUsuario, Musculo1, Musculo2, DataSelecionada, Treino1, Treino2, sexo As String 'Declaração de variáveis públicas
    Public db As New ADODB.Connection 'Variável do Banco
    Public rs As New ADODB.Recordset 'Variável da Tabela
    Public cont, tipoTreino As Integer
    Public preenchido As Boolean
    Sub InicializarBanco()
        Try
            Dim db As New ADODB.Connection
            db.Open("Provider=SQLOLEDB;Data Source=DOUGLAS-NOTE;Initial Catalog=master;Trusted_Connection=Yes;")

            db.Execute("IF DB_ID('projetinho') IS NULL CREATE DATABASE projetinho")
            db.Close()

            db.Open("Provider=SQLOLEDB;Data Source=DOUGLAS-NOTE;Initial Catalog=projetinho;Trusted_Connection=Yes;")

            db.Execute("IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='login' AND xtype='U') " &
                   "CREATE TABLE login (Email VARCHAR(120) PRIMARY KEY, senha VARCHAR(80) NOT NULL)")

            db.Execute("IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Treino' AND xtype='U') " &
                   "CREATE TABLE Treino (" &
                   "Email VARCHAR(120), " &
                   "Musculo VARCHAR(30), " &
                   "Exercicio VARCHAR(150), " &
                   "Carga VARCHAR(10), " &
                   "Repeticoes INT, " &
                   "Descanso VARCHAR(10), " &
                   "Data VARCHAR(25), " &
                   "FOREIGN KEY (Email) REFERENCES login(email))")

            db.Execute("IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='DadosUsuario' AND xtype='U') " &
                   "CREATE TABLE DadosUsuario (" &
                   "Email VARCHAR(120) NOT NULL, " &
                   "Nome VARCHAR(120) NOT NULL, " &
                   "Sexo VARCHAR(30) NOT NULL, " &
                   "DataNasc VARCHAR(25) NOT NULL, " &
                   "Altura FLOAT NOT NULL, " &
                   "Peso FLOAT NOT NULL, " &
                   "Imagem VARCHAR(500), " &
                   "FOREIGN KEY (Email) REFERENCES login(email))")

            db.Close()


        Catch ex As Exception
            MsgBox("Erro ao inicializar o banco: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub ConectarBanco()
        Try
            If db.State = 1 Then db.Close() ' 1 = aberto
            db.Open("Provider=SQLOLEDB;Data Source=DOUGLAS-NOTE;Initial Catalog=projetinho;Trusted_Connection=Yes;")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub





    Sub treinoinicianteH()
        Dim valores As String = ""
        Dim EmailUsuario As String = "usuario@exemplo.com"  ' Substitua com o e-mail do usuário

        ' Inserção para o treino masculino iniciante
        valores &= $"('{EmailUsuario}', 'Peito', 'Supino Reto com Barra', '10KG', '10', '30s', '13/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Peito', 'Crucifixo Reto', '10KG', '10', '30s', '13/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Costas', 'Puxada na Frente', '10KG', '10', '30s', '14/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Costas', 'Remada Baixa', '10KG', '10', '30s', '14/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Ombro', 'Elevação Lateral', '10KG', '10', '30s', '15/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Ombro', 'Desenvolvimento com Halteres', '10KG', '10', '30s', '15/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Perna', 'Agachamento Livre', '10KG', '10', '30s', '16/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Perna', 'Cadeira Extensora', '10KG', '10', '30s', '16/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Bíceps', 'Rosca Direta', '10KG', '10', '30s', '17/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Bíceps', 'Rosca Martelo', '10KG', '10', '30s', '17/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Tríceps', 'Tríceps Pulley', '10KG', '10', '30s', '18/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Tríceps', 'Tríceps Testa', '10KG', '10', '30s', '18/04/2025');"

        ' Agora você pode executar o comando SQL concatenado
        Dim sql As String = "INSERT INTO Treino (Email, Musculo, Exercicio, Carga, Repeticoes, Descanso, Data) VALUES " & valores

        ' Código para executar a query no banco de dados
        Try
            ' Supondo que você tenha uma função para executar a query, como ExecuteNonQuery
            ' ExecuteNonQuery(sql)
            MessageBox.Show("Dados inseridos com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir dados: " & ex.Message)
        End Try
    End Sub

    Sub treinoinicianteM()
        Dim valores As String = ""
        Dim EmailUsuario As String = "usuario@exemplo.com"  ' Substitua com o e-mail do usuário

        ' Inserção para o treino feminino iniciante
        valores &= $"('{EmailUsuario}', 'Peito', 'Flexão de Braço', '10KG', '10', '30s', '13/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Peito', 'Crucifixo Reto', '10KG', '10', '30s', '13/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Costas', 'Puxada Frente', '10KG', '10', '30s', '14/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Costas', 'Remada Unilateral', '10KG', '10', '30s', '14/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Ombro', 'Elevação Lateral', '10KG', '10', '30s', '15/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Ombro', 'Desenvolvimento com Halteres', '10KG', '10', '30s', '15/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Perna', 'Agachamento Livre', '10KG', '10', '30s', '16/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Perna', 'Glúteo na Máquina', '10KG', '10', '30s', '16/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Bíceps', 'Rosca Direta', '10KG', '10', '30s', '17/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Bíceps', 'Rosca Alternada', '10KG', '10', '30s', '17/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Tríceps', 'Tríceps Pulley', '10KG', '10', '30s', '18/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Tríceps', 'Tríceps Francês', '10KG', '10', '30s', '18/04/2025');"

        ' Agora você pode executar o comando SQL concatenado
        Dim sql As String = "INSERT INTO Treino (Email, Musculo, Exercicio, Carga, Repeticoes, Descanso, Data) VALUES " & valores

        ' Código para executar a query no banco de dados
        Try
            ' Supondo que você tenha uma função para executar a query, como ExecuteNonQuery
            ' ExecuteNonQuery(sql)
            MessageBox.Show("Dados inseridos com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir dados: " & ex.Message)
        End Try
    End Sub


    Sub treinoIntermediarioH()
        Dim valores As String = ""
        Dim EmailUsuario As String = "usuario@exemplo.com"  ' Substitua com o e-mail do usuário

        ' Inserção para o treino masculino intermediário
        valores &= $"('{EmailUsuario}', 'Peito', 'Supino Reto com Barra', '20KG', '12', '30s', '13/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Peito', 'Crucifixo Reto', '20KG', '12', '30s', '13/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Costas', 'Puxada na Frente', '20KG', '12', '30s', '14/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Costas', 'Remada Baixa', '20KG', '12', '30s', '14/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Ombro', 'Elevação Lateral', '20KG', '12', '30s', '15/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Ombro', 'Desenvolvimento com Halteres', '20KG', '12', '30s', '15/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Perna', 'Agachamento Livre', '20KG', '12', '30s', '16/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Perna', 'Cadeira Extensora', '20KG', '12', '30s', '16/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Bíceps', 'Rosca Direta', '20KG', '12', '30s', '17/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Bíceps', 'Rosca Martelo', '20KG', '12', '30s', '17/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Tríceps', 'Tríceps Pulley', '20KG', '12', '30s', '18/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Tríceps', 'Tríceps Testa', '20KG', '12', '30s', '18/04/2025');"

        ' Agora você pode executar o comando SQL concatenado
        Dim sql As String = "INSERT INTO Treino (Email, Musculo, Exercicio, Carga, Repeticoes, Descanso, Data) VALUES " & valores

        ' Código para executar a query no banco de dados
        Try
            ' Supondo que você tenha uma função para executar a query, como ExecuteNonQuery
            ' ExecuteNonQuery(sql)
            MessageBox.Show("Dados inseridos com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir dados: " & ex.Message)
        End Try
    End Sub

    Sub treinoIntermediarioM()
        Dim valores As String = ""
        Dim EmailUsuario As String = "usuario@exemplo.com"  ' Substitua com o e-mail do usuário

        ' Inserção para o treino feminino intermediário
        valores &= $"('{EmailUsuario}', 'Peito', 'Flexão de Braço', '20KG', '12', '30s', '13/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Peito', 'Crucifixo Reto', '20KG', '12', '30s', '13/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Costas', 'Puxada Frente', '20KG', '12', '30s', '14/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Costas', 'Remada Unilateral', '20KG', '12', '30s', '14/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Ombro', 'Elevação Lateral', '20KG', '12', '30s', '15/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Ombro', 'Desenvolvimento com Halteres', '20KG', '12', '30s', '15/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Perna', 'Agachamento Livre', '20KG', '12', '30s', '16/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Perna', 'Glúteo na Máquina', '20KG', '12', '30s', '16/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Bíceps', 'Rosca Direta', '20KG', '12', '30s', '17/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Bíceps', 'Rosca Alternada', '20KG', '12', '30s', '17/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Tríceps', 'Tríceps Pulley', '20KG', '12', '30s', '18/04/2025'),"
        valores &= $"('{EmailUsuario}', 'Tríceps', 'Tríceps Francês', '20KG', '12', '30s', '18/04/2025');"

        ' Agora você pode executar o comando SQL concatenado
        Dim sql As String = "INSERT INTO Treino (Email, Musculo, Exercicio, Carga, Repeticoes, Descanso, Data) VALUES " & valores

        ' Código para executar a query no banco de dados
        Try
            ' Supondo que você tenha uma função para executar a query, como ExecuteNonQuery
            ' ExecuteNonQuery(sql)
            MessageBox.Show("Dados inseridos com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir dados: " & ex.Message)
        End Try
    End Sub







End Module

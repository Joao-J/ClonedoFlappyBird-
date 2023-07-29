Imports System.IO
Imports System.Media
Imports System.Net.NetworkInformation
Imports System.Net.Security
Imports Microsoft.VisualBasic.Logging

Public Class Form1
    Dim tamanho_passaro
    Dim gravidade As Double = 1
    Dim pulo As Double
    Dim r As New Random
    Dim c As Control
    Dim morto As Boolean = False
    Dim start As Boolean = False
    Dim sua_pontucao As Integer
    Dim pv As Integer = 0
    Dim tamanho_abertura = 120


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pontuacao()
        fundo.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Left = Me.Width / 2 - Label1.Height / 2
        sua_pontucao = Int(Label1.Text)
        '-------------------------------------- > pulo do passaro
        passaro.Top += 1 + gravidade - pulo
        gravidade += 0.3

        If pulo > 0 Then
            pulo -= 1
        End If

        '-------------------------------------- > centralizador do passaro

        passaro.Left = Me.Width / 2 - passaro.Width / 2

        '--------------------------------------- > verificação dos canos

        For Each c In Me.Controls
            If c.Tag = "cano" Then
                c.Left -= 1
                If c.Left + c.Width <= 0 Then
                    Me.Controls.Remove(c)
                End If
                If c.Bounds.IntersectsWith(passaro.Bounds) Then

                    pontuacao()

                End If
                If c.Top = 0 And c.Left + c.Width + 1 = passaro.Left And morto = False Then
                    Label1.Text += 1
                    System.Media.SystemSounds.Exclamation.Play()
                    pv += 1
                    If pv = 10 And Timer2.Interval > 300 Then
                        Timer2.Interval -= 50
                        pv = 0
                    End If
                End If
            End If
        Next
        '-----------------------------------------------
        If passaro.Top > Me.Height Then
            pontuacao()
        End If



    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space And morto = False Then
            pulo = 10
            gravidade = 1
        End If
        If e.KeyCode = Keys.Space And start = False Then
            start = True
        End If
    End Sub

    Private Sub criar_canos()
        Dim cano_cima As New PictureBox
        With cano_cima
            .Width = passaro.Width + 10
            .Height = r.Next((Me.Height - tamanho_abertura))
            .Top = 0
            .Left = Me.Width + cano_cima.Width
            .BackColor = Color.Green
            .Tag = "cano"
        End With

        Dim cabecadocanoc As New PictureBox
        With cabecadocanoc
            .Width = passaro.Width + 30
            .Tag = "cano"
            .Left = cano_cima.Left - 7
            .BackColor = Me.BackColor
            .Image = Image.FromFile("C:\Users\Tenata\Documents\181-1811759_flappy-bird-pipes-png-transparent-download-8-bit.png")
            .Image.RotateFlip(RotateFlipType.Rotate180FlipX)
            .Height = 20
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Top = cano_cima.Height - 20
        End With



        Dim cano_baixo As New PictureBox
        With cano_baixo
            .Width = passaro.Width + 10
            .Left = Me.Width + cano_cima.Width
            .Tag = "cano"
            .Height = Me.Height - cano_cima.Height - tamanho_abertura
            .Top = Me.Height - cano_baixo.Height
            .BackColor = Color.Green
        End With

        Dim cabecadocanob As New PictureBox
        With cabecadocanob
            .Width = passaro.Width + 30
            .Tag = "cano"
            .Left = cano_cima.Left - 7
            .BackColor = Me.BackColor
            .Image = Image.FromFile("C:\Users\Tenata\Documents\181-1811759_flappy-bird-pipes-png-transparent-download-8-bit.png")
            .Height = 20
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Top = cano_baixo.Top
        End With

        Me.Controls.AddRange({cabecadocanob, cano_baixo, cabecadocanoc, cano_cima})
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        criar_canos()

    End Sub
    Sub posicaopassarotela()
        passaro.Top = Panel1.Top + Panel1.Height
        passaro.Left = Panel1.Left + Panel1.Width / 2 - passaro.Width / 2
    End Sub
    Sub ver_start()
        If start = False Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Label1.Visible = False
            Panel1.Visible = True
            For Each c In Me.Controls
                If c.Tag = "cano" Then
                    Me.Controls.Remove(c)
                End If
            Next
            Label1.Text = 0
            morto = False
        Else
            Panel1.Visible = False
            Timer1.Enabled = True
            Timer2.Enabled = True
            Label1.Visible = True
            morto = False
        End If
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        start = True
        Panel1.Visible = False
    End Sub

    Private Sub pontuacao()
        start = False
        morto = True
        posicaopassarotela()

        If IO.File.Exists("C:\Users\Tenata\Documents\pontuacao.txt") = False Then
            File.CreateText("C:\Users\Tenata\Documents\pontuacao.txt").Flush()
        End If


        Dim pontos As String
        pontos = File.ReadAllText("C:\Users\Tenata\Documents\pontuacao.txt")
        Label6.Text = pontos.ToString()
        If pontos = "" Then
            pontos = 0
        End If

        If Int(pontos) < Int(sua_pontucao) Then
            IO.File.WriteAllText("C:\Users\Tenata\Documents\pontuacao.txt", sua_pontucao)
            Label6.Text = "Novo Recorde " & sua_pontucao
        End If
        Label5.Text = sua_pontucao

    End Sub


    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        '--------------------------------------> verifica se deu start
        ver_start()
        Panel1.Left = Me.Width / 2 - Panel1.Width / 2
        Panel1.Top = Me.Height / 2 - Panel1.Height / 2

    End Sub
    Dim sobe_desce As Boolean = True

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        If start = False Then
            If sobe_desce = True And Panel1.Top + Panel1.Height < passaro.Top + 20 Then
                passaro.Top -= 1

            Else
                sobe_desce = False
                passaro.Top += 1
                If passaro.Top > Panel1.Top + Panel1.Height + 30 Then
                    sobe_desce = True
                End If
            End If
        End If


    End Sub


End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        passaro = New PictureBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Timer3 = New Timer(components)
        Timer4 = New Timer(components)
        Label1 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        CType(passaro, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' passaro
        ' 
        passaro.BackColor = SystemColors.Control
        passaro.Image = My.Resources.Resources.Flappy_Bird_PNG_Image
        passaro.Location = New Point(173, 268)
        passaro.Name = "passaro"
        passaro.Size = New Size(32, 32)
        passaro.SizeMode = PictureBoxSizeMode.Zoom
        passaro.TabIndex = 0
        passaro.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 2500
        ' 
        ' Timer3
        ' 
        Timer3.Enabled = True
        Timer3.Interval = 10
        ' 
        ' Timer4
        ' 
        Timer4.Enabled = True
        Timer4.Interval = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Minecrafter", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(173, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 21)
        Label1.TabIndex = 1
        Label1.Text = "00"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(90, 51)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(182, 185)
        Panel1.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Minecrafter", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(71, 137)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 21)
        Label6.TabIndex = 4
        Label6.Text = "00"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Minecrafter", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(71, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 21)
        Label5.TabIndex = 3
        Label5.Text = "00"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(42, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 15)
        Label4.TabIndex = 2
        Label4.Text = "melhor ponuação"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(42, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 1
        Label3.Text = "sua pontuação"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(51, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 37)
        Label2.TabIndex = 0
        Label2.Text = "Start"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(347, 445)
        Controls.Add(passaro)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        Text = "CLONE DE FLAP BIRD"
        TopMost = True
        TransparencyKey = SystemColors.Control
        CType(passaro, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents passaro As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fundo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        p2 = New PictureBox()
        p1 = New PictureBox()
        Timer1 = New Timer(components)
        CType(p2, ComponentModel.ISupportInitialize).BeginInit()
        CType(p1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' p2
        ' 
        p2.Image = My.Resources.Resources._46888871_624a3900_ce7f_11e8_808e_99fd90c8a3f4
        p2.Location = New Point(349, 0)
        p2.Name = "p2"
        p2.Size = New Size(693, 444)
        p2.TabIndex = 6
        p2.TabStop = False
        ' 
        ' p1
        ' 
        p1.Image = My.Resources.Resources._46888871_624a3900_ce7f_11e8_808e_99fd90c8a3f4
        p1.Location = New Point(-343, 0)
        p1.Name = "p1"
        p1.Size = New Size(693, 444)
        p1.TabIndex = 5
        p1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 50
        ' 
        ' fundo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 445)
        Controls.Add(p2)
        Controls.Add(p1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximumSize = New Size(363, 484)
        MinimumSize = New Size(363, 484)
        Name = "fundo"
        Text = "fundo"
        CType(p2, ComponentModel.ISupportInitialize).EndInit()
        CType(p1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents p2 As PictureBox
    Friend WithEvents p1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class

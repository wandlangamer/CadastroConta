<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbConta = New System.Windows.Forms.TextBox()
        Me.txbCliente = New System.Windows.Forms.TextBox()
        Me.txbSaldo = New System.Windows.Forms.TextBox()
        Me.txbAniversario = New System.Windows.Forms.TextBox()
        Me.btnCriar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.btnSacar = New System.Windows.Forms.Button()
        Me.txbSaldoFinal = New System.Windows.Forms.TextBox()
        Me.TetxbValor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Saldo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Aniversário"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Valor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(418, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Saldo"
        '
        'txbConta
        '
        Me.txbConta.Location = New System.Drawing.Point(118, 37)
        Me.txbConta.Name = "txbConta"
        Me.txbConta.Size = New System.Drawing.Size(235, 20)
        Me.txbConta.TabIndex = 6
        '
        'txbCliente
        '
        Me.txbCliente.Location = New System.Drawing.Point(118, 84)
        Me.txbCliente.Name = "txbCliente"
        Me.txbCliente.Size = New System.Drawing.Size(235, 20)
        Me.txbCliente.TabIndex = 7
        '
        'txbSaldo
        '
        Me.txbSaldo.Location = New System.Drawing.Point(118, 133)
        Me.txbSaldo.Name = "txbSaldo"
        Me.txbSaldo.Size = New System.Drawing.Size(235, 20)
        Me.txbSaldo.TabIndex = 8
        '
        'txbAniversario
        '
        Me.txbAniversario.Location = New System.Drawing.Point(118, 182)
        Me.txbAniversario.Name = "txbAniversario"
        Me.txbAniversario.Size = New System.Drawing.Size(235, 20)
        Me.txbAniversario.TabIndex = 9
        '
        'btnCriar
        '
        Me.btnCriar.Location = New System.Drawing.Point(421, 113)
        Me.btnCriar.Name = "btnCriar"
        Me.btnCriar.Size = New System.Drawing.Size(75, 23)
        Me.btnCriar.TabIndex = 10
        Me.btnCriar.Text = "&Criar"
        Me.btnCriar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(266, 233)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(75, 23)
        Me.btnDepositar.TabIndex = 11
        Me.btnDepositar.Text = "&Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'btnSacar
        '
        Me.btnSacar.Location = New System.Drawing.Point(266, 299)
        Me.btnSacar.Name = "btnSacar"
        Me.btnSacar.Size = New System.Drawing.Size(75, 23)
        Me.btnSacar.TabIndex = 12
        Me.btnSacar.Text = "&Sacar"
        Me.btnSacar.UseVisualStyleBackColor = True
        '
        'txbSaldoFinal
        '
        Me.txbSaldoFinal.Location = New System.Drawing.Point(421, 270)
        Me.txbSaldoFinal.Name = "txbSaldoFinal"
        Me.txbSaldoFinal.Size = New System.Drawing.Size(100, 20)
        Me.txbSaldoFinal.TabIndex = 13
        '
        'TetxbValor
        '
        Me.TetxbValor.Location = New System.Drawing.Point(92, 270)
        Me.TetxbValor.Name = "TetxbValor"
        Me.TetxbValor.Size = New System.Drawing.Size(100, 20)
        Me.TetxbValor.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 355)
        Me.Controls.Add(Me.TetxbValor)
        Me.Controls.Add(Me.txbSaldoFinal)
        Me.Controls.Add(Me.btnSacar)
        Me.Controls.Add(Me.btnDepositar)
        Me.Controls.Add(Me.btnCriar)
        Me.Controls.Add(Me.txbAniversario)
        Me.Controls.Add(Me.txbSaldo)
        Me.Controls.Add(Me.txbCliente)
        Me.Controls.Add(Me.txbConta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txbConta As TextBox
    Friend WithEvents txbCliente As TextBox
    Friend WithEvents txbSaldo As TextBox
    Friend WithEvents txbAniversario As TextBox
    Friend WithEvents btnCriar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnSacar As Button
    Friend WithEvents txbSaldoFinal As TextBox
    Friend WithEvents TetxbValor As TextBox
End Class

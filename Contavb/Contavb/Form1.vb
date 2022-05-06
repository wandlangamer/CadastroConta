Public Class Form1
    ' Estamos criando o objeto com público, ou seja, global, todos tem acesso
    Dim obj_poupanca As New Poupanca
    Private Sub btnCriar_Click(sender As Object, e As EventArgs) Handles btnCriar.Click
        obj_poupanca.pConta = txbConta.Text
        obj_poupanca.pCliente = txbCliente.Text
        'CDec é a função para converter texto em número decimal
        obj_poupanca.pSaldo = CDec(txbSaldo.Text)
        'CInt é a função para converter texto em número inteiro
        obj_poupanca.pAniversario = CInt(txbAniversario.Text)

        'Para exibir o saldo final
        'txbSaldoFinal.Text = obj_poupanca.pSaldo
        'Para exibir o saldo final
        AtualizaSaldo()

    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        obj_poupanca.Depositar(CDec(TetxbValor.Text))
        AtualizaSaldo()
    End Sub

    Private Sub AtualizaSaldo()
        txbSaldoFinal.Text = obj_poupanca.pSaldo
    End Sub

    Private Sub btnSacar_Click(sender As Object, e As EventArgs) Handles btnSacar.Click
        obj_poupanca.Sacar(CDec(TetxbValor.Text))
        AtualizaSaldo()
    End Sub
End Class

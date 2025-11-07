/*
Crie uma classe chamada Pedido com:

Propriedade pública NumeroPedido (string).
Propriedade pública NomeCliente (string).
Propriedade pública Status (string).
Um método chamado AtualizarStatus(string novoStatus) para alterar o status.
Um método chamado ExibirPedido() que mostre os dados na tela.
*/

class Pedido
{
    public Pedido(string numeroPedido, string nomeCliente, string status)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = status;
    }

    public string NumeroPedido { get; set; }
    public string NomeCliente { get; set; }
    public string Status { get; set; }

    public void AtualizarStatus(string novoStatus)
    {
        Status = novoStatus;
    }
    public void ExibirPedido()
    {
        Console.WriteLine($"Pedido nº {NumeroPedido}\r\nCliente: {NomeCliente}\r\nStatus: {Status}");
    }
}
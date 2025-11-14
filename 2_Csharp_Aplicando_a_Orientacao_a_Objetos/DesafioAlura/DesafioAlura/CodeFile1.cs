using System.ComponentModel;
using System.Runtime.CompilerServices;

class Conta
{
    public int idConta;
    public string titular;
    public double saldo;
    public string senha;

    public void ExibirInformacoesConta()
    {
        Console.WriteLine("INFORMAÇÕES DA CONTA:");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
    }
}
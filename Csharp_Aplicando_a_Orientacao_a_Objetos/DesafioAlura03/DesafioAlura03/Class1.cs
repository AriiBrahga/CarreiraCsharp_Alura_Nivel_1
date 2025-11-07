using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1 - Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, 
      saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.*/


class Conta
{
    public Conta(Titular nome, float limite, int numeroConta)
    {
        Nome = nome;
        Limite = limite;
        NumConta = numeroConta;
    }

    private Titular Nome { get; }
    public int Agencia { get; set; }
    private int NumConta { get; }
    public float Saldo { get; set; }
    private float Limite { get; }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Aqui esta as informações da sua conta:\n");
        Console.WriteLine($"Titular: {Nome.Name}\nCPF: {Nome.Cpf}\nNúmero da Conta: {NumConta}\nAgência: {Agencia}\nSaldo Atual: {Saldo}\nLimite: {Limite}");
    }


}
class ClienteVIP : Pessoa
{
    public ClienteVIP(string nome, int idade, string fidelidade, string codigoVip) : base(nome, idade)
    {
        NivelFidelidade = fidelidade;
        CodigoVip = codigoVip;
    }
    public string NivelFidelidade { get; set; }
    public string CodigoVip { get; set; }

    public void Cliente()
    {
        Console.WriteLine($"Bem-vindo, cliente VIP: {Nome}\r\nIdade: {Idade}\r\nNível de Fidelidade: {NivelFidelidade}\r\nCódigo VIP: {CodigoVip}\r\n \r\n");
    }
}


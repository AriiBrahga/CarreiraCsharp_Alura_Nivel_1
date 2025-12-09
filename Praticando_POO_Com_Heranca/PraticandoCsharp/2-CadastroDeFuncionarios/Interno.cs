class Interno : Funcionario
{
    public Interno(string nome, string cargo, decimal salario) : base(nome, cargo)
    {
        Salario = salario;
    }

    public decimal Salario { get; set; }

    public void Descricao()
    {
        Console.WriteLine($"Funcionária {Nome} – Cargo: {Cargo} – Salário: R$ {Salario}\r");
    }
}
using System.ComponentModel.Design;

class Freelancer : Funcionario
{
    public Freelancer(string nome, string cargo, decimal valorProjeto) : base(nome, cargo)
    {
        ValorProjeto = valorProjeto;
    }

    public decimal ValorProjeto { get; }

    public void Descricao()
    {
        Console.WriteLine($"\nFreelancer {Nome} – Cargo: {Cargo} – Projeto atual: R$ {ValorProjeto}");
    }
}

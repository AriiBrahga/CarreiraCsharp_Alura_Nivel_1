using System;

class Consultoria : IServico
{
    public Consultoria(string tarefa, Funcionario func)
    {
        Tarefa = tarefa;
        Func = func;
    }

    public string Tarefa { get; set; }
    public Funcionario Func { get; set; }

    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de consultoria: {Tarefa}\r\nResponsável: {Func.Nome} - Departamento: {Func.Departamento}");
    }
}

class Passageiro : Pessoa
{
    public Passageiro(string nome, int idade, int quantidadeBilhetes) : base(nome, idade)
    {
        QuantidadeBilhetes = quantidadeBilhetes;
    }

    public int QuantidadeBilhetes { get; set; }

    public void Descricao()
    {
        Console.WriteLine($"Passageiro: {Nome} - Idade: {Idade} - Bilhetes: {QuantidadeBilhetes}\r\n");
    }

}
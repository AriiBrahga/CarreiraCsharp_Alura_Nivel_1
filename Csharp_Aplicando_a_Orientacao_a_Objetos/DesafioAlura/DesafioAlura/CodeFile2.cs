class Carro
{
    public int velocidade;
    public string modelo;

    public void ExibirCarro()
    {
        Console.WriteLine($"Carro:{modelo}");
        Console.WriteLine($"Velocidade Atual: {velocidade}km ");
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando.....");
        velocidade += 10;
        Console.WriteLine($"Velocidade atual: {velocidade}km ");
    }

    public void Frear()
    {
        Console.WriteLine("Freando......");
        velocidade -= 10;
        Console.WriteLine($"Velocidade atual: {velocidade}km ");
    }

    public void Buzinar()
    {
        Console.WriteLine("Bi bi");
    }

}
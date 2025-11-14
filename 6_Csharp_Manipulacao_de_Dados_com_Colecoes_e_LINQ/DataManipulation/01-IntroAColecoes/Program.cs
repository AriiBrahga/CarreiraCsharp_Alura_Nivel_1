using System.Collections;

var diaDaSemana = new DiasDaSemana();

var carrinho = new List<Produto>()
{
    new Produto() {Nome = "Leite", Preco = 7.83},
    new Produto() {Nome = "Manteiga", Preco = 3.45 }
};





void PercorrendoComEnumerator()
{
    var enumerator = diaDaSemana.GetEnumerator();
    while (enumerator.MoveNext())
    {
        var dia = enumerator.Current;
        Console.WriteLine(dia);
    }

}

void PercorrendoDiasDaSemana()
{
    foreach (string dia in diaDaSemana) //IEnumerable<string>
    {
        Console.WriteLine(dia);
    }
}

void PercorrendoComFor()
{
    for (int i = 0; i < carrinho.Count; i++)
    {
        var produto = carrinho[i];
        Console.WriteLine(produto.Nome);
    }
}
void PercorrendoComForEach()
{

    foreach (var produto in carrinho)
    {
        Console.WriteLine($"Produto: {produto.Nome}");
    }
}

class Produto
{
    public string Nome { get; set; }
    public double  Preco { get; set; }
}

class DiasDaSemanaEnumerator : IEnumerator<string>
{
    private int posicao = -1;
    private string[] dias = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

    public string Current => dias[posicao];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        posicao++;
        return posicao < dias.Length;
    }

    public void Reset()
    {
        posicao = -1;
    }
}

class DiasDaSemana : IEnumerable<string>
{
    

    public IEnumerator<string> GetEnumerator()
    {
        yield return "Domingo";
        yield return "Segunda";
        yield return "Terça";
        yield return "Quarta";
        yield return "Quinta";
        yield return "Sexta";
        yield return "Sábado";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
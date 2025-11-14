class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    private List<Episodio> Episodios = new List<Episodio>();
    public int TotalEpisodios => Episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}, produzido por {Host}");
        
        var episodiosOrdenados = Episodios.OrderBy(t => t.Ordem).ToList();
        
        foreach (var a in episodiosOrdenados)
        {
            Console.WriteLine(a.Resumo);
        }
        Console.WriteLine($"\n\nEsse podcast possui um total de {TotalEpisodios} episodios");
    }

}

class Episodio
{
    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"Episódio {Ordem} - {Titulo} \nCom os Convidados: {string.Join(", ", Convidado)}, Possui a duracao de {Duracao} minutos";
    
    private List<string> Convidado = new List<string>();
    public void AdicionarConvidados(string convidado)
    {
        Convidado.Add(convidado);
    }
}
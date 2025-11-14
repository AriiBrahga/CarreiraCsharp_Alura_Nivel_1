class Album
{
    //Criar um campo de Atributo Privado
    private List<Musica> musicas = new List<Musica>();

    // Construtor
    public Album(string nome)
    {
        Nome = nome;
    }

    //Propriedades
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas dod Album {Nome}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você de {DuracaoTotal} segundos");
    }
}
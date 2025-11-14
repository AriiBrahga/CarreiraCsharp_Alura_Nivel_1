Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my Life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

Console.WriteLine("\n\n\n\n\n");

Podcast podcast = new Podcast("Daniel", "FlowPodcast");
Episodio episodio = new Episodio(65,3, "Epidemias" );
episodio.AdicionarConvidados("Igor e Severino");

Episodio episodio1 = new Episodio(60, 1, "Viagens");
episodio1.AdicionarConvidados("Severino");

Episodio episodio2 = new Episodio(51, 2, "Politica");
episodio2.AdicionarConvidados("Igor");

podcast.AdicionarEpisodio(episodio);
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);

podcast.ExibirDetalhes();
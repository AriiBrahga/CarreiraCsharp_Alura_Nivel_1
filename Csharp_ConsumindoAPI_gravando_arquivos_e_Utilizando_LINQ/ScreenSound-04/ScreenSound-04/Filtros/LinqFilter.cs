using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicas = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicas)
        {
            Console.WriteLine($" - {genero}");
        }
    }

    public static void FiltarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical >> {genero}");
        foreach (var artistas in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artistas}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    public static void FiltrarTodasMusicasPelaKey(List<Musica> musicas, string indice)
    {
        var todasKeys = musicas.Where(musica => musica.Skey.Equals(indice)).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Indice: {indice} ");
        foreach (var keys in todasKeys)
        {
            Console.WriteLine($" - {keys}");
        }
    }

}

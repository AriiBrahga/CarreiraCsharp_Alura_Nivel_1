/*
    Seja um aplicativo de gerenciamento de músicas onde os usuários podem organizar suas faixas
    favoritas em playlists personalizadas. Para cada playlist, é essencial que o usuário tenha
    controle total sobre a sequência de reprodução das músicas, permitindo reordená-las
    livremente a qualquer momento. Além disso, o aplicativo precisa oferecer a funcionalidade de
    reprodução aleatória para uma playlist específica, proporcionando uma experiência de audição
    dinâmica e variada, sem, contudo, alterar a ordem original que o usuário definiu. O desafio
    é criar uma estrutura robusta que suporte a adição e remoção eficiente de músicas, a
    reordenação flexível dentro das playlists e a seleção de faixas tanto em modo sequencial
    quanto aleatório.

    Funcoes que vamos implementar:
    // [x] Criar as classes para musicas e playlist
    // [x] Listar musicas da playlist
    // [x] Adicionar musica à playlist
    // [x] Obter uma musica especifica da playlist
    // [x] Remover musica da playlist
    // [x] Tocar uma musica aleatoria da playlist
    // [x] Reordenar musicas segundo alguma logica especifica (ex. duracao)
    // [ ] Uma playlist nao pode ter musicas repetidas
    // [ ] Exibir as 10 musicas mais tocadas em todas as playlists (ranking)
    // [ ] Player de musica com:
    // [ ] - Fila de reproducao (para musicas avulsas e/ou playlists)
    // [ ] - Historico de reproducao
*/

using System.Collections;

var musica1 = new Musica { Titulo = "Que Pais é Esse?", Artista = "Legião Urbana", Duracao = 350 };
var musica2 = new Musica { Titulo = "Tempo Perdido", Artista = "Legião Urbana", Duracao = 455 };
var musica3 = new Musica { Titulo = "Pro Dia Nascer Feliz", Artista = "Barão Vermelho", Duracao = 345 };
var musica4 = new Musica { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 530 };
var musica5 = new Musica { Titulo = "Geração Coca-Cola", Artista = "Legião Urbana", Duracao = 380 };

var rockNacional = new Playlist { Nome = "Rock Nacional" };
rockNacional.Add(musica1);
rockNacional.Add(musica2);
rockNacional.Add(musica3);
rockNacional.Add(musica4);
rockNacional.Add(musica5);

ExibirPlaylist(rockNacional);

rockNacional.OrdenarPorDuracao();
ExibirPlaylist(rockNacional);

rockNacional.OrdenarPorArtista();
ExibirPlaylist(rockNacional);


rockNacional.OrdenarPorTitulo();
ExibirPlaylist(rockNacional);

void ExibirPlaylist(Playlist playlist)
{
    Console.WriteLine($"\n Tocando as musicas de {playlist.Nome}");
    foreach (var musica in playlist)
    {
        Console.WriteLine($"\t - {musica.Titulo} ({musica.Artista}) - {musica.Duracao} segundos");
    }
}

void RemoverMusicaPeloTitulo(Playlist playlist, string titulo)
{
    var musicaEncontrada = playlist.ObterPeloTitulo(titulo);
    if (musicaEncontrada is not null)
    {
        Console.WriteLine("\nRemovendo música...");
        rockNacional.Remove(musicaEncontrada);
    }
    else
    {
        Console.WriteLine("\nMúsica não encontrada!");
    }
    ExibirPlaylist(rockNacional);
}

void ExibirMusicaAleatoria(Playlist playlist)
{
    var musicaAleatoria = playlist.ObterAletoria();
    if (musicaAleatoria is not null)
    {
        Console.WriteLine($"\nA música Aleatória é {musicaAleatoria.Titulo}");
    }
    else
    {
        Console.WriteLine("Playlist Vazia!!");
    }

}

class PorArtista : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Artista.CompareTo(y.Artista);
    }
}
class PorTitulo : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Titulo.CompareTo(y.Titulo);
    }
}

class Musica : IComparable
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }

    public int CompareTo(object? other) // iguais = 0; menor = -1; maior = 1
    {
        if (other == null) return -1;
        if (other is Musica outraMusica) return this.Duracao.CompareTo(outraMusica.Duracao);
        return -1;
    }

}

class Playlist : ICollection<Musica>
{
    public string Nome { get; set; }

    public int Count => lista.Count;

    public bool IsReadOnly => false;

    private List<Musica> lista = new List<Musica>();

    public IEnumerator<Musica> GetEnumerator()
    {
        return lista.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Musica musica)
    {
        lista.Add(musica);
    }

    public void Clear()
    {
        lista.Clear();
    }

    public bool Contains(Musica item)
    {
        return lista.Contains(item);
    }

    public Musica? ObterPeloTitulo(string titulo)
    {
        foreach (var musica in lista)
        {
            if (musica.Titulo == titulo)
            {
                return musica;
            }
        }
        return null;
    }

    public Musica? ObterAletoria()
    {
        if (lista.Count == 0) return null;
        var random = new Random();
        var indiceAleatorio = random.Next(0, lista.Count - 1);
        return lista[indiceAleatorio];
    }


    public void OrdenarPorTitulo()
    {
        lista.Sort(new PorTitulo());
    }

    public void OrdenarPorArtista()
    {
        lista.Sort(new PorArtista());
    }

    public void OrdenarPorDuracao()
    {
        lista.Sort(); // duracao? IComparable
    }
    public void CopyTo(Musica[] array, int arrayIndex)
    {
        lista.CopyTo(array, arrayIndex);
    }

    public bool Remove(Musica item)
    {
        return (lista.Remove(item));
    }
}

using System.Text.Json;
using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        LinqFilter.FiltrarTodasMusicasPelaKey(musicas, "C#");

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");



        //musicas[0].ExibirDetalhesDaMusica();


        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[5]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[854]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();
        //musicasPreferidasDoDaniel.GerarArquivoJson();


    }
    catch (Exception ex){
        Console.WriteLine($"Temos um problema: { ex.Message}");
    }
}
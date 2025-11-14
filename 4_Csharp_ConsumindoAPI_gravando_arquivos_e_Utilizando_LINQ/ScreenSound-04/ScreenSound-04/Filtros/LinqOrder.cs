using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros
{
    class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine("Lista de Artistas Ordenados");
            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}

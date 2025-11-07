using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos
{
    class Musica
    {
        private List<string> tonalidades = new List<string>() {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" }; 

        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        [JsonPropertyName("key")]
        public int Key { get; set; }
        public string Skey
        {
            get
            {
                return tonalidades[Key];
            }
        }
        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Duracao: {Duracao/1000} segundos");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Key : {Skey}");
        }

    }
}

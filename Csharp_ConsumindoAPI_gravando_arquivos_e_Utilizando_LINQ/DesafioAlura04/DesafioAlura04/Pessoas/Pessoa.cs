
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesafioAlura04.Pessoas
{
    class Pessoa
    {
        
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("idade")]
        public int Idade { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        private string path { get; set; }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                idade = Idade,
                email = Email
            });
            string nomeDoArquivo = $"Informacoes-do-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"Json foi criado com sucesso! \n{Path.GetFullPath(nomeDoArquivo)}");
            path = Path.GetFullPath(nomeDoArquivo);
        }

        public void LerArquivoJson()
        {
            Console.WriteLine("Arquivo Json: " + path);
            var arquivojson = File.ReadAllText(path);

            var pessoa = JsonSerializer.Deserialize<Pessoa>(arquivojson)!;

            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"Email: {pessoa.Email}");
        }
    }
}

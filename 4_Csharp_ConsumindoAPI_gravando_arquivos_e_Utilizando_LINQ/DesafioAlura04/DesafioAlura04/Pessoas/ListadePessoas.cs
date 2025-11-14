using System.Text.Json;

namespace DesafioAlura04.Pessoas
{
    class ListadePessoas
    {
        public ListadePessoas()
        {
            Pessoas = new List<Pessoa>();
            path = "";
        }

        public List<Pessoa> Pessoas { get; set; }
        private string path {  get; set; }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public void GerarArquivoJson()
        {
            string nomeDoArquivo = $"Informacoes-das-Pessoas.json";
            string json = JsonSerializer.Serialize(Pessoas);
            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"Json foi criado com sucesso! \n{Path.GetFullPath(nomeDoArquivo)}");
            path = Path.GetFullPath(nomeDoArquivo);
        }

        public void LerArquivoJson()
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    Console.WriteLine("Arquivo JSON não encontrado. Verifique o caminho.");
                    return;
                }

                var arquivojson = File.ReadAllText(path);
                
                var pessoa = JsonSerializer.Deserialize<List<Pessoa>>(arquivojson)!;

                Console.WriteLine("Pessoas: \n");
                foreach (var item in pessoa)
                {
                    Console.WriteLine($"\nNome: {item.Nome}");
                    Console.WriteLine($"Idade: {item.Idade}");
                    Console.WriteLine($"Email: {item.Email}");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

    }
}

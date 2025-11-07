namespace Alura.Filme;

//1 - Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco.Após isso, colocá-la no namespace Alura.Filmes.

class Filme
{
    public Filme(string nomeFilme, int duracao, List<string>? elenco)
    {
        NomeFilme = nomeFilme;
        Duracao = duracao;

        if (elenco != null )
        {
            Elenco = elenco;
        }
        else
        {
            Elenco = new List<string>();
        }

    }

    public string NomeFilme { get; set; }
    public int Duracao { get; set; }
    public List<string> Elenco { get; set; }


    public void AdicionarElenco(string elenco)
    {
        Elenco.Add(elenco);
    }
    public void ListarElenco()
    {
        if (Elenco.Count == 0)
        {
            Console.WriteLine("Elenco vazio.");
        }
        else
        {
            Console.WriteLine("Elenco... ");
            foreach (var ator in Elenco)
            {
                Console.WriteLine(ator);
            }
        }
    }


}
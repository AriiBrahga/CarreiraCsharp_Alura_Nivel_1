namespace Alura.Filme;

/*
3 - Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. 
    A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.
*/

class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    private List<Filme> Filmes = new List<Filme>();
    public int QuantidadeDeFilmes => Filmes.Count;

    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void AdicionarFilme(Filme filme)
    {
        Filmes.Add(filme);
    }

    public void ExibirDetalhes()
    {
        if (Filmes.Count > 0)
        {
            Console.WriteLine($"Artista: {Nome}\nIdade: {Idade}");
            Console.WriteLine($"Filmes que {Nome} atuou: ");
            foreach (Filme filme in Filmes)
            {
                Console.WriteLine($"Titulo: {filme.NomeFilme} ");
            }
        }
        else
        {
            Console.WriteLine($"Nenhum filme encontrado para o ator {Nome} ");
        }       
    }
}
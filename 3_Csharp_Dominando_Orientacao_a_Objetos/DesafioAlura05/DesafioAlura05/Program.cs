/*
1 - Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

2 - Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.

3 - Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. 
    A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.

4 - Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, 
    ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

 */

using Alura.Filme;
//2

List<Filme> filme = new();
Filme filme1 = new("Minions", 120, new List<string>());

Filme filme2 = new("Superman", 110, new List<string>() { "Marlon Brando", "Al Pacino", "Talia Shire" });

Filme filme3 = new("Flash", 90, new List<string>() { "Carlos", "Adam", "Gust" });

Filme filme4 = new("Vingadores", 140, new List<string>() { "Joao", "Pacino", "Shire" });

Filme filme5 = new("Batman", 150, new List<string>() { "Hiago", "Al Pacino", "Shire" });

filme.Add(filme1);
filme.Add(filme2);
filme.Add(filme3);
filme.Add(filme4);
filme.Add(filme5);

foreach (var i in filme)
{
    Console.WriteLine($"\nFilme: {i.NomeFilme}\nDuracao: {i.Duracao}");
    Console.WriteLine();
    i.ListarElenco();
    Console.WriteLine();
}

// 3 
Artista artista = new("Brad Pit", 45);
artista.AdicionarFilme(filme1);
artista.AdicionarFilme(filme5);
artista.ExibirDetalhes();

using DesafioAlura04.Pessoas;

namespace DesafioAlura04.Filtros
{
    class LinqFilter
    {
        public static void FiltarPessoasPorIdade(List<Pessoa> pessoas, int idade)
        {
            var pessoasPorIdade = pessoas.Where(pessoa => pessoa.Idade! == idade).Select(pessoa => pessoa).ToList();
            Console.WriteLine($"Exibindo as pessoas pela Idade >> {idade}");
            foreach (var pessoa in pessoasPorIdade)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Idade: {pessoa.Idade}");
                Console.WriteLine($"Email: {pessoa.Email}");

            }
        }
    }
}

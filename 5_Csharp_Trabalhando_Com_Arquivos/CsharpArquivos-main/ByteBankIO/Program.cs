using System.Text;
using ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {
        //UsarStreamDeEntrada();


        //Console.WriteLine("Digite um nome: ");
        //var nome = Console.ReadLine();


        //var linhas = File.ReadAllLines("contas.txt");
        //Console.WriteLine(linhas);

        //foreach (var line in linhas)
        //{
        //    Console.WriteLine(line);
        //}

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"O Arquvio possui {bytesArquivo.Length} bytes");

        File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

        Console.WriteLine("Aplicacao Finalizada");

        Console.ReadLine();
    }
}

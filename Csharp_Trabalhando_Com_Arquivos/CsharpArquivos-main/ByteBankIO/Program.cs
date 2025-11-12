using System.Text;
using ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor =new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine(); le a linha

            //var texto = leitor.ReadToEnd(); le o arquivo completo

            //var numero = leitor.Read(); le o primeiro byte

            while(!leitor.EndOfStream )
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }


        }
        Console.ReadLine();
    }
}

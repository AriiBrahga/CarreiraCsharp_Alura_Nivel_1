using System.Text;
using ByteBankIO;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            // 1 KB
            var buffer = new byte[1024];

            while (numeroDeBytesLidos != 0)
            {

                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes Lidos {numeroDeBytesLidos} ");
                EscreverBuffer(buffer, numeroDeBytesLidos);

            }


            //Devoluções
            // O numero total de bytes lidos do buffer. Isso poderá ser menor que o numero de
            // bytes solicitando se esse byneri de bystes não estiver disponivel no momento,
            // ou zero, se o final do fluxo for atingido



            fluxoDoArquivo.Close();

            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);
        /*
        foreach (byte b in buffer)
        {
            Console.Write(b);
            Console.Write(" ");
        }*/
    }
}
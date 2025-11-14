/*double a, b;
Console.Write("Digite o valor de A: ");
a = double.Parse(Console.ReadLine());
Console.Write("Digite o valor de B: ");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o operador *,/,+,-");
string operador = Console.ReadLine();
double operacao = 0.0;

operacao = operador switch {
    "*" => a * b,
    "+" => a + b,
    "-" => a - b,
    "/" => a / b,
};
Console.WriteLine("Resultado: " +operacao);*/

int somaValor = 0;
int numero;

do
{
    Console.WriteLine("Digite o valor da venda, ou 0 para encerrar: ");
    numero = int.Parse(Console.ReadLine());
    somaValor += numero;
} while (numero != 0);

Console.WriteLine($"O valor total de vendas é {somaValor}");

int escolha, quantidade;
int estoque = 0;
do
{
    Console.WriteLine("Deseja adicionar um produto ao estoque?\r\n1 - Sim | 0 - Não");
    escolha = int.Parse(Console.ReadLine()!);
    if (escolha == 0)
    {
        break;
    }
    Console.WriteLine("Quantidade: ");
    quantidade = int.Parse(Console.ReadLine()!);
    estoque += quantidade;

    Console.WriteLine($"Estoque: {estoque}");
} while ( escolha != 0);

/*Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o
 * resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.*/
/*
using System.Xml;

//1
double a, b;

Console.Write("Digite o numero A: ");
a = double.Parse(Console.ReadLine());
Console.Write("Digite o numero B: ");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Soma de A e B: " + (a + b));
Console.WriteLine("Subtracao de A e B: " + (a - b));
Console.WriteLine("Divisao de A e B: " + (a / b));
Console.WriteLine("Multiplicacao de A e B: " + (a * b));


//2
List<string> bandas = new List<string>();

do
{
    Console.Write("Fale uma Banda para adicionar a Lista: ");
    string nomeBanda = Console.ReadLine();
    bandas.Add(nomeBanda);
    Console.WriteLine("Deseja Adicionar mais? S/N");
    char resposta = char.Parse(Console.ReadLine()!);
    if (resposta == 'N' || resposta == 'n')
    {
        break;
    }
    else if (resposta != 's' && resposta != 'S')
    {
        Console.WriteLine("Respósta inválida!");
        return;
    }
} while (true);

//3
Console.WriteLine("Suas Bandas Listadas: ");
foreach (string banda in bandas)
{
    Console.WriteLine(banda);
}
//4

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
int somaNumeros = 0;

foreach (int numero in numeros)
{
    somaNumeros += numero;
}
Console.WriteLine("Soma dos Numeros: " + somaNumeros);

*/
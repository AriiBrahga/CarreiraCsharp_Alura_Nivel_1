/* A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos 
 * que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a 
 * sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar então?

Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
Dica: Em caso de dúvidas para resolver os exercícios, recorra a Luri (Inteligência Artificial da Alura) ou a nossa comunidade no Fórum.*/

/*
// 1
int notamedia = int.Parse(Console.ReadLine());

if (notamedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
}
// 2

List<string> lista = new List<string>();


string linguagem;
int n = 0;
while (true)
{
    Console.Write("Informe a Linguagem: ");
    linguagem = Console.ReadLine();
    lista.Add(linguagem!);

    Console.WriteLine("Sair? S/N");
    string sair = Console.ReadLine()!;
    if (sair == "S")
    {
        break;
    }
}

// 3
Console.WriteLine(lista[0]);

//4
Console.Write("Digite a Posição da Lista:  ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(lista[num]);

*/
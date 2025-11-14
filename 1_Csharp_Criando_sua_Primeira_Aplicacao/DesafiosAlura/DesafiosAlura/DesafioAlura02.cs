/*Chegou a hora de você seguir todos os passos realizados durante esta aula e criar um jogo com os conhecimentos adquiridos.

Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número.
O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor do que o número gerado pelo programa.

O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias 
tentativas até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem indicando que o jogo acabou.*/

/*
var random = new Random();
int numeroAleatorio = random.Next(0, 100);

int numeroEscolhido;

do
{
    Console.Write("Tente acertar o número que estou pensando entre 1 a 100: ");
    numeroEscolhido = int.Parse(Console.ReadLine());

    if (numeroEscolhido > numeroAleatorio)
    {
        Console.WriteLine("O numero que eu pensei é um pouco menor! Tente Novamente! ");
    }
    else if (numeroEscolhido < numeroAleatorio)
    {
        Console.WriteLine("O numero que eu pensei é um pouco maior! Tente Novamente! ");
    }
} while (numeroEscolhido != numeroAleatorio);

Console.WriteLine("Acerto!!! O numero que eu pensei era " + numeroAleatorio);

*/
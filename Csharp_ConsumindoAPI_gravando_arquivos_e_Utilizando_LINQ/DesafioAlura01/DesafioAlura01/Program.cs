/*
1 - Escrever um programa que faça uma requisição para a API de games CheapShark e mostre na tela a lista de promoções cadastrada na ferramenta 
    (Você pode utilizar o endpoint: https://www.cheapshark.com/api/1.0/deals).

2 - Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b. 
    Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.

3 - Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.

4 - Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.
*/

using DesafioAlura01;
//1
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

//2 



try
{
    Console.WriteLine("A: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("B: ");
    int b = int.Parse(Console.ReadLine());
    int rep = a / b;
    Console.WriteLine(rep);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: Na Matematica nao é possivel divisão por 0");
}
catch (Exception ex)
{
    Console.WriteLine($"Temos um problema: {ex.Message}");
}


// 3 


try
{
    List<int> list = new List<int>() { 1, 2, 5, 6 };
    Console.WriteLine($"Numero: {list[7]} ");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

// 4 
try
{
    Classe objetoNulo = null;
    objetoNulo.Metodo();
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

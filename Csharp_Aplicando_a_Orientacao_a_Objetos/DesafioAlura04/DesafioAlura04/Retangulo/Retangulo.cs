/*Crie uma classe chamada Retangulo que tenha:

Duas propriedades públicas: Altura e Largura.
Um método chamado CalcularArea() que retorne a área do retângulo (altura × largura).
Depois, crie um objeto da classe, atribua os valores e mostre o resultado da área na tela.
*/

class Retangulo
{
    public decimal Altura { get; set; }
    public decimal Largura { get; set; }

    public void CalcularArea()
    {
        Console.WriteLine($"A Area do Retangulo é {Altura * Largura}");
    }

}


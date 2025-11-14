/*
1 - Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. 
    Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.

2 - Crie uma hierarquia de classes representando funcionários de uma empresa. 
    Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, 
    além das propriedades comuns a todos os funcionários, como Nome e Salário.

3 - Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca. 
    Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.

4 - Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. 
    Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.

5 - Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. 
    Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.
*/

using DesafioAlura07.FormasGeometricas;

Dictionary<int, FormaGeometrica> opcao = new();
opcao.Add(1, new Triangulo());
opcao.Add(2, new Quadrado());
opcao.Add(3, new Circulo());
Console.Write("\nCalcular o Perimetro e Area: \n1 - Triangulo\n2 - Quadrado\n3 - Circulo \nEscolha: ");
int escolha = int.Parse(Console.ReadLine());

double bases, altura, lado, lado2, raio;

FormaGeometrica formaGeometrica = opcao[escolha];

if (escolha == 1)
{
    Console.WriteLine("Informe a Base: ");
    bases = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a Altura: ");
    altura = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o Lado 1: ");
    lado = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o Lado 2: ");
    lado2 = double.Parse(Console.ReadLine());
    formaGeometrica = new Triangulo()
    {
        Base = bases,
        Altura = altura,
        Lado1 = lado,
        Lado2 = lado2,
    };
}else if (escolha == 2)
{
    Console.WriteLine("Informe o Lado: ");
    lado = double.Parse(Console.ReadLine());
    formaGeometrica = new Quadrado()
    {
        Lado = lado,
    };

}else if (escolha == 3)
{
    Console.Write("Informe o Raio: ");
    raio = double.Parse(Console.ReadLine());
    formaGeometrica = new Circulo()
    {
        Raio = raio,
    };
}

if (opcao.ContainsKey(escolha))
{
    double area, perimetro;
    area = formaGeometrica.CalcularArea();
    perimetro = formaGeometrica.Perimetro();
    Console.WriteLine($"Area: {area}");
    Console.WriteLine($"Perimetro: {perimetro}");
}
else
{
    Console.WriteLine("Opcao Inválida!");
}

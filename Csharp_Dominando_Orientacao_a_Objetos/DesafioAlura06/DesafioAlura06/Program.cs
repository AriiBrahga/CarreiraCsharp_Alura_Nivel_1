/*
1 - Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

2 - Modelar o funcionamento de uma oficina automobilistica.

3 - Criar um programa Program.cs e simular o funcionamento do programa.

4 - Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. 
    O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.
 */

//1

using DesafioAlura06.Calculadora;
using DesafioAlura06.Oficina;
using DesafioAlura06.PetShop;

Medico medico = new("Franciele", 32, "Cirurgia");
Medico medico2 = new("Alfred", 24, "Veterinario");

Pet pet1 = new("Pongo", "Dalmata", "Cachorro", "Macho");
Pet pet2 = new("Mia", "Egipcio", "Gato", "Femea");
Pet pet3 = new("Hero", "Calopsita", "Passarinho", "Macho");

Dono dono1 = new(17, "Joao", "16-9999-9999");
Dono dono2 = new(32, "Joana", "17-8888-8888");

Consulta consulta1 = new("Almeida's Pet", new DateTime(2025, 12, 25, 10, 30, 0), dono1, medico, pet1);
consulta1.ValorConsulta(210.10);
consulta1.ExibirFicha();

// 3

Veiculo meuCarro = new Veiculo("Chevrolet", "Cruze", 2020, "ABC1234");
Cliente cliente = new Cliente("Carlos", "987654321");
Mecanico mecanico = new Mecanico("Mário", "Mecânica Geral");
FichaCliente ficha = new FichaCliente(meuCarro, cliente, mecanico);
Console.WriteLine("\n\n");
ficha.AgendarServico(new DateTime(2025, 12, 25, 10, 30, 0));
ficha.ExibirFicha();
Console.WriteLine("\n\n");
Oficina oficina = new Oficina();
oficina.AdicionarFicha(ficha);
oficina.ListarVeiculos();

// 4

double num1, num2;
double resultado;
char operacao;
Console.Write("Num A: ");
num1 = double.Parse(Console.ReadLine());
Console.Write("Num B: ");
num2 = double.Parse(Console.ReadLine());
Console.Write("Operacao: (*, /, -, +, r, ^): ");
operacao = char.Parse(Console.ReadLine());

resultado = Calculadora.Operacao(num1, num2, operacao);
Console.WriteLine($"{resultado.ToString("F2")}");
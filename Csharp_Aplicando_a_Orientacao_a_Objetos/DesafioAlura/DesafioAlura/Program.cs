/*
1 - Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
2 - Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
3 - Desenvolver um método da classe Conta que exibe suas informações.
4 - Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar*/

//1

//2

Conta conta = new Conta();
conta.idConta = 1;
conta.titular = "João";
conta.saldo = 1733.1;
conta.senha = "123456qwert";

/*Console.WriteLine("INFORMAÇÕES DA CONTA:");
Console.WriteLine($"Titular: {conta.titular}");
Console.WriteLine($"Saldo: {conta.saldo}");*/

//3
conta.ExibirInformacoesConta();


//4
Carro carro = new Carro();
carro.modelo = "Voyage";
carro.velocidade = 80;

carro.ExibirCarro();
carro.Acelerar();
carro.Frear();
carro.Buzinar();

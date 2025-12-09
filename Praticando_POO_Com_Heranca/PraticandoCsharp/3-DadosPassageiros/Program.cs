/*Imagine que você está desenvolvendo um sistema para uma empresa de transporte que precisa gerenciar informações sobre seus passageiros. 
 Cada pessoa cadastrada possui dados básicos, como nome e idade, mas os passageiros também podem informar quantos bilhetes já adquiriram. 
 Seu objetivo é criar uma estrutura que organize essas informações de forma clara e eficiente.

Crie um programa que:

1 - Defina uma classe Pessoa com os atributos Nome e Idade.
2 - Crie a classe Passageiro, herdando de Pessoa, e adicione o atributo QuantidadeBilhetes.
3 - Implemente um método dentro de Passageiro para exibir os dados formatados no console.
4 - Cadastre dois passageiros com dados fictícios e exiba suas informações.
*/

Passageiro p1 = new Passageiro("Lúcia", 45, 3);
Passageiro p2 = new Passageiro("Rodrigo", 30, 1);

p1.Descricao();
p2.Descricao();
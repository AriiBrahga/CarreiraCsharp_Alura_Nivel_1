/*
Você está desenvolvendo um sistema para um centro técnico especializado na montagem de computadores personalizados. 
Cada computador é composto por diferentes peças, e cada peça possui características próprias. Ao invés de herdar, 
faz mais sentido compor um computador com essas peças, já que um computador tem uma placa-mãe, tem um processador, e assim por diante.

Seu desafio é criar uma estrutura que represente essa montagem usando composição.

Crie um programa que:

1 - Defina a classe Processador, com os atributos Marca e Modelo.
2 - Defina a classe PlacaMae, com os atributos Fabricante e Socket.
3 - Crie a classe Computador, que possua como atributos um Processador e uma PlacaMae.
4 - Instancie objetos das peças com dados fictícios e associe a um objeto da classe Computador.
5 - Crie um método ExibirConfiguracao() na classe Computador que exiba no console os dados completos do computador. 
*/
Processador cpu = new Processador("Intel", "i7-12700K");
PlacaMae mobo = new PlacaMae("ASUS", "LGA1700");
Computador pc = new Computador(cpu, mobo);

pc.ExibirConfiguracao();
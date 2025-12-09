/*
    Você está desenvolvendo um sistema interno para uma empresa que deseja organizar as informações de seus colaboradores. 
    A empresa possui funcionários fixos, que recebem salário mensal, e freelancers, que trabalham por projetos com valores específicos. 
    Seu desafio é criar uma estrutura que represente esses dois tipos de colaboradores, aproveitando os conceitos de herança para evitar repetição de código.

    Crie um programa que:

    Defina uma classe base Funcionario com os atributos Nome e Cargo.
    Crie uma classe filha Freelancer que herde de Funcionario e adicione o atributo ValorProjeto.
    Crie uma classe filha Interno que herde de Funcionario e adicione o atributo Salario.
    Instancie pelo menos um objeto de cada classe filha, atribuindo valores a cada atributo.
    Exiba as informações no terminal.
 
*/
Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00m);
Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00m);

f1.Descricao();
f2.Descricao();
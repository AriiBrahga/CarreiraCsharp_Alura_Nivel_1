/*
Imagine que você está criando um sistema para uma empresa de tecnologia que oferece diferentes tipos de serviços (como manutenção ou consultoria). 
Cada serviço tem um responsável técnico (funcionário), e cada tipo de serviço possui sua própria forma de executar a tarefa.

O objetivo é garantir que todos os serviços possam ser executados de forma padronizada, 
mas com lógica específica. E, cada serviço deve conter um funcionário responsável.

Seu desafio é combinar interface e composição para representar essa estrutura.

Crie um programa que:

1 - Defina a interface IServico, com o método ExecutarServico().
2 - Crie a classe Funcionario, com os atributos Nome e Departamento.
3 - Crie as classes Manutencao e Consultoria, que implementam IServico.
4 - Em cada classe, associe um Funcionario por composição e implemente o método ExecutarServico() com:
        O tipo do serviço
        O título da tarefa
5 - E os dados do funcionário responsável.
6 - No Program.cs, instancie os serviços e chame o método ExecutarServico().
 */

Funcionario tecnico = new Funcionario("João", "TI");
IServico s1 = new Manutencao("Atualização de servidor", tecnico);

Funcionario analista = new Funcionario("Marina", "Consultoria");
IServico s2 = new Consultoria("Planejamento estratégico", analista);

s1.ExecutarServico();
s2.ExecutarServico();
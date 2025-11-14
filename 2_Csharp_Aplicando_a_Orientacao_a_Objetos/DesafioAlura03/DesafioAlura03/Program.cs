/*
1 - Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, 
      saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
2 - Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
3 - Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
4 - Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. 
        A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
5 - Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. 
    A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.*/



// 2

Titular novaConta = new Titular("João")
{
    Cpf = "46185584771",
    Endereco = "Rua Lorem, n123"
};
Conta conta = new Conta(novaConta, 1000, 3485);
conta.Saldo = 854;
conta.Agencia = 4010;

conta.ExibirInformacoes();

// 3

Produto produto1 = new Produto("Agua", "Garrafa de 200ml de Agua", 2.50, 10);
Produto produto2 = new Produto("Refigerante", "Garrafa de 300ml", 4.50, 10);
Estoque estoque = new Estoque();    
estoque.AdicionarProduto(produto1);
estoque.AdicionarProduto(produto2);
estoque.ExibirProdutos();

// 4 

Console.WriteLine("------------ \n\n\n\n");

Aluno aluno1 = new Aluno();
aluno1.Idade = 17;
aluno1.Nome = "João";
aluno1.Notas = 8;

Aluno aluno2 = new Aluno();
aluno2.Idade = 17;
aluno2.Nome = "Clara";
aluno2.Notas = 7;

Disciplina disciplina = new Disciplina();
disciplina.NomeDiciplina = "Matemática";
disciplina.AdicionarAlunos(aluno1);
disciplina.AdicionarAlunos(aluno2);

Disciplina disciplina1 = new Disciplina();
disciplina1.NomeDiciplina = "Portugues";
disciplina1.AdicionarAlunos(aluno2);

Professor prof = new Professor();
prof.Nome = "Carlos";
prof.AdicionarDiciplinas(disciplina);
prof.AdicionarDiciplinas(disciplina1);

prof.ExibirInformacoes();

prof.RemoverDisciplina(disciplina);
Console.WriteLine("Removendo");
prof.ExibirInformacoes();
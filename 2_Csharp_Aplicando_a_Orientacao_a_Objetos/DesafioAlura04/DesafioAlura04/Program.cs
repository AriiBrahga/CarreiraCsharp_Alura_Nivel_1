Retangulo retangulo = new Retangulo();
retangulo.Altura = 8;
retangulo.Largura = 12;
retangulo.CalcularArea();

Filme filme = new Filme();
filme.Titulo = "Minions";
filme.ClassificacaoEtaria = 12;
filme.PodeAssistir(10);

Produto produto = new Produto("Agua", 10);
produto.Retirar(8);
produto.ExibirEstoque();

Pedido pedido = new Pedido("001", "Joao", "Pendente");
Console.WriteLine("\n\n");
pedido.ExibirPedido();
pedido.AtualizarStatus("Enviado");
pedido.ExibirPedido();

Console.WriteLine("\n\n");
Consulta consulta = new Consulta("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
consulta.ExibirResumo();
consulta.Reagendar(new DateTime(2025, 5, 25));
consulta.ExibirResumo();


Console.WriteLine("\n\n");
InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
ProdutoDigital Digital = new ProdutoDigital("Photoshop", 89.99, info);
Digital.ExibirDetalhes();
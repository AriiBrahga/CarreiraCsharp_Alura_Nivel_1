// 3 - Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.

class Estoque
{

    List<Produto> Produtos = new List<Produto>();

    public void AdicionarProduto(Produto p)
    {
        Produtos.Add(new Produto(p.Nome, p.Descricao, p.Preco, p.QuantidadeProduto));
    }

    public void ExibirProdutos()
    {

        Console.WriteLine($"Estoque de Produtos");
        foreach (Produto produto in Produtos)
        {
            Console.WriteLine($"Produto: {produto.Nome}\nDescricao: {produto.Descricao}\nPreco: {produto.Preco}\nQuantidade: {produto.QuantidadeProduto}");
        }
    }

}

class Produto
{
    public Produto(string nome, string descricao, double preco, int quantidadeProduto)
    {
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        QuantidadeProduto = quantidadeProduto;
    }

    public string Nome { get;}
    public string Descricao { get; }
    public double Preco { get;}
    public int QuantidadeProduto { get;}

    public void ExibirProduto()
    {
        Console.WriteLine($"Produto: {Nome}\nDescricao: {Descricao}\nPreco: {Preco}\nQuantidade: {QuantidadeProduto}");
    }

}
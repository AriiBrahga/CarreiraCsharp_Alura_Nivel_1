/*
Crie uma classe chamada Produto com:

Propriedade pública Nome.
Campo privado quantidadeEstoque.
Um construtor que receba o nome e a quantidade inicial.
Um método público Retirar(int quantidade) que:
Reduz a quantidade apenas se houver estoque suficiente.
Exiba uma mensagem indicando o sucesso ou a falha da operação.
Um método ExibirEstoque() para mostrar a quantidade atual.
*/

class Produto
{

    public string Nome { get; set; }
    private int quantidadeEstoque;

    public Produto(string nome, int quantidadeEstoque)
    {
        Nome = nome;
        this.quantidadeEstoque = quantidadeEstoque;
    }

    public void Retirar(int quantidade)
    {
        if (quantidadeEstoque > 0)
        {
            if (quantidadeEstoque > quantidade)
            {
                quantidadeEstoque -= quantidade;
                Console.WriteLine($"Retirada de {quantidade} unidades realizada com sucesso.");
            }
            else
            {
                Console.WriteLine($"Erro: Estoque insuficiente para retirada de {quantidade} unidades.");
            }
        }
        else
        {
            Console.WriteLine($"O Produto {Nome} não possui estoque disponivel");
        }
    }
    public void ExibirEstoque()
    {
        Console.WriteLine($"Produto: {Nome} \nEstoque disponivel: {quantidadeEstoque}");
    }
}

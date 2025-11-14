/*Crie:

Uma classe InformacaoTecnica com:
Propriedades TamanhoMB e SistemaOperacional.
Uma classe ProdutoDigital com:
Propriedades Nome, Preco e InfoTecnica (do tipo InformacaoTecnica).
Um método ExibirDetalhes() para mostrar tudo na tela.*/

class InformacaoTecnica
{
    public InformacaoTecnica(int tamanhoMB, string sistemaOperacional)
    {
        TamanhoMB = tamanhoMB;
        SistemaOperacional = sistemaOperacional;
    }

    public int TamanhoMB { get; set; }
    public string SistemaOperacional { get; set; }

}

class ProdutoDigital
{
    public ProdutoDigital(string nome, double preco, InformacaoTecnica infoTecnica)
    {
        Nome = nome;
        Preco = preco;
        InfoTecnica = infoTecnica;
    }

    public string Nome { get; set; }
    public double Preco { get; set; }
    public InformacaoTecnica InfoTecnica { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}\r\nPreço: R$ {Preco.ToString("F2")}\r\nTamanho: {InfoTecnica.TamanhoMB}MB\r\nCompatível com: {InfoTecnica.SistemaOperacional}");
    }
}
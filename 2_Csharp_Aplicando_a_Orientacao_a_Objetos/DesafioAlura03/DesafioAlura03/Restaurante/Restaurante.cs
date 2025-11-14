/*
5 - Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. 
    A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. 
    Os pedidos podem estar associados a uma mesa.
*/

class Restaurante
{
    public string NomeRestaurante { get; set; }
    public List<Mesa> Mesas { get; set; }  = new List<Mesa>();
    public Cardapio Cardapio { get; set; } = new Cardapio();

}
class Mesa
{
    public int MesaNumero { get; set; }
    public List<Pedido> Pedidos = new List<Pedido>();
    public bool Disponivel { get; }
}
class Pedido
{
    public int Quantidade { get; set; }
    public ItensCardapio Item { get; set; }

}

class Cardapio
{
    public List<ItensCardapio> Produtos { get; set; } = new List<ItensCardapio>();
    
}
class ItensCardapio
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}
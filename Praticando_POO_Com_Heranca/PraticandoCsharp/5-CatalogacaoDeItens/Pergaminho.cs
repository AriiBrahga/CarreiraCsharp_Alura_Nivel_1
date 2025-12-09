class Pergaminho : ItemDigital
{
    public Pergaminho(string titulo, string conteudoTextual) : base(titulo)
    {
        ConteudoTextual = conteudoTextual;
    }
    public string ConteudoTextual { get; set; }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Detalhes do Pergaminho:\r\nTítulo: {Titulo}\r\nDescrição: {ConteudoTextual}");
    }

}
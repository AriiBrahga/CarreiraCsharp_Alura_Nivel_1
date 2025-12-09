class Certificado
{
    public Certificado(Profissao profissao)
    {
        this.profissao = profissao;
        Console.WriteLine($"Certificado emitido para: {profissao.Titulo}");
    }

    public Profissao profissao { get; set; }
}

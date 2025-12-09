class Computador
{
    public Computador(Processador proc, PlacaMae plMae)
    {
        Proc = proc;
        PlMae = plMae;
    }

    public Processador Proc { get; set; }
    public PlacaMae PlMae { get; set; }

    public void ExibirConfiguracao()
    {
        Console.WriteLine($"Computador configurado com:\r\nProcessador: {Proc.Marca} - {Proc.Modelo}\r\nPlaca-mãe: {PlMae.Fabricante} - {PlMae.Socket}");
    }
}

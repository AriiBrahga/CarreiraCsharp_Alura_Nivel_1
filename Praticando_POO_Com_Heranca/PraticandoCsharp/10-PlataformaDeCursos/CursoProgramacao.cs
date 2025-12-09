class CursoProgramacao : ICurso
{
    public CursoProgramacao(string curso, Instrutor professor)
    {
        Curso = curso;
        Professor = professor;
    }

    public string Curso { get; set; }
    public Instrutor Professor { get; set; }

    public void PublicarCurso()
    {
        Console.WriteLine($"Validando conteúdo do curso de programação: {Curso}\r\n");
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Curso publicado com sucesso: {Curso} - Instrutora: {Professor.Nome} ({Professor.Especialidade})");
    }
}
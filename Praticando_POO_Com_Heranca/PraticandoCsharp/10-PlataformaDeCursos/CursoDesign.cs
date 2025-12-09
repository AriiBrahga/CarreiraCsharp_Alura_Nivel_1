class CursoDesign : ICurso
{
    public CursoDesign(string curso, Instrutor professor)
    {
        Curso = curso;
        Professor = professor;
    }

    public string Curso { get; set; }
    public Instrutor Professor { get; set; }
    public void PublicarCurso()
    {
        Console.WriteLine($"Validando conteúdo do curso de design: {Curso}\r\n");
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Curso publicado com sucesso: {Curso} - Instrutor: {Professor.Nome} ({Professor.Especialidade})");
    }
}
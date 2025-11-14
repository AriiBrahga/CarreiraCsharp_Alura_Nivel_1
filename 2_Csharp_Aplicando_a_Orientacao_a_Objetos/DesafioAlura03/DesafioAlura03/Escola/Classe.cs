/*
4 - Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. 
    A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
*/

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public float Notas { get; set; }

}

class Professor
{
    public string Nome { get; set; }
    private List<Disciplina> Disciplinas = new List<Disciplina>();

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Professor: {Nome}");
        foreach ( var d in Disciplinas)
        {
            d.ExibirDiciplinasAlunos();
        }
    }

    public void AdicionarDiciplinas(Disciplina disciplina)
    {
        Disciplinas.Add(disciplina);
    }

    public void RemoverDisciplina(Disciplina disciplina)
    {
        Console.WriteLine($"Removendo Disciplina de {disciplina.NomeDiciplina} do professor {Nome} ");
        Disciplinas.Remove(disciplina);
    }

}

class Disciplina
{
    public string NomeDiciplina { get; set; }

    private List<Aluno> Alunos = new List<Aluno>();

    public void AdicionarAlunos(Aluno alunos)
    {
        Alunos.Add(alunos);
    }

    public void ExibirDiciplinasAlunos()
    {
        Console.WriteLine($"Diciplina: {NomeDiciplina}");

        foreach (var alunos in Alunos)
        {
            Console.WriteLine($"Aluno: {alunos.Nome}\nIdade: {alunos.Idade}\nNota {alunos.Notas}\n");

        }
    }

}
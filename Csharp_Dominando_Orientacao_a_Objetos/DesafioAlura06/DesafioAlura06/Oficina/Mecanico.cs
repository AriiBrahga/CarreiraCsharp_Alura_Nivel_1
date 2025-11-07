namespace DesafioAlura06.Oficina
{
    class Mecanico
    {
        public Mecanico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

        public string Nome { get; set; }
        public string Especialidade { get; set; }

    }
}

namespace DesafioAlura06.PetShop
{
    class Medico
    {
        public Medico(string nome, int idade, string especialidade)
        {
            Nome = nome;
            Idade = idade;
            Especialidade = especialidade;
        }

        public string Nome { get; }
        public int Idade { get; }
        public string Especialidade { get; set; }
    }
}

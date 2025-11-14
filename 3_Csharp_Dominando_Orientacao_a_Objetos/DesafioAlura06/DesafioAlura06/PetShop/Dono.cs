namespace DesafioAlura06.PetShop
{
    class Dono
    {
        public Dono(int idade, string nome, string contato)
        {
            Idade = idade;
            Nome = nome;
            Contato = contato;
        }
        public int Idade { get; }
        public string Nome { get; }
        public string Contato { get; }
    }
}

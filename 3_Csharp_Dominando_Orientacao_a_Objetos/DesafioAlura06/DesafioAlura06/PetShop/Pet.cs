namespace DesafioAlura06.PetShop
{
    class Pet
    {
        public Pet(string nome, string raca, string especie, string sexo)
        {
            Nome = nome;
            Raca = raca;
            Especie = especie;
            Sexo = sexo;
        }

        public string Nome { get; }
        public string Raca { get; }
        public string Especie { get; }
        public string Sexo { get; }
    }
}

namespace DesafioAlura06.Oficina
{
    class Cliente
    {
        public Cliente(string nome, string contato)
        {
            Nome = nome;
            Contato = contato;
        }

        public string Nome { get; set; }
        public string Contato { get; set; }

    }
}

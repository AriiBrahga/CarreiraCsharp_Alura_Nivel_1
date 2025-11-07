namespace DesafioAlura06.PetShop
{
    class Consulta
    {
        public Consulta(string nomePetShop, DateTime dataDaConsulta, Dono donoPet, Medico veterinario, Pet pets)
        {
            NomePetShop = nomePetShop;
            DataDaConsulta = dataDaConsulta;
            DonoPet = donoPet;
            Veterinario = veterinario;
            Pets = pets;
        }

        public string NomePetShop { get; set; }
        public DateTime DataDaConsulta { get; set; }
        public Dono DonoPet { get; set; }
        private double PrecoConsulta { get; set; }
        public Medico Veterinario { get; set; }
        public Pet Pets { get; set; }

        public void ExibirFicha()
        {
            Console.WriteLine($"Petshop {NomePetShop}\n------ Ficha Tecnica ------\n");
            Console.WriteLine($"\nInformacoes do Dono: \nNome: {DonoPet.Nome}\nContato: {DonoPet.Contato}");
            Console.WriteLine($"\nInformacoes do Pet: \nNome: {Pets.Nome}\nRaça: {Pets.Raca}\nEspecie: {Pets.Especie}\nSexo: {Pets.Sexo}");

            Console.WriteLine($"\nData da Consulta: {DataDaConsulta.ToString("dd/MM/yyyy - HH:mm")}\nCom o Médico: {Veterinario.Nome} ");
            Console.WriteLine($"O valor da consulta será de R${PrecoConsulta.ToString("F2")}, que deverá ser pago no dia da Consulta");
        }

        public void ValorConsulta(double valor)
        {
            PrecoConsulta = valor;
        }

    }
}

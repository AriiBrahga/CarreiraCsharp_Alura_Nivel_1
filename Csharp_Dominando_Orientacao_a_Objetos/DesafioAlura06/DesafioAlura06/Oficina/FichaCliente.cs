namespace DesafioAlura06.Oficina
{
    class FichaCliente
    {
        public FichaCliente(Veiculo carro, Cliente clienteInfo, Mecanico mecanicoAtribuido)
        {
            Carro = carro;
            ClienteInfo = clienteInfo;
            MecanicoAtribuido = mecanicoAtribuido;
        }

        public Veiculo Carro { get; set; }
        public Cliente ClienteInfo { get; set; }
        public Mecanico MecanicoAtribuido { get; set; }
        public DateTime DataAgendada { get; set; }

        public void AgendarServico(DateTime dataAgendada)
        {            
            DataAgendada = dataAgendada;
            Console.WriteLine($"Serviço para o carro {Carro.Modelo} com a Placa {Carro.Placa} do cliente {ClienteInfo.Nome} foi agendado para a data {dataAgendada.ToString("dd/MM/yyyy - HH:mm")}");
        }
        public void ExibirFicha()
        {
            Console.WriteLine("Ficha do Cliente: ");
            Console.WriteLine($"Cliente: {ClienteInfo.Nome}\nContato: {ClienteInfo.Contato}");
            Console.WriteLine("Infomacao Carro: ");
            Console.WriteLine($"Carro: {Carro.Modelo}\nPlaca: {Carro.Placa}");
            Console.WriteLine($"Mecanico Atribuido: \nNome: {MecanicoAtribuido.Nome}");
        }
    }
}

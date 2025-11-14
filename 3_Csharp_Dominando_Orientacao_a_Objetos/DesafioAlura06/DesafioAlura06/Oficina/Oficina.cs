namespace DesafioAlura06.Oficina
{
    class Oficina
    {
        public Oficina()
        {
            List<FichaCliente> VeiculosNaOficina = new List<FichaCliente>();
        }

        public List<FichaCliente> VeiculosNaOficina = new();

        public void AdicionarFicha(FichaCliente ficha)
        {
            VeiculosNaOficina.Add(ficha);
        }

        public void ListarVeiculos()
        {
            foreach(FichaCliente f in VeiculosNaOficina)
            {
                Console.WriteLine($"Carro: {f.Carro.Modelo}\nModelo: {f.Carro.Modelo}\nPlaca: {f.Carro.Placa}");
            }
        }
    }
}

/*Crie uma classe chamada Consulta com:

Propriedade pública NomePaciente.
Propriedade pública NomeMedico.
Propriedade pública DataConsulta (do tipo DateTime).
Método Reagendar(DateTime novaData) para atualizar a data.
Método ExibirResumo() que mostra as informações da consulta, usando "Data:" na primeira exibição e "Nova data:" se ela tiver sido reagendada.
*/
class Consulta
{
    public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
    {
        NomePaciente = nomePaciente;
        NomeMedico = nomeMedico;
        DataConsulta = dataConsulta;
        foiReagendada = false;
    }

    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }

    private bool foiReagendada;

    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
        foiReagendada = true;
    }
    public void ExibirResumo()
    {
        if (foiReagendada)
        {
            Console.WriteLine($"Consulta marcada com {NomeMedico} para o paciente {NomePaciente}.\r\nNova Data: {DataConsulta.ToString("dd/MM/yyyy")}");
        }
        else
        {
            Console.WriteLine($"Consulta marcada com {NomeMedico} para o paciente {NomePaciente}.\r\nData: {DataConsulta.ToString("dd/MM/yyyy")}");
        }
    }
}
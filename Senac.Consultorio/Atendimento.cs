namespace Senac.Consultorio
{
    public class Atendimento
    {
        public DateTime DataHoraAtendimento { get; set; }
        public Paciente PacienteAtendido { get; set; }
        public Procedimento ProcedimentoEfetuado { get; set; }
    }
}

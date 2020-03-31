using System;
namespace testDrive.Models
{
    public class Agendamento
    {

        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public Veiculo Veiculo { get; set; }

        public DateTime DataAgendamento { get; set; }

        public TimeSpan HoraAgendamento { get; set; }

    }
}

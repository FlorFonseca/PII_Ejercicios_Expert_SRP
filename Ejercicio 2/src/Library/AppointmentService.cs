using System;
using System.Text;

namespace Library
{
    public class AppointmentService//La clase tiene más de una responsabilidad, lo que la hace menos flexible a la hora de poder reutilizarla 
    {
        public DatosCliente Paciente { get; set; }
        public DatosReserva Reserva { get; set; }
        public DatosDoctor Medico   { get; set; }

        public AppointmentService (DatosCliente paciente, DatosReserva reserva, DatosDoctor medico)
        {
            this.Paciente = paciente;
            this.Reserva = reserva;
            this.Medico = medico;
        }
    }
}

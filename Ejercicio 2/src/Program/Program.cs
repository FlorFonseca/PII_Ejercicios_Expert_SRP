using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosCliente paciente1= new DatosCliente("Steve Johnson","5555-555-555","093652804","41");
            DatosReserva reserva1= new DatosReserva(DateTime.Now,"Wall Street", Guid.NewGuid().ToString());
            DatosDoctor doctor1= new DatosDoctor("Arturo","Fisioterapeuta");

            ControlContenido resultadop1= new ControlContenido(paciente1);
            ControlContenido resultador1= new ControlContenido(reserva1);
            ControlContenido resultadod1=new ControlContenido(doctor1);

            Console.WriteLine($"Hello, {paciente1.ClientName}! Here is your medical appoinment:\n "+$"Pacient info: {paciente1.ClientName}\n               {paciente1.ID}\n               {paciente1.PhoneNumber}\n               {paciente1.Age}\n"+$"Appoinment date: {reserva1.Date}\n"+$"Appoinment place: {reserva1.AppoinmentPlace}\n"+$"Appoinment ID: {reserva1.AppoinmentIdentificator}\n\n"+$"You will be attended by {doctor1.DoctorName},{doctor1.Especialidad}\n\n"+"Have a nice day!☻");

        }
    }
}

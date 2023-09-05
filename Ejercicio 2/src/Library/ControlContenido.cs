using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace Library
{
    public class ControlContenido
    {

        public ControlContenido(DatosCliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "Enter a valid client");
            }

            if (string.IsNullOrWhiteSpace(cliente.ClientName))
            {
                throw new ArgumentException("Unable to schedule appointment, 'name' is required\n", nameof(cliente.ClientName));
            }

            if (string.IsNullOrWhiteSpace(cliente.ID))
            {
                throw new ArgumentException("Unable to schedule appointment, 'id' is required\n", nameof(cliente.ID));
            }

            if (string.IsNullOrWhiteSpace(cliente.PhoneNumber))
            {
                throw new ArgumentException("Unable to schedule appointment, 'phone number' is required\n", nameof(cliente.PhoneNumber));
            }

            if (string.IsNullOrWhiteSpace(cliente.Age))
            {
                throw new ArgumentException("Unable to schedule appointment, 'age' is required\n", nameof(cliente.Age));
            }

        }

        public ControlContenido(DatosDoctor doc)
        {
            if (string.IsNullOrWhiteSpace(doc.DoctorName))
            {
                throw new ArgumentException("Unable to schedule appointment, 'doctorname' is required\n", nameof(doc.DoctorName));
            }
            if (string.IsNullOrWhiteSpace(doc.Especialidad))
            {
                throw new ArgumentException ("Unable to schedule appointment, 'especialidad' is required\n", nameof(doc.Especialidad));
            }

        }

        public ControlContenido(DatosReserva reserv)
        {
            if (string.IsNullOrWhiteSpace(reserv.AppoinmentPlace))
            {
                throw new ArgumentException("Unable to schedule appointment, 'appoinmentplace' is required\n", nameof(reserv.AppoinmentPlace));
            }
            if (string.IsNullOrWhiteSpace(reserv.AppoinmentIdentificator))
            {
                throw new ArgumentException("Unable to schedule appointment, 'appoinmentid' is required\n", nameof(reserv.AppoinmentIdentificator));
            }

        }
    }
}

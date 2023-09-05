using System;
using System.Security.Cryptography;
using System.Text;

namespace Library
{
    public class DatosReserva
    {
        public string AppoinmentPlace { get; set; }
        public string AppoinmentIdentificator{ get;}
        public DateTime Date { get; }

        

        public DatosReserva(DateTime date, string direccion, string reservaid)
        {
            
            AppoinmentIdentificator= Guid.NewGuid().ToString();
            this.AppoinmentIdentificator=reservaid;
            this.AppoinmentPlace = direccion;
            this.Date = date;
        }
    }
}
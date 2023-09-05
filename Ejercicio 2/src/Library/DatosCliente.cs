using System;
using System.Security.Cryptography;
using System.Text;

namespace Library
{
    public class DatosCliente
    {
        public string ClientName { get; set; }
        public string ID { get; set; }
        public string PhoneNumber { get; set; }
        public string Age { get; set; }

        public DatosCliente (string nombre, string id,string numerocel, string edad)
        {
            this.ClientName = nombre;
            this.ID = id;
            this.PhoneNumber = numerocel;
            this.Age = edad;
        }
    }
}
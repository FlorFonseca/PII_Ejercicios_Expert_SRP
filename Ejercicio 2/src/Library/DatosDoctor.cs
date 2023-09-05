using System;
using System.Security.Cryptography;
using System.Text;

namespace Library
{
    public class DatosDoctor
    {
        public string DoctorName { get; set; }
        public string Especialidad { get; set; }

        public DatosDoctor (string doctorName, string especialidad)
        {
            this.DoctorName = doctorName;
            this.Especialidad = especialidad;
        }
    }
}
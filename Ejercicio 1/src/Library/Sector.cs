using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public string NombreSector{ get; set; } 
        public List<Shelve> ListaEstantes { get; set; }

        public Sector(string NombreSect)
        {
            this.NombreSector = NombreSect;
            ListaEstantes=new List<Shelve>();
        }
        public void AgregarEstante(Shelve estante)
        {
            this.ListaEstantes.Add(estante);
        }
    }
}
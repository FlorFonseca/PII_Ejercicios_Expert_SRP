using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        public List<Book> ListaLibros {get ; set ;}
        public string NumeroEstante {get ; set ; }

        public Shelve(string NumeroEst)
        {
            this.NumeroEstante = NumeroEst;
            ListaLibros=new List<Book>();
        }
        public void AgregarLibro(Book libro)
        {
            this.ListaLibros.Add(libro);
        }
    }
}
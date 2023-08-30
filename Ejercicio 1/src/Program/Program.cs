using System;
using System.Collections.Generic;
namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Sector sector1=new Sector("A");
            Sector sector2=new Sector("B");
            Shelve estante1= new Shelve ("7");
            Shelve estante2= new Shelve("3");
            sector1.AgregarEstante(estante1);
            estante1.AgregarLibro(book1);
            sector2.AgregarEstante(estante2);
            estante2.AgregarLibro(book2);
            Console.WriteLine($"El libro {book1.Title} del autor {book1.Author} con el código {book1.Code}, forma parte del sector {sector1.NombreSector} y pertenece al estante {estante1.NumeroEstante}");
        }
    }
}
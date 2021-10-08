using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Controller
    {

        public List<Book> Books { get; set; } //laver en list
        public List<Amulet> Amulets { get; set; }//-...-

        public Controller()
        {
            Books = new List<Book>(); //initialisere en vores list (new list) af Klassen <Book>
            Amulets = new List<Amulet>(); //-...-
        }
 
        public Book AddToList(Book Book)//-...-tilføjer en book vi kalder metoden Addtolist og Køre klassen "Book, og kalder den Book" 
        {
            Books.Add(Book);//tilføjer med metoden "Add"
            return Book;//returner Book
        }
        public Amulet AddToList(Amulet Amulet)//same -...-
        {
            Amulets.Add(Amulet);
            return Amulet;
        }




    }


}


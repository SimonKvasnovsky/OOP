using System;
using System.Security.Cryptography.X509Certificates;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {         
            Book LOTR = new Book();
            LOTR.SetPages(26);
            LOTR.SetTitle("Šimonko's Book");
            LOTR.SetAuthor("Šimon");
            LOTR.SetCategory("Komédia");
            LOTR.SetReleaseDate(2020);
            Console.WriteLine(LOTR.ToString());


        }
    }
}

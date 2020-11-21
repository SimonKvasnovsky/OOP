using System;
using System.Security.Cryptography.X509Certificates;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {         
            Book LOTR = new Book();
            LOTR.GetPages(26);
            LOTR.GetTitle("Šimonko's Book");
            LOTR.GetAuthor("Šimon");
            LOTR.GetCategory("Komédia");
            LOTR.GetReleaseDate("30.11.2020");
            LOTR.Datas();


        }
    }
}

using System;
using System.Security.Cryptography.X509Certificates;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {         
            Book LOTR = new Book();
            LOTR.category = "Komédia";        
            LOTR.author = "Šimon";  
            LOTR.releaseDate = "20.11.2020";
            Console.WriteLine(LOTR.category);
            Console.WriteLine(LOTR.author);
            Console.WriteLine(LOTR.releaseDate);
        }
    }
}

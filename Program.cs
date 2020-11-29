using System;
using System.Security.Cryptography.X509Certificates;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            Console.WriteLine("Pocet stran : ");
            LOTR.Pages = int.Parse(Console.ReadLine());
        
            Console.WriteLine("Zadaj nazov: ");
            LOTR.Title = Console.ReadLine();

            Console.WriteLine("Zadaj autora: ");
            LOTR.Author = Console.ReadLine();

            Console.WriteLine("Zadaj kategoriu: ");
            LOTR.Category = Console.ReadLine();

            Console.WriteLine("Zadaj datum vydania: ");
            LOTR.ReleaseDate = int.Parse(Console.ReadLine());

            Console.WriteLine(LOTR.ToString());


        }
    }
}

using System;
using System.Security.Cryptography.X509Certificates;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {         
            Book LOTR = new Book();
            LOTR.Title = "šimon";
            LOTR.Pages = 55;
            LOTR.TitleAndPages();
        }
    }
}

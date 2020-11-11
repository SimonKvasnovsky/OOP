using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {
        private int Pages;
        public string Title;
        public void TitleAndPages()
        {
            Console.WriteLine("The title of the book is " + Title + " and it has " + Pages + " pages ");
        }
      
    }
}

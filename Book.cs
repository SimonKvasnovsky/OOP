using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {
        private int pages;
        private string title;
        private string author;
        private string category;
        private string releaseDate;
        public void GetPages(int Pages)
        {
            pages = Pages;
        }
        public void GetTitle(string Title)
        {
            title = Title;
        }                      
        public void GetAuthor(string Author)
        {
            author = Author;
        }
        public void GetCategory(string Category)
        {
            category = Category;
        }
        public void GetReleaseDate(string ReleaseDate)
        {
            releaseDate = ReleaseDate;
        }
       
        public void Datas()
        {
            Console.WriteLine(pages);
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.WriteLine(category);
            Console.WriteLine(releaseDate);
        }
       
    }

}

  
    



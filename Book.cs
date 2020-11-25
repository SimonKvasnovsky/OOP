using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {
        private int Pages;
        private string Title;
        private string Author;
        private string Category;
        private int ReleaseDate;
        public void SetPages(int pages)
        {
            Pages = pages;
        }
        public void SetTitle(string title)
        {
            Title = title;
        }                      
        public void SetAuthor(string author)
        {
            Author = author;
        }
        public void SetCategory(string category)
        {
            Category = category;
        }
        public void SetReleaseDate(int releaseDate)
        {
            ReleaseDate = releaseDate;
        }
       
        public override string ToString()
        {
            return String.Format($"{ Pages}\n{Title}\n{ Author}\n{ Category}\n{ReleaseDate}");
        }
       
    }

}

  
    



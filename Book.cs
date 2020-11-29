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
        private int releaseDate;
        public int Pages   
        {
            get { pages = Pages; return pages; }
            set 
            {
                if(pages < 0)
                {
                    pages = 1;
                }
            }
        }
        public string Title 
        { get { title = Title; return title; }
            set{; } 
        }
        public string Author
        {
            get { author = Author; return author; }
            set {; }
        }
        public string Category
        {
            get { category = Category; return category; }
            set {; }
        }
        public int ReleaseDate
        {
            get { releaseDate = ReleaseDate; return releaseDate; }
            set 
            {
                if (ReleaseDate < 1450 || ReleaseDate > 2021)
                {
                    ReleaseDate = -1;
                }
            }
        }

        public void SetPages(int Pages1)
        {
            pages = Pages1;
        }     
        public void SetTitle(string Title1)
        {
            title = Title1;
        }
        public void SetAuthor(string Author1)
        {
            author = Author1;
        }
        public void SetCategory(string Category1)
        {
            category = Category1;
        }
        public void SetReleaseDate(int ReleaseDate1)
        {
            releaseDate = ReleaseDate1;
        }

        public override string ToString()
        {
            return String.Format($"{pages}\n{title}\n{author}\n{category}\n{releaseDate}");
        }


    }

}

  
    



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
            get { return pages; }
            set 
            {
                if(value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public string Title 
        { get { return title; }
            set{ title = value; } 
        }
        public string Author
        {
            get { return author; }
            set {author = value; }
        }
        public string Category
        {
            get { return category; }
            set {category = value; }
        }
        public int ReleaseDate
        {
            get { return releaseDate; }
            set 
            {
                if (value < 1450 || value > 2021)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
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

  
    



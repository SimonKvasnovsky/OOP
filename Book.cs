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
        public string category;
        private int releaseDate;
        /// <summary>
        /// A property, that changes minus value to positive value +1 and returns pages.
        /// </summary>
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
        /// <summary>
        /// A property, that returns variable title and set value to it.
        /// </summary>        
        public string Title 
        { get { return title; }
            set{ title = value; } 
        }
        /// <summary>
        /// A property, that returns variable author and set value to it.
        /// </summary>
        public string Author
        {
            get { return author; }
            set {author = value; }
        }
        /// <summary>
        /// A property, that returns variable category and set value to it.
        /// </summary>
        public string Category
        {
            private get { return category; }
            set {category = value; }
        }
        /// <summary>
        /// A property, that returns variable releaseDate and set if value is less than 1450 or higher than 2021, if true it sets value, if false it sets value to -1.
        /// </summary>
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
        /// <summary>
        /// A public static list which consist of genres.
        /// </summary>
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };

    public Book()
        {
            this.pages = -1;
            this.title = "-1";
            this.author = "-1";
            this.category = "-1";
            this.releaseDate = -1;
        }
        public Book(int pagess, string titlee)
        {
            this.pages = pagess;
            this.title = titlee;
            this.author = "-1";
            this.category = "-1";
            this.releaseDate = -1;
        }
        public Book(int Pages, string Title, string Author, string Category, int ReleaseDate)
        {
            pages = Pages;
            title = Title;
            author = Author;
            category = Category;
            releaseDate = ReleaseDate;
        }
       
        public override string ToString()
        {
            return String.Format($"{pages}\n{title}\n{author}\n{category}\n{releaseDate}");
        }
        
      
    }

}

  
    



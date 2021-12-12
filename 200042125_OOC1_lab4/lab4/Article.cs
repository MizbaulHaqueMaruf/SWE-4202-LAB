using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Article:Book
    {
        public string DOI;
        public string PublishedDate;
        public string Type;

            public Article(int id, string title, string author, string publisher, int quantity, string doi, string publishedDate, string type)
            {
                this.ID = id;
                this.Title = title;
                this.Author = author;
                this.Publisher = publisher;
                this.Quantity = quantity;
                this.DOI = doi;
                this.PublishedDate = publishedDate;
                this.Type = type;
            }

        public string Getinfo()
        {
            return Convert.ToString(ID) + "\t" + Title + "\t" + Author + "\t" + DOI + "\t" + Convert.ToString(Quantity) + "\t" + Type;
        }

    }
          
    
}

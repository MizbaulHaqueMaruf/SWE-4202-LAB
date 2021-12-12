using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Sbooks:Book
    {
        public string ISBN;
        public string Genre;

        public Sbooks(int id, string title, string author, string publisher, int quantity, string isbn, string genre)
        {
            this.ID = id;
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Quantity = quantity;
            this.ISBN = isbn;
            this.Genre = genre;

        }

       /* public bool checkSbook(int bookID)
        {
            if (bookID == ID)
            {
                return true;
            }
            else
                return false;
        }*/

        public string getSbook()
        {
            string setbook = ID.ToString() + "\t" + Title + "\t" + Author + "\t" + Publisher + "\t" + Quantity.ToString() + "\t" + ISBN + "\t" + Genre ;
            return setbook;
        }

       /* public bool SbookQuantityCheck()
        {
            if (Quantity == 0)
                return false;
            else
                return true;
        }

        public void SbookQuantityDecrease()
        {
            Quantity -= Quantity;
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Book
    {
        public int bookID;
        public string bookName;       
        public string bookAuthor;
        public string bookPublisher;
        public int bookQuantity;

        public Book(int bookID, string bookName, string bookAuthor, string bookPublisher, int bookQuantity)
        {
            this.bookID = bookID;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookPublisher = bookPublisher;
            this.bookQuantity = bookQuantity;
        }
        public string history()
        {
            return this.bookID.ToString() + "\t" + this.bookName;
        }
    }
}

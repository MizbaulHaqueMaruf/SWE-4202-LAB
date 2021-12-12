using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        List<Article> articleList = new List<Article>();
        List<Book> bookList = new List<Book>();

        //public object BookList { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addStudyBookbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(bookIDtxt.Text);
            string title = bookTitleTxt.Text;
            string author = bookAuthorTxt.Text;
            string publisher = bookAuthorTxt.Text;
            int quantity = Convert.ToInt32(bookQuantityTxt.Text);
            string isbn = bookISBNtxt.Text;
            string genre = bookGenreTxt.Text;

            Sbooks tempbook = new Sbooks(id, title, author, publisher, quantity, isbn, genre);

            //tempbook.setterSbook(id, title, author, publisher, quantity, isbn, genre);
            bookList.Add(tempbook);
            MessageBox.Show("Study Book has been added successfully!");
        }

        private void addResearchArticleButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(articleIDtxt.Text);
            string title = articleTitletxt.Text;
            string author = articleAuthorTxt.Text;
            string publisher = articlePublisherTxt.Text;
            int quantity = Convert.ToInt32(articleQuantityTxt.Text);
            string doi = articleDOItxt.Text;
            string publishedDate = articlePublishedDateTxt.Text;
            string type = ConOrJournalTxt.Text;

            Article temparticle = new Article(id, title, author, publisher, quantity, doi, publishedDate, type);

            //temparticle.setterArticle(id, title, author, publisher, quantity, doi, publishedDate, type);


            articleList.Add(temparticle);
            MessageBox.Show("Research Article has been added successfully!");
        }

        private void bookBorrowButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(bookIDinSearchTxt.Text);



            /*bool bookExists = false;
            bool quantityExists = false;

            int i = 0;
            for (i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].checkSbook(ScheckID))
                {
                    bookExists = true;
                    if (bookList[i].SbookQuantityCheck())
                    {
                        quantityExists = true;
                        
                    }
                    break;
                }
            }

            if (bookExists && quantityExists)
            {
                bookList[i].bookQuantityDecreas();
                MessageBox.Show("Book has been borrowed!!");
            }

            else
            {
                if (quantityExists == false)
                {
                    MessageBox.Show("Insufficient Books");
                }
                if (bookExists == false)
                    MessageBox.Show("Invalid Input");
            }*/
            bool flag = false;
            foreach (Sbooks bookItem in bookList)
            {
                if (id == bookItem.ID)
                {
                    flag = true;
                    if (bookItem.Quantity < 1)
                    {
                        MessageBox.Show("Book is currently Unavaiable to borrow!");
                        break;
                    }
                    bookItem.Quantity -= 1;
                    MessageBox.Show("The book has been borrowed successfully");
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("The book is not available");
            }
        }
        private void articleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showBookButton_Click(object sender, EventArgs e)
        {
            /*int ScheckID = Convert.ToInt32(bookIDinSearchTxt.Text);

            bool bookExists = false;
            int i = 0;
            for (i = 0; i<bookList.Count; i++)
            {
                if (bookList[i].checkSbook(ScheckID))
                {
                    bookExists = true;
                    break;
                }
            }

            if (bookExists)
            {
                bookListBox.Items.Clear();
                bookListBox.Items.Add(bookList[i].getSbook());              
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }*/

            bookListBox.Items.Clear();
            foreach (Sbooks book in bookList)
            {
                bookListBox.Items.Add(book.getSbook());
            }
        }

        private void articleBorrowButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(articleIDinSearchTxt.Text);
            bool flag = false;
            foreach (Article book in articleList)
            {
                if (id == book.ID)
                {
                    flag = true;
                    book.Quantity -= 1;
                    MessageBox.Show("The book has been borrowed successfully");
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("The book is not available");
            }
        }

        private void showArticleButtton_Click(object sender, EventArgs e)
        {
            bookListBox.Items.Clear();
            foreach (Article book in articleList)
            {
                articleListBox.Items.Add(book.Getinfo());
            }
        }
    }    
}

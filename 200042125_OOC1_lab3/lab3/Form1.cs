using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private bool userExists(int userID)
        {
            foreach(User user in users)
            {
                if (user.userID == userID)
                {
                    return true;
                }
            }
            return false;
        }

        private bool bookExists(int bookID)
        {
            foreach (Book book in books)
            {
                if (book.bookID == bookID)
                {
                    return true;
                }
            }
            return false;
        }
        private void addUserButton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(userIDtextbox.Text);
            string userName = userNameTextBox.Text;
            string userAddress = userAddressTextBox.Text;

            User dummy = new User(userID, userName, userAddress);

            users.Add(dummy);
            MessageBox.Show("User has been added successfully!");
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(bookIDtextBox.Text);
            string bookName = bookNameTextBox.Text;
            string bookAuthor = authorTextBox.Text;
            string bookPublisher = publisherTextBox.Text;
            int bookQuantity = Convert.ToInt32(quantityTextBox.Text);

            Book dummy = new Book(bookID, bookName, bookAuthor, bookPublisher, bookQuantity);

            books.Add(dummy);
            MessageBox.Show("Book has been added successfully");


    }

    private void userIDinHistoryTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bookHistoryShowButton_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(bookIDinHistorytextBox.Text);
            bool flag = false;
            foreach(Book book in books)
            {
                if(book.bookID == bookid)
                {
                    flag = true;
                    lblID.Text = book.bookID.ToString();
                    lblName.Text = book.bookName;
                    lblAuthor.Text = book.bookAuthor;
                    lblPublisher.Text = book.bookPublisher;
                    lblQuantity.Text = book.bookQuantity.ToString();
                }
            }
            if(flag == false)
            {
                MessageBox.Show("Book could not be found");
            }
        }

        private void userHistoryShowButton_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(userIDinHistoryTextBox.Text);
            User dummy = new User();
           
            
            bool flag = false;
            foreach(User user in users)
            {
                if (user.userID == userid)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }

            if (flag == false)
            {
                MessageBox.Show("User could not be found");
            }

            userListbox.Items.Clear();
            for(int i = 0; i<dummy.books.Count; i++)
            {
                int id_book = dummy.books[i];
                for(int j = 0; j < books.Count; j++)
                {
                    if(books[j].bookID == id_book)
                    {
                        userListbox.Items.Add(books[j].history());
                    }
                }
            }

        }

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            int userBID = Convert.ToInt32(userIDinBorrowtextBox.Text);
            int bookBID = Convert.ToInt32(bookIDinBorrowTextBox.Text);

            if (bookExists(bookBID) && userExists(userBID))
            {
                foreach(Book book in books)
                {
                    if (book.bookID == bookBID)
                    {
                        if (book.bookQuantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock.");
                            break;
                        }
                        book.bookQuantity -= 1;
                        foreach(User user in users)
                        {
                            if (user.userID == userBID)
                            {
                                user.books.Add(bookBID);
                                MessageBox.Show("Book has been added to the user.");
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void userListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


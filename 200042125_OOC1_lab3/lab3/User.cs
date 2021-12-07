using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class User
    {
        public int userID;
        public string userName;
        public string userAddress;
        public List<int> books = new List<int>();

        public User()
        {

        }

        public User(int userID, string userName, string userAddress)
        {
            this.userID = userID;
            this.userName = userName;
            this.userAddress = userAddress;
        }

        public void addBook(int userID)
        {
            books.Add(userID);
        }

        
    }
}

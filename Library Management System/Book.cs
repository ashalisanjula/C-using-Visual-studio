using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Book
    {
        public int Book_Id { get; set; } // to create auto-implemented properites,helps with encapsulation,readability, and maintainability.
        public string Title { get; set; }

        public string Author { get; set; }

        public bool IsBrorrowed { get; private set; }
    }

    public Book(int bookId, string title, string author)
        {
            Book_Id = bookId;
            Title = title;
            Author = author;
            IsBrorrowed = false;
        }


        public void BrorrowBook()
        {

            if (!IsBrorrowed) { 
                IsBrorrowed = true;
            Console.WriteLine($"'{Title}' has been borrwed.");
            }
            else
            {
                IsBrorrowed=false;
                Console.WriteLine($"'{Title}' is already borrowed");
            }
        }

        public void ReturnBook()
        {
            if (!IsBrorrowed)
            {
                IsBrorrowed = true;
                Console.WriteLine($"'{Title}' has been returned");
            }
            else
            {
                IsBrorrowed = false;
                Console.WriteLine($"'{Title}' was not borrowed");
            }
        }

        public override string ToString()
        {
            return $"{Book_Id}:  {Title} by {Author} - {(IsBrorrowed? "Borrowed" : "Available")}";
        }
    }

}

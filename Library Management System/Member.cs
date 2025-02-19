using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Member
    {
        public int MemberId {  get; set; }
        public string Name { get; set; }

       private List<Book> borrowedBooks;


        public Member(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;    
            borrowedBooks = new List<Book>();
        }

        public void BrorrowBook(Book book) 
        {
            if (!book.IsBrorrowed)
            {
                book.BrorrowBook();
                borrowedBooks.Add(book);
            }else
            {
               Console.WriteLine($"Sorry '{Name}', the book '{book.Title}' is not available."); 
            }
        }

        public void ReturnBook(Book book)
        {
            if (borrowedBooks.Contains(book))
            {
                book.ReturnBook();
                borrowedBooks.Remove(book);
            }
            else
            {
                Console.WriteLine($"Sorry {Name}, you did not borrow '{book.Title}'.");
            }
        }

    }
}

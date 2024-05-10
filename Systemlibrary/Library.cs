using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemlibrary
{
    public class Library
    {
        private List<Book> books;
        private List<Book> Borrowbooks;

        public void Display()
        {
            if (books != null)
            {
                foreach (var item in books)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                Console.WriteLine("the library is empty");
            }
        }
        public void add(Book book)
        {
            books.Add(book);
            Console.WriteLine("the book added succesfuly");
        }
        public void remove(Book book) 
        {
            if (books != null)
            {
                books.Remove(book);
                Console.WriteLine("the book removed succesfuly");
            }
            else
            {
                Console.WriteLine("there is no books to be removed");

            }
        }
        public void Borrowbook(Book book)
        {
            if (books.Count != 0)
                books.Remove(book);
            else
                Console.WriteLine("sorry we don't have any books right now");


        }

    }
}

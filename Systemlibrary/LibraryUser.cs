using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemlibrary
{
    public class LibraryUser : user 
    {
        public LibraryCard Card { get; set; }
        public LibraryUser(string name)
        {

            Name = name;

        }
        public void Displaybooks(Library library)
        {
            library.Display();
        }
        public void BorrowBook(Book book , Library library)
        {
            library.Borrowbook(book);
        }
    }
}

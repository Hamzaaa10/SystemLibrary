using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemlibrary
{
    internal class librarian : user 
    {

        public int EmployeeId { get; set; }

        public librarian(string name)
        {
            this.Name = name;
        }
        public void AddBook(Book newbook ,Library library)
        {
            library.add(newbook);
        }
        public void RemoveBook(Book book , Library library)
        {
            library.remove(book); 
        }
        public void Displaybooks(Library library)
        {
            library.Display();
        }
    }
}

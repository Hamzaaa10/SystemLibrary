using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemlibrary
{
    public class Book
    {
        public string Name { set; get; }
        public int Year {  set; get; }
        public string Author { set; get; }

        public Book(string name , string Author ,int Year)
        {
            this.Name = name;
            this.Author = Author;
            this.Year = Year;
        }
    }
}

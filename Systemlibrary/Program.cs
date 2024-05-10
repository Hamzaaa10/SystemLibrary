namespace Systemlibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.WriteLine(" welcome to the system");
            Console.WriteLine("Are you librarian or regular user L/R");
            char userType = Console.ReadLine().ToUpper()[0];

            if (userType == 'L')
            {
                Console.WriteLine("Enter your name");
                string librarianName = Console.ReadLine();
                librarian L1 = new librarian(librarianName);
                Console.WriteLine($"welcome {L1.Name}");
                while (true)
                {
                    Console.WriteLine("please choose to Add (A) , Remove book (R) ,Display (D)  ");
                    userType = Console.ReadLine().ToUpper()[0];
                    switch (userType)
                    {
                        case 'A':
                            Console.WriteLine("enter book details");
                            Console.WriteLine("first enter book name");
                            String bookName = Console.ReadLine();
                            Console.WriteLine("first enter book author");
                            String bookAuthor = Console.ReadLine();
                            Console.WriteLine("first enter book year");
                            int boookYear = int.Parse(Console.ReadLine());
                            Book b1 = new Book(bookName, bookAuthor, boookYear);
                            L1.AddBook(b1, library);
                            break;

                        case 'R':
                            Console.WriteLine("enter the book you want to delete ");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            boookYear = int.Parse(Console.ReadLine());
                            b1 = new Book(bookName, bookAuthor, boookYear);
                            L1.RemoveBook(b1, library);
                            break;

                        case 'D':
                            L1.Displaybooks(library);
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }

                }
            }

            else if (userType == 'R')
            {
                Console.WriteLine("Enter your name");
                string userName = Console.ReadLine();
                LibraryUser user = new LibraryUser(userName);
                Console.WriteLine($"Welcome {user.Name}");
                while (true)
                {
                    Console.WriteLine("please choose to  Borrow book (B)  or Display (D)  ");
                    userType = Console.ReadLine().ToUpper()[0];
                    switch (userType)
                    {


                        case 'B':
                            Console.WriteLine("enter the book you want to delete ");
                            Console.WriteLine("first enter book name");
                            String bookName = Console.ReadLine();
                            Console.WriteLine("first enter book author");
                            String bookAuthor = Console.ReadLine();
                            Console.WriteLine("first enter book year");
                            int boookYear = int.Parse(Console.ReadLine());
                            Book b1 = new Book(bookName, bookAuthor, boookYear);
                            user.BorrowBook(b1, library);
                            break;

                        case 'D':
                            user.Displaybooks(library);
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("pleasr enter L or R");
            }
            
        }
    }
}

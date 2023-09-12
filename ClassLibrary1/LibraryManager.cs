using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LibraryManager
    {
        public static User NewClient(int id) 
        {
            Console.WriteLine("Imię:");
            string name = Console.ReadLine();
            Console.WriteLine("Nazwisko:");
            string surname = Console.ReadLine();
            
            User user1  = new User(name, surname, id);
            return user1;
            
        }
        public static Book AddNewBook(int id)
        {


            Console.WriteLine("Podaj tytul:");
            string title = Console.ReadLine();
            Console.WriteLine("Podaj autora:");
            string author = Console.ReadLine();
            string bookType;
            do
            {
                Console.WriteLine("Podaj typ książki: 1. Fabularna 2. Niefabularna");
                bookType = Console.ReadLine();
            } while (bookType != "1" && bookType != "2");

            switch (bookType)
            {
                case "1":
                    Book book1 = new FictionBook(author, title, id, GetLiteraryGenre());
                    return book1;
                case "2":
                    Book book2 = new NonFictionBook(author, title, id);
                    return book2;
            }
            return null;

        }
        public static void RemoveBook() { }
        public static void BorrowBook(Dictionary<int, Book> bookList, Dictionary<int, User> userList) 
        {
            
            int bookId = ProperBookId(bookList);
            int borrowerId = ProperBorrowerId(userList);


            if (bookList.TryGetValue(bookId, out Book book)) 
            {
                if (book.Borrower != 0)
                {
                    Console.WriteLine("Ksiazka niezwrocona");
                }
                else
                {
                    book.Borrower = borrowerId;
                    Console.WriteLine("Ksiazka poprawnie wypozyczona dla:" + userList[borrowerId].Name + " " + userList[borrowerId].Surname );
                }
            }
            else
            {
                Console.WriteLine("Error, przerwano wypozyczanie ksiazki");
            }
        }
        public static void FindClient() { }
        public static void FindBook() { }
        public static void ReturnBook(Dictionary<int, Book> bookList) 
        {
            Console.WriteLine("Podaj id ksiazki do zwrotu");
            int bookId = ProperBookId(bookList);
            if (bookList.TryGetValue(bookId, out Book book))
            {
                if (book.Borrower != 0)
                {
                    book.Borrower = 0;
                    Console.WriteLine("Ksiazka zwrocona! Dziekujemy");
                }
                else
                {
                    Console.WriteLine("Ksiazka nie jest wypozyczona");
                }
            }
            else
            {
                Console.WriteLine("Error, przerywamy zwrot ksiazki");
            }

        }
        public static void BorrowedBooks() { }
        public static void AllBooks(Dictionary<int, Book> bookList)
        {
           
        }
        public static void AllUsers(Dictionary<int, User> userList) 
        {
        }
        public static string GetLiteraryGenre()
        {
            bool properNumber;
            uint genreId;
            do
            {
                Console.WriteLine("Podaj typ książki:\n1.Powieść\n2.Poezja\n3.Dramat\n4.Inne");
                string genreIdToConvert = Console.ReadLine();
                properNumber = UInt32.TryParse(genreIdToConvert, out genreId);
            } while (!properNumber || genreId < 1 || genreId > 4);
            switch (genreId)
            {

                case 1:
                    return "Powieść";
                case 2:
                    return "Poezja";
                case 3:
                    return "Dramat";
                case 4:
                    return "Inne";
                default:
                    return "Error";

            }
        }
        public static int ProperBookId(Dictionary<int, Book> bookList)
        {
            bool properBookId;
            int bookId;
            do
            {
                Console.WriteLine("Wprowadz 0 by przerwać lub podaj poprawne id ksiazki:");
                properBookId = Int32.TryParse(Console.ReadLine(), out bookId);
                // Check proper format and bookid exist
                if (bookId == 0)
                {
                    break;
                }
            } while (!properBookId || !bookList.ContainsKey(bookId));
            return bookId;
        }
        public static int ProperBorrowerId(Dictionary<int, User> userList)
        {
            bool properBorrowerId;
            int borrowerId;
            do
            {
                Console.WriteLine("Wprowadz 0 by przerwać lub podaj poprawne id wypozyczajacego:");
                properBorrowerId = Int32.TryParse(Console.ReadLine(), out borrowerId);
                if (borrowerId == 0)
                {
                    break;
                }
            } while (!properBorrowerId || !userList.ContainsKey(borrowerId));
            return borrowerId;
        }
    }
}

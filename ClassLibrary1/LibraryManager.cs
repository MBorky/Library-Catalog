using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LibraryManager
    {
        public static void NewClient() { }
        public static void AddNewBook() 
        {
            
            
            Console.WriteLine("Podaj tytul:");
            string title = Console.ReadLine();
            Console.WriteLine("Podaj autora:");
            string author = Console.ReadLine();
            Console.WriteLine("Podaj typ książki: 1. Fabularna 2. Niefabularna");
            

        }
        public static void RemoveBook() { }
        public static void BorrowBook() { }
        public static void FindClient() { }
        public static void FindBook() { }
        public static void ReturnBook() { }
        public static void BorrowedBooks() { }
    }
}

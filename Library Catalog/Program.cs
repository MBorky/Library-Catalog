// See https://aka.ms/new-console-template for more information
//Dictionary private set?
using ClassLibrary1;
int bookToken = 1;
int userToken = 1;
string choice;
Dictionary<int, Book> bookList = new Dictionary<int, Book>();
Dictionary<int, User> userList = new Dictionary<int, User>();
while (true)
{
        Console.WriteLine("Podejmij akcje:\n" +
                    "1. Dodaj ksiazke\n2. Dodaj uzytkownika\n3. Wypozycz Ksiazke" +
                    "\n4. Zwroc kiazke\n5. Zamknij program");
        choice = Console.ReadLine();

    if (choice == "1")
    {
        bookList.Add(bookToken, LibraryManager.AddNewBook(bookToken));
        bookToken++;
    }
    else if (choice == "2")
    {
        userList.Add(userToken, LibraryManager.NewClient(userToken));
        userToken++;
    }
    else if (choice == "3")
    {
        LibraryManager.BorrowBook(bookList, userList);
        break;
    }
    else if (choice == "5")
    {
        Console.WriteLine("Zamykanie");
        break;
    }
    else if (choice == "5")
    {
        Console.WriteLine("Zamykanie");
        break;
    }
            
    
}
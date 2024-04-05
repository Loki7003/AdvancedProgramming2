using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4_BDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>()
            {
                new Book{ Id = 1, Title = "Bastion", Author = "Stepehn King", Price = 39.99M, Isbn = "9788383610672", Publisher = "Albatros" },
                new Book{ Id = 2, Title = "Diuna", Author = "Frank Herbert", Price = 65.00M, Isbn = "9788381884471", Publisher = "Rebis" },
                new Book{ Id = 3, Title = "Zgroza w Dunwich i inne przerażające opowieści", Author = "H.P. Lovecraft", Price = 52.99M, Isbn = "9788377310984", Publisher = "Vesper" },
                new Book{ Id = 4, Title = "Miecz przeznaczenia", Author = "Andrzej Sapkowski", Price = 29.95M, Isbn = "9788375780642", Publisher = "superNOWA" }
            };

            Console.WriteLine("Welcome to the Bookshop Ordering System!");
           

            ChooseBook(books);
            
        }

        static void ChooseBook(List<Book> books)
        {
            Console.WriteLine("Available Books:");

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}. {book.Title} by {book.Author}\nPrice: {book.Price}zł\nISBN: {book.Isbn}\nPublisher: {book.Publisher}");
            }

            Console.WriteLine("Enter ID of book you want to order: ");
            int userChoice;
            bool checkGivenValue = int.TryParse(Console.ReadLine(), out userChoice);

            if (checkGivenValue)
            {
                var selectedBook = books.Find(b => b.Id == userChoice);
                if (selectedBook != null)
                {
                    Console.WriteLine($"You've oredered {selectedBook.Title} for {selectedBook.Price}zł");
                }
                else
                {
                    Console.WriteLine("Book not found. Please check ID and try again.");
                    ChooseBook(books);
                }
            }
            else
            {
                Console.WriteLine("Given value is not a number! Try again.");
                ChooseBook(books);
            }
        }
    }
}

using System;
using TechTalk.SpecFlow;

namespace Zad4_BDD.StepDefinitions
{
    [Binding]
    public class BookshopSystemStepDefinitions
    {
        private string _orderedBookTitle;
        private List<Book> _availableBooks = new List<Book>();
        private List<Book> _orderedBooks = new List<Book>();

        [Given(@"the bookshop contains the following books:")]
        public void GivenTheBookshopContainsTheFollowingBooks(Table table)
        {
            foreach (var row in table.Rows)
            {
                var book = new Book
                {
                    Id = int.Parse(row["Id"]),
                    Title = row["Title"],
                    Author = row["Author"],
                    Price = Convert.ToDecimal(row["Price"]),
                    Isbn = row["Isbn"],
                    Publisher = row["Publisher"]

                };
                _availableBooks.Add(book);
            }
        }

        [When(@"I order ""([^""]*)""")]
        public void WhenIOrder(string bookTitle)
        {
            _orderedBookTitle = bookTitle;
            var orderedBook = _availableBooks.Find(b => b.Title.Equals(_orderedBookTitle, StringComparison.OrdinalIgnoreCase));

            if (orderedBook != null)
            {
                _orderedBooks.Add(orderedBook);
                Console.WriteLine($"Order placed for {orderedBook.Title} by {orderedBook.Author} for ${orderedBook.Price}");
            }
            else
            {
                Console.WriteLine("Error: Book not found. Please check the title and try again.");
            }
        }

        [Then(@"I should receive an order confirmation")]
        public void ThenIShouldReceiveAnOrderConfirmation()
        {
            var orderedBook = _availableBooks.Find(b => b.Title.Equals(_orderedBookTitle, StringComparison.OrdinalIgnoreCase));
            if (orderedBook != null)
            {
                Console.WriteLine($"Order confirmed for {orderedBook.Title} by {orderedBook.Author} for ${orderedBook.Price}");
            }
            else
            {
                Console.WriteLine("Error: Book not found. Please check the title and try again.");
            }
        }

        [Given(@"the bookshop contains no books")]
        public void GivenTheBookshopContainsNoBooks()
        {
            throw new PendingStepException();
        }

        [Then(@"I should receive an error message")]
        public void ThenIShouldReceiveAnErrorMessage()
        {
            Console.WriteLine($"Error: {_orderedBookTitle} is unavailable");
        }
    }
}

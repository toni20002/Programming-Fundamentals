using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //{title} {author} {publisher} {release date} {ISBN} {price}.
            int numberOfBooks = int.Parse(Console.ReadLine());
           Dictionary<string, Book> books = new Dictionary<string, Book>();
           //     Library library = new Library();
          //  library.Books = new List<Book>();
            for (int i = 0; i < numberOfBooks; i++)
            {
                var input = Console.ReadLine().Split(' ');
                if (!books.ContainsKey(input[1]))
                    books.Add(input[1], new Book() { Price = 0 });
                    books[input[1]].Price += double.Parse(input[5]);
            }
            foreach (var book in books.OrderByDescending(x => x.Value.Price).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:f2}" ,book.Key , book.Value.Price);
            }
        }
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBN { get; set; }
        public double Price { get; set; }
    }
}

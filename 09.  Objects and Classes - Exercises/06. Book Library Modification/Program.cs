using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            //{title} {author} {publisher} {release date} {ISBN} {price}.
            long numberOfBooks = long.Parse(Console.ReadLine());
            Dictionary<string, Book> books = new Dictionary<string, Book>();

            for (long i = 0; i < numberOfBooks; i++)
            {
                var input = Console.ReadLine().Split(' ');
                if (!books.ContainsKey(input[1]))
                    books.Add(input[0], new Book() { ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy" , CultureInfo.InvariantCulture) });
            }
            DateTime newDate = DateTime.ParseExact(Console.ReadLine() , "dd.MM.yyyy" ,CultureInfo.InvariantCulture);
            foreach (var book in books.OrderBy(x => x.Value.ReleaseDate).ThenBy(x => x.Key).Where(x => x.Value.ReleaseDate >= newDate))
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}" , book.Key ,book.Value.ReleaseDate);
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
        public long ISBN { get; set; }
        public decimal Price { get; set; }
    }
}

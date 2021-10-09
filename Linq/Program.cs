using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {

        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}


            //LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;


            //LINQ Extension Methods
            //books.OrderBy(b => b.Title);
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);


            //Important LINQ Extension Methods
            var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            Console.WriteLine(book == null);


            var book1 = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book1.Title + " " + book1.Price);


            var book2 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book2 == null);


            var book3 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book3.Title + " " + book1.Price);


            var book4 = books.Skip(2).Take(3);
            foreach (var pageBook in book4)
            {
                Console.WriteLine(pageBook.Title + " " + pageBook.Price);
            }


            var count = books.Count();
            Console.WriteLine(count);

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);

            var sumPrice = books.Sum(b => b.Price);
            Console.WriteLine(sumPrice);




            foreach (var bookk in cheapBooks)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(bookk);
            }

        }
    }
}

using System;

namespace LambdaExpressions
{
    partial class Program
    {


        static void Main(string[] args)
        {

            //Lambda expression syntax

            // args => expression
            // () => ...
            // x => ...
            // (x, y, z, ...) => ...


            //Lambda expression with delegate Func<>
            Func<int, int> squared = number => number * number;
            Console.WriteLine(squared(5));

            const int factor = 5;
            Func<int, int> multipler = n => n * factor;

            Console.WriteLine(multipler(5));

            //--------------------------------------------
            
            var books = new BookRepository().GetBooks();


            // var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapBooks = books.FindAll(b => b.Price < 10);


            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }


        }

        
        //not used because of lambda
        //Line 21
        static int Squared(int number)
        {
            return number * number;
        }

        //not used because of lambda
        //Line 35
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}

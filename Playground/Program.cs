using System.IO;
using System;

namespace Playground
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer2(1);

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);




        }


        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

        }

        static void UserPoints()
        {
            try
            {
                var point = new Point(10, 20);

                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}

namespace Polymorphism
{

    class Program
    {
        static void Main(string[] args)
        {
            //Doesn't work because Shape is an Abstract Class
           // var shape = new Shape();



            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

        }
    }
}

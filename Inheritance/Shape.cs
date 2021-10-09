namespace Inheritance
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {

        }
    }
}
/*          Text text = new Text();
            Shape shape = text;

            //Both shape and text are referencing the same object
            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);*/
using System;

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 25);
            Rectangle rectangle2 = new Rectangle(65, 15);
            Circle circle = new Circle(15);
            Square square = new Square(8);

            Shape[] shapes = new Shape[]{square, rectangle2, circle, rectangle};

            /*foreach(Shape shape in shapes)
            {
                //shape.Coucou();
                Console.WriteLine(shape);
            }*/

            for(int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i]);

                if(shapes[i] is Circle circle1)
                {
                    Console.WriteLine(circle1.Diameter());
                }
                else if(shapes[i] is Rectangle rectangle1)
                {
                    Console.WriteLine(rectangle1.Diagonal());
                }
                else if(shapes[i] is Square square1)
                {
                    Console.WriteLine(square1.Diagonal());
                }
            }
        }
    }
}

using System;

namespace Exo1
{
    public class Square : Shape
    {        
        private float _width;

        public Square(float width)
        {
            _width = width;
        }

        public override float Area()
        {
            return _width * _width;
        }

        public override float Perimeter()
        {
            return 4 * _width;
        }

        public float Diagonal()
        {
            return MathF.Sqrt(2 *(_width * _width));
        }

        public override string ToString()
        {
            return $"Type Figure : Carré\nLargeur : {_width}\n" + base.ToString();
        }
    }
}
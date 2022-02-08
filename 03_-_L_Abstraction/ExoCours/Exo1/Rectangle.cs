using System;

namespace Exo1
{
    public class Rectangle : Shape
    {
        private float _width, _height;

        public Rectangle(float width, float height)
        {
            _height = height;
            _width = width;
        }

        public override float Area()
        {
            return _height * _width;
        }

        public override float Perimeter()
        {
            return 2 * _width + 2 * _height;
        }

        public float Diagonal()
        {
            return MathF.Sqrt(_height * _height + _width * _width);
        }

        public override string ToString()
        {
            return $"Type Figure : Rectangle\nLargeur : {_width}, Hauteur : {_height}\n" + base.ToString();
        }
    }
}
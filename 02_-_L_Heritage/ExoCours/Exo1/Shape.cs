using System;

namespace Exo1
{
    public class Shape
    {
        public virtual float Area()
        {
            return 0;
        }

        public virtual float Perimeter()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Perimètre : {Perimeter()}\nAire : {Area()}";
        }
    }
}
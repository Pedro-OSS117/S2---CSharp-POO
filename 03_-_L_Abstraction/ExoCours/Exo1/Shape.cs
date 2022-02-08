using System;

namespace Exo1
{
    public abstract class Shape
    {
        public abstract float Area();

        public abstract float Perimeter();
        
        public override string ToString()
        {
            return $"Perimètre : {Perimeter()}\nAire : {Area()}";
        }
    }
}
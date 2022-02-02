using System;

namespace Exo1
{
    public class Circle : Shape
    {
        private float _radius;
        
        public Circle(float radius)
        {
            _radius = radius;
        }

        public override float Area()
        {
            return MathF.PI * (_radius * _radius);
        }

        public override float Perimeter()
        {
            return 2 * MathF.PI * _radius;
        }

        public float Diameter()
        {
            return _radius * 2;
        }

        public override string ToString()
        {
            return $"Type Figure : Cercle\nRayon : {_radius}\n" + base.ToString();
        }    
    }
}
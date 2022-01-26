namespace Exo3
{
    public class Rectangle
    {
        private int _width;
        private int _height;
        private float _positionX;
        private float _positionY;

        // Question 5
        public Rectangle()
        {
            _width = _height = 10;
            _positionX = _positionY = 0;
        }

        public Rectangle(Rectangle rect)
        {
            _width = rect._width;
            _height = rect._height;
            _positionX = rect._positionX;
            _positionY = rect._positionY;
        }

        // Question 2
        public Rectangle(int width, int height, float positionX, float positionY)
        {
            if(width < 1)
            {
                width = 1;
            }
            _width = width;

            if(height < 1)
            {
                height = 1;
            }
            _height = height;
            _positionX = positionX;
            _positionY = positionY;
        }

        // Question 4
        public override string ToString()
        {
            return $"Rectangle de largeur {_width}, de hauteur {_height} et de position ({_positionX},{_positionY}).";
        }

        // Question 3
        public float Aire()
        {
            return _width * _height;
        }

        // Question 6
        public void DoublerTaille()
        {
            _width *=2;
            _height *=2;
        }

        // Question 8
        public bool IsLittleThan(Rectangle toTest)
        {
            return Aire() > toTest.Aire();
        }

        public Rectangle Copy()
        {
            return new Rectangle(_width, _height, _positionX, _positionY);
        }
    }
}
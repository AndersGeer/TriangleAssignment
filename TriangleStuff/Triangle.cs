namespace TriangleStuff
{
    public class Triangle
    {
        public Triangle(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        private readonly int _a;
        private readonly int _b;
        private readonly int _c;

        public string NotTriangle { get; } = "This is not a triangle";

        public string EquilateralTriangle { get; } = "This is an equilateral triangle";

        public string IsoscelesTriangle { get; } = "This is an isosceles triangle";

        public string ScaleneTriangle { get; } = "This is a scalene triangle";

        public string TriangleTest()
        {
            if (_a+_b<_c || _a+_c<_b || _b+_c<_a)
            {
                return NotTriangle;
            }
            else if(_a == _b && _b == _c)
            {
                return EquilateralTriangle;
            }
            else if ((_a == _b && _a!= _c) || (_b == _c && _b != _a))
            {
                return IsoscelesTriangle;
            }
            else
            {
                return ScaleneTriangle;
            }
        }
    }
}
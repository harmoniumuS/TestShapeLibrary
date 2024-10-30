namespace ShapeLibrary
{
    interface IShape
    { 
        double Area { get; }
    }


    public class Circle:IShape
    {
        public double Area { get { return Math.PI * Math.Pow(Radius,2);}}
        public double Radius { get; }

        public Circle(double radius)
        { 
           Radius = radius;
        }
    }
    public class Triangle:IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double Area { get{ return Math.Sqrt(P * (P - A) * (P - B) * (P - C));}}
        public double P { get { return (A + B + C)/2;} }
        public bool IsRectangular { get; }
        public Triangle(double a,double b,double c)
        { 
            A= a; B = b; C= c;

            double[] sides = new[] { A, B, C };
            sides.Order();
            if (Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2))
            {
                IsRectangular = true;
            }
            else
            {
                IsRectangular = false;
            }
        }
    }
}


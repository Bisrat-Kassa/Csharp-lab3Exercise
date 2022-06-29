namespace labex3
{
     abstract class Shape
    {
        public abstract double area();
        public abstract double perimeter();
    }

    class Square : Shape
    {
        public double width { get; set; }
            public override double area()
        {
            return width * width;  
        }
        public override double perimeter()
        {
            return 4 * width;
        }

    }

    class Circle : Shape
    {
        readonly double pi = 3.14;
        public double radius { get; set; }
        public override double area()
        {
            return pi * radius * radius;
        }
        public override double perimeter()
        {
            return 2*pi*radius;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp, ans;
            Circle circ = new Circle();
            Square sq = new Square();

            do
            {
                Console.Write("Enter the radius of your circle: ");
                temp = Console.ReadLine();
                circ.radius = Convert.ToDouble(temp);
                Console.WriteLine("Area of the circle is: " + circ.area());
                Console.WriteLine("Parameter of the circle is: " + circ.perimeter());

                Console.Write("Enter the width of your square: ");
                temp = Console.ReadLine();
                sq.width = Convert.ToDouble(temp);
                Console.WriteLine("Area of the square is: " + sq.area());
                Console.WriteLine("Parameter of the square is: " + sq.perimeter());

                Console.Write("Would you like to continue?(Y?N): ");
                ans = Console.ReadLine();
            } while (ans == "Y" || ans == "y");

            Console.ReadKey();

        }
}
}
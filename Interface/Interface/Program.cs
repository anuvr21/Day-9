using System;


namespace Interface
{
    interface IFigure
    {
        int Dimension
        {
            get;
            set;
        }
        double Area();
        double Perimeter();
    }

    class Circle : IFigure
    {
        private int _radius;
        public int Dimension
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public double Area()
        {
            return Math.PI * _radius * _radius;

        }
        public double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }

    class Square : IFigure
    {
        private int _side;
        public int Dimension
        {
            get { return _side; }
            set { _side = value; }
        }
        public double Area()
        {
            return _side * _side;

        }
        public double Perimeter()
        {
            return 4 * _side;
        }

    }
        class Program
    {
        public static void Main(string[] args)
        {
            IFigure fig = null;
            Console.WriteLine("Enter 'C' for Circle or 'S' for Square");
            string ch=Console.ReadLine();
            if(ch=="S")
            {
                fig=new Square();
            }
            else if(ch=="C") 
            {
                fig = new Circle();
            }
            fig.Dimension = 10;
            Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());
        }
    }
}
    
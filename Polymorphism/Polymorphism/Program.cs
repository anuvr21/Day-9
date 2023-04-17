using System;


namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s1 = new Shape();
            //s1.DrawShape();             //Shape
            //Circle c1 = new Circle();
            //c1.DrawShape();             //Circle
            //Rectangle r1 = new Rectangle();
            //r1.DrawShape();             //Rectangle

            //Shape s2 = new Circle();    //Upcatsing
            //s2.DrawShape();             //Circle

            //Shape s3 = new Rectangle();
            //s3.DrawShape();             //Rectangle


            //Array of references of base class referencing derived class object(UPCASTING)
            Shape[] p =
            {
                new Circle(),
                new Rectangle(),
                //new Circle(),
                //new Rectangle(),
                //new Circle(),
            };
            for(int i=0;i<p.Length; i++)
                p[i].DrawShape();

            Shape t = null;
            Console.WriteLine("Enter shape:");
            string shape=Console.ReadLine();
            if(shape.ToLower()=="circle")
            {
                t = new Circle();
            }
            else if(shape.ToLower()=="rectangle")
            {
                t = new Rectangle();
            }
            t.DrawShape();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonteStruct
{
    public struct Coords
    {
        public double x, y;
        public Coords(double p1, double p2)
        {
            x = p1;
            y = p2;
        }

       double Hypotenuse()
        {
            double hypoteneuse = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var rnd = new Random();

            Console.WriteLine("How many points do you wish to test? ");
            double s = double.Parse(Console.ReadLine());
            int s1 = (int)s;

            double x;
            double y;

            Coords[] point = new Coords[s1];

            for (var i = 0; i < s1; i++)
            {
                point[i] = new Coords(rnd.NextDouble(), rnd.NextDouble());

            }

            foreach (Coords i in point)
            {
                Console.WriteLine("\tx = {0:f3}, y = {1:f3}", i.x, i.y);

                //    if (i.Hypotenuse() <= 1.0)
                //    {
                //        ++inCircle;
                //    }
                //}

                //    each (var i in point)
                //{
                //    Console.WriteLine;
                //}
                //Console.ReadLine();

                //z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                //Console.WriteLine(Math.Round(z, 3));

                //
            }
        } 
    }
}






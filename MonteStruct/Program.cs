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

        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
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

            double inCircle = 0;
            double outCircle = 0;

            Coords[] point = new Coords[s1];

            for (var i = 0; i < s1; i++)
            {
                point[i] = new Coords(rnd.NextDouble(), rnd.NextDouble());

            }

            foreach (Coords i in point)
            {
                //Console.WriteLine("\tx = {0:f4}, y = {1:f4}", i.x, i.y);

                if (i.Hypotenuse() <= 1.0)
                {
                    ++inCircle;
                }
                else if (i.Hypotenuse() > 1.0)
                {
                    ++outCircle;
                }
            }
            double piEstimate = (Math.Abs(((inCircle / point.Length) * 4) - Math.PI));

            Console.Clear();
            Console.WriteLine("Returned " + inCircle + " points inside the circle, and " + outCircle + " points outsided the circle \n" +
                "Your estimate of Pi is: " + ((inCircle / point.Length) * 4));
            Console.WriteLine("\nyour estimate is " + Math.Round(piEstimate, 5) + " from the actual value of Pi");
            Console.ReadLine();
        }
    }
}






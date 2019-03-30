using System;

namespace MonteStruct
{

    class Program
    {
        static void Main(string[] args)
        {

            Coords myCoords = new Coords();
           

           var rnd = new Random();

            Console.WriteLine("How many points do you wish to test? ");
            double s = double.Parse(Console.ReadLine());
            int s1 = (int)s;



            double x;
            double y;
            double z;

            for (var i = 0; i < s1; i++)
            {
              x = rnd.NextDouble();
              y = rnd.NextDouble();

                z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                Console.WriteLine(Math.Round(z,3));
                if (z )
            }
            Console.ReadLine();


                            }


            //int c1 = (int)p;

            //Coords newCoords = new Coords();


            //    double count = 0;

            //    for (int i = 0; i < p; i++)
            //    {
            //        count++;
            //        double x = rand.NextDouble();
            //        double y = rand.NextDouble();

            //        double Array[p] = new Array(,);




            //        Array[i] newCoord = new Coords(x, y)
            //        {
            //            x, y;
            //        }

            //        struct Coord[;] coordArray = new Coord[p1];



            //        (rand.NextDouble(), rand.NextDouble()); 
            //}
            //        double[] coords = new Coords[p1];
        }

    }






namespace HomeWork1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            //int b = 0;
            //int c = 0;
            //int d = 0;


            //a = SeedValue("a");
            //b = SeedValue("b");
            //c = SeedValue("c");
            //d = SeedValue("d");

            //int tmp = a;

            //if (tmp < b)
            //{ tmp = b; }

            //if (tmp < c)
            //{ tmp = c; }

            //if (tmp < d)
            //{ tmp = d; }


            //Console.WriteLine("max value: " + tmp.ToString());



            ////////////////////////////////////////////////////////////////

            /// it is not code:  sqrt(p(p-a)(p-b)(p-b))

            //int a = 0;
            //int b = 0;
            //int c = 0;
            //bool isValid = true;

            //a = SeedValue("a");
            //b = SeedValue("b");
            //c = SeedValue("c");

            //if (a <= 0)
            //{
            //    Console.WriteLine("Sorry, side cannot be less than 0 or be 0");
            //    isValid = false;
            //}
            //if (b <= 0)
            //{
            //    Console.WriteLine("Sorry, side cannot be less than 0 or be 0");
            //    isValid = false;
            //}
            //if (c <= 0)
            //{
            //    Console.WriteLine("Sorry, side cannot be less than 0 or be 0");
            //    isValid = false;
            //}

            //if (isValid)
            //{

            //    double p = (a + b + c) / 2;

            //    double res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            //    Console.WriteLine("area of a triangle: " + res);
            //}


            ////////////////////////////////////////////////////////////////////////////


            //int x1 = 0;
            //int y1 = 0;
            //int z1 = 0;

            //x1 = SeedValue("X1");
            //y1 = SeedValue("Y1");
            //z1 = SeedValue("Z1");

            //int x2 = 0;
            //int y2 = 0;
            //int z2 = 0;

            //x2 = SeedValue("X2");
            //y2 = SeedValue("Y2");
            //z2 = SeedValue("Z2");



            //double module = Math.Sqrt(Math.Pow((x2 - x1), 2) + 
            //    Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

            //Console.WriteLine("Module of vector: " + module);

          
        }

        /// <summary>
        /// Function for set value to varible
        /// </summary>
        /// <param name="name">Param for a name of variable</param>
        /// <returns>Entered data</returns>
        static int SeedValue(string name)
        {
            int value = 0;
            Console.Write($"Enter value for {name}: ");
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Type of data is not valid!");
                value = -1;
            }
            return value;
        }



    }
}

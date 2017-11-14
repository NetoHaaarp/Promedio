using System;
namespace prog
{
    class Promedio
    {
        public static void Main(String[] args)
        {
            int i = 0;
            double n = 0;
            double h = 0;
            double k = 1;
            while (k != 0)
            {
                Console.WriteLine("Da numero");
                n = double.Parse(Console.ReadLine());
                if (n == 0)
                {
                    k = 0;
                }
                else
                {
                    h = h + n;
                    i++;
                }

            }
            h = h / i;
            Console.WriteLine("R = " + h);
            Console.ReadKey();
        }

    }
}
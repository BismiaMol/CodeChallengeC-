using System;

namespace ClearanceSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name of the Product");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Price of the Product");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is the product on SALE (yes/no) : ");
            string sale = Console.ReadLine();
            Console.WriteLine("Enter number of product sold in day 1  ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 2  ");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 3  ");
            int r = Convert.ToInt32(Console.ReadLine());
            float a1, a2, a3, t1, t2, t3;
            float d1, d2, d3;
            if (sale == "yes")
            {
                d1 = price * 7 / 100;
                a1 = price - d1;
                d2 = a1 * 7 / 100;
                a2 = a1 - d2;
                d3 = a2 * 7 / 100;
                a3 = a2 - d3;
                t1 = a1 * p;
                t2 = a2 * q;
                t3 = a3 * r;
                Console.WriteLine($"{name}");
                Console.WriteLine($"Day 1 sales total : {t1} ");
                Console.WriteLine($"Day 2 sales total : {t2} ");
                Console.WriteLine($"Day 3 sales total : {t3} ");
            }
            else
            {
                t1 = p * price;
                t2 = q * price;
                t3 = r * price;
                Console.WriteLine($"{name}");
                Console.WriteLine($"Day 1 sales total : {t1} ");
                Console.WriteLine($"Day 2 sales total : {t2} ");
                Console.WriteLine($"Day 3 sales total : {t3} ");

            }


        }
    }
}
using System;


namespace ISPLABS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me text with words and see show!!!");


            string str;
            str = Console.ReadLine();

            string[] arr = str.Split(' ');
            Array.Reverse(arr);
            string str1 = string.Join(" ", arr);
            Console.WriteLine(str1);

            

            int a, b, n = 0, per;
            Console.WriteLine("Lets found the biggest 2^n, whick can separate the some factorialm. Give first number, and later second");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                per = i;
                while (per % 2 == 0)
                {
                    n = n + 1;
                    per = per / 2;

                }

            }
            Console.WriteLine($"The biggest 2^{n}");


            int x1 = 0, x2 = 0, x3 = 0, y1 = 0, y2 = 0, y3 = 0, check = 1;
            Console.WriteLine("Start work with triaunguale.");
            while (check == 1)
            {

                Console.WriteLine("Give me x1.");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give me x2.");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give me x3.");
                x3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give me y1.");
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give me y2.");
                y2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give me y3.");
                y3 = Convert.ToInt32(Console.ReadLine());

                               check = 0;
                    



                }
                double S, P, r, R, ct, at, bt, p;
                at = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
                bt = Math.Sqrt(((x1 - x3) * (x1 - x3)) + ((y1 - y3) * (y1 - y3)));
                ct = Math.Sqrt(((x2 - x3) * (x2 - x3)) + ((y2 - y3) * (y2 - y3)));
                P = at + bt + ct;
                p = P / 2;
                S = Math.Sqrt(p * (p - at) * (p - bt) * (p - ct));
                R = at * bt * ct / (4 * S);
                r = S / p;
                Console.WriteLine($"AB={at},BC={bt},AC={ct}, P={P}, S={S}, R={R}, r={r}. ");
                Console.ReadKey();
            }
        }
    }
}


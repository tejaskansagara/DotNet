using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            pattern1();
            pattern2();
            pattern3();
        }

        
        public static void pattern1()
        {
            Console.WriteLine("pattern1");
            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        
        public static void pattern2()
        {
            Console.WriteLine("pattern2"); 
            for (int i = 5; i >= 1; --i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }



        public static void pattern3()
        {
            Console.WriteLine("pattern3");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
 
    }
}

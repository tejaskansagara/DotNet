using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to Octal"); 
            DecimaltoOctal();
            Console.WriteLine("\nDecimal to Hex");
            DecimaltoHex();
            Console.WriteLine("\nDecimal to binary");
            DecimaltoBinary();
            Console.WriteLine("\nbinary to decimal");
            BinarytoDecimal();
            Console.Read();
        }

        public static void DecimaltoOctal()
        {
            int decimalnumber = 15;
            char[] octalnumber = new char[50];
            int i = 0;
            while (decimalnumber > 0)
            {
                int temp = decimalnumber % 8;
                octalnumber[i] = (char)(temp + 48);
                i++;
                decimalnumber /= 2;
            }

            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(octalnumber[j]+" ");
            }

        }




        public static void DecimaltoHex()
        {   
            int decimalnumber = 20;
            char[] hexnumber = new char[50];
            int i = 0;
            while (decimalnumber > 0)
            {
                int temp = decimalnumber % 16;
                if (temp > 9)
                    hexnumber[i] = (char)(temp + 58);
                else
                    hexnumber[i] = (char)(temp + 48);
                i++;
                decimalnumber /= 16;
            }

            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(hexnumber[j]+" ");
            }

        }

        public static void DecimaltoBinary()
        {
            int n, i;
            int[] a = new int[10];
            Console.Write("Enter the number decimal to convert: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given binary number: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }      

        }
        public static void BinarytoDecimal()
        {
            int num, binVal, decVal = 0, baseVal = 1, rem;
            num = 101;
            binVal = num;
            while (num > 0)
            {
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
            Console.Write("Binary Number: " + binVal);
            Console.Write("\nDecimal: " + decVal);
            Console.ReadLine();

        }


       

        }


    }


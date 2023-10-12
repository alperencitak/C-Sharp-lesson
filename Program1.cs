using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AsalDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 9;


            if (sayi == 2)
            {
                Console.WriteLine("This is a Prime Number");
            }
            if (sayi < 2)
            {
                Console.WriteLine("This is not a Prime Number");
            }

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine("This is not a Prime Number");
                    break;
                }
                else
                {
                    Console.WriteLine("This is a Prime Number");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}

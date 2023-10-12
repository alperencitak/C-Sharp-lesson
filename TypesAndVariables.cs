using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            double number5 = 10.4;
            decimal number6 = 9.67859234598510m;
            char character = 'A';
            string city = "Ankara";
            bool condition = false;
            byte number4 = 128;
            short number0 = -345;
            int number1 = 10;
            int number2 = 20;
            long number3 = 3124976435698;
            var number7 = 41;
            number7 = 'A';
            Console.WriteLine("Number 2 is {1}, Number 3 is {2}, Number 0 is {3}", number1,number2,number3,number0);
            Console.WriteLine("Number 4 is {0}, Number 5 is {1}, Number 6 is {2}", number4,number5,number6);
            Console.WriteLine("Number 7 is {0}", number7);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=10,Tuesday=20,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}

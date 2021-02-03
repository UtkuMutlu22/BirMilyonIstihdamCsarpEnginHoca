using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            Console.WriteLine("Number 1 is {0}",number1);
            long number2 = 20;
            Console.WriteLine("Number 2 is {0}",number2);
            short number3 = 3434;
            Console.WriteLine("Number 3 is {0}", number3);
            byte number4 = 255;
            Console.WriteLine("Number 4 is {0}", number4);
            bool number5 = true;
            Console.WriteLine("Number 5 is {0}", number5);
            char character = 'A';
            Console.WriteLine("Character is {0}", character);
            double number6 = 12.3;
            Console.WriteLine("Number 6 is {0}", number6);
            decimal number7 = 16.4m;
            Console.WriteLine("Number 7 is {0}", number7);
            Console.WriteLine((int)days.friday);
            var number8 = 10;
            number8 = 'A';
            Console.WriteLine("Number 8 is {0}", number8);
        }
        enum days{monday,tuesday,wednesday,thursday,friday,saturday,sunday}
    }
}

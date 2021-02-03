using System;

namespace ReferanceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number1 = 30;
            Console.WriteLine(number2);
            string[] citys = { "Ankara", "Adana", "Afyon" };
            string [] citys2 = { "Bursa", "Bolu", "Balıkesir" };
            citys2 = citys;
            citys2[0] = "İstanbul";
            Console.WriteLine(citys[0]);

        }
    }
}

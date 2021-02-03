

using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number0 = 0;
            for (int i = 0; i <=100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("while döngüsü");
            while (number0<100)
            {
                Console.WriteLine(number0);
                number0++;
            }
            Console.WriteLine("do-while döngüsü");
            do
            {
                Console.WriteLine(number0);
                number0++;
            } while (number0<100);
            Console.WriteLine("foreach döngüsü");
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 3;
            numbers[2] = 5;
            numbers[3] = 7;
            numbers[4] = 9;
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            int kontrol = 0;
            List<int> asalSayilar = new List<int>();
            int number3 = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <number3; i+=2)
            {
                if (i%number3==0)
                {
                    kontrol++;
                }
            }
            if (kontrol!=0)
            {
                Console.WriteLine("sayi asal değil");
            }
            else
            {
                Console.WriteLine("sayi asal");
            }
        }
    }
}

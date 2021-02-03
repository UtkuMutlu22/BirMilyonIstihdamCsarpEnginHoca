using System;
using System.Linq;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            // int number1 = 20;
            //int number2 = 100;

            ////int result = Add2(number1,number2);
            //int result2 = Add3(out number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,2));
           int result = Add4(1, 2, 3, 45, 56, 676, 78732);
            Console.WriteLine(result);
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add2( int number1, int number2 = 30)
        {
            return number1 + number2;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;


            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {


            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {


            return number1 * number2*number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}

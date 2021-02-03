using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Utku";
            string student2 = "Arzu";
            string student3 = "Fuat";
            string student4 = "Mürvet";

            string[] students = new string[4];
            students[0] = "Utku";
            students[1] = "Arzu";
            students[2] = "Fuat";
            students[3] = "Mürvet";
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            string[] students2 = new string[4];
            students[0] = "Ali";
            students[1] = "Veli";
            students[2] = "Ahmet";
            students[3] = "Mehmet";
            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }
            string[,] regions = new string[7, 3] { { "İstanbul", "İzmit", "Edirne" }, { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" }, { "Rize", "Trabzon", "Samsun" }, 
                { "İzmir", "Muğla", "Manisa" }, { "Diyarbakır", "Mardin", "Batman" },
                { "Erzincan", "Erzurum", "Kars" } };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("****");
            }


        }
    }
}

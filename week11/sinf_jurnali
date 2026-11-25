namespace Sinf_jadvali
{
    internal class Program
    {
        static void Main(string[] args)

            {
            string[] oquvchilar = { "Shahzoda", "Zilola", "Guljahon", "Dilnoza","Gulsanam","Dilshoda","Muborak","Shabbona"};
            string[] fanlar = { "Hisob", "Fizika", "Dasturlash","Xorijiy til","Akademik yozuv","O`zbekistonning eng yangi tarixi"};

            int[,] sinfJadvali = {
            { 5, 4, 5, 5, 5, 4},
            { 4, 5, 4,5, 5,5,},
            { 5, 5, 5,4,3 ,4},
            { 5, 4, 3 ,5,5,5},
            {5,4,5,3,5,4},
            {4,5,5,5,4,5},
            {5,5,4,4,3,4},
            {4,3,5,3,4,5 },
        };
            int oquvchilarSoni = sinfJadvali.GetLength(0);
            int fanlarSoni = sinfJadvali.GetLength(1);

            Console.WriteLine("Sinf jadvali:\n");
            Console.Write("O'quvchi\t");
            for (int j = 0; j < fanlarSoni; j++)
            {
                Console.Write($"{fanlar[j]}\t");
            }
            Console.WriteLine("\n-");

            for (int i = 0; i < oquvchilarSoni; i++)
            {
                Console.Write($"{oquvchilar[i]}\t\t");
                for (int j = 0; j < fanlarSoni; j++)
                {
                    Console.Write($"{sinfJadvali[i, j]}\t\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--");
            Console.Write("O'rtacha:\t");
            for (int j = 0; j < fanlarSoni; j++)
            {
                double ustunYigindisi = 0;
                for (int i = 0; i < oquvchilarSoni; i++)
                {
                    ustunYigindisi += sinfJadvali[i, j];
                }

                double ortacha = ustunYigindisi / oquvchilarSoni;
                Console.Write($"{ortacha:F2}\t\t");
            }

            Console.WriteLine();
        }
    }
}

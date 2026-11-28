namespace Ortacha_qiymat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 ta son o'rtachasi: " + Ortacha(10, 20, 30));
            Console.WriteLine("5 ta son o'rtachasi: " + Ortacha(4, 8, 15, 16, 23));
            Console.WriteLine("2 ta son o'rtachasi: " + Ortacha(7, 12));
        }

        static double Ortacha(params int[] sonlar)
        {
            if (sonlar.Length == 0)
                return 0;

            double yigindi = 0;

            foreach (int son in sonlar)
            {
                yigindi += son;
            }

            return yigindi / sonlar.Length;
        }
    }
}

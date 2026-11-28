namespace _2ta_sondan_kattasini_qaytaruvchi_metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinchi sonni kiriting:");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ikkinchi sonni kiriting:");
            int y = int.Parse(Console.ReadLine());

            int natija = Katta(x, y);
            Console.WriteLine($"Kattasi: {natija}");
        }
        static int Katta(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }    

}

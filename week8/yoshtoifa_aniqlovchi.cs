namespace Yosh_toifa_aniqlovchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("YOSHINGIZNI KIRITING:");
            string kiritilgan = Console.ReadLine();

            if (int.TryParse(kiritilgan, out int yosh)) ;
            {
                if (yosh <= 12) Console.WriteLine("TOIFA:BOLA");
                else if (yosh <= 18) Console.WriteLine("TOIFA:O`SMIR");
                else if (yosh <= 60) Console.WriteLine("TOIFA:KATTALAR");
                else Console.WriteLine("TOIFA:KEKSA");
            }
        }   
    }
}

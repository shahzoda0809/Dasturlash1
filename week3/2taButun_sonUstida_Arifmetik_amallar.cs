namespace _2ta_butun_son_ustida_arifmetik_amallar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinchi butun sonni kiriting (a): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikkinchi butun sonni kiriting (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Yig'indi (a + b): {a + b}");
            Console.WriteLine($"Ayirma (a - b): {a - b}");
            Console.WriteLine($"Ko'paytma (a * b): {a * b}");

            if (b != 0)
            {
                Console.WriteLine($"Bo'linma (a / b, butun): {a / b}");
                Console.WriteLine($"Qoldiq (a % b): {a % b}");
            }
            else
            {
                Console.WriteLine("Bo'linma va qoldiq: 0 ga bo'lish mumkin emas!");
            }
        }
    }
}

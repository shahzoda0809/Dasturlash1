namespace double_ga_keltirish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Double ga keltirish uchun son kiriting: ");
            double kiritilganSon = Convert.ToDouble(Console.ReadLine());
            double natijaDouble = kiritilganSon; // kiritilgan qiymat double turida saqlandi
            Console.WriteLine($"Double ko'rinishida: {natijaDouble}");
            Console.WriteLine("Izoh: double turi kasr (o'nlik) sonlarni ham aniqlik bilan saqlaydi, int esa faqat butun sonlarni.");
        }
    }
}

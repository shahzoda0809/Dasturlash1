namespace Fibonachchi_soni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nechinchi Fibonachchi sonini topmoqchisiz (n): ");
            int n = int.Parse(Console.ReadLine());

            int natija = Fibonachchi(n);
            Console.WriteLine($"{n}-Fibonachchi soni: {natija}");
        }

        static int Fibonachchi(int n)
        {
            if (n <= 1)
                return n;

            return Fibonachchi(n - 1) + Fibonachchi(n - 2);
        }
    }
    
}

namespace _10ta_int_elementli_massiv_yaratish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sonlar = { 4, 12, 7, 19, 3, 25, 8, 14, 6, 10 };

            Console.WriteLine("1-topshiriq (Massiv elementlari):");
            foreach (int element in sonlar)
            {
                Console.Write(element + " ");
            }
        }
    }
}

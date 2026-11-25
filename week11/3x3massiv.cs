namespace _3x3_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matritsa = {
            { 8, 18, 22 },
            { 4, 8, 6 },
            { 7, 8, 9 }
        };

            int umumiyYigindi = 0;

            foreach (int element in matritsa)
            {
                umumiyYigindi += element;
            }

            Console.WriteLine("Barcha elementlar yig'indisi: " + umumiyYigindi);
          
        }
    }
}

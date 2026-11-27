namespace Random_klassi_yordamida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] zarMassiv = new int[5];

            Console.WriteLine(" (Zar sonlari 1..6):");
            for (int i = 0; i < zarMassiv.Length; i++)
            {
                zarMassiv[i] = rnd.Next(1, 7);
                Console.Write(zarMassiv[i] + " ");
            }
        }
    }
}

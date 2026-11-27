namespace massiv_elementlar_yig_indisi_for_sikliYordamida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sonlar = { 19, 2, 3, 4, 12, 18, 8, 25, 9, 10 };

            int yigindi = 0;
            for (int i = 0; i < sonlar.Length; i++)
            {
                yigindi += sonlar[i];
                Console.WriteLine("Massiv elementlar yig'indisi: " + yigindi);
            }
        }
    }
}

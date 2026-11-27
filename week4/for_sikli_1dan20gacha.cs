namespace for_sikli_1dan_20gacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 dan 20 gacha juft sonlar:");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }   
    }
}

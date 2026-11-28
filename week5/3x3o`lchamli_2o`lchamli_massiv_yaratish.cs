namespace _3x3_o_lchamli__2o_lchamli_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matritsa = new int[3, 3];

            Console.WriteLine("3x3 massiv:");
            for(int qator=0; qator<matritsa.GetLength(0);qator++)
            {
                for(int ustun=0; ustun < matritsa.GetLength(1); ustun++)
                {
                    matritsa[qator, ustun] = (qator + 1) * (ustun + 1);
                    Console.Write(matritsa[qator, ustun] + "/t");
                }
                Console.WriteLine();
            }
        }
    }
}

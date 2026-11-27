{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0 dan 100 gacha ball kiriting: ");
            int ball = Convert.ToInt32(Console.ReadLine());

            if (ball < 0 || ball > 100)
            {
                Console.WriteLine("Xato: ball 0 va 100 oralig'ida bo'lishi kerak!");
            }
            else if (ball >= 86)
            {
                Console.WriteLine("Baho: 5 (A'lo)");
            }
            else if (ball >= 71)
            {
                Console.WriteLine("Baho: 4 (Yaxshi)");
            }
            else if (ball >= 56)
            {
                Console.WriteLine("Baho: 3 (Qoniqarli)");
            }
            else
            {
                Console.WriteLine("Baho: 2 (Qoniqarsiz)");
            }
        }
    }
}

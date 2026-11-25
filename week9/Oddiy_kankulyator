namespace ODDIY_KANKULYATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinchi sonni kiriting;");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Amallarni kiriting(+,-,*,/):");
            char amal = Convert.ToChar(Console.ReadLine());

            Console.Write("Ikkinchi sonni kiriting:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double natija = 0;
            bool xato = false;

            switch (amal)
            {
                case '+':
                    natija = num1 + num2;
                    break;
                case '-':
                    natija = num1 - num2;
                    break;
                case '/':
                    if (num2 != 0)
                        natija = num1 / num2;
                    else
                    {
                        Console.WriteLine("nolga bo`lish mumkin emas!");
                        xato = true;
                    }
                    break;
                default:
                    Console.WriteLine("notog`ri amal kiritildi!");
                    xato = true;
                    break;
            }
            if (!xato)
            {
                Console.WriteLine($"natija:{num1} {amal} {num2}={natija}");

            
        
   

            }              
        }
    }
}

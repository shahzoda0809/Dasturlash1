namespace do_while_sikli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tanlov;
            do
            {
                Console.Write("Chiqish uchun 0 kiriting (boshqa son davom ettiradi): ");
                tanlov = Convert.ToInt32(Console.ReadLine());
            } while (tanlov != 0);
        }
    }
}

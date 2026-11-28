namespace satrdagi_unli_harflarni_hisoblash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matn kiriting: ");
            string matn = Console.ReadLine() ?? "";

            int unlilarSoni = UnlilarniHisobla(matn);
            Console.WriteLine($"Matndagi unli harflar soni-{unlilarSoni}ta");
        }
        static int UnlilarniHisobla(string satr)
        {
            int sanoq = 0;

            foreach (char belgi in satr.ToLower())
            {
                if (char.IsLetter(belgi) &&
                    (belgi == 'a'||  belgi == 'e'||  belgi == 'i' || belgi == 'o'||  belgi == 'u'))
                {
                    sanoq++;
                }
            }

            return sanoq;

        }

    }
}

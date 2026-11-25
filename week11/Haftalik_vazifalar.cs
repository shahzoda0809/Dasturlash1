namespace Haftalik_vazifalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            string[] kunlar = {
                "Dushanba", "Seshanba", "Chorshanba",
                "Payshanba", "Juma", "Shanba", "Yakshanba"
            };
            string[][] haftalikVazifalar = new string[7][];
            haftalikVazifalar[0] = new string[] { "Hisoblah darsi", " misollar ishlash", "qoidalar yodlash" };
            haftalikVazifalar[1] = new string[] { "Fizika laboratoriya", "labaratoriyani bajarish" };
            haftalikVazifalar[2] = new string[] { "Dasturlash loyihasi", "uy ishi", "dastur yozish", "GitHubga yuklash" };
            haftalikVazifalar[3] = new string[] { "Akademik yozuv", "mustaqil ish tayyorlash" };
            haftalikVazifalar[4] = new string[] { "Xorijiy til", "lug`at yodlash", "Takrorlash","mashqlarni bajarish","nazorat ishiga tayyorlanish" };
            haftalikVazifalar[5] = new string[] { "Dam olish", "Xarid qilish", "Oila azolarga yordam", "Kino ko'rish", "Reja tuzish","vazifalarni bajarish", };
            haftalikVazifalar[6] = new string[] { "Dam olish", "Oila bilan vaqt o'tkazish", "Kitob o'qish", "Sport bilan shug'ullanish", "Uy ishlarini bajarish", };
            Console.WriteLine("=== HAFTALIK VAZIFALAR RO'YXATI ===\n");
            for (int i = 0; i < haftalikVazifalar.Length; i++)
            {
                Console.Write($"{kunlar[i]} ({haftalikVazifalar[i].Length} ta): ");
                for (int j = 0; j < haftalikVazifalar[i].Length; j++)
                {
                    Console.Write(haftalikVazifalar[i][j]);
                    if (j < haftalikVazifalar[i].Length - 1) Console.Write(", ");
                }
                Console.WriteLine();
            }

            int maxIndex = 0;
            for (int i = 1; i < haftalikVazifalar.Length; i++)
            {
                if (haftalikVazifalar[i].Length > haftalikVazifalar[maxIndex].Length)
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine("/n=== ENG KO'P VAZIFALI KUN ===");
            Console.WriteLine($"{kunlar[maxIndex]} ({haftalikVazifalar[maxIndex].Length} ta)");
        }
    }
}

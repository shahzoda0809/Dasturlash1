            Console.Write("Nechta talaba bor? ");
            int soni = int.Parse(Console.ReadLine());
            int[] ballar = new int[soni];
            for (int i = 0; i < soni; i++)
            {
                Console.Write($"{i + 1}-talaba balli: ");
                ballar[i] = int.Parse(Console.ReadLine());
            }

            int yigindi = 0;
            foreach (int ball in ballar)
            {
                yigindi += ball;
            }

            int minimum = ballar[0];
            int maksimum = ballar[0];

            for (int i = 1; i < soni; i++)
            {
                if (ballar[i] < minimum)
                {
                    minimum = ballar[i];
                }
                if (ballar[i] > maksimum)
                {
                    maksimum = ballar[i];
                }
            
            double ortacha = (double)yigindi / soni;
              
            Console.WriteLine("\nNATIJA (Console chiqishi)");
            Console.WriteLine($"Yig'indi: {yigindi}");
            Console.WriteLine($"Minimum: {minimum}");
            Console.WriteLine($"Maksimum: {maksimum}");
            Console.WriteLine($"O'rtacha: {ortacha}");
        }
    
}

        {
            Console.WriteLine("sinfda nechta o`quvchi bor? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ballar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"o`quvchi {i + 1} ballini kiriting: ");
                ballar[i] = Convert.ToInt32(Console.ReadLine());
            }
            double ortachaBallar = ballar.Average();
            int pastBallarSoni = 0;

            for (int i = 0; i < n; i++)
            {
                if (ballar[i] < ortachaBallar)
                {
                    pastBallarSoni++;
                }
            }
            Console.WriteLine($"/nSinfning o`rtacha balli:{ortachaBallar:F1}");
            Console.WriteLine($"O`rtachadan pastroq ball olganlar soni: {pastBallarSoni} ta");
        }


        
        
    


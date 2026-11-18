 {
     double[] haroratlar = new double[7];
     for (int i = 0; i < 7; i++)
     {
         Console.Write($" {i + 1}-kun haroratini kiriting: ");
         haroratlar[i] = Convert.ToDouble(Console.ReadLine());
     }
     double maxHarorat = haroratlar.Max();
     double minHarorat = haroratlar.Min();

     int maxKun = Array.IndexOf(haroratlar, maxHarorat) + 1;
     int minKun = Array.IndexOf(haroratlar, minHarorat) + 1;

     Console.WriteLine($"/n Eng issiq kun:{maxKun}-kun, harorat: {maxHarorat}°C");
     Console.WriteLine($"Eng sovuq kun:{minKun}-kun, harorat: {minHarorat}°C");
 }         

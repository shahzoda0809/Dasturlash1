Console.Write("Juft yoki toqligini tekshirish uchun butun son kiriting: ");
            int son = Convert.ToInt32(Console.ReadLine());
            string juftYokiToq = (son % 2 == 0) ? "Juft son" : "Toq son";
            Console.WriteLine($"Natija: {son} — {juftYokiToq}");

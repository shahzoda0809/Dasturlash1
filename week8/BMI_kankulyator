namespace BMI_kankulyatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bo`yingizni metrda kiriting(1.82):");
            double boy = double.Parse(Console.ReadLine());

            Console.Write("Vazningizni kgda kiriting (82): ");
            double vazn= double.Parse(Console.ReadLine());

            double bmi = Math.Round(vazn / (boy * boy), 1);
            Console.WriteLine($"sizning BMI ko`rsatgichingiz:{bmi}");

            if (bmi < 18.5) Console.WriteLine("toifa:kam vazn");
            else if (bmi <= 25) Console.WriteLine("toifa:normal");
            else Console.WriteLine("toifa:ortiqcha vazn");

        }
    }
}

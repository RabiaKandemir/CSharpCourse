namespace Loops
{
    internal class Program
    {
        /// <summary>
        /// Döngüler
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /* For Döngüsü */
            ForLoop();
            /* While Döngsü */
            WhileLoop();
            /* Do-While Döngüsü */
            DoWhileLoop();
            /* ForEach Döngüsü */
            ForEachLoop();
            /* Asal Sayı */
            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine("Tek Sayılar: " + i);
            }
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine("Çift Sayılar: " + i);
            }
        }
    }
}
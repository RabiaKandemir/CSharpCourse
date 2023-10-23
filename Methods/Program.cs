namespace Methods
{
    internal class Program
    {
        /// <summary>
        /// Methodlar
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            Add();
            Console.WriteLine("Parametreli Metot: "+Add2(2, 7));
            Console.WriteLine("Defauld Parametre: "+Add3(20));
            var result = Add4(ref number1,number2);
            Console.WriteLine("Ref Keyword: "+result);
            Console.WriteLine(number1);
            var result2 = Add5(out number1, number2);
            Console.WriteLine("Out Keyword: " + result2);
            Console.WriteLine(number1);
            Console.WriteLine("Method Overloading: "+Multiply(2,3));
            Console.WriteLine("Method Overloading: "+Multiply(2,3,4));
            Console.WriteLine("Params: "+Add6(1,2,3,4,5,6,7,8,9));
        }
        /* Metot */
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        /* Parametreli Geriye Değer Döndüren Metot */
        static int Add2(int number1,int number2) 
        {
            return number1 + number2;
        }

        /* Default Parametreli Metot */
        static int Add3(int number1, int number2=30)
        {
            return number1 + number2;
        }
        /* Ref Keyword */
        static int Add4( ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        /* Out Keyword */
        static int Add5(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        /* Method Overloading */
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }
        /* Params Keyword */
        static int Add6(params int[]numbers)
        {
            return numbers.Sum();
        }
    }
}
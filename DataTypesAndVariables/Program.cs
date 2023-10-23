using System.Runtime.InteropServices.JavaScript;

namespace DataTypesAndVariables
{
    internal class Program
    {
       /// <summary>
       /// Value Types
       /// </summary>
       /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*Integer Veri Tipi*/
            int number1 = 10;
            Console.WriteLine("Number1 is {0} ",number1);
            /*Long Veri Tipi*/
            long number2 = 214561445664;
            Console.WriteLine("Number1 is {0} ", number2);
            /*Short Veri Tipi*/
            short number3 = 32767;
            Console.WriteLine("Number1 is {0} ", number3);
            /*Byte Veri Tipi
             0-255
             */
            byte number4 = 255;
            Console.WriteLine("Number1 is {0} ", number4);
            /*Bool Veri Tipi*/
            bool condition1 = true;
            bool condition2 = false;
            /*Char Veri Tipi*/
            char character = 'A';
            Console.WriteLine("Character is {0} ", character);
            Console.WriteLine("Character is {0} ", (int)character); //ASCII
            /*Double Veri Tipi*/
            double number5 = 10.4;
            Console.WriteLine("Number5 is {0} ", number5);
            /*Decimal Veri Tipi*/
            decimal number6 = 10.4m;
            Console.WriteLine("Number6 is {0} ", number6);
            /*Enum Veri Tipi*/
            Console.WriteLine((int)Days.Friday);
            /*Var Keywordu*/
            var number7 = 10;
            Console.WriteLine(number7);
            number7 = 'A';
            Console.WriteLine(number7);
        }
    }
    enum Days
    {
        Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
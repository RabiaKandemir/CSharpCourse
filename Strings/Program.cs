using System.Data.SqlTypes;

namespace Strings
{
    internal class Program
    {
        /// <summary>
        /// String Metodları
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Intro();
            string sentence = "My name is Rabia Kandemir";
            /* Lenght */
            var result=sentence.Length;
            Console.WriteLine("Lenght: "+ result);
            /* Clone */
            var result2=sentence.Clone();
            sentence = "My name is Engin Demiroğ";
            Console.WriteLine("Clone: "+result2);
            /* EndsWith-StartsWidth */
            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");
            /* IndexOf */
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            Console.WriteLine("IndexOf: "+result5);
            Console.WriteLine("IndexOf: "+result6);
            /* LastIndexOf */
            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine("LastIndexOf: " + result7);
            /* Insert */
            var result8 =sentence.Insert(0,"Hello, ");
            Console.WriteLine("Insert: "+result8);
            /* Substring */
            var result9 = sentence.Substring(3,4);
            Console.WriteLine("Substring: " + result9);
            /* ToLower */
            var result10 = sentence.ToLower();
            Console.WriteLine("ToLower: " + result10);
            /* ToUpper */
            var result11 = sentence.ToUpper();
            Console.WriteLine("ToUpper: " + result11);
            /* Replace */
            var result12 = sentence.Replace(" ","-");
            Console.WriteLine("Replace: " + result12);
            /* Remove */
            var result13 = sentence.Remove(2,5);
            Console.WriteLine("Remove: " + result13);
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
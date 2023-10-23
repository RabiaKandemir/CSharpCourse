namespace Arrays
{
    internal class Program
    {
        /// <summary>
        /// Diziler
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /* Tek Boyutlu Diziler */
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";
            //string[] students2 = { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student + "\n");
            }

            /* Çok Boyutlu Diziler */
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Giresun","Ankara" },
                {"İzmir","Muğla","Manisa" }
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                Console.WriteLine("*****************************");
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);

                }
            }
        }
    }
}
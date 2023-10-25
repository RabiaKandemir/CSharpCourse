namespace Inheritance
{
    internal class Program
    {
        /// <summary>
        /// Inheritance(Kalıtım): Sınıf bir tane inheritance alabilir
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Person[] persons=new Person[3]
            {
                new Customer{FirstName="Rabia"},new Student{FirstName="Engin"},new Person{FirstName="Salih"}
            };
            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
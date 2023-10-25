namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceIntro();
            /* Interface */
            Demo();
            /* Polymorphism */
            ICustomerDal[] customerDals = {new SqlServerCustomerDal(),new OracleCustomerDal(),new MySqlCustomerDal()};
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfaceIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Rabia", LastName = "Kandemir", Address = "Ankara" });
            Student student = new Student()
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Departmant = "Computer Sciences"
            };
            manager.Add(student);
        }
    }
    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
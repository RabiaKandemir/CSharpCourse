namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Rabia";
            customer.LastName = "Kandemir";
            customer.City = "Ankara";
            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName="Engin",
                LastName="Demiroğ",
                City="İstanbul"
            };
            Console.WriteLine(customer2.FirstName);
        }
    }
}
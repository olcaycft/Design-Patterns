using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerObserver customer1 = new CustomerObserver();
            ProductManager productManager = new ProductManager();
            productManager.Attach(customer1);
            productManager.Attach(new EmployeeObserver());
            productManager.Detach(customer1);
            productManager.UpdatePrice();
        }
    }
}

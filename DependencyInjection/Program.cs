using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new NhbProductDal());
            productManager.Save();
        }
    }
}

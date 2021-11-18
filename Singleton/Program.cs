using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var customermanager=CustomerManager.CreateAsSingleton();
            var customermanager2 = CustomerManager.CreateAsSingleton();
            customermanager.Save();
        }
    }
}

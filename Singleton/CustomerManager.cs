using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class CustomerManager
    {
        private static CustomerManager _customerManager;

        private int _degisken;
        private CustomerManager()
        {

        }

        public void Save()
        {
            Console.WriteLine("Saved");
        }
        public static CustomerManager CreateAsSingleton()
        {
            if(_customerManager==null)
            {
                _customerManager = new CustomerManager();
            }


            return _customerManager;
        }
    }
}

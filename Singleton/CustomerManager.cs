﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class CustomerManager
    {
        private static CustomerManager _customerManager;
        static object _lockObject = new object();


        private CustomerManager()
        {

        }

        public void Save()
        {
            Console.WriteLine("Saved");
        }
        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }
                


            return _customerManager;
        }
    }
}

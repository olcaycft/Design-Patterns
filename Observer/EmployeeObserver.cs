using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class EmployeeObserver:Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message for Employees Product price changed!");
        }
    }
}

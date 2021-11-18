using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class CustomerObserver:Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message for Customers Product price changed!");
        }
    }
}

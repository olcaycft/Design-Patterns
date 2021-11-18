using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class NhbProductDal:IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with Nhb");
        }
    }
}

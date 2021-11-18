using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ProductManager
    {

        List<Observer> _observers = new List<Observer>();
        public void UpdatePrice()
        {
            Console.WriteLine("Product Price changed");
            Notify();
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var obs in _observers)
            {
                obs.Update();
            }
        }
    }
}

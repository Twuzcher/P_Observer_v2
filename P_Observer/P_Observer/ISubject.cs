using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Observer
{
    interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservers();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Observer
{
    class Newspaper : ISubject
    {
        private List<IObserver> observers;
        private string text;

        public Newspaper()
        {
            observers = new List<IObserver>();
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = observers[i];
                observer.update(text);
            }
        }

        public void newInformation()
        {
            notifyObservers();
        }

        public void setText(string text)
        {
            this.text = text;
            newInformation();
        }


    }
}

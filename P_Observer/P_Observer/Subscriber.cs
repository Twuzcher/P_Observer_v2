using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Observer
{
    class Subscriber : IDisplayElement, IObserver
    {
        private ISubject newspaper;
        private string name;
        private string text;

        public Subscriber(ISubject newspaper, string name)
        {
            this.name = name;
            this.newspaper = newspaper;
            this.newspaper.registerObserver(this);
        }

        public void update(string text)
        {
            this.text = text;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name + "; News: " + text);
        }
    }
}

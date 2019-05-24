using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Newspaper newspaper = new Newspaper();
            Subscriber John = new Subscriber(newspaper);
            Subscriber Jo = new Subscriber(newspaper);
            newspaper.setText("Hello world! :)");
            newspaper.setText("This is pattern observer!");
            newspaper.setText("Nice to see you!");
            newspaper.removeObserver(John);
            newspaper.setText("Good luck! :)");
            Console.ReadKey();
        }
    }
}

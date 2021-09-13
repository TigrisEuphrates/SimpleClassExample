using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car chuck = new Car();
            chuck.PrintState();

            Car mary = new Car("Mary");
            mary.PrintState();

            Car daisy = new Car(cs: 75, pn: "Daisy");
            daisy.PrintState();

            Motorcycle mc = new Motorcycle(15);
            mc.PopAWheely();
            Console.WriteLine();

            Motorcycle c = new Motorcycle();
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine($"Rider's name is {c.name}"); ;
            Console.WriteLine();
        }
    }
}

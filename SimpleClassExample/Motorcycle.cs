using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;
        
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeee Haaaeeewww!");
            }
        }
        //public Motorcycle() { }
        //public Motorcycle(int intensity) : this(intensity, "") { }
        //public Motorcycle(string name) : this(0, name) { }
        //public Motorcycle(int intensivity, string name)
        //{
        //    if (intensivity>10)
        //    {
        //        intensivity = 0;
        //    }
        //    driverIntensity = intensivity;
        //    this.name = name;
        //}
        public Motorcycle(int intensivity=0, string name="")
        {
            if (intensivity > 10)
            {
                intensivity = 10;
            }
            driverIntensity = intensivity;
            this.name = name;
        }

        public void SetDriverName(string name)
        {
            this.name = name;
        }
    }
}

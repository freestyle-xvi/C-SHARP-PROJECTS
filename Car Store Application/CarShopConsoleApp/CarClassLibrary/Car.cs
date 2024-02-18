using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "Toybota";
            Model = "Controller";
            Price = 69.420M;
        }
        public Car(string a, string b, decimal c)
        {
            Make=a;
            Model=b;
            Price = c;
        }
        override public string ToString()
        {
            return "\nMake/Manufacturer: " + Make + "\n" + "Model: " + Model + "\nPrice: R" + Price;  

        }
    }
}

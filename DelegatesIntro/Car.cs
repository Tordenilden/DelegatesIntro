using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesIntro
{
    public class Car
    {
        public Car(Car c)
        {
            C = c;
        }
        public Car() { }
        public int id { get; set; }
        public string model { get; set; } //s40
        public string brand { get; set; } // volvo
        public int year { get; set; }
        public int price { get; set; }
        public string color { get; set; }
        public Car C { get; }
    }
    public interface myType
    {

    }
}

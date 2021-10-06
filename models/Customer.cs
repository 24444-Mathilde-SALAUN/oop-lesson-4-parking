using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking
{
    public class Customer
    {
        public int hoursParked { get; set; }
        public string registration { get; set; }
        public Customer(string registration, int hoursParked)
        {
            this.registration = registration;
            this.hoursParked = hoursParked;
            Console.WriteLine($"I am the Customer {registration}");
        }
        public override string ToString()
        {
            return $"I am the Customer {registration}";
        }
    }
}

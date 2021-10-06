using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking
{
    public class Car_Park_Charge
    {
        public int minimumFee { get; set; }
        public int minimumHours { get; set; }
        public Car_Park_Charge(int minimumFee=2, int minimumHours=3)
        {
            Console.WriteLine("I am the Car Park Charge");
            this.minimumFee = minimumFee;
            this.minimumHours = minimumHours;
        }
        public override string ToString()
        {
            return "I am the Car Park Charge";
        }
        public int Calculate_Charge(int hoursParked)
        {          
            int calculatedFee = hoursParked < minimumHours ? minimumFee : hoursParked * minimumFee;
            return calculatedFee;
        }
    }
}

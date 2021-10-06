using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking
{
    public class Car_Park
    {
        public List<Customer> listOfCustomers = new List<Customer>();
        public Car_Park_Charge carPArkCharge = new Car_Park_Charge();
        public Car_Park()
        {
            Console.WriteLine("I am the Car Park");
        }
        public override string ToString()
        {
            return "I am the Car Park";
        }
        public void Calculate_Charges()
        {
            foreach (Customer current_customer in listOfCustomers)
            {
                int calculatedCharge = carPArkCharge.Calculate_Charge(current_customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer {current_customer.registration}");
            }
        }
    }
}

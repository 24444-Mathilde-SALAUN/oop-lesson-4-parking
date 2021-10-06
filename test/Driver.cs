using System;
using System.Collections.Generic;
using System.Text;

namespace oop_lesson_4_parking
{
    public class Driver
    {
        public Driver ()
        {
            Console.WriteLine("I am the code driver");
        }
        public void CreateObjects ()
        {
            Car_Park carPark = new Car_Park();
            carPark.listOfCustomers.Add(new Customer("a",2));
            carPark.listOfCustomers.Add(new Customer("b",3));
            carPark.listOfCustomers.Add(new Customer("c",4));
            carPark.listOfCustomers.Add(new Customer("d",5));
            carPark.listOfCustomers.Add(new Customer("e",6));
            carPark.listOfCustomers.Add(new Customer("f",7));

            carPark.Calculate_Charges();

            Customer customer = new Customer("g",8);
            Car_Park_Charge carParkCharge = new Car_Park_Charge();

            //Call the ToString() Method

            Console.WriteLine(carPark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carParkCharge.ToString());
        }
    }
}

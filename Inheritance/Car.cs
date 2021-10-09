using System;

namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being initalized. {0}.", registrationNumber);
        }
    }
}

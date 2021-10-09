namespace Inheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
      //  {
       //     System.Console.WriteLine("Vehicle is being initalized");
       // }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            System.Console.WriteLine("Vehicle is being initalized. {0}.", registrationNumber);
        }
    }
}

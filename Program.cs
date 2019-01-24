using System;

namespace p1Bascis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rental Vehicles services!");

            // Declare and use a bool, int, double, char, string, and decimal type.
            var name = " ";
            Console.WriteLine("please enter your name: ");
            name = Console.ReadLine();

            var vehicleType = " ";
            Console.WriteLine("please enter type of vehicle you want from the following list: \n 1.sedan \n 2.SUV \n 3.Truck \n 4.Van");
            vehicleType = Console.ReadLine();

            var days = 0;
            Console.WriteLine("How many days do you want to rent a vehicle: ");
            var x = Console.ReadLine();
            days = Convert.ToInt32(x);

            var price = 0.0m;
            var roundTrip = false;
            var vehiclePrice = 0.0m;

            var isroundTrip = ' ';
            Console.WriteLine("If you are going for a round trip, for Yes please press y or for No please press n ?");
            var y = Console.ReadLine();
            isroundTrip = Convert.ToChar(y);
            
            if (isroundTrip == 'y'){
                roundTrip = true;
            }
            else{
                roundTrip = false;
            }
            
            
        }
        
    }
    
}

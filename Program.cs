using System;

namespace p1Bascis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rental Vehicles services!");
            Console.WriteLine("\n");
         while(true) {
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
            Console.WriteLine("If you are going for a round trip please press y for yes and press n for No?");
            var y = Console.ReadLine();
            isroundTrip = Convert.ToChar(y);
            
            if (isroundTrip == 'y'){
                roundTrip = true;
            }
            else{
                roundTrip = false;
            }
            
            // findTotalPrice Function to find the the toal proce of the trip.
            decimal findTotalPrice(int daysIn, decimal priceIn){
                var totalPrice = 0.0m;
                totalPrice = daysIn*priceIn;
                return totalPrice;
            }

             // A Switch statement based on vehicle type.
            switch(vehicleType) {
                
                case "sedan": 
                case"Sedan": price = 30.5m;
                                                 
                             if(roundTrip){
                               vehiclePrice = 2*findTotalPrice(days,price);
                             }
                             else{
                                 vehiclePrice = findTotalPrice(days,price);
                             }
                             break;
                case "SUV": 
                case "suv": price = 45.5m;
                           
                             if(roundTrip){
                               vehiclePrice = 2*findTotalPrice(days,price);
                             }
                             else{
                                 vehiclePrice = findTotalPrice(days,price);
                             }
                             break;
                case "Truck": 
                case "truck": price = 80.4m;
                              
                             if(roundTrip){
                               vehiclePrice = 2*findTotalPrice(days,price);
                             }
                             else{
                                 vehiclePrice = findTotalPrice(days,price);
                             }
                             break;
                case "Van": 
                case "van": price = 55.5m;
                            
                             if(roundTrip){
                               vehiclePrice = 2*findTotalPrice(days,price);
                             }
                             else{
                                 vehiclePrice = findTotalPrice(days,price);
                             }
                             break;                          
            }
            // Interpolation statement to display the total price.
            Console.WriteLine("\n");
            Console.WriteLine("Your Trip Details");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Your Name: {name}");
            Console.WriteLine($"Your Trip will be {days} Days");
            Console.WriteLine($"The Total Rental price for your selected {vehicleType} is {vehiclePrice}");
            Console.WriteLine("\n");
            var quit = ' ';
            Console.WriteLine("Enter q to quit the console");
            var q = Console.ReadLine();
            quit = Convert.ToChar(q);
            
            if(quit == 'q'){
                break;
            }
         }
        
        }
        
    }
    
}

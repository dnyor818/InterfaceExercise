using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */
            Car myFirstCar = new Car { HasTrunk = true, Make = "Acura", Model = "TSX", Year = "2009", HasNosKit = true, ColorScheme ="Blue and Black", Logo = "Acura 'A'" };
            Truck myFirstTruck = new Truck { HasBed = true, Make = "Nissan", Model = "SV6", Year = "1985", HasLiftKit = false, ColorScheme = "Red", Logo = "Nissan Logo" };
            SUV myFirstSuv = new SUV { HasTrunk = true, Make = "Chevrolet", Model = "Yukon", Year = "2010", ColorScheme = "Yellow", Logo = "Yellow Chevy Logo" };
            
            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(myFirstCar);
            vehicles.Add(myFirstTruck);
            vehicles.Add(myFirstSuv);



            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year :{vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model} Logo: {vehicle.Logo} CholorScheme: {vehicle.ColorScheme}");
                vehicle.Drive();
            }
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}

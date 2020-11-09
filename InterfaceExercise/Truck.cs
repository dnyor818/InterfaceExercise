using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public string Year { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        public bool HasBed { get; set; }

        public bool HasLiftKit { get; set; }
        public string Logo { get; set; }
        public string ColorScheme { get; set; }
        

        public void Drive()
        {
            Console.WriteLine($"Roll'n in my {GetType().Name}");
        }
    }
}

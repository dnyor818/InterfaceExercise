using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public string Year { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        public bool HasTrunk { get; set; }
        public string Logo { get; set; }
        public string ColorScheme { get; set; }

        public bool HasNosKit { get; set; }
        

        public void Drive()
        {
            Console.WriteLine($"Roll'n in my {GetType().Name}");
        }
    }
}

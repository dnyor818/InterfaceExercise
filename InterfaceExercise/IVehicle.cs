namespace InterfaceExercise
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }
        string Logo { get; set; }
        string ColorScheme { get; set; }

        void Drive();
    }
}
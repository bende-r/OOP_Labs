namespace Carslib
{
    public class Automobile : Car
    {
       public string CarBrand { get; set; }
       public int? LoadCapacity { get; set; }
       public int? PassengerCapacity { get; set; }

        public Automobile(string Name, string Type, int Cap, int DateTime, int Milage) : base(DateTime, Milage)
        {
            this.CarBrand = Name;
            if (Type == "Cargo")
            {
                this.LoadCapacity = Cap;
                this.PassengerCapacity = null;
            }
            if (Type == "Passenger")
            {
                this.PassengerCapacity = Cap;
                this.LoadCapacity = null;
            }

            this.ReleaseDate = DateTime;
            this.Mileage = Milage;
        }

        public Automobile(string Name, int PasCap, int LoadCap, int DateTime, int Milage) : base(DateTime, Milage)
        {
            this.CarBrand = Name;
            this.LoadCapacity = LoadCap;
            this.PassengerCapacity = PasCap;
            this.ReleaseDate = DateTime;
            this.Mileage = Milage;
        }
    }
}

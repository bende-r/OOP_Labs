using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carslib
{
    public abstract class Car
    {
        public int ReleaseDate { get; set; }
        public int Mileage { get; set; } //пробег 
        public Car(int dateTime, int mileage)
        {
            ReleaseDate = dateTime;
            Mileage = mileage;
        }
    }
}

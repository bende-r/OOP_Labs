using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carslib;

namespace AutomobileProg
{
    internal class Automobiles
    {
        static void Main(string[] args)
        {
            List<Automobile> list = new List<Automobile>();

            Automobile Ford_Transit = new Automobile("FordTransit", 3, 4000, 2009, 130000);
            Automobile Gaz = new Automobile("Газель", "Passanger", 9, 2010, 13000);
            Automobile Mersedes_w220 = new Automobile("Mersedes W220", "Passanger", 4, 2004, 200000);
            Automobile MAZ = new Automobile("МАЗ", "Cargo", 10000, 2022, 1300);
            Automobile Liaz = new Automobile("ЛИАЗ", "Passanger", 30, 1980, 400000);
            Automobile Gaz_1 = new Automobile("Газель", "Cargo", 5000, 2011, 230000);
            Automobile BMW_E36 = new Automobile("BMW E36", "Passanger", 4, 1999, 134050);
            Automobile Scania = new Automobile("SCANIA", "Cargo", 20000, 2013, 150200);
            Automobile MAN = new Automobile("MAN", "Cargo", 30000, 2016, 56000);
            Automobile Iveco = new Automobile("Iveco", "Cargo", 9000, 2014, 34350);

            list.Add(Ford_Transit);
            list.Add(Gaz);
            list.Add(MAZ);
            list.Add(Liaz);
            list.Add(BMW_E36);
            list.Add(Scania);
            list.Add(Iveco);
            list.Add(Gaz_1);
            list.Add(MAN);
            list.Add(Mersedes_w220);

            double AvaragePasCap=0;
            double AvarageCargoCap=0;
            double AvarageCargoMileage = 0;
            double AvarageCargoPasMileage = 0;
            int ACMC=0;
            int ACPMC=0;


            foreach (var item in list)
                if(item.PassengerCapacity!=null)
                AvaragePasCap += (double)item.PassengerCapacity;

            AvaragePasCap = AvaragePasCap / list.Count;

            foreach (var item in list)
                if(item.LoadCapacity!=null)
                AvarageCargoCap += (double)item.LoadCapacity;

            AvarageCargoCap = AvarageCargoCap / list.Count;



            foreach (var item in list)
                if (item.LoadCapacity != null)
                {
                    AvarageCargoMileage += (double)item.Mileage;
                    ACMC++;
                }

            AvarageCargoMileage /= ACMC;

            foreach (var item in list)
                if (item.LoadCapacity != null)
                {
                    AvarageCargoMileage += (double)item.Mileage;
                    ACMC++;
                }

            AvarageCargoMileage /= ACMC;

            foreach (var item in list)
                if (item.LoadCapacity != null && item.PassengerCapacity!=null)
                {
                    AvarageCargoPasMileage += (double)item.Mileage;
                    ACPMC++;
                }

            AvarageCargoPasMileage /= ACPMC;

            Console.WriteLine($"средняя пассажироёмкость {AvaragePasCap} \n " +
                $"средняя грузоподъёмность {AvarageCargoCap} \n" +
                $" средний пробег по всем грузовым автомобилям {AvarageCargoMileage} \n " +
                $"средний пробег по грузопассажирским автомобилям {AvarageCargoPasMileage}"  );

            Console.ReadKey();
        }
    }
}

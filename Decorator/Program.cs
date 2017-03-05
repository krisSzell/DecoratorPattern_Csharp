using Decorator.Car_Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar baseCar = new BaseCar();

            // Show how specific features of car are
            showCarStats(baseCar);

            // decorate baseCar with RaceCar and see how car chages
            ICar raceCar = new RaceCar(baseCar);
            showCarStats(raceCar);

            // decorate our car yet again, this time with RustyCar and see changes
            ICar yetSomeOtherCar = new RustyCar(raceCar);
            showCarStats(yetSomeOtherCar);

            // to show flexibility we decorate our first made car with RustyCar to show different 'decorations' work independently
            ICar baseRustyCar = new RustyCar(baseCar);
            showCarStats(baseRustyCar);
        }

        private static void showCarStats(ICar carToShow)
        {
            Console.WriteLine(carToShow.Accelerate());
            Console.WriteLine(carToShow.Turn());
            Console.WriteLine(carToShow.Brake());
            Console.WriteLine();
        }
    }
}

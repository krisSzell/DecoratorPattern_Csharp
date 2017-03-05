using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Car_Decorator
{
    class RaceCar : ICar
    {
        private ICar _decoratedCar;

        public RaceCar(ICar decoratedCar)
        {
            this._decoratedCar = decoratedCar;
        }

        public int Accelerate() => _decoratedCar.Accelerate() + 50;

        public int Turn() => _decoratedCar.Turn() + 50;

        public int Brake() => _decoratedCar.Brake() + 50;
    }
}

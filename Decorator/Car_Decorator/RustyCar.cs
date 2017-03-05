using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Car_Decorator
{
    class RustyCar : ICar
    {
        private ICar _decoratedCar;

        public RustyCar(ICar decoratedCar)
        {
            this._decoratedCar = decoratedCar;
        }

        public int Accelerate() => _decoratedCar.Accelerate();

        public int Turn() => _decoratedCar.Turn() - 20;

        public int Brake() => _decoratedCar.Brake() -80;

    }
}

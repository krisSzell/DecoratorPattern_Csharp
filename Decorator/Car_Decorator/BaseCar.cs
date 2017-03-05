using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Car_Decorator
{
    class BaseCar : ICar
    {
        public int Accelerate()
        {
            return 100;
        }

        public int Brake()
        {
            return 100;
        }

        public int Turn()
        {
            return 100;
        }
    }
}

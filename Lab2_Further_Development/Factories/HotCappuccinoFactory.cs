using Lab2_Further_Development.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Further_Development.Factories
{
    class HotCappuccinoFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot cappuccino in your cup");
            return new Cappuccino();
        }
    }
}

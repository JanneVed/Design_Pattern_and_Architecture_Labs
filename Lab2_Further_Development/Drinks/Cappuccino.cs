using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Further_Development.Drinks
{
    class Cappuccino : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Warm Cappuccino is served");
        }
    }
}

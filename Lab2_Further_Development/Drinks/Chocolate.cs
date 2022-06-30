using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Further_Development.Drinks
{
    class Chocolate : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Warm Chocolate is served");
        }
    }
}

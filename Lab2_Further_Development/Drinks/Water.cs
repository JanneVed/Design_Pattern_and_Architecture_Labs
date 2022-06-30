using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Further_Development
{
    class Water : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Warm Water is served");
        }
    }
}

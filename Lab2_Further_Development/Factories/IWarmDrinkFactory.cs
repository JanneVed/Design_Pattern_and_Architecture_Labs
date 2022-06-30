using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Further_Development
{
    public interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(int total);
    }
}

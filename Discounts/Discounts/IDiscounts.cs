using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public interface IDiscounts
    {
        double Discount { get; }
        double ChosenDiscount { get; }
    }
}

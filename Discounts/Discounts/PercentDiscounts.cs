using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public class PercentDiscounts : IDiscounts
    {
        public double _costOfGoods;
        public double _chosenDiscount;
        private double _summa;

 
        public PercentDiscounts(double _costOfGoods, double _chosenDiscount)
        {
            if (_chosenDiscount < 0 || _chosenDiscount > 1)
                throw new ArgumentException("Должно быть от 0 до 1", "_chosenDiscount");
            this._chosenDiscount = _chosenDiscount;
            this._costOfGoods = _costOfGoods;
            _summa = _costOfGoods - _costOfGoods * _chosenDiscount;
        }

       public double Discount
        {
            get
                { return _summa; }
            
        }
        public double ChosenDiscount
        {
            get
            { return _chosenDiscount; }
        }
    }
}

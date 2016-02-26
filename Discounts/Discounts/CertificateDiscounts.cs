using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public class CertificateDiscounts : IDiscounts
    {
        private double _costOfGoods;
        public double _chosenDiscount;
        public double summa;

       

        public CertificateDiscounts(double _costOfGoods, double _chosenDiscount)
        {
          
            if (_chosenDiscount < 0)
                throw new ArgumentException("Должно быть больше нуля", "_chosenDiscount");

            this._chosenDiscount = _chosenDiscount;
            this._costOfGoods = _costOfGoods;
            if ((_costOfGoods - _chosenDiscount) < 0)
            {
                _costOfGoods = 0;
            }
            else
            {
                summa = _costOfGoods - _chosenDiscount;
            }
        }

        public double Discount
        {

            get
            {
                return summa;
            }
                
        }

        public double ChosenDiscount
        {
            get
            {
                return _chosenDiscount;
            }
        }
       
    }
}


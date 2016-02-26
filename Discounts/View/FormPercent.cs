using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discounts;

namespace View
{
    public partial class FormPercent : Form
    {
        public FormPercent()
        {
            InitializeComponent();
            chooseBox1.SelectedIndex = 0;
        }
        public List<IDiscounts> DiscountList { get; set; }
        private void textBoxPrice1_Validadating(object sender, EventArgs e)
        {
            try
            {
                double doubleValue=0;
                if (double.TryParse(textBoxPrice1.Text, out doubleValue)) throw new Exeption("Цена должна быть задана числом!");
                if (doubleValue <= 0) throw new Exeption("Цена должна быть больше нуля.");
            }
            catch (Exeption exFCircle)
            {
                Console.WriteLine("{0} Exception caught.", exFCircle);
            }

        }
       
        private void textBoxPrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    if (e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double _discount = 0;
            switch (Convert.ToInt32(chooseBox1.SelectedIndex))
            {
                case 0:
                    _discount = 0.05;
                    break;
                case 1:
                    _discount = 0.2;
                    break;
                case 2:
                    _discount = 0.5;
                    break;
            }
            double doubleValue = Convert.ToDouble(textBoxPrice1.Text.Replace(".", ","));
             PercentDiscounts percent = new PercentDiscounts(doubleValue, _discount);
            //IDiscounts Percent = new PercentDiscounts(doubleValue, _discount);
            //Result.Text = Percent.Discount().ToString() + " д.е.";
             DiscountList.Add(percent);
             Close();

        }

      
    }
}

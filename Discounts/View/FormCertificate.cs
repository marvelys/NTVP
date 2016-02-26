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
    public partial class FormCertificate : Form
    {
        public FormCertificate()
        {
            InitializeComponent();
            chooseBox2.SelectedIndex = 0;
        }
        public List<IDiscounts> DiscountList { get; set; }
        private void textBoxPrice_Validadating(object sender, EventArgs e)
        {
            try
            {
                double doubleValue=0;
                if (double.TryParse(textBoxPrice.Text, out doubleValue)) throw new Exeption("Цена должна быть задана числом!");
                if (doubleValue <= 0) throw new Exeption("Цена должна быть больше нуля.");
            }
            catch (Exeption exFCircle)
            {
                Console.WriteLine("{0} Exception caught.", exFCircle);
            }

        }
        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double _discount = 0;
            switch (Convert.ToInt32(chooseBox2.SelectedIndex))
            {
                case 0:
                    _discount = 1000;
                    break;
                case 1:
                    _discount = 2000;
                    break;
                case 2:
                    _discount = 5000;
                    break;
            }
            double doubleValue = Convert.ToDouble(textBoxPrice.Text.Replace(".", ","));
            CertificateDiscounts percent = new CertificateDiscounts(doubleValue, _discount);
            DiscountList.Add(percent);
            Close();
        }

        
    }
}

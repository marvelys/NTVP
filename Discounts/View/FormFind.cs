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
    public partial class FormFind : Form
    {
        public FormFind()
        {
            InitializeComponent();
        }
        public List<IDiscounts> DiscountList { get; set; }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            double findDiscount = 0;
            if (textBoxPrice.Text !="")
            {
                findDiscount = Convert.ToDouble(textBoxPrice.Text.Replace(".", ","));
            }
            if (DiscountList != null)
            {
                if (checkBoxPercent.Checked||checkBoxCertificate.Checked)
                {
                    foreach(var item in DiscountList)
                    {
                        if ((item is PercentDiscounts) && (checkBoxPercent.Checked))
                        {
                            if ((item.Discount==findDiscount)|| (textBoxPrice.Text == ""))
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView1);
                                row.Cells[0].Value = "Процентная";
                                row.Cells[1].Value = item.ChosenDiscount;
                                row.Cells[2].Value = item.Discount;
                                dataGridView1.Rows.Add(row);
                            }
                        }
                        if ((item is CertificateDiscounts) && (checkBoxCertificate.Checked))
                        {
                            if ((item.Discount == findDiscount) || (textBoxPrice.Text == ""))
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView1);
                                row.Cells[0].Value = "Сертификатная";
                                row.Cells[1].Value = item.ChosenDiscount;
                                row.Cells[2].Value = item.Discount;
                                dataGridView1.Rows.Add(row);
                            }
                        }
                    }

                }
            }
        }
    }
}

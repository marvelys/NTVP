using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discounts;
using System.Runtime.Serialization.Formatters.Binary;

namespace View
{
    public partial class FormDiscounts : Form
    {
        public List<IDiscounts> Discount = new List<IDiscounts>();
        public FormDiscounts()
        {
            InitializeComponent();
        }

        private void percent_Click(object sender, EventArgs e)
        {
            FormPercent addDiscount = new FormPercent();
            addDiscount.DiscountList = Discount;
            addDiscount.ShowDialog();
        }

        private void sertificate_Click(object sender, EventArgs e)
        {
            FormCertificate addDiscount = new FormCertificate();
            addDiscount.DiscountList = Discount;
            addDiscount.ShowDialog();
        }
        private void FormDiscounts_Activated(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < Discount.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);
                if (Discount[i] is PercentDiscounts) { row.Cells[0].Value = "Процентная "; }
                if (Discount[i] is CertificateDiscounts) { row.Cells[0].Value = "Сертификаты"; }
                row.Cells[1].Value = Discount[i].ChosenDiscount;
                row.Cells[2].Value = Discount[i].Discount;               
                dataGridView.Rows.Add(row);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                Discount.RemoveAt(row.Index);
            }
            UpdateDataGridView();

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FormFind addDiscount = new FormFind();
            addDiscount.DiscountList = Discount;
            addDiscount.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Discount.Count != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = "acalc";
                saveFileDialog.Filter = "Калькулятор (*.acalc)|*.acalc";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (saveFileDialog.FileName != "")
                        {
                            FileStream stream = (FileStream)saveFileDialog.OpenFile();
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            binaryFormatter.Serialize(stream, Discount);
                            stream.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: Не удалось сохранить файл на диск. Original error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Список пуст.");
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Калькулятор (*.acalc)|*.acalc";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream stream = null;
                    if ((stream = (FileStream)openFileDialog.OpenFile()) != null)
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        Discount = (List<IDiscounts>)binaryFormatter.Deserialize(stream);
                        stream.Close();
                        UpdateDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: Не удалось открыть файл с диска. Original error: " + ex.Message);
                }
            }
        }
    }
}
        


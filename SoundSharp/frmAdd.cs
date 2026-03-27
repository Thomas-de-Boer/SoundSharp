using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SoundSharp
{
    public partial class frmAdd : Form

    {
        public SmartPhone CurrentPhone { get; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Storage { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public frmAdd(SmartPhone current_phone)
        {
            CurrentPhone = current_phone;
            InitializeComponent();
            //Console.WriteLine(current_phone.ToString());
        }
        private void frmAdd_Load(object sender, EventArgs e)
        {
            if (CurrentPhone.Id != -10)
            {
                tbxBrand.Text = CurrentPhone.Brand;
                tbxModel.Text = CurrentPhone.Model;
                tbxSize.Text = CurrentPhone.Storage.ToString();
                tbxPrice.Text = CurrentPhone.Price.ToString();
                nudStock.Value = CurrentPhone.Stock;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Brand = tbxBrand.Text;
                Model = tbxModel.Text;
                Storage = decimal.Parse(tbxSize.Text);
                Price = decimal.Parse(tbxPrice.Text);
                Stock = int.Parse(nudStock.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid values for all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(Brand) ||
                string.IsNullOrWhiteSpace(Model))
            {
                MessageBox.Show("Please enter valid values for all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxBrand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

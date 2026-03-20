using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundSharp
{
    public partial class frmAdd : Form
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Storage { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public frmAdd()
        {
            InitializeComponent();
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
    }
}

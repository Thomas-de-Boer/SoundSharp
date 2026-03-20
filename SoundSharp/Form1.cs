using System.Diagnostics;

namespace SoundSharp
{
    public partial class frmMain : Form
    {
        public SmartPhoneJsonStore jsonStore = new SmartPhoneJsonStore();

        public void RefreshStockList()
        {
            lstStock.Items.Clear();

            foreach (var phone in jsonStore.data.phones)
            {
                lstStock.Items.Add(phone);
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            jsonStore.Load();

            RefreshStockList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmAdd = new frmAdd();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                var addForm = (frmAdd)frmAdd;
                SmartPhone newPhone = new SmartPhone(
                    jsonStore.data.phones.Count + 1,
                    addForm.Brand,
                    addForm.Model,
                    addForm.Storage,
                    addForm.Price,
                    addForm.Stock
                );
                jsonStore.data.phones.Add(newPhone);
                jsonStore.Save();
            }

            RefreshStockList();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            SmartPhone phone = new SmartPhone(1, "Samsung", "S25", 512000, 1079.00m, 25);
            jsonStore.data.phones.Add(phone);
            jsonStore.Save();
        }
    }
}
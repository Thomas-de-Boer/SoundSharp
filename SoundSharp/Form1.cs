using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SoundSharp
{
    public partial class frmMain : Form
    {
        public SmartPhoneJsonStore jsonStore { get; set; }
        public frmMain(SmartPhoneJsonStore json_store)
        {
            jsonStore = json_store;
            InitializeComponent();
        }
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
            RefreshStockList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SmartPhone empty_phone = new SmartPhone(-10, "very empty", "very very empty", 1, 2, 3);
            Form frmAdd = new frmAdd(empty_phone);
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
            SmartPhone TempStorage;
            try
            {
                TempStorage = jsonStore.data.phones[lstStock.SelectedIndex];
                jsonStore.data.phones.RemoveAt(lstStock.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a phone to edit.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Form frmAdd = new frmAdd(TempStorage);
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                var addForm = (frmAdd)frmAdd;
                SmartPhone newPhone = new SmartPhone(
                lstStock.SelectedIndex + 1,
                addForm.Brand,
                addForm.Model,
                addForm.Storage,
                addForm.Price,
                addForm.Stock
            );
                jsonStore.data.phones.Insert(lstStock.SelectedIndex, newPhone);
                jsonStore.Save();
            }
            else
            {
                jsonStore.data.phones.Insert(lstStock.SelectedIndex, TempStorage);
                jsonStore.Save();
            }

            RefreshStockList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            jsonStore.data.phones.RemoveAt(lstStock.SelectedIndex);
            foreach (SmartPhone phone in jsonStore.data.phones)
            {
                if (phone.Id > lstStock.SelectedIndex + 1) { phone.Id -= 1; }
            }
            RefreshStockList();
            jsonStore.Save();
        }
    }
}
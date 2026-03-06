namespace SoundSharp
{
    public partial class frmMain : Form
    {
        public List<SmartPhone> Phones = new List<SmartPhone>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmAddEdit = new frmAddEdit();
            frmAddEdit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit knoppie!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}

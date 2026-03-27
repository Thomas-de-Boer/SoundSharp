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
    public partial class frmLogin : Form
    {
        public SmartPhoneJsonStore jsonStore = new SmartPhoneJsonStore();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            jsonStore.Load();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserAccount user = jsonStore.data.users.FirstOrDefault(u => u.Username == tbxUsername.Text);
            if (user == null)
            {
                lblError.Text = "Invalid username or password.";
                return;
            }

            if (user.IsLocked)
            {
                lblError.Text = "Account is locked, please contact support. +31 06 38486025";
                return;
            }

            if (user.Password == tbxPassword.Text)
            {
                user.FailedLoginAttempts = 0;
                jsonStore.Save();
                frmMain frmMain = new frmMain(jsonStore);
                this.Hide();
                frmMain.ShowDialog();
                this.Close();
                return;
            }

            user.FailedLoginAttempts++;
            if (user.FailedLoginAttempts >= 3)
            {
                user.IsLocked = true;
                lblError.Text = "Account locked due to too many failed login attempts.";
            }
            else
            {
                lblError.Text = $"Invalid password. {3 - user.FailedLoginAttempts} attempts remaining.";
            }
            jsonStore.Save();
        }
    }
}
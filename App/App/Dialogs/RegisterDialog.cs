using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Dialogs
{
    public partial class RegisterDialog : Form
    {
        private bool kompl;
        public RegisterDialog(bool kompl, string email)
        {
            InitializeComponent();
            this.kompl = kompl;
            if (this.kompl)
            {
                tbKompEmail.Text = email;
                tbKompEmail.Enabled = false;
                panel2.Show();
                panel1.Hide();
            }
            else
            {
                tbEmail.Text = email;
                tbEmail.Enabled = false;
                panel1.Show();
                panel2.Hide();
            }
        }



        private void komplRegBtn_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

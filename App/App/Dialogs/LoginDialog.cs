using App.Model;
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
    public partial class LoginDialog : Form
    {
        public User user;
        public LoginDialog(bool login)
        {
            InitializeComponent();
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void buttonZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

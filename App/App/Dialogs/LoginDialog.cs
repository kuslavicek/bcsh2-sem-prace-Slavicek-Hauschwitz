using App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App.Dialogs
{
    public partial class LoginDialog : Form
    {
        public User user;
        private Database _database;
        public LoginDialog(bool login)
        {
            InitializeComponent();
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                var parameters = new Dictionary<string, object>
            {
                { "username", tbName.Text },
                { "password", tbPass.Text }
            };

                var result = _database.ExecuteFunction("login", parameters);
                user = User.ParseUser(result);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Přihlášení se nezdařilo");
            }

            
        }

        private void buttonZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

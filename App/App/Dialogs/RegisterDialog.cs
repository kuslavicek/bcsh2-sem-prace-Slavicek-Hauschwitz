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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App.Dialogs
{
    public partial class RegisterDialog : Form
    {
        private bool kompl;
        public User user;
        private Database _database;
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
            try
            {
                if (tbKompPass.Text != tbKompPassRepeat.Text)
                {
                    MessageBox.Show("Hesla nejsou stejná");
                    return;
                }
                var parameters = new Dictionary<string, object>
                {
                    { "jmeno", tbJmeno.Text },
                    { "prijmeni", tbPrijmeni.Text },
                    { "username", tbKompUsername.Text },
                    { "email", tbKompEmail.Text},
                    { "password", tbKompPass.Text },
                    { "telefon", int.Parse(tbTelefon.Text) },
                    { "provozovna", int.Parse(cbProv.SelectedItem.ToString())}
                };

                var result = _database.ExecuteFunction("complete_registration", parameters);

                user = User.ParseUser(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Přihlášení se nezdařilo");
            }
        }


        private void regBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbPass.Text != tbPassRepeat.Text)
                {
                    MessageBox.Show("Hesla nejsou stejná");
                    return;
                }

                var parameters = new Dictionary<string, object>
                {
                    { "username", tbUsername.Text },
                    { "password", tbPass.Text },
                    { "email", tbEmail.Text }
                };

                var result = _database.ExecuteFunction("quick_registration", parameters);


                user = User.ParseUser(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Přihlášení se nezdařilo");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

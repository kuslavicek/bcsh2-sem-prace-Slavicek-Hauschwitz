using App.Model;
using App.Repositories;
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
        private ProvozovnaRepo _provozovnaRepo { get; set; }
        public RegisterDialog(bool kompl, string email)
        {
            InitializeComponent();
            _provozovnaRepo = new ProvozovnaRepo();
            var provozovnyDict = _provozovnaRepo.GetProvozovnyEnum();

            cbProv.DataSource = new BindingSource(provozovnyDict, null);
            cbProv.DisplayMember = "nazev";
            cbProv.ValueMember = "value";
            cbProv.SelectedIndex = 0;


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

                object result = _database.ExecuteCompleteRegistration(tbJmeno.Text, tbPrijmeni.Text, tbKompUsername.Text, tbKompEmail.Text, tbKompPass.Text, int.Parse(tbTelefon.Text), ((KeyValuePair<int, string>)cbProv.SelectedItem).Key);

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

                

                object result = _database.ExecuteQuickRegistration(tbUsername.Text, tbPass.Text, tbEmail.Text);


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

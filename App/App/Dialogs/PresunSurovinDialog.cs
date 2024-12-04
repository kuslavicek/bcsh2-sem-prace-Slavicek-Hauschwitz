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

namespace App.Dialogs
{
    public partial class PresunSurovinDialog : Form
    {
        private SurovinaRepo surovinaRepo = new SurovinaRepo();
        private SkladRepo skladRepo = new SkladRepo();
        private Database _database = new Database();
        public PresunSurovinDialog()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            var sklady = skladRepo.GetSklady();
            var suroviny = surovinaRepo.Load();

            cbSkladZdroj.DataSource = sklady;
            cbSkladZdroj.DisplayMember = "Nazev";
            cbSkladZdroj.ValueMember = "Id";
            cbSkladZdroj.SelectedIndex = 0;

            cbSkladCil.DataSource = sklady;
            cbSkladCil.DisplayMember = "Nazev";
            cbSkladCil.ValueMember = "Id";
            cbSkladCil.SelectedIndex = 0;

            cbSurovina.DataSource = suroviny;
            cbSurovina.DisplayMember = "Nazev";
            cbSurovina.ValueMember = "Id";
            cbSurovina.SelectedIndex = 0;
        }

        private void PresunBtn_Click(object sender, EventArgs e)
        {
            var idSurovina = (int)cbSurovina.SelectedValue;
            var idSkladZ = (int)cbSkladZdroj.SelectedValue;
            var idSkladDo = (int)cbSkladCil.SelectedValue;
            var mnozstvi = (double)numMnozstvi.Value;

            try
            {
                var parameters = new Dictionary<string, object>
{
{ "p_id_surovina", idSurovina },
{ "p_id_sklad_z", idSkladZ },
{ "p_id_sklad_do", idSkladDo },
{ "p_mnozstvi", mnozstvi }
};

                _database.ExecuteProcedure("other_pkg.presun_surovin", parameters);
                MessageBox.Show("Přesun byl úspěšně dokončen.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba: " + ex.Message);
            }
         
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}

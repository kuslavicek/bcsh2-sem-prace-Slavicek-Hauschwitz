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

namespace App.Dialogs.SkladDialogs
{
    public partial class SkladMigraceDialog : Form
    {
        private SkladRepo _skladRepo { get; set; }
        public SkladMigraceDialog(SkladRepo repo)
        {
            InitializeComponent();
            this._skladRepo = repo;
            this.fill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkZbozi.Checked || checkSuroviny.Checked)
            {
                if (((KeyValuePair<int, string>)comboZ.SelectedItem).Key != ((KeyValuePair<int, string>)comboDo.SelectedItem).Key)
                {
                    _skladRepo.Migrate(((KeyValuePair<int, string>)comboZ.SelectedItem).Key, ((KeyValuePair<int, string>)comboDo.SelectedItem).Key, checkSuroviny.Checked==true?1:0,checkZbozi.Checked==true?1:0);
                    MessageBox.Show("Migrace proběhla v pořádku");
                }
                else {
                    MessageBox.Show("Nelze migrovat do stejnýho skladu.");
                }
            }
            else {
                MessageBox.Show("Není vybraná entita pro migraci.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fill() {
            var skladyDict = _skladRepo.LoadSkladyForSelect();
            comboZ.DataSource = new BindingSource(skladyDict, null);
            comboZ.DisplayMember = "Value";
            comboZ.ValueMember = "Key";

            comboDo.DataSource = new BindingSource(skladyDict, null);
            comboDo.DisplayMember = "Value";
            comboDo.ValueMember = "Key";
        }
    }
}

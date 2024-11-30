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
    public partial class AdresaUseDialog : Form
    {
        private AdresaRepo _adresaRepo { get; set; }
        private int id { get; set; }
        public AdresaUseDialog(AdresaRepo repo,int id)
        {
            this._adresaRepo = repo;
            this.id = id;
            InitializeComponent();
            this.fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fill()
        {
            lvUsed.Columns.Clear();
            lvUsed.View = View.Details;
            lvUsed.FullRowSelect = true;
            lvUsed.Columns.Add("Entitiy", 750);
            var list = this._adresaRepo.LoadAdresaEntities(id);

            lvUsed.Items.Clear();

            foreach (var item in list)
            {
                lvUsed.Items.Add(item);
            }
        }

    }
}

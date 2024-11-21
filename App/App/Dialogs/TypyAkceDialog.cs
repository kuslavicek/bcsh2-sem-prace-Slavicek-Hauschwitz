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
    public partial class TypyAkceDialog : Form
    {
        private bool IsEditMode { get; set; }
        private TypAkce Typ { get; set; }
        private TypAkceRepo _typAkceRepo { get; set; }
        public TypyAkceDialog(TypAkceRepo repo,TypAkce typ,bool edit)
        {
            InitializeComponent();
            this.IsEditMode = edit;
            this.Typ = typ!=null?typ:new TypAkce(); 
            this._typAkceRepo = repo;
            this.fill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtNazev.Text != "") {
                this.Typ.Nazev = this.txtNazev.Text;
                this._typAkceRepo.UpdateTypAkce(this.Typ);
            }
            MessageBox.Show("Typ akce byl uložen");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fill() {
            if (this.IsEditMode) {
                this.txtNazev.Text=Typ.Nazev;
            }
        }
    }
}

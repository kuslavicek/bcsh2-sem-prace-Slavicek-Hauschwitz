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
using System.Windows.Forms.VisualStyles;

namespace App.Dialogs
{
    public partial class SkladDialog : Form
    {
        private SkladRepo _skladRepo { get; set; }
        private Sklad Sklad { get; set; }
        private bool IsEditMode { get; set; }
        public SkladDialog(SkladRepo repo, Sklad sklad, bool edit)
        {
            InitializeComponent();
            this._skladRepo = repo; this.Sklad = sklad; this.IsEditMode = edit;
            this.fill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEditMode)
                {
                    this.Sklad.Nazev = txtNazev.Text;
                    this.Sklad.UzitnaPlocha = double.Parse(txtPlocha.Text);
                    this.Sklad.Adresa.Mesto = txtMesto.Text;
                    this.Sklad.Adresa.Ulice = txtUlice.Text;
                    this.Sklad.Adresa.CisloPopisne = int.Parse(txtCisloPopisne.Text);
                    this.Sklad.Adresa.Psc = int.Parse(txtPsc.Text);
                    this.Sklad.Adresa.Stat = txtStat.Text;

                    _skladRepo.UpdateSklad(this.Sklad);
                    MessageBox.Show("Sklad byl úspěšně aktualizován.");
                }
                else
                {
                    var adresa = new Adresa
                    (
                        null,
                        txtMesto.Text,
                        txtUlice.Text,
                        int.Parse(txtCisloPopisne.Text),
                        int.Parse(txtPsc.Text),
                        txtStat.Text
                    );

                    var sklad = new Sklad
                    {
                        Nazev=txtNazev.Text,
                        UzitnaPlocha=double.Parse(txtPlocha.Text),
                        Adresa=adresa,
                    };
                    _skladRepo.UpdateSklad(sklad);
                    MessageBox.Show("Sklad byl úspěšně přidán.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při ukládání: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fill() {
            if (this.IsEditMode) {
                txtNazev.Text=this.Sklad.Nazev;
                txtPlocha.Text=this.Sklad.UzitnaPlocha.ToString();
                txtUlice.Text = this.Sklad.Adresa.Ulice;
                this.txtMesto.Text=this.Sklad.Adresa.Mesto;
                txtPsc.Text = this.Sklad.Adresa.Psc.ToString();
                txtCisloPopisne.Text = this.Sklad.Adresa.CisloPopisne.ToString();
                txtStat.Text=this.Sklad.Adresa.Stat.ToString();
            }
        }
    }
}

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
    public partial class ProvozovnaDialog : Form
    {
        private bool IsEditMode { get; set; }
        private Provozovna Provozovna { get; set; }
        private ProvozovnaRepo _provozovnaRepo { get; set; }
        public ProvozovnaDialog(ProvozovnaRepo repo,Provozovna provozovna, bool isEditMode=false)
        {
            InitializeComponent();
            this._provozovnaRepo =repo;
            this.IsEditMode = isEditMode;
            this.Provozovna = provozovna;

            this.fill();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNazev.Text) || string.IsNullOrEmpty(textBoxNazev.Text))
            {
                MessageBox.Show("Prosím, vyplňte všechny údaje.");
                return;
            }

            try
            {
                if (IsEditMode)
                {
                    this.Provozovna.Nazev = textBoxNazev.Text;
                    this.Provozovna.Adresa.Mesto = textBoxMesto.Text;
                    this.Provozovna.Adresa.Ulice = textBoxUlice.Text;
                    this.Provozovna.Adresa.CisloPopisne = int.Parse(textBoxCisloPopisne.Text);
                    this.Provozovna.Adresa.Psc = int.Parse(textBoxPsc.Text);
                    this.Provozovna.Adresa.Stat = textBoxStat.Text;
                    _provozovnaRepo.UpdateProvozovna(this.Provozovna);
                    MessageBox.Show("Provozovna byla úspěšně aktualizována.");
                }
                else
                {
                    var adresa = new Adresa
                    (
                        null,
                        textBoxMesto.Text,
                        textBoxUlice.Text,
                        int.Parse(textBoxCisloPopisne.Text),
                        int.Parse(textBoxPsc.Text),
                        textBoxStat.Text
                    );

                    var provozovna = new Provozovna
                    {
                        Nazev = textBoxNazev.Text.ToString(),
                        PocetZamestnancu = Convert.ToInt32(textBoxPocet.Text),
                        Adresa=adresa,
                    };

                    _provozovnaRepo.UpdateProvozovna(provozovna);
                    MessageBox.Show("Provozovna byla úspěšně přidána.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při ukládání: " + ex.Message);
            }
        }

        private void fill() {
            if (this.IsEditMode)
            {
                this.textBoxNazev.Text = this.Provozovna.Nazev;
                this.textBoxPocet.Text = this.Provozovna.PocetZamestnancu.ToString();
                this.textBoxUlice.Text = this.Provozovna.Adresa.Ulice;
                this.textBoxStat.Text = this.Provozovna.Adresa.Stat;
                this.textBoxPsc.Text = this.Provozovna.Adresa.Psc.ToString();
                this.textBoxMesto.Text = this.Provozovna.Adresa.Mesto;
                this.textBoxCisloPopisne.Text = this.Provozovna.Adresa.CisloPopisne.ToString();
            }
            else {
                this.textBoxPocet.Text = "0";
            }
        }
    }
}

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
    public partial class ZakaznikDialog : Form
    {
        private ZakaznikRepo _zakaznikRepo;
        public bool IsEditMode { get; set; } = false;
        private Zakaznik zakaznik { get; set; }
        public ZakaznikDialog(ZakaznikRepo zakaznikRepo, Zakaznik zakaznik, bool edit)
        {
            InitializeComponent();
            this.IsEditMode = edit;
            this._zakaznikRepo = zakaznikRepo;
            this.zakaznik = zakaznik;
            this.FillData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxJmeno.Text) || string.IsNullOrEmpty(textBoxTelefon.Text) || string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Prosím, vyplňte všechny údaje.");
                return;
            }

            try
            {
                if (IsEditMode)
                {
                    this.zakaznik.Jmeno = textBoxJmeno.Text;
                    this.zakaznik.Telefon = double.Parse(textBoxTelefon.Text);
                    this.zakaznik.Email = textBoxEmail.Text;
                    this.zakaznik.Adresa.Mesto = textBoxMesto.Text;
                    this.zakaznik.Adresa.Ulice = textBoxUlice.Text;
                    this.zakaznik.Adresa.CisloPopisne = int.Parse(textBoxCisloPopisne.Text);
                    this.zakaznik.Adresa.Psc = int.Parse(textBoxPsc.Text);
                    this.zakaznik.Adresa.Stat = textBoxStat.Text;

                    zakaznik.Id = this.zakaznik.Id;
                    _zakaznikRepo.UpdateZakaznik(zakaznik);
                    MessageBox.Show("Zakaznik byl úspěšně aktualizováa.");
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

                    var zakaznik = new Zakaznik
                    (
                        null,
                        textBoxJmeno.Text,
                        double.Parse(textBoxTelefon.Text),
                        textBoxEmail.Text,
                        adresa
                    );
                    _zakaznikRepo.UpdateZakaznik(zakaznik);
                    MessageBox.Show("Zakaznik byl úspěšně přidán.");
                }
            }
            catch (Exception ex)
            {
                // Chyba při ukládání
                MessageBox.Show("Chyba při ukládání: " + ex.Message);
            }
        }

        // Cancel button click handler
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Close the dialog without saving
            this.Close();
        }

        private void FillData()
        {
            if (this.IsEditMode)
            {
                textBoxJmeno.Text = this.zakaznik.Jmeno;
                textBoxTelefon.Text = this.zakaznik.Telefon.ToString();
                textBoxEmail.Text = this.zakaznik.Email;

                if (this.zakaznik.Adresa != null)
                {
                    textBoxMesto.Text = this.zakaznik.Adresa.Mesto;
                    textBoxUlice.Text = this.zakaznik.Adresa.Ulice;
                    textBoxCisloPopisne.Text = this.zakaznik.Adresa.CisloPopisne.ToString();
                    textBoxPsc.Text = this.zakaznik.Adresa.Psc.ToString();
                    textBoxStat.Text = this.zakaznik.Adresa.Stat;
                }
            }
        }

    }
}

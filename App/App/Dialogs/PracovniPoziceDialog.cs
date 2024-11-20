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
    public partial class PracovniPoziceDialog : Form
    {
        private PracovniPoziceRepo _poziceRepo { get; set; }
        private PracovniPozice Pozice { get; set; }
        private bool IsEditMode { get; set; }
        public PracovniPoziceDialog(PracovniPoziceRepo poziceRepo, PracovniPozice pozice, bool edit)
        {
            InitializeComponent();
            this._poziceRepo = poziceRepo;
            this.Pozice = pozice;
            this.IsEditMode = edit;
            if (this.IsEditMode) { this.fill(); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxPlat.Text == "" || textBoxPlat.Text == "")
            {
                MessageBox.Show("Není vyplněný název nebo plat");
                return;
            }


            var pozice = new PracovniPozice {
                Nazev = textBoxNazev.Text,
                Plat=double.Parse(textBoxPlat.Text)
            };

            try
            {
                if (IsEditMode)
                {
                    pozice.Id = this.Pozice.Id;
                    _poziceRepo.UpdatePozice(pozice);
                    MessageBox.Show("Pozice byla úspěšně aktualizována.");
                }
                else
                {
                    _poziceRepo.UpdatePozice(pozice);
                    MessageBox.Show("Pozica byla úspěšně přidána.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při ukládání: " + ex.Message);
            }
        }

        private void fill() {
            if (IsEditMode) {
                this.textBoxNazev.Text = this.Pozice.Nazev;
                this.textBoxPlat.Text = this.Pozice.Plat.ToString();
            }
        }
    }
}

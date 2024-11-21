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
            if (!InputValidator.IsNotEmpty(textBoxNazev, "Pole 'Název' nesmí být prázdné.")||
                !InputValidator.IsTextOnly(textBoxNazev))
            {
                return;
            }

            if (!InputValidator.IsNotEmpty(textBoxPlat, "Pole 'Plat' nesmí být prázdné.") ||
                !InputValidator.IsNumber(textBoxPlat, "Pole 'Plat' musí obsahovat platné číslo.") ||
                !InputValidator.IsNumberInRange(textBoxPlat, 16000, double.MaxValue, "Pole 'Plat' musí být větší než 16000."))
            {
                return;
            }

            double plat = double.Parse(textBoxPlat.Text);

            var pozice = new PracovniPozice
            {
                Nazev = textBoxNazev.Text,
                Plat = plat
            };

            try
            {
                if (IsEditMode)
                {
                    pozice.Id = this.Pozice.Id;
                    _poziceRepo.UpdatePozice(pozice);
                    MessageBox.Show("Pozice byla úspěšně aktualizována.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _poziceRepo.UpdatePozice(pozice);
                    MessageBox.Show("Pozice byla úspěšně přidána.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při ukládání: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

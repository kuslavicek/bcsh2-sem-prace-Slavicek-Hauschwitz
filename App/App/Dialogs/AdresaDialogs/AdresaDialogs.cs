using App.Extensions;
using App.Model;
using App.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Dialogs
{
    public partial class AdresaDialogs : Form
    {
        private AdresaRepo _adresaRepo { get; set; }
        private Adresa Adresa { get; set; }
        private bool IsEditMode {get; set;}
        public AdresaDialogs(AdresaRepo adresaRepo, Adresa adresa, bool edit)
        {
            this._adresaRepo = adresaRepo;
            this.Adresa = adresa;
            this.IsEditMode = edit;
            InitializeComponent();
            this.fill();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            State selectedState = comboStat.SelectedItem as State;
            if (!InputValidator.IsNotEmpty(txtUlice, "Ulice není vyplněna") ||
                !InputValidator.IsNotEmpty(txtMesto, "Město není vyplněno") ||
                !InputValidator.IsNotEmpty(txtPsc, "PSČ není vyplněno") ||
                !InputValidator.IsSelected(comboStat, "Není vybrán stát") ||
                !InputValidator.IsNotEmpty(txtCisloPopisne, "Číslo popisné není vyplněno není vyplněno"))
            {
                return;
            }

            if (!InputValidator.IsTextOnly(txtUlice, "Ulice nemůže obsahovat čísla") ||
                !InputValidator.IsTextOnly(txtMesto, "Město nemůže obsahovat čísla.") ||
                !InputValidator.IsNumber(txtCisloPopisne, "Číslo popisné nemůže obsahovat znaky."))
            {
                return;
            }

            bool isPostalCodeValid = await InputValidator.ValidatePostalCode(selectedState.Code, txtPsc.Text.Replace(" ", ""));
            if (!isPostalCodeValid)
            {
                MessageBox.Show("Nevalidní PSČ pro zvolenou zemi.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (IsEditMode)
                {
                    this.Adresa.Mesto = txtMesto.Text;
                    this.Adresa.Ulice = txtUlice.Text;
                    this.Adresa.CisloPopisne = int.Parse(txtCisloPopisne.Text);
                    this.Adresa.Psc = int.Parse(txtPsc.Text.Replace(" ", ""));
                    this.Adresa.Stat = selectedState.Name;

                    Adresa.Id = this.Adresa.Id;
                    _adresaRepo.UpdateAdresa(Adresa);
                    MessageBox.Show("Adresa byla úspěšně aktualizována.");
                }
                else
                {
                    var adresa = new Adresa
                    (
                        null,
                        txtMesto.Text,
                        txtUlice.Text,
                        int.Parse(txtCisloPopisne.Text), 
                        int.Parse(txtPsc.Text.Replace(" ", "")),
                        selectedState.Name
                    );

                    _adresaRepo.UpdateAdresa(adresa);
                    MessageBox.Show("Adresa byla úspěšně přidána.");
                }
            }
            catch (Exception ex)
            {
                // Chyba při ukládání
                MessageBox.Show("Chyba při ukládání: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fill() {
            if (this.IsEditMode) {
                this.txtUlice.Text = this.Adresa.Ulice;
                this.txtMesto.Text = this.Adresa.Mesto;
                this.txtPsc.Text = this.Adresa.Psc.ToString();
                this.txtCisloPopisne.Text = this.Adresa.CisloPopisne.ToString();
            }
            this.FillComboBox();
        }

        private async void FillComboBox()
        {
            var states = await StateLoader.GetStatesFromApiAsync();
            comboStat.DataSource = states;
            comboStat.DisplayMember = "Name";
            comboStat.ValueMember = "Code";

            if (this.Adresa != null)
            {
                var selectedState = states.FirstOrDefault(s => s.Name == this.Adresa.Stat);

                if (selectedState != null)
                {
                    comboStat.SelectedItem = selectedState;
                }
                else
                {
                    comboStat.SelectedItem = null;
                }
            }
        }
    }
}

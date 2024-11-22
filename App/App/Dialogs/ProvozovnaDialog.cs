using App.Extensions;
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
            this.FillComboBox();
            this._provozovnaRepo =repo;
            this.IsEditMode = isEditMode;
            this.Provozovna = provozovna;

            this.fill();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            State selectedState = comboStat.SelectedItem as State;
            if (!InputValidator.IsNotEmpty(textBoxNazev, "Název není vyplněný.") ||
                !InputValidator.IsNotEmpty(textBoxUlice, "Ulice není vyplněna") ||
                !InputValidator.IsNotEmpty(textBoxMesto, "Město není vyplněno") ||
                !InputValidator.IsNotEmpty(textBoxPsc, "PSČ není vyplněno") ||
                !InputValidator.IsSelected(comboStat, "Není vybrán stát") ||
                !InputValidator.IsNotEmpty(textBoxCisloPopisne, "Číslo popisné není vyplněno není vyplněno"))
            {
                return;
            }

            if (!InputValidator.IsTextOnly(textBoxNazev, "Název nesmí obsahovat čísla.") ||
                !InputValidator.IsTextOnly(textBoxUlice, "Ulice nemůže obsahovat čísla") ||
                !InputValidator.IsTextOnly(textBoxMesto, "Město nemůže obsahovat čísla") ||
                !InputValidator.IsNumber(textBoxCisloPopisne, "Číslo popisné nemůže obsahovat znaky."))
            {
                return;
            }

            bool isPostalCodeValid = await InputValidator.ValidatePostalCode(selectedState.Code, textBoxPsc.Text);
            if (!isPostalCodeValid)
            {
                MessageBox.Show("Nevalidní PSČ pro zvolenou zemi.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    this.Provozovna.Adresa.Psc = int.Parse(textBoxPsc.Text.Replace(" ", ""));
                    this.Provozovna.Adresa.Stat = selectedState.Name;
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
                        int.Parse(textBoxPsc.Text.Replace(" ", "")),
                        selectedState.Name
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
                this.textBoxPsc.Text = this.Provozovna.Adresa.Psc.ToString();
                this.textBoxMesto.Text = this.Provozovna.Adresa.Mesto;
                this.textBoxCisloPopisne.Text = this.Provozovna.Adresa.CisloPopisne.ToString();
            }
            else {
                this.textBoxPocet.Text = "0";
            }
        }

        private async void FillComboBox()
        {
            var states = await StateLoader.GetStatesFromApiAsync();
            comboStat.DataSource = states;
            comboStat.DisplayMember = "Name";
            comboStat.ValueMember = "Code";

            if (this.Provozovna != null)
            {
                var selectedState = states.FirstOrDefault(s => s.Name == this.Provozovna.Adresa.Stat);

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

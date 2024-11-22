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
using System.Windows.Forms.VisualStyles;

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
            this.FillComboBox();
            this.IsEditMode = edit;
            this._zakaznikRepo = zakaznikRepo;
            this.zakaznik = zakaznik;
            this.FillData();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            State selectedState = comboStat.SelectedItem as State;
            if (!InputValidator.IsNotEmpty(textBoxJmeno,"Jméno není vyplněno")||
                !InputValidator.IsNotEmpty(textBoxTelefon, "Telefon není vyplněn")||
                !InputValidator.IsNotEmpty(textBoxEmail, "Email není vyplněn")||
                !InputValidator.IsNotEmpty(textBoxUlice, "Ulice není vyplněna")||
                !InputValidator.IsNotEmpty(textBoxMesto, "Město není vyplněno")||
                !InputValidator.IsNotEmpty(textBoxPsc, "PSČ není vyplněno")||
                !InputValidator.IsSelected(comboStat, "Není vybrán stát") ||
                !InputValidator.IsNotEmpty(textBoxCisloPopisne, "Číslo popisné není vyplněno není vyplněno")) {
                return;
            }

            if (!InputValidator.IsTextOnly(textBoxJmeno, "Jméno nemůže obsahovat čísla.") ||
                !InputValidator.IsPhoneNumber(textBoxTelefon, "Neplatné telefoní číslo.") ||
                !InputValidator.IsEmail(textBoxEmail, "Neplatný email.") ||
                !InputValidator.IsTextOnly(textBoxUlice, "Ulice nemůže obsahovat čísla") ||
                !InputValidator.IsTextOnly(textBoxMesto, "Město nemůže obsahovat čísla.") ||
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
                    this.zakaznik.Jmeno = textBoxJmeno.Text;
                    this.zakaznik.Telefon = double.Parse(textBoxTelefon.Text);
                    this.zakaznik.Email = textBoxEmail.Text;
                    this.zakaznik.Adresa.Mesto = textBoxMesto.Text;
                    this.zakaznik.Adresa.Ulice = textBoxUlice.Text;
                    this.zakaznik.Adresa.CisloPopisne = int.Parse(textBoxCisloPopisne.Text);
                    this.zakaznik.Adresa.Psc = int.Parse(textBoxPsc.Text);
                    this.zakaznik.Adresa.Stat = selectedState.Name;

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
                        selectedState.Name
                    );

                    var zakaznik = new Zakaznik
                    (
                        null,
                        textBoxJmeno.Text,
                        double.Parse(textBoxTelefon.Text),
                        textBoxEmail.Text,
                        adresa,
                        null
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
                }
            }
            GlobalStyles.ApplyButtonStyle(this.cancelButton);
            GlobalStyles.ApplyButtonStyle(this.saveButton);
        }

        private async void FillComboBox()
        {
            var states = await StateLoader.GetStatesFromApiAsync();
            comboStat.DataSource = states;
            comboStat.DisplayMember = "Name";
            comboStat.ValueMember = "Code";

            if (this.zakaznik!=null) {
                var selectedState = states.FirstOrDefault(s => s.Name == this.zakaznik.Adresa.Stat);

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

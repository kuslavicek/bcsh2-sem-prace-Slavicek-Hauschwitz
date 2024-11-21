using App.Model;
using App.Repositories;

namespace App.Dialogs
{
    public partial class SurovinaDialog : Form
    {
        private SurovinaRepo _surovinaRepo;
        private SkladRepo _skladRepo;
        public bool IsEditMode { get; set; } = false;
        private Surovina surovina { get; set; }
        public SurovinaDialog(SurovinaRepo surovinaRepo, Surovina surovina,bool edit)
        {
            InitializeComponent();
            this.IsEditMode = edit;
            this._surovinaRepo = surovinaRepo;
            this._skladRepo=new SkladRepo();
            this.surovina = surovina;
            this.fillData();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!InputValidator.IsNotEmpty(textBoxMnozstvi,"Množství není vyplněný.")||
                !InputValidator.IsNotEmpty(textBoxNazev, "Název není vyplněný.")||
                !InputValidator.IsSelected(comboSklad, "Sklad není vybraný.")) {
                return;
            }

            if (!InputValidator.IsNumber(textBoxMnozstvi, "Množství nesmí obsahovat znaky.")||
                !InputValidator.IsTextOnly(textBoxNazev, "Název nesmí obsahovat čísla.")) {
                return;
            }

            var selectedSklad = comboSklad.SelectedIndex;

            var surovina = new Surovina(
                nazev: textBoxNazev.Text,
                mnozstvi: double.Parse(textBoxMnozstvi.Text),
                idSklad: selectedSklad+1
            );

            try
            {
                if (IsEditMode)
                {
                    surovina.Id = this.surovina.Id;
                    _surovinaRepo.UpdateSurovina(surovina);
                    MessageBox.Show("Surovina byla úspěšně aktualizována.");
                }
                else
                {
                    _surovinaRepo.UpdateSurovina(surovina);
                    MessageBox.Show("Surovina byla úspěšně přidána.");
                }
            }
            catch (Exception ex)
            {
                // Chyba při ukládání
                MessageBox.Show("Chyba při ukládání: " + ex.Message);
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillData()
        {
            var skladyDict = _skladRepo.LoadSkladyForSelect();

            comboSklad.DataSource = new BindingSource(skladyDict, null);
            comboSklad.DisplayMember = "Value";
            comboSklad.ValueMember = "Key";
            comboSklad.SelectedIndex = 0;
            if (surovina != null)
            {
                IsEditMode = true;
                this.textBoxMnozstvi.Text=surovina.Mnozstvi.ToString();
                this.textBoxNazev.Text = surovina.Nazev;
                foreach (var item in ((BindingSource)comboSklad.DataSource))
                {
                    if (((KeyValuePair<int, string>)item).Value == surovina.NazevSklad)
                    {
                        comboSklad.SelectedItem = item;
                        break;
                    }
                }
            }
            GlobalStyles.ApplyButtonStyle(this.buttonCancel);
            GlobalStyles.ApplyButtonStyle(this.buttonOk);
        }
    }
}

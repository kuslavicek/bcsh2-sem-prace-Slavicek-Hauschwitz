using App.Model;
using App.Repositories;

namespace App.Dialogs
{
    public partial class SurovinaDialog : Form
    {
        private SurovinaRepo _surovinaRepo;
        public bool IsEditMode { get; set; } = false;
        private Surovina surovina { get; set; }
        public SurovinaDialog(SurovinaRepo surovinaRepo, Surovina surovina,bool edit)
        {
            InitializeComponent();
            this.IsEditMode = edit;
            this._surovinaRepo = surovinaRepo;
            this.surovina = surovina;
            if (this.IsEditMode) { this.fillData(); }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboSklad.SelectedItem == null)
            {
                MessageBox.Show("Není vybrán sklad");
                return;
            }

            var selectedSklad = (Sklad)comboSklad.SelectedItem;
            int skladId = (int)selectedSklad.Id;

            var surovina = new Surovina(
                nazev: textBoxNazev.Text,
                mnozstvi: double.Parse(textBoxMnozstvi.Text),
                idSklad: skladId
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
            if (surovina != null)
            {
                IsEditMode = true;
                this.textBoxMnozstvi.Text=surovina.Mnozstvi.ToString();
                this.textBoxNazev.Text = surovina.Nazev;
                this.comboSklad.SelectedItem = surovina.NazevSklad;
            }
            GlobalStyles.ApplyButtonStyle(this.buttonCancel);
            GlobalStyles.ApplyButtonStyle(this.buttonOk);
        }
    }
}

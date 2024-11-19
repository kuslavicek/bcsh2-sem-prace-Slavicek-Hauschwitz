using App.Model;
using App.Repositories;

namespace App.Dialogs
{
    public partial class ZboziDialog : Form
    {
        private ZboziData _zboziData;
        public bool IsEditMode { get; set; } = false;
        private Zbozi zbozi { get; set; }
        public ZboziDialog(ZboziData zboziData, Zbozi zbozi, bool edit)
        {
            InitializeComponent();
            this.IsEditMode = edit;
            this.zbozi=zbozi;
            _zboziData = zboziData;
            if (this.IsEditMode) { this.fillData();}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboTyp.SelectedItem == null || comboSklad.SelectedItem == null)
            {
                MessageBox.Show("Není vybrán sklad nebo typ.");
                return;
            }

            var selectedSklad = (Sklad)comboSklad.SelectedItem;
            int skladId = (int)selectedSklad.Id;

            var zbozi = new Zbozi(
                nazev: txtNazev.Text,
                obsahAlkoholu: double.Parse(txtObsahAlkoholu.Text),
                cena: double.Parse(txtCena.Text),
                typ: comboTyp.SelectedItem.ToString()[0],
                skladId: skladId,
                odrudaJablek: comboTyp.SelectedItem.ToString() == "c" ? txtSpecificValue.Text : "",
                stupnovitost: comboTyp.SelectedItem.ToString() == "p" ? double.Parse(txtSpecificValue.Text) : 0
            );

            try
            {
                if (IsEditMode)
                {
                    zbozi.Id = this.zbozi.Id;
                    _zboziData.UpdateZbozi(zbozi);
                    MessageBox.Show("Zboží bylo úspěšně aktualizováno.");
                }
                else
                {
                    _zboziData.UpdateZbozi(zbozi);
                    MessageBox.Show("Zboží bylo úspěšně přidáno.");
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

        private void fillData() {
            if (zbozi != null)
            {
                GlobalStyles.ApplyButtonStyle(this.btnCancel);
                GlobalStyles.ApplyButtonStyle(this.btnSave);
                IsEditMode = true;
                this.txtNazev.Text = zbozi.Nazev.ToString();
                this.txtObsahAlkoholu.Text = zbozi.ObsahAlkoholu.ToString();
                this.txtCena.Text = zbozi.Cena.ToString();
                this.comboSklad.SelectedItem = zbozi.SkladNazev;
                this.comboTyp.SelectedItem = zbozi.Typ;
                this.txtSpecificValue.Text = zbozi.Typ == 'c' ? zbozi.OdrudaJablek.ToString() : zbozi.Stupnovitost.ToString();
            }
        }
    }
}

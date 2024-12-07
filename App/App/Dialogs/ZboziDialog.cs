using App.Model;
using App.Repositories;

namespace App.Dialogs
{
    public partial class ZboziDialog : Form
    {
        private ZboziData _zboziData;
        public bool IsEditMode { get; set; } = false;
        private Zbozi zbozi { get; set; }
        private SkladRepo _skladRepo { get; set; }
        public ZboziDialog(ZboziData zboziData, Zbozi zbozi, bool edit)
        {
            InitializeComponent();
            this.IsEditMode = edit;
            this.zbozi=zbozi;
            _zboziData = zboziData;
            _skladRepo = new SkladRepo();
            this.fillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!InputValidator.IsNotEmpty(txtCena,"Pole cena není vyplněné")||
                !InputValidator.IsNotEmpty(txtSpecificValue, "Pole Stupňovitost/odrůda není vyplněné")||
                !InputValidator.IsNotEmpty(txtNazev, "Pole Název není vyplněné")||
                !InputValidator.IsNotEmpty(txtObsahAlkoholu, "Pole Obsah Alkoholu není vyplněné")||
                !InputValidator.IsSelected(comboTyp, "Není vybraný typ.")||
                !InputValidator.IsSelected(comboSklad, "Není vybraný sklad."))
            {

                return;
            }

            if (!InputValidator.IsNumber(txtCena, "Hodnota v poli cena musí být číslo")||
                !InputValidator.IsTextOnly(txtNazev, "Název musí být tvořen znaky")||
                !InputValidator.IsNumber(txtObsahAlkoholu, "Hodnota v poli Obsah alkoholu musí být číslo.")) {
                return;
            }

            if (this.comboTyp.SelectedIndex==0 && !InputValidator.IsNumber(txtSpecificValue, "Pro typ pivo musí být vyplněna stupňovitost.")||
                this.comboTyp.SelectedIndex==1 && !InputValidator.IsTextOnly(txtSpecificValue, "Pro pivo musí být vyplněná odrůda.")) {
                return;
            }

            var selectedSklad = (int)comboSklad.SelectedValue;

            var zbozi = new Zbozi(
                nazev: txtNazev.Text,
                obsahAlkoholu: double.Parse(txtObsahAlkoholu.Text),
                cena: double.Parse(txtCena.Text),
                typ: comboTyp.SelectedItem.ToString()[0],
                skladId: selectedSklad,
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
            var skladyDict = _skladRepo.LoadSkladyForSelect();

            comboSklad.DataSource = new BindingSource(skladyDict, null);
            comboSklad.DisplayMember = "Value";
            comboSklad.ValueMember = "Key";

            if (zbozi != null)
            {
                GlobalStyles.ApplyButtonStyle(this.btnCancel);
                GlobalStyles.ApplyButtonStyle(this.btnSave);
                IsEditMode = true;
                this.txtNazev.Text = zbozi.Nazev.ToString();
                this.txtObsahAlkoholu.Text = zbozi.ObsahAlkoholu.ToString();
                this.txtCena.Text = zbozi.Cena.ToString();
                foreach (var item in ((BindingSource)comboSklad.DataSource))
                {
                    if (((KeyValuePair<int, string>)item).Value == zbozi.SkladNazev)
                    {
                        comboSklad.SelectedItem = item;
                        break;
                    }
                }
                this.comboTyp.SelectedIndex = zbozi.Typ == 'c' ? 1 : 0;
                this.txtSpecificValue.Text = zbozi.Typ == 'c' ? zbozi.OdrudaJablek.ToString() : zbozi.Stupnovitost.ToString();
            }
            else {
                this.comboTyp.SelectedIndex = 0;
                this.comboSklad.SelectedIndex = 0;
            }
        }
    }
}

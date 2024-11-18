using App.Dialogs.ObjednavkaDialogs;
using App.Model;
using App.Repositories;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection.Metadata;

namespace App.Dialogs
{
    public partial class ObjednavkaDialog : Form
    {
        private ObjednavkaRepo _objednavkaRepo;
        private ZakaznikRepo _zakaznikRepo;
        private ObjednaneZboziRepo _objednaneZboziRepo;
        private ZboziData _zboziRepo;
        private AkceRepo _akceRepo;
        public bool IsEditMode { get; set; } = false;
        private Objednavka Objednavka { get; set; }
        private Zakaznik Zakaznik { get; set; }
        private List<KeyValuePair<ObjednaneZbozi, Zbozi>> ZboziSeznam { get; set; }
        private List<Akce> AkceSeznam { get; set; }
        private int originalCount = 0;

        public ObjednavkaDialog(ObjednavkaRepo objednavkaRepo, Objednavka objednavka, bool edit)
        {
            InitializeComponent();
            this.IsEditMode = edit;
            this._objednavkaRepo = objednavkaRepo;
            this._zakaznikRepo = new ZakaznikRepo();
            this._objednaneZboziRepo = new ObjednaneZboziRepo();
            this._zboziRepo = new ZboziData();
            this._akceRepo = new AkceRepo();
            this.Objednavka = objednavka;

            this.Zakaznik = _zakaznikRepo.GetZakaznikById(this.Objednavka.IdZakaznik);
            this.ZboziSeznam = _objednaneZboziRepo.GetObjednaneZboziByObjednavka(this.Objednavka.Id);
            this.AkceSeznam = _akceRepo.GetAkceByIdObjednavka(this.Objednavka.Id);
            this.originalCount = this.ZboziSeznam.Count;

            if (this.IsEditMode) { this.fillData(); }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonEditFaktura_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonEditZakaznik_Click(object sender, EventArgs e)
        {
            try
            {
                ZakaznikDialog zakaznikDialog = new ZakaznikDialog(_zakaznikRepo, Zakaznik, true);
                if (zakaznikDialog.ShowDialog() == DialogResult.OK)
                {
                    zakaznikDialog.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillData()
        {
            if (this.IsEditMode) {
                this.textBoxCena.Text=this.Objednavka.Cena.ToString();
                this.dateTimePickerDatum.Value = this.Objednavka.DatumZalozeni;
                this.textBoxZakaznik.Text=this.Zakaznik.Jmeno.ToString();
                this.listViewZbozi.Items.Clear();
                LoadZboziListView();
                LoadAkceListView();
            }
        }

        private void LoadZboziListView()
        {
            listViewZbozi.Columns.Clear();
            listViewZbozi.Columns.Add("Množství", 150);
            listViewZbozi.Columns.Add("Název", 150);
            listViewZbozi.Columns.Add("Cena", 100);
            listViewZbozi.Items.Clear();

            for (int i = 0; i < ZboziSeznam.Count; i++)
            {
                var pair = ZboziSeznam[i];
                var item = new ListViewItem(new[]
                {
                    pair.Key.Mnozstvi.ToString(),
                    pair.Value.Nazev,
                    pair.Value.Cena.ToString(),
                });

                item.Tag = pair.Key.Id;

                if (i >= originalCount)
                {
                    item.ForeColor = Color.Red;
                }

                listViewZbozi.Items.Add(item);
            }
        }

        private void LoadAkceListView()
        {
            listViewAkce.Columns.Clear();
            listViewAkce.Columns.Add("Počet osob", 100);
            listViewAkce.Columns.Add("Datum", 150);
            listViewAkce.Columns.Add("Typ akce", 100);
            listViewAkce.Columns.Add("Objednávka ID", 100);
            listViewAkce.Items.Clear();


            for (int i = 0; i < AkceSeznam.Count; i++)
            {
                var akce = AkceSeznam[i];
                var item = new ListViewItem(new[]
                {
                    akce.PocetOsob.ToString(),
                    akce.Datum.ToShortDateString(),
                    akce.IdTypAkce.ToString(),
                    akce.IdObjednavka.ToString(),
                });

                item.Tag = akce.Id;

                listViewAkce.Items.Add(item);
            }
        }

        private void buttonAddZbozi_Click(object sender, EventArgs e)
        {
            try
            {
                ZboziManipulationDialog zboziDialog = new ZboziManipulationDialog();

                zboziDialog.ZboziAdded += ZboziDialog_ZboziAdded;

                if (zboziDialog.ShowDialog() == DialogResult.OK)
                {
                    zboziDialog.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ZboziDialog_ZboziAdded(List<ObjednaneZbozi> objednaneZbozi)
        {
            try
            {
                List<KeyValuePair<ObjednaneZbozi, Zbozi>> mergedList = new List<KeyValuePair<ObjednaneZbozi, Zbozi>>();

                foreach (var objednane in objednaneZbozi)
                {
                    Zbozi zbozi = _zboziRepo.LoadById(objednane.IdZbozi);

                    if (zbozi != null)
                    {
                        mergedList.Add(new KeyValuePair<ObjednaneZbozi, Zbozi>(objednane, zbozi));
                    }
                    else
                    {
                        MessageBox.Show($"Zboží s ID {objednane.IdZbozi} nebylo nalezeno.");
                    }
                }

                ZboziSeznam.AddRange(mergedList);
                this.LoadZboziListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při přidávání zboží: " + ex.Message);
            }
        }
    }
}

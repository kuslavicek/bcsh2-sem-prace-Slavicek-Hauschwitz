using App.Dialogs.ObjednavkaDialogs;
using App.Model;
using App.Model.Enums;
using App.Repositories;
using App.Utils;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Linq;
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
        FileStream file;
        private int originalCountZbozi = 0;
        private int originalCountAkce = 0;

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
            this.originalCountZbozi = this.ZboziSeznam.Count;
            this.originalCountAkce = this.AkceSeznam.Count;

            if (this.IsEditMode) { this.fillData(); }
            this.LoadStyles();
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
            try {
                string customerName = this.Zakaznik.Jmeno;

                var zboziItems = ZboziSeznam.Select(zbozi => new
                {
                    Description = zbozi.Value.Nazev,
                    Quantity = zbozi.Key.Mnozstvi,
                    Price = zbozi.Value.Cena
                }).ToList();

                var akceItems = AkceSeznam.Select(akce => new
                {
                    Description = _akceRepo.GetTypAkceById(akce.IdTypAkce) + " - " + akce.Datum.ToShortDateString(),
                    Quantity = akce.PocetOsob,
                    Price = 0.0
                }).ToList();

                MemoryStream fakturaStream = InvoiceGenerator.GenerateInvoice(customerName, zboziItems, akceItems);
                file = new FileStream("faktura.pdf", FileMode.Create, FileAccess.ReadWrite);
                fakturaStream.CopyTo(file);
                file.Flush();
                file.Position = 0;
                this.btnSaveFaktura.Enabled = true;
                MessageBox.Show("Faktura byla úspěšně vygenerována.");
            } catch (Exception ex) {
                MessageBox.Show("Chyba"+ex.Message);
            }
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
            if (this.IsEditMode)
            {
                this.textBoxCena.Text = this.Objednavka.Cena.ToString();
                this.dateTimePickerDatum.Value = this.Objednavka.DatumZalozeni;
                this.textBoxZakaznik.Text = this.Zakaznik.Jmeno.ToString();
                this.listViewZbozi.Items.Clear();
                this.btnSaveFaktura.Enabled = true;
                LoadZboziListView();
                LoadAkceListView();
            }
            else
            {
                this.btnSaveFaktura.Enabled = false;
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

                if (i >= originalCountZbozi)
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
            listViewAkce.Items.Clear();


            for (int i = 0; i < AkceSeznam.Count; i++)
            {
                var akce = AkceSeznam[i];
                var item = new ListViewItem(new[]
                {
                    akce.PocetOsob.ToString(),
                    akce.Datum.ToShortDateString(),
                    Enum.GetName(typeof(TypyAkce), akce.IdTypAkce)
                });

                item.Tag = akce.Id;

                if (i >= originalCountAkce)
                {
                    item.ForeColor = Color.Red;
                }

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

        private void AkceDialog_AkceAdded(Akce akce)
        {
            this.AkceSeznam.Add(akce);
            this.LoadAkceListView();
        }

        private void LoadStyles()
        {
            GlobalStyles.ApplyButtonStyle(this.buttonAddAkce);
            GlobalStyles.ApplyButtonStyle(this.buttonAddZbozi);
        }

        private void buttonAddAkce_Click(object sender, EventArgs e)
        {
            try
            {
                AkceManipulationDialog akceDialog = new AkceManipulationDialog();

                akceDialog.AkceAdded += AkceDialog_AkceAdded;

                if (akceDialog.ShowDialog() == DialogResult.OK)
                {
                    akceDialog.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteZbozi_Click(object sender, EventArgs e)
        {
            if (this.listViewZbozi.SelectedItems.Count > 0)
            {
                var selectedItem = this.listViewZbozi.SelectedItems[0];
                int selectedIndex = selectedItem.Index;

                if (selectedIndex >= 0 && selectedIndex < ZboziSeznam.Count)
                {
                    ZboziSeznam.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Není vybrané žádné zboží.");
            }

            LoadZboziListView();
        }

        private void btnOdebratAkci_Click(object sender, EventArgs e)
        {
            if (this.listViewAkce.SelectedItems.Count > 0)
            {
                var selectedItem = this.listViewAkce.SelectedItems[0];
                int selectedIndex = selectedItem.Index;

                if (selectedIndex >= 0 && selectedIndex < AkceSeznam.Count)
                {
                    AkceSeznam.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Není vybraná žádná akce.");
            }

            LoadAkceListView();
        }

        private void btnSaveFaktura_Click(object sender, EventArgs e)
        {
            try
            {
                file.Position = 0;
                if (file == null || file.Length == 0 || file.CanRead == false)
                {
                    MessageBox.Show("Faktura není připravena k uložení.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                file.Position = 0;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF soubory (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Uložit fakturu";
                    saveFileDialog.FileName = "Faktura.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream saveStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            file.CopyTo(saveStream);
                        }

                        MessageBox.Show("Faktura byla úspěšně uložena.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba při ukládání faktury: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

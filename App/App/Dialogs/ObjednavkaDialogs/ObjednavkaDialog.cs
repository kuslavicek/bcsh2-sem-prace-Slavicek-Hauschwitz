﻿using App.Dialogs.ObjednavkaDialogs;
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
        private FakturaRepo _fakturaRepo;
        public bool IsEditMode { get; set; } = false;
        private Objednavka Objednavka { get; set; }
        private Zakaznik Zakaznik { get; set; }
        private Faktura Faktura { get; set; }
        private List<KeyValuePair<ObjednaneZbozi, Zbozi>> ZboziSeznam { get; set; }
        private List<Akce> AkceSeznam { get; set; }
        FileStream file;
        private int originalCountZbozi = 0;
        private int originalCountAkce = 0;

        public ObjednavkaDialog(ObjednavkaRepo objednavkaRepo, Objednavka? objednavka, bool edit)
        {
            InitializeComponent();
            this.IsEditMode = edit;
            this._objednavkaRepo = objednavkaRepo;
            this._zakaznikRepo = new ZakaznikRepo();
            this._objednaneZboziRepo = new ObjednaneZboziRepo();
            this._zboziRepo = new ZboziData();
            this._akceRepo = new AkceRepo();
            this._fakturaRepo = new FakturaRepo();
            this.Objednavka = objednavka!=null?objednavka:new Objednavka();
            this.originalCountZbozi = 0;
            this.originalCountAkce = 0;
            if (this.IsEditMode)
            {
                this.Zakaznik = _zakaznikRepo.GetZakaznikById((int)this.Objednavka.IdZakaznik);
                this.ZboziSeznam = _objednaneZboziRepo.GetObjednaneZboziByObjednavka(this.Objednavka.Id);
                this.AkceSeznam = _akceRepo.GetAkceByIdObjednavka(this.Objednavka.Id);
                this.Faktura = this._fakturaRepo.GetFakturaByObjednavka(this.Objednavka.Id);
                this.originalCountZbozi = this.ZboziSeznam.Count;
                this.originalCountAkce = this.ZboziSeznam.Count;
                this.fillData();
            }
            else {
                this.ZboziSeznam = new List<KeyValuePair<ObjednaneZbozi, Zbozi>>();
                this.AkceSeznam = new List<Akce>();
                this.btnSaveFaktura.Enabled = false;
                this.buttonGenerateFaktura.Enabled = false;

            }
            this.LoadStyles();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var cena=this.UpdateOrderPrice();
            this.Objednavka.Cena = cena;
            this.Objednavka.IdZakaznik=this.Zakaznik.Id;
            this.Objednavka.DatumZalozeni = this.dateTimePickerDatum.Value;
            if (this.Faktura != null && this.Objednavka !=null && (this.ZboziSeznam.Count>0 || this.AkceSeznam.Count>0)) {
                this._objednavkaRepo.Save(Objednavka, Faktura, ZboziSeznam, AkceSeznam);
            }
            this.Close();
        }

        private double UpdateOrderPrice() {
            double cena = 0;
            foreach (var zbozi in this.ZboziSeznam)
            {
                cena += zbozi.Value.Cena * zbozi.Key.Mnozstvi;
            }
            this.textBoxCena.Text = cena.ToString();
            return cena;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

                string fileName = "faktura-" + InvoiceGenerator.GenerateInvoiceNumber() + ".pdf";

                MemoryStream fakturaStream = InvoiceGenerator.GenerateInvoice(fileName, customerName, zboziItems, akceItems);

                using (FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fakturaStream.CopyTo(file);
                }

                byte[] fileBytes = File.ReadAllBytes(fileName);

                this.textBoxFaktura.Text = fileName;
                this.btnSaveFaktura.Enabled = true;

                this.Faktura = new Faktura
                {
                    Id = this.Faktura != null ? this.Faktura.Id : null,
                    FakturaBlob = fileBytes,
                    NazevSouboru = fileName,
                    DatumVlozeni = DateTime.Now
                };
                MessageBox.Show("Faktura byla úspěšně vygenerována.");
            } catch (Exception ex) {
                MessageBox.Show("Chyba"+ex.Message);
            }
        }

        private void buttonEditZakaznik_Click(object sender, EventArgs e)
        {
            if (this.Zakaznik != null)
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
            else {
                try
                {
                    ZakaznikSelectDialog zakaznikDialog = new ZakaznikSelectDialog();
                    if (zakaznikDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.Zakaznik = zakaznikDialog.SelectedZakaznik;
                        this.textBoxZakaznik.Text = this.Zakaznik.Jmeno;
                        zakaznikDialog.Close();
                        this.buttonGenerateFaktura.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                this.textBoxFaktura.Text = this.Faktura.NazevSouboru;
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
                foreach (var objednane in objednaneZbozi)
                {
                    Zbozi zbozi = _zboziRepo.LoadById(objednane.IdZbozi);

                    if (zbozi != null)
                    {
                        var existingItem = ZboziSeznam.FirstOrDefault(item => item.Value.Id == zbozi.Id);

                        if (existingItem.Key != null)
                        {
                            existingItem.Key.Mnozstvi += objednane.Mnozstvi;
                        }
                        else
                        {
                            ZboziSeznam.Add(new KeyValuePair<ObjednaneZbozi, Zbozi>(objednane, zbozi));
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Zboží s ID {objednane.IdZbozi} nebylo nalezeno.");
                    }
                }

                this.LoadZboziListView();
                this.UpdateOrderPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při přidávání zboží: " + ex.Message);
            }
        }

        private void AkceDialog_AkceAdded(Akce akce)
        {
            var existingAkce = this.AkceSeznam.FirstOrDefault(a => a.Datum == akce.Datum);

            if (existingAkce != null)
            {
                existingAkce.PocetOsob += akce.PocetOsob;
            }
            else
            {
                this.AkceSeznam.Add(akce);
            }

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
                    _objednaneZboziRepo.DeleteObjednaneZbozi(Convert.ToInt32(selectedItem.Tag));
                    this.LoadZboziListView();
                    this.UpdateOrderPrice();
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
                    _akceRepo.DeleteAkce(Convert.ToInt32(selectedItem.Tag));
                    this.LoadAkceListView();
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
            if (this.Faktura != null && this.Faktura.FakturaBlob != null)
            {
                byte[] fakturaBlob = this.Faktura.FakturaBlob;

                if (fakturaBlob != null && fakturaBlob.Length > 0)
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PDF File|*.pdf|All files|*.*";
                        saveFileDialog.Title = "Uložit fakturu jako";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;

                            try
                            {
                                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                                {
                                    fileStream.Write(fakturaBlob, 0, fakturaBlob.Length);
                                }

                                MessageBox.Show("Faktura byla úspěšně uložena.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Chyba při ukládání faktury: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faktura je prázdná.");
                }
            }
            else
            {
                MessageBox.Show("Faktura nebyla nalezena.");
            }
        }
    }
}

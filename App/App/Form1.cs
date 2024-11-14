using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Windows.Forms;
using App.Repositories;
using App.Model;
using App.Dialogs;
namespace App
{
    public partial class Form1 : Form
    {
        private ZboziData _zboziData;
        private SurovinaRepo _surovinaRepo;
        private ZakaznikRepo _zakaznikRepo;
        private AdresaRepo _adresaRepo;
        public Form1()
        {
            InitializeComponent();

            _zboziData = new ZboziData();
            LoadZbozi();

            _surovinaRepo = new SurovinaRepo();
            LoadSuroviny();

            _zakaznikRepo = new ZakaznikRepo();
            LoadZakaznici();

            _adresaRepo = new AdresaRepo();

            InitializeLvObjednavky();
            LoadObjednavky();
        }
        #region Zbozi

        private void LoadZbozi()
        {
            lvPiva.Columns.Clear();
            lvPiva.View = View.Details;
            lvPiva.FullRowSelect = true;
            lvPiva.Columns.Add("Název", 150);
            lvPiva.Columns.Add("Obsah alkoholu", 100);
            lvPiva.Columns.Add("Cena", 100);
            lvPiva.Columns.Add("Typ", 100);
            lvPiva.Columns.Add("Název skladu", 150);
            lvPiva.Columns.Add("Stupòovitost/odrùda", 150);

            var zboziList = _zboziData.Load();
            lvPiva.Items.Clear();

            foreach (var zbozi in zboziList)
            {
                // Urèíme hodnotu pro specifický sloupec podle typu
                string specificValue = zbozi.Typ == 'c' ? zbozi.OdrudaJablek : zbozi.Stupnovitost.ToString();

                var item = new ListViewItem(new[]
                {
                    zbozi.Nazev,
                    zbozi.ObsahAlkoholu.ToString(),
                    zbozi.Cena.ToString(),
                    zbozi.Typ.ToString(),
                    zbozi.SkladNazev.ToString(),
                    specificValue
                });

                item.Tag = zbozi.Id;
                lvPiva.Items.Add(item);
            }
        }


        private void updateZboziBtn_Click(object sender, EventArgs e)
        {
            if (lvPiva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvPiva.SelectedItems[0];
            double stupnovitost = 0;
            if (selectedItem.SubItems[3].Text == "p" && double.TryParse(selectedItem.SubItems[5].Text, out double parsedStupnovitost))
            {
                stupnovitost = parsedStupnovitost;
            }

            var zbozi = new Zbozi(
                id: (int)selectedItem.Tag,
                nazev: selectedItem.SubItems[0].Text,
                obsahAlkoholu: double.Parse(selectedItem.SubItems[1].Text),
                cena: double.Parse(selectedItem.SubItems[2].Text),
                typ: selectedItem.SubItems[3].Text[0],
                skladNazev: selectedItem.SubItems[4].Text,
                odrudaJablek: selectedItem.SubItems[3].Text == "c" ? selectedItem.SubItems[5].Text : null,
                stupnovitost: stupnovitost
            );

            try
            {
                ZboziDialog zboziDialog = new ZboziDialog(_zboziData, zbozi,true);
                if (zboziDialog.ShowDialog() == DialogResult.OK)
                {
                    this.LoadZbozi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadZbozi();
        }
        private void InsertZboziBtn_Click(object sender, EventArgs e)
        {
            ZboziDialog zboziDialog = new ZboziDialog(_zboziData,null,false);
            DialogResult result = zboziDialog.ShowDialog();

            if (result == DialogResult.OK || result==DialogResult.Cancel)
            {
                this.LoadZbozi();
            }
        }

        private void DeleteZboziBtn_Click(object sender, EventArgs e)
        {
            if (lvPiva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvPiva.SelectedItems[0];
            var zboziId = (int)selectedItem.Tag;

            try
            {
                _zboziData.DeleteZbozi(zboziId);
                MessageBox.Show("Zboží bylo úspìšnì smazáno.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadZbozi();
        }

        #endregion

        #region Objednávka

        private void InitializeLvObjednavky()
        {
            lvObjednavky.View = View.Details;
            lvObjednavky.FullRowSelect = true;
            lvObjednavky.Columns.Add("Datum založení", 100);
            lvObjednavky.Columns.Add("Cena", 100);
            lvObjednavky.Columns.Add("Zákazník", 150);
            lvObjednavky.Columns.Add("Faktura", 150);
        }
        private void LoadObjednavky()
        {
            //string query = "SELECT id, datum_zalozeni, cena, zakaznik, faktura FROM v_objednavka";


            //var data = _database.GetDataFromView(query);


            //lvObjednavky.Items.Clear();

            //foreach (var row in data)
            //{
            //    var item = new ListViewItem(new[]
            //    {
            //    row["DATUM_ZALOZENI"].ToString(),
            //    row["CENA"].ToString(),
            //    row["ZAKAZNIK"].ToString(),
            //    row["FAKTURA"].ToString()
            //});
            //    item.Tag = row["ID"];
            //    lvObjednavky.Items.Add(item);
            //}
        }

        private void InsertObjednávkaBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateObjednavkaBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteObjednavkaBtn_Click(object sender, EventArgs e)
        {

        }

        private void objZboziBtn_Click(object sender, EventArgs e)
        {
                
        }

        private void FakturaBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Surovina

        private void LoadSuroviny()
        {
            lvSuroviny.Columns.Clear();
            lvSuroviny.View = View.Details;
            lvSuroviny.FullRowSelect = true;
            lvSuroviny.Columns.Add("Název", 150);
            lvSuroviny.Columns.Add("Množství", 100);
            lvSuroviny.Columns.Add("Název skladu", 150);

            var surovinaList = _surovinaRepo.Load();
            lvSuroviny.Items.Clear();

            foreach (var surovina in surovinaList)
            {
                var item = new ListViewItem(new[]
                {
                    surovina.Nazev,
                    surovina.Mnozstvi.ToString(),
                    surovina.NazevSklad
                });

                item.Tag = surovina.Id;
                lvSuroviny.Items.Add(item);
            }
        }

        private void InsertSurovinaBtn_Click(object sender, EventArgs e)
        {
            SurovinaDialog zboziDialog = new SurovinaDialog(_surovinaRepo, null,false);
            DialogResult result = zboziDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                this.LoadSuroviny();
            }
        }

        private void UpdateSurovinaBtn_Click(object sender, EventArgs e)
        {
            if (lvSuroviny.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvSuroviny.SelectedItems[0];
            double mnozstvi = 0;
            if (double.TryParse(selectedItem.SubItems[1].Text, out double parsedMnozstvi))
            {
                mnozstvi = parsedMnozstvi;
            }

            var surovina = new Surovina(
                id: (int)selectedItem.Tag,
                nazev: selectedItem.SubItems[0].Text,
                mnozstvi: mnozstvi,
                nazevSklad: selectedItem.SubItems[2].Text
            );

            try
            {
                SurovinaDialog surovinaDialog = new SurovinaDialog(_surovinaRepo, surovina,true);
                if (surovinaDialog.ShowDialog() == DialogResult.OK)
                {
                    this.LoadSuroviny();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadSuroviny();
        }

        private void DeleteSurovinaBtn_Click(object sender, EventArgs e)
        {
            if (lvSuroviny.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvSuroviny.SelectedItems[0];
            var surovinaId = (int)selectedItem.Tag;

            try
            {
                _surovinaRepo.DeleteSurovina(surovinaId);
                MessageBox.Show("Surovina byl úspìšnì smazána.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadSuroviny();
        }

        #endregion

        #region Zakazník
        private void LoadZakaznici()
        {
            lvZakaznici.Columns.Clear();
            lvZakaznici.View = View.Details;
            lvZakaznici.FullRowSelect = true;
            lvZakaznici.Columns.Add("Jméno", 150);
            lvZakaznici.Columns.Add("Telefon", 100);
            lvZakaznici.Columns.Add("Email", 200);
            lvZakaznici.Columns.Add("Adresa", 300);

            var zakazniciList = _zakaznikRepo.Load();
            lvZakaznici.Items.Clear();

            foreach (var zakaznik in zakazniciList)
            {
                string adresa = $"{zakaznik.Adresa.Mesto}, {zakaznik.Adresa.Ulice}, {zakaznik.Adresa.CisloPopisne}, {zakaznik.Adresa.Psc}, {zakaznik.Adresa.Stat}";

                var item = new ListViewItem(new[]
                {
                    zakaznik.Jmeno,
                    zakaznik.Telefon.ToString(),
                    zakaznik.Email,
                    adresa
                });

                item.Tag = zakaznik.Id;
                item.SubItems[3].Tag = zakaznik.Adresa.Id;
                lvZakaznici.Items.Add(item);
            }
        }

        private void InsertZakaznikBtn_Click(object sender, EventArgs e)
        {
            ZakaznikDialog zakaznikDialog = new ZakaznikDialog(_zakaznikRepo, null, false);
            DialogResult result = zakaznikDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                this.LoadZakaznici();
            }
        }

        private void UpdateZakaznikBtn_Click(object sender, EventArgs e)
        {
            if (lvZakaznici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvZakaznici.SelectedItems[0];

            var zakaznik = new Zakaznik(
                id: (int)selectedItem.Tag,
                jmeno: selectedItem.SubItems[0].Text,
                telefon: double.Parse(selectedItem.SubItems[1].Text),
                email: selectedItem.SubItems[2].Text,
                adresa: _adresaRepo.ParseAdresa(selectedItem.SubItems[3].Text+", " + selectedItem.SubItems[3].Tag)
            );

            try
            {
                ZakaznikDialog zakaznikDialog = new ZakaznikDialog(_zakaznikRepo, zakaznik, true);
                if (zakaznikDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadZakaznici();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadZakaznici();
        }


        private void DeleteZakaznikBtn_Click(object sender, EventArgs e)
        {
            if (lvZakaznici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvZakaznici.SelectedItems[0];
            var zakaznikId = (int)selectedItem.Tag;

            try
            {
                _zakaznikRepo.DeleteZakaznik(zakaznikId);
                MessageBox.Show("Zákazník byl úspìšnì smazán.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadZakaznici();
        }


        #endregion

        #region Zamìstnanec

        #endregion


    }
}

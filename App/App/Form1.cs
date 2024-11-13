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
        public Form1()
        {
            InitializeComponent();

            _zboziData = new ZboziData();
            LoadZbozi();

            InitializeLvObjednavky();
            InitializeLvSurovina();
            InitializeLvZakaznici();
            LoadObjednavky();
            LoadZakaznici();
            LoadSuroviny();
            
        }
        #region Zbozi

        private void LoadZbozi()
        {
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
                string specificValue = zbozi.Typ == "c" ? zbozi.OdrudaJablek : zbozi.Stupnovitost.ToString();

                var item = new ListViewItem(new[]
                {
                    zbozi.Nazev,
                    zbozi.ObsahAlkoholu.ToString(),
                    zbozi.Cena.ToString(),
                    zbozi.Typ,
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
            if (selectedItem.SubItems[3].Text == "p" && double.TryParse(selectedItem.SubItems[6].Text, out double parsedStupnovitost))
            {
                stupnovitost = parsedStupnovitost;
            }

            var zbozi = new Zbozi(
                id: (int)selectedItem.Tag,
                nazev: selectedItem.SubItems[0].Text,
                obsahAlkoholu: double.Parse(selectedItem.SubItems[1].Text),
                cena: double.Parse(selectedItem.SubItems[2].Text),
                typ: selectedItem.SubItems[3].Text,
                skladNazev: selectedItem.SubItems[4].Text,
                odrudaJablek: selectedItem.SubItems[3].Text == "c" ? selectedItem.SubItems[5].Text : null,
                stupnovitost: stupnovitost
            );

            try
            {
                ZboziDialog zboziDialog = new ZboziDialog(_zboziData, zbozi);
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
            ZboziDialog zboziDialog = new ZboziDialog(_zboziData,null);

            if (zboziDialog.ShowDialog() == DialogResult.OK)
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

        private void InitializeLvSurovina()
        {
            lvSuroviny.View = View.Details;
            lvSuroviny.FullRowSelect = true;
            lvSuroviny.Columns.Add("Název", 200);
            lvSuroviny.Columns.Add("Množství", 100);
            lvSuroviny.Columns.Add("Název skladu", 150);
        }
        private void LoadSuroviny()
        {
            //string query = "SELECT id, nazev, mnozstvi, nazev_sklad FROM v_surovina";


            //var data = _database.GetDataFromView(query);


            //lvSuroviny.Items.Clear();

            //foreach (var row in data)
            //{
            //    var item = new ListViewItem(new[]
            //    {
            //    row["NAZEV"].ToString(),
            //    row["MNOZSTVI"].ToString(),
            //    row["NAZEV_SKLAD"].ToString(),

            //});
            //    item.Tag = row["ID"];
            //    lvSuroviny.Items.Add(item);
            //}

        }
        private void InsertSurovinaBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateSurovinaBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSurovinaBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Zakazník
        private void InitializeLvZakaznici()
        {
            lvZakaznici.View = View.Details;
            lvZakaznici.FullRowSelect = true;
            lvZakaznici.Columns.Add("Jmeno", 100);
            lvZakaznici.Columns.Add("Telefon", 100);
            lvZakaznici.Columns.Add("Email", 100);
            lvZakaznici.Columns.Add("Adresa", 250);
        }
        private void LoadZakaznici()
        {
            //string query = "SELECT id, jmeno, telefon, email, adresa FROM v_zakaznik";


            //var data = _database.GetDataFromView(query);


            //lvZakaznici.Items.Clear();

            //foreach (var row in data)
            //{
            //    var item = new ListViewItem(new[]
            //    {
            //    row["JMENO"].ToString(),
            //    row["TELEFON"].ToString(),
            //    row["EMAIL"].ToString(),
            //    row["ADRESA"].ToString()
            //});
            //    item.Tag = row["ID"];
            //    lvZakaznici.Items.Add(item);
            //}
        }

        #endregion

        #region Zamìstnanec

        #endregion

        
    }
}

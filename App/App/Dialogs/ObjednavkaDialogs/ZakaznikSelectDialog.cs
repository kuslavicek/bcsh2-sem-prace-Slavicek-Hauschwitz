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

namespace App.Dialogs.ObjednavkaDialogs
{
    public partial class ZakaznikSelectDialog : Form
    {
        private ZakaznikRepo _zakaznikRepo { get; set; }
        private AdresaRepo _adresaRepo { get; set; }
        private List<Zakaznik> ZakaznikSeznam { get; set; }
        public Zakaznik SelectedZakaznik { get; private set; }
        public ZakaznikSelectDialog()
        {
            InitializeComponent();
            this._zakaznikRepo = new ZakaznikRepo();
            this._adresaRepo = new AdresaRepo();
            this.fill();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelectZakaznik_Click(object sender, EventArgs e)
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
                null,
                adresa: _adresaRepo.ParseAdresa(selectedItem.SubItems[3].Text + ", " + selectedItem.SubItems[3].Tag),
                null
            );
            this.SelectedZakaznik = zakaznik;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fill() {
            lvZakaznici.Columns.Clear();
            lvZakaznici.View = View.Details;
            lvZakaznici.FullRowSelect = true;
            lvZakaznici.Columns.Add("Jméno", 150);
            lvZakaznici.Columns.Add("Telefon", 100);
            lvZakaznici.Columns.Add("Email", 200);
            lvZakaznici.Columns.Add("Adresa", 300);

            this.ZakaznikSeznam = _zakaznikRepo.Load();
            lvZakaznici.Items.Clear();

            foreach (var zakaznik in ZakaznikSeznam)
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
    }
}

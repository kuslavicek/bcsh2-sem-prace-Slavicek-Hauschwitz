using App.Model;
using App.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App.Dialogs.ObjednavkaDialogs
{
    public partial class ZboziManipulationDialog : Form
    {
        public delegate void ZboziAddedEventHandler(List<ObjednaneZbozi> objednaneZbozi);
        public event ZboziAddedEventHandler ZboziAdded;
        private ZboziData _zboziRepo { get; set; }
        private List<ObjednaneZbozi> _objednaneZbozi { get; set; }

        public ZboziManipulationDialog()
        {
            InitializeComponent();
            this._zboziRepo = new ZboziData();
            this._objednaneZbozi = new List<ObjednaneZbozi>();
            this.fill();
        }

        private void BtnPridat_Click(object sender, EventArgs e)
        {
            if (listViewZbozi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vyberte zboží, které chcete přidat.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(inputPocet.Text) || !int.TryParse(inputPocet.Text, out int mnozstvi) || mnozstvi <= 0)
            {
                MessageBox.Show("Zadejte platné množství.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listViewZbozi.SelectedItems[0];
            int zboziId = (int)selectedItem.Tag;

            var objednaneZbozi = new ObjednaneZbozi
            {
                Id = null,
                IdObjednavka = null,
                IdZbozi = zboziId,
                Mnozstvi = mnozstvi
            };

            _objednaneZbozi.Add(objednaneZbozi);
            MessageBox.Show("Zboží přidáno množství.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ZboziAdded?.Invoke(_objednaneZbozi);

            this.Close();
        }

        private void fill()
        {
            this.listViewZbozi.Columns.Clear();
            this.listViewZbozi.View = View.Details;
            this.listViewZbozi.FullRowSelect = true;

            // Nastavení sloupců ListView
            this.listViewZbozi.Columns.Add("Název", 150);
            this.listViewZbozi.Columns.Add("Obsah alkoholu", 100);
            this.listViewZbozi.Columns.Add("Cena", 100);
            this.listViewZbozi.Columns.Add("Typ", 100);
            this.listViewZbozi.Columns.Add("Název skladu", 150);
            this.listViewZbozi.Columns.Add("Stupňovitost/odrůda", 150);

            // Načtení dat
            var zboziList = _zboziRepo.Load();
            this.listViewZbozi.Items.Clear();

            foreach (var zbozi in zboziList)
            {
                // Specifická hodnota pro typ
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
                this.listViewZbozi.Items.Add(item);
            }
        }
    }
}

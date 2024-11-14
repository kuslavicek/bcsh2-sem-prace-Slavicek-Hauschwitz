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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App.Dialogs
{
    public partial class ObjednavkaDialog : Form
    {
        private ObjednavkaRepo _objednavkaRepo;
        private ZakaznikRepo _zakaznikRepo;
        private ObjednaneZboziRepo _objednaneZboziRepo;
        public bool IsEditMode { get; set; } = false;
        private Objednavka Objednavka { get; set; }
        private Zakaznik Zakaznik { get; set; }
        private List<KeyValuePair<ObjednaneZbozi, Zbozi>> ZboziSeznam { get; set; }

        public ObjednavkaDialog(ObjednavkaRepo objednavkaRepo, Objednavka objednavka, bool edit)
        {
            InitializeComponent();
            this.IsEditMode = edit;
            this._objednavkaRepo = objednavkaRepo;
            this._zakaznikRepo = new ZakaznikRepo();
            this._objednaneZboziRepo = new ObjednaneZboziRepo();
            this.Objednavka = objednavka;
            this.Zakaznik = _zakaznikRepo.GetZakaznikById(this.Objednavka.IdZakaznik);
            this.ZboziSeznam = _objednaneZboziRepo.GetObjednaneZboziByObjednavka(this.Objednavka.Id);
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
            }
        }

        private void LoadZboziListView()
        {
            listViewZbozi.Columns.Add("Množství", 150);
            listViewZbozi.Columns.Add("Název", 150);
            listViewZbozi.Columns.Add("Cena", 100);
            listViewZbozi.Items.Clear();

            foreach (var pair in this.ZboziSeznam)
            {
                var item = new ListViewItem(new[]
                {
                    pair.Key.Mnozstvi.ToString(),
                    pair.Value.Nazev,
                    pair.Value.Cena.ToString(),
                });

                item.Tag = pair.Key.Id;
                listViewZbozi.Items.Add(item);
            }
        }
    }
}

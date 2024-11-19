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
        private List<Zakaznik> ZakaznikSeznam { get; set; }
        public ZakaznikSelectDialog()
        {
            InitializeComponent();
            this.fill();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectZakaznik_Click(object sender, EventArgs e)
        {

        }

        private void fill() {
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
